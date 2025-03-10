import { useState } from "react";
import useTeams from "../../hooks/useTeams";
import ResultsList from "./results-list/ResultsList";
import SearchBar from "./SearchBar";
import { Team } from "../../types/Team";

const Search = () => {
    const { getTeams } = useTeams();
    const [ searchResult, setSearchResult ] = useState<Team[]>([]);

    const onSubmit = (searchValue: string) => {
        if (searchValue.length === 0) {
            setSearchResult([]);
            return;
        }

        const result = getTeams().filter((value: Team) => {
            return value.name.includes(searchValue) || value.nickname.includes(searchValue);
        });

        setSearchResult(result);
    }

    return (
        <>
            <SearchBar onSubmit={onSubmit}/>
            <ResultsList searchResult={searchResult} />
        </>
    )
};

export default Search;