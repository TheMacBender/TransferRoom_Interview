import { render, screen } from '@testing-library/react';
import Home from './Home';
import { MemoryRouter } from 'react-router';

describe('HomeComponent', () => {
  it('renders the component properly', () => {
    render(
        <MemoryRouter>
            <Home />
        </MemoryRouter>
    );
    expect(screen.getByText('Premier League Squads Finder')).toBeInTheDocument();
  });
});