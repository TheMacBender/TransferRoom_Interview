import { Button, Container } from "react-bootstrap";

import "./Home.css";
import { useNavigate } from "react-router";

const Home = () => {
    const navigate = useNavigate();

    const onButtonClick = () => {
        void navigate("/search");
    }

    return (
        <header className="home-header">
            <Container className="interview-app-container p-5">
                <h1 className="home-title">Premier League Squads Finder</h1>
                <p className="home-subtitle">Search for your favorite team and take a look at its current squad!</p>
                <div className="home-buttons-section">
                    <Button type="button" className="secondary" onClick={onButtonClick}>Search Now!</Button>
                </div>
            </Container>
        </header>
    )
};

export default Home;