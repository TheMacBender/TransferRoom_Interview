import { LazyLoadImage } from "react-lazy-load-image-component";
import { Player } from "../../../types/Player";
import { getImageUrl } from "../../../utils/img.utils";

interface SinglePlayerProps {
    playerData: Player;
}

const SinglePlayerRow = ({ playerData }: SinglePlayerProps) => {
    return (
        <>
            <LazyLoadImage src={getImageUrl(playerData.profilePictureUrl)} width={50} height={50} alt="Player" />
            <div>{playerData.firstName} {playerData.lastName}</div>
            <div>{playerData.playerPosition}</div>
        </>
    )
};

export default SinglePlayerRow;