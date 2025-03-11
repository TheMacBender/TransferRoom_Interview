import { useState } from "react";
import useTeams from "../../hooks/useTeams";
import ResultsList from "./results-list/ResultsList";
import SearchBar from "./SearchBar";
import { Team } from "../../types/Team";
import { Container } from "react-bootstrap";

const Search = () => {
    const { getTeams } = useTeams();
    const [ searchResult, setSearchResult ] = useState<Team[]>([]);

    const onSubmit = async (searchValue: string) => {
        if (searchValue.length === 0) {
            setSearchResult([]);
            return;
        }

        const result = await getTeams(searchValue);

        setSearchResult(result);
    }

    return (
        <Container className="p-2">
            <SearchBar onSubmit={onSubmit}/>
            <ResultsList searchResult={searchResult} />
        </Container>
    )
};

export default Search;