import SingleSearchResult from "./SingleSearchResult";
import { ListGroup } from "react-bootstrap";

interface ResultsListProps {
    errorMessage?: string | undefined;
}

const EmptyResultsList = ({ errorMessage }: ResultsListProps) => {
    return (
        <ListGroup className="p-2" as="ul">
            <ListGroup.Item
                as="li"
                className="d-flex justify-content-between align-items-start"
            >
                <div className="ms-2 me-auto">
                    <SingleSearchResult teamName={errorMessage ?? "No results found"}/>
                </div>
            </ListGroup.Item>
        </ListGroup>
    );
};

export default EmptyResultsList;