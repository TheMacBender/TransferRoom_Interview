import { Stack } from "react-bootstrap";
import { Link } from "react-router";

const NoPageFound = () => {
    return (
        <Stack gap={3}>
            <div className="p-2">No Page Found</div>
            <div className="p-2"><Link to="/">Back to Home</Link></div>
        </Stack>
    )
};

export default NoPageFound;