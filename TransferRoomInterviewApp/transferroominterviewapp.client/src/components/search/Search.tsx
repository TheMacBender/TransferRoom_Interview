import { useState } from "react";
import useTeams from "../../hooks/useTeams";
import ResultsList from "./results-list/ResultsList";
import SearchBar from "./SearchBar";
import { Container } from "react-bootstrap";
import { useQuery } from "@tanstack/react-query";
import EmptyResultsList from "./results-list/EmptyResultsList";

const Search = () => {
    const { getTeams } = useTeams();
    const [ searchInput, setSearchInput ] = useState<string>("");

    const { isLoading, data, isError, isFetched } = useQuery({
        queryKey: ['team', searchInput],
        queryFn: () => getTeams(searchInput),
        enabled: !!searchInput,
    });

    const onSubmit = (searchValue: string) => {
        setSearchInput(searchValue);
    }

    return (
        <Container className="p-2">
            <SearchBar isFetched={isFetched} isLoading={isLoading} onSubmit={onSubmit}/>
            { isError && <EmptyResultsList errorMessage={"Error while fetching data from API"} /> }
            { data ? <ResultsList searchResult={data} /> : ((!isError && !isLoading && isFetched) && <EmptyResultsList />) }
        </Container>
    )
};

export default Search;