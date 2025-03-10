import { ListGroup } from "react-bootstrap";
import { Player } from "../../../types/Player";
import SinglePlayerRow from "./SinglePlayerRow";

interface PlayersListProps {
    players: Player[];
}

const PlayersList = ({ players }: PlayersListProps) => {
    return (
        <ListGroup className="p-2" as="ul">
            {
                players.map((p: Player, index: number) => (
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
    )
};

export default PlayersList;