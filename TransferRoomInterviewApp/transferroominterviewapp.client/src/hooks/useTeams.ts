import { Team } from "../types/Team";

const useTeams = () => {
    const teams: Team[] = [{
        id: 1,
        name: "Liverpool",
        nickname: "The Reds",
        badgeUrl: "",
        players: [{
            id: 1,
            firstName: "Mohamed",
            surname: "Salah",
            position: "FW",
            birthDate: "",
            photoUrl: "",
        }],
    }, {
        id: 2,
        name: "Leicester",
        nickname: "The Foxes",
        badgeUrl: "",
        players: [{
            id: 2,
            firstName: "Jamie",
            surname: "Vardy",
            position: "FW",
            birthDate: "",
            photoUrl: "",
        }],
    }];

    const getTeams = (): Team[] => {
        return teams;
    }

    const getTeamById = (id: number): Team | undefined => {
        return teams.find(t => t.id === id);
    }

    return {
        getTeams,
        getTeamById,
    }
};

export default useTeams;