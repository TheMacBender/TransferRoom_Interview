import { Team } from "../../../types/Team";
import { Image, Stack } from "react-bootstrap";
import { getImageUrl } from "../../../utils/img.utils";

interface SingleSearchResultProps {
    data: Team;
}

const SingleSearchResult = ({ data }: SingleSearchResultProps) => {
    return (
        <Stack direction="horizontal" gap={2}>
            <Image src={getImageUrl(data.badgeUrl)} width={50} height={50} alt="Badge" />
            <div>{data.name}</div>
        </Stack>
    );
};

export default SingleSearchResult;