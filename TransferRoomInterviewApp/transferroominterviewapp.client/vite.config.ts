import { fileURLToPath, URL } from 'node:url';
import path from 'node:path';

import { defineConfig, normalizePath } from 'vite';
import plugin from '@vitejs/plugin-react';
import { viteStaticCopy } from "vite-plugin-static-copy";

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
        port: 5173
    }
})
