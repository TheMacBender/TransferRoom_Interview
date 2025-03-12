import { fileURLToPath, URL } from 'node:url';
import path from 'node:path';

import { defineConfig } from 'vitest/config';
import { normalizePath } from 'vite';
import plugin from '@vitejs/plugin-react';
import { viteStaticCopy } from "vite-plugin-static-copy";

import fs from 'fs';
import child_process from 'child_process';

const isRunningLocal = process.env.AZURE_DEPLOYMENT == null;

let keyFilePath = "";
let certFilePath = "";

if (isRunningLocal) {
    const baseFolder =
     process.env.APPDATA !== undefined && process.env.APPDATA !== ''
         ? `${process.env.APPDATA}/ASP.NET/https`
         : `${process.env.HOME}/.aspnet/https`;
 
    const certificateArg = process.argv.map(arg => arg.match(/--name=(?<value>.+)/i)).filter(Boolean)[0];
    const certificateName = certificateArg ? certificateArg.groups?.value : "transferroominterviewapp.client";

    if (!certificateName) {
        console.error('Invalid certificate name. Run this script in the context of an npm/yarn script or pass --name=<<app>> explicitly.')
        process.exit(-1);
    }
    
    certFilePath = path.join(baseFolder, `${certificateName}.pem`);
    keyFilePath = path.join(baseFolder, `${certificateName}.key`);
    
    if (!fs.existsSync(certFilePath) || !fs.existsSync(keyFilePath)) {
        if (0 !== child_process.spawnSync('dotnet', [
            'dev-certs',
            'https',
            '--export-path',
            certFilePath,
            '--format',
            'Pem',
            '--no-password',
        ], { stdio: 'inherit', }).status) {
            throw new Error("Could not create certificate.");
        }
    }
}

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [plugin(), viteStaticCopy({
        targets: [
            {
                src: normalizePath(path.resolve(__dirname, 'staticwebapp.config.json')),
                dest: './'
            }
        ]
    })],
    resolve: {
        alias: {
            '@': fileURLToPath(new URL('./src', import.meta.url))
        }
    },
    server: {
        proxy: {
            '/api': {
                target: 'https://localhost:7030/',
                secure: false,
            }
        },
        port: 5173,
        https: isRunningLocal ? {
            key: fs.readFileSync(keyFilePath),
            cert: fs.readFileSync(certFilePath),
        } : undefined
    },
    test: {
        globals: true,
        environment: 'jsdom',
        setupFiles: './setupTests.ts',
        include: ['**/*.test.tsx', '**/*.test.ts'],
    }    
})
