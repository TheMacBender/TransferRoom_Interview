import React from "react";

interface PlayerPositionBadgeProps {
    position: string;
}

const PlayerPositionBadge = ({ position }: PlayerPositionBadgeProps) => {
    const badgeDisplayOptions: Record<string, React.CSSProperties> = {
        "Goalkeeper": {
            color: "white",
            backgroundColor: "red",
            borderColor: "red" 
        },
        "Defender": {
            color: "black",
            backgroundColor: "yellow",
            borderColor: "yellow",
        },
        "Midfielder": {
            color: "white",
            backgroundColor: "blue",
            borderColor: "blue",
        },
        "Attacker": {
            borderColor: "green",
            background: "green",
            color: "white"
        }
    }

    const getStyleByPosition = (): React.CSSProperties => {
        const baseStyle: React.CSSProperties = {
            borderWidth: "1px",
            borderStyle: "solid",
            borderRadius: "0.375rem",
            textAlign: "center",
        }

        const style: React.CSSProperties = badgeDisplayOptions[position];

        return {
            ...baseStyle,
            ...style,
        };
    };

    return (
        <div style={getStyleByPosition()}>{position}</div>
    )
}

export default PlayerPositionBadge;