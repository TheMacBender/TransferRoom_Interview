import { Container, ListGroup } from "react-bootstrap";
import { Player } from "../../../types/Player";
import SinglePlayerRow from "./SinglePlayerRow";
import usePlayers from "../../../hooks/usePlayers";
import { useQuery } from "@tanstack/react-query";

interface PlayersListProps {
    teamId: number;
}

const PlayersList = ({ teamId }: PlayersListProps) => {
    const { getPlayersByTeamId } = usePlayers();
    const { isPending, isError, data, error } = useQuery({
        queryKey: ['players'],
        queryFn: async () => ( await getPlayersByTeamId(teamId) )
    });

    return (
        <>
            {isPending && <div>Loading...</div>}
            {isError && <div>{error.message}</div>}
            {data && (
                <ListGroup className="p-2" as="ul">
                {
                    data.map((p: Player, index: number) => (
                        <ListGroup.Item
                        as="li"
                        className="d-flex justify-content-between align-items-start"
                        key={index}
                        >
                            <Container className="ms-2 me-auto">
                                <SinglePlayerRow playerData={p} />
                            </Container>
                        </ListGroup.Item>
                    ))
                }
                </ListGroup>
            )}
        </>
    )
};

export default PlayersList;