import { Team } from "../types/Team";

const useTeams = () => {
    const apiUrl = `${window.origin}/api/teams`

    const getTeams = async (searchInput?: string): Promise<Team[]> => {
        const request = `${apiUrl}?searchInput=${searchInput ?? ""}`;
        const response = await fetch(request);
        return await response.json() as Team[];
    }

    const getTeamById = async (id: number): Promise<Team> => {
        const request = `${apiUrl}/${id.toString()}`;
        const response = await fetch(request);
        return await response.json() as Team;
    }

    return {
        getTeams,
        getTeamById,
    }
};

export default useTeams;