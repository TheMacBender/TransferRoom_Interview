import { sanitizeName } from "./string.utils";

it("Name containing apostrophe is sanitized correctly", () => {
    const name = "O&apos;Reilly";
    const result = sanitizeName(name);
    expect(result).toBe("O'Reilly");
})