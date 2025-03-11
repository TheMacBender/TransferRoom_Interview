import { ListGroup } from "react-bootstrap";
import { Player } from "../../../types/Player";
import SinglePlayerRow from "./SinglePlayerRow";
import { useFetch } from "../../../hooks/useFetch";

interface PlayersListProps {
    teamId: string;
}

const PlayersList = ({ teamId }: PlayersListProps) => {
    const { data, isPending } = useFetch(`https://localhost:5173/api/teams/${parseInt(teamId)}/players`)

    return (
        <>
            {isPending && <div>Loading...</div>}
            <ListGroup className="p-2" as="ul">
                {
                    (data ?? []).map((p: Player, index: number) => (
                        <ListGroup.Item
                        as="li"
                        className="d-flex justify-content-between align-items-start"
                        key={index}
                        >
                            <div className="ms-2 me-auto">
                                <SinglePlayerRow playerData={p} />
                            </div>
                        </ListGroup.Item>
                    ))
                }
            </ListGroup>
        </>
    )
};

export default PlayersList;