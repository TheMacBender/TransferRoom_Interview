import viteSvg from "../assets/vite.svg";

export const getImageUrl = (url: string): string | undefined => {
    if (url.length === 0) {
        return viteSvg;
    }

    return url;
}