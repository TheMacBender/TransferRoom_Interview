import { Container } from "react-bootstrap";
import TeamHeader from "./header/TeamHeader";
import { useParams } from "react-router";

import "./Team.css";
import { useFetch } from "../../hooks/useFetch";
import PlayersList from "./players-list/PlayersList";

const Team = () => {
    const params = useParams();
    const { data, isPending, error } = useFetch(`https://localhost:5173/api/teams/${parseInt(params.id ?? "0")}`);

    return (
        <Container>
            { isPending && <div>Loading...</div>}
            <>
                { error && <div>{error}</div>}
                { data && (
                    <>
                        <TeamHeader team={data}/>
                        <PlayersList teamId={params.id ?? "0"}/>
                    </>
                )}
            </>
        </Container>
    )
};

export default Team;