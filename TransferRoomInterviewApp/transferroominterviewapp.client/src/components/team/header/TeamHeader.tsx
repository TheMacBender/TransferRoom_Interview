import { Col, Image, Row } from "react-bootstrap"
import { Team } from "../../../types/Team";
import { getImageUrl } from "../../../utils/img.utils";

import "../Team.css"

interface TeamHeaderProps {
    team: Team
}

const TeamHeader = ({ team }: TeamHeaderProps) => {
    return (
        <div className="interview-app-container">
            { team.id ? (
                <Row>
                    <Col xs={3}>
                        <Image src={getImageUrl(team.badgeUrl)} width={200} height={200} className="interview-app-img" alt="Badge" />
                    </Col>
                    <Col className="align-content-center">
                        <h1>{team.name}</h1>
                    </Col>
                </Row>
            ) : (
                <Row>
                    <Col className="text-center">
                        <h1>Team not found</h1>
                    </Col>
                </Row>
            )}
        </div>
    )
};

export default TeamHeader;