import { Container } from "react-bootstrap";
import TeamHeader from "./header/TeamHeader";
import PlayersList from "./players-list/PlayersList";
import useTeams from "../../hooks/useTeams";
import { useParams } from "react-router";

import "./Team.css";

const Team = () => {
    const params = useParams();
    const { getTeamById } = useTeams();

    const teamData = getTeamById(parseInt(params.id ?? "0"));

    return (
        <Container>
            { teamData ? (
                <>
                    <TeamHeader team={teamData}/>
                    <PlayersList players={teamData.players} />
                </>
            ) : <div>No data found</div>}
        </Container>
    )
};

export default Team;