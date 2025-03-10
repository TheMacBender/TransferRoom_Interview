import { Team } from "../types/Team";

const useTeams = () => {
    const teams: Team[] = [{
        id: 1,
        name: "Liverpool",
        nickname: "The Reds"
    }];

    const getTeams = () => {
        return teams;
    }

    return {
        getTeams,
    }
};

export default useTeams;