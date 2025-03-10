import { Image } from "react-bootstrap";
import { Player } from "../../../types/Player";
import { getImageUrl } from "../../../utils/img.utils";

interface SinglePlayerProps {
    playerData: Player;
}

const SinglePlayerRow = ({ playerData }: SinglePlayerProps) => {
    return (
        <>
            <Image src={getImageUrl(playerData.photoUrl)} width={50} height={50} alt="Player" />
            <div>{playerData.firstName} {playerData.surname}</div>
            <div>{playerData.position}</div>
        </>
    )
};

export default SinglePlayerRow;