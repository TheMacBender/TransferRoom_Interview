import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import { BrowserRouter, Routes, Route } from 'react-router'
import './index.css'
import '../node_modules/bootstrap/dist/css/bootstrap.min.css';

import App from './App.tsx'
import Home from './components/home/Home.tsx';
import Search from './components/search/Search.tsx';
import Team from './components/team/Team.tsx';
import NoPageFound from './NoPageFound.tsx';
import { QueryClient, QueryClientProvider } from '@tanstack/react-query';

const queryClient = new QueryClient();

// eslint-disable-next-line @typescript-eslint/no-non-null-assertion
createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <QueryClientProvider client={queryClient}>
      <BrowserRouter>
          <Routes>
            <Route element={<App />}>
              <Route path="/" element={<Home />} />
              <Route path="/search" element={<Search />} />
              <Route path="/team/:id" element={<Team />} />
              <Route path="*" element={<NoPageFound />} />
            </Route>
          </Routes>
      </BrowserRouter>
    </QueryClientProvider>
  </StrictMode>,
)
