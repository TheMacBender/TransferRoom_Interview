import { Container } from "react-bootstrap";
import { useParams } from "react-router";
import { useQuery } from "@tanstack/react-query";

import "./Team.css";
import TeamHeader from "./header/TeamHeader";
import PlayersList from "./players-list/PlayersList";
import useTeams from "../../hooks/useTeams";

const Team = () => {
    const params = useParams();
    const teamId = parseInt(params.id ?? "0");
    const { getTeamById } = useTeams();
    const { isPending, isError, data, error } = useQuery({
        queryKey: ['getTeamData'],
        queryFn: async () => ( await getTeamById(teamId) )
    })

    return (
        <Container>
            { isPending && <div>Loading...</div>}
            <>
                { isError && <div>{error.message}</div>}
                { data && (
                    <>
                        <TeamHeader team={data}/>
                        <PlayersList teamId={teamId}/>
                    </>
                )}
            </>
        </Container>
    )
};

export default Team;