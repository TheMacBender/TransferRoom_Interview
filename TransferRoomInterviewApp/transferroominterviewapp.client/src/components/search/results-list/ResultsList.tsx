import { useNavigate } from "react-router";
import { Team } from "../../../types/Team";
import SingleSearchResult from "./SingleSearchResult";
import { ListGroup } from "react-bootstrap";

interface ResultsListProps {
    searchResult: Team[] | undefined;
}

const ResultsList = ({ searchResult }: ResultsListProps) => {
    const navigate = useNavigate();

    const onResultClick = (id: number) => {
        navigate(`/team/${id}`);
    }

    return (
        <ListGroup className="p-2" as="ul">
            {
                searchResult?.map((value: Team, index: number) => (
                    <ListGroup.Item
                        as="li"
                        className="d-flex justify-content-between align-items-start"
                        action
                        key={index}
                        onClick={() => onResultClick(value.id)}
                    >
                        <div className="ms-2 me-auto">
                            <SingleSearchResult teamName={value.name}/>
                        </div>
                    </ListGroup.Item>
                ))
            }   
        </ListGroup>
    );
};

export default ResultsList;