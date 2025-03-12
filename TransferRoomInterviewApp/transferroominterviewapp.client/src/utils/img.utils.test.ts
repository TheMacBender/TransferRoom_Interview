import { getImageUrl } from './img.utils';
import viteSvg from "../assets/vite.svg";

it.each(["", undefined])('returns url to temporary image when url param is %i', (url) => {
    const result = getImageUrl(url);
    expect(result).toBe(viteSvg);
});