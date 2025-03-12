import { Stack } from "react-bootstrap";

interface SingleSearchResultProps {
    teamName: string;
}

const SingleSearchResult = ({ teamName }: SingleSearchResultProps) => {
    return (
        <Stack direction="horizontal" gap={2}>
            <div>{teamName}</div>
        </Stack>
    );
};

export default SingleSearchResult;