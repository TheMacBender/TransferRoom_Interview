import { Outlet } from "react-router";
import { Container } from "react-bootstrap";
import NavBar from "./components/navbar/NavBar";
import "./App.css";

const App = () => {
    return (
        <>
            <NavBar />
            <Container>
                <Outlet />
            </Container>
        </>
    )
}

export default App;