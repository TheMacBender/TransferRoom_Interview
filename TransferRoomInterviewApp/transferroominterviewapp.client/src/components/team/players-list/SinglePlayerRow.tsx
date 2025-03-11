import { Image } from "react-bootstrap";
import { Player } from "../../../types/Player";
import { getImageUrl } from "../../../utils/img.utils";

interface SinglePlayerProps {
    playerData: Player;
}

const SinglePlayerRow = ({ playerData }: SinglePlayerProps) => {
    return (
        <>
            <Image src={getImageUrl(playerData.profilePictureUrl)} width={50} height={50} alt="Player" />
            <div>{playerData.firstName} {playerData.lastName}</div>
            <div>{playerData.playerPosition}</div>
        </>
    )
};

export default SinglePlayerRow;