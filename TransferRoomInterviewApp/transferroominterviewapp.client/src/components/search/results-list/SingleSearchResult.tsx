import { Team } from "../../../types/Team";
import { Stack } from "react-bootstrap";

interface SingleSearchResultProps {
    data: Team;
}

const SingleSearchResult = ({ data }: SingleSearchResultProps) => {
    return (
        <Stack direction="horizontal" gap={2}>
            <div>{data.name}</div>
        </Stack>
    );
};

export default SingleSearchResult;