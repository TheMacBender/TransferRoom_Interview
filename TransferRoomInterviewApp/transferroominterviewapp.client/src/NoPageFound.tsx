import { Container, Stack } from "react-bootstrap";
import { Link } from "react-router";

const NoPageFound = () => {
    return (
        <Container>
            <Stack gap={3}>
                <div className="p-2">No Page Found</div>
                <div className="p-2"><Link to="/">Back to Home</Link></div>
            </Stack>
        </Container>
    )
};

export default NoPageFound;