import { Link } from "react-router";
import { Team } from "../../../types/Team";

interface ResultsListProps {
    searchResult: Team[];
}

const ResultsList = ({ searchResult }: ResultsListProps) => {
    return (
        <>
        {
            searchResult.map((value: Team, index: number) => (
                <div key={index}>
                    <Link to={`/team/${value.id}`}>{value.name}</Link>
                </div>
            ))
        }
        </>    
    );
};

export default ResultsList;