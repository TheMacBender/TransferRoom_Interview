import { Outlet } from "react-router";
import NavBar from "./components/navbar/NavBar";
import "./App.css";

const App = () => {
    return (
        <>
            <NavBar />
            <Outlet />
        </>
    )
}

export default App;