import { Col, Image, Row } from "react-bootstrap"
import { Team } from "../../../types/Team";
import { getImageUrl } from "../../../utils/img.utils";

interface TeamHeaderProps {
    team: Team
}

const TeamHeader = ({ team }: TeamHeaderProps) => {
    return (
        <div className="interview-app-container">
            <Row>
                <Col className="m-3">
                    <Image src={getImageUrl(team.badgeUrl)} width={200} height={200} style={{objectFit: "scale-down"}} alt="Badge" />
                </Col>
                <Col className="align-content-center">
                    <h1>{team.name}</h1>
                </Col>
            </Row>
        </div>
    )
};

export default TeamHeader;