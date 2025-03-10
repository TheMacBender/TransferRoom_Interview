import { Player } from "./Player";

export type Team = {
    id: number;
    name: string;
    nickname: string;
    badgeUrl: string;
    players: Player[];
}