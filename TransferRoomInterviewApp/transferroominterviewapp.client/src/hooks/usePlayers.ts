import { Player } from "../types/Player";

const usePlayers = () => {
    const apiUrl = `${window.origin}/api/teams`;

    const getPlayersByTeamId = async (teamId: number): Promise<Player[]> => {
        const request = `${apiUrl}/${teamId.toString()}/players`;
        const response = await fetch(request);
        return await response.json() as Player[];
    }

    return {
        getPlayersByTeamId
    }
};

export default usePlayers;