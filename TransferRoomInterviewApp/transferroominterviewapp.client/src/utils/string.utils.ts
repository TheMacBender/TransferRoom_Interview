export const sanitizeName = (name: string) => {
    return name.replace("&apos;", "'");
}