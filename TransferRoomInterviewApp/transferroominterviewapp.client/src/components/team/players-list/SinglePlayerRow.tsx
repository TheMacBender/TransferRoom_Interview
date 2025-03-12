import { LazyLoadImage } from "react-lazy-load-image-component";
import { Player } from "../../../types/Player";
import { getImageUrl } from "../../../utils/img.utils";
import { Col, Row } from "react-bootstrap";
import PlayerPositionBadge from "./PlayerPositionBadge";

interface SinglePlayerProps {
    playerData: Player;
}

const SinglePlayerRow = ({ playerData }: SinglePlayerProps) => {
    return (
        <Row>
            <Col xs={1} className="align-content-center">
                <LazyLoadImage src={getImageUrl(playerData.profilePictureUrl)} width={75} height={75} className="interview-app-img" alt="Player" />
            </Col>
            <Col xs={9} className="align-content-center">
                <h3>{playerData.firstName} {playerData.lastName}</h3>
                <div>Age: {playerData.age}</div>
            </Col>
            <Col xs={3} md={2} className="align-content-center">
                <PlayerPositionBadge position={playerData.playerPosition} />
            </Col>
        </Row>
    )
};

export default SinglePlayerRow;