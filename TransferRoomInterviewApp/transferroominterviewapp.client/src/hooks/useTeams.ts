import { Team } from "../types/Team";

const useTeams = () => {
    const apiUrl = "api/teams"

    const getTeams = async (searchInput?: string): Promise<Team[]> => {
        const request = `${apiUrl}?searchInput=${searchInput}`;
        const response = await fetch(request);
        const json = await response.json();
        return json;
    }

    return {
        getTeams
    }
};

export default useTeams;