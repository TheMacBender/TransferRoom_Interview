import { useEffect, useState } from "react";
import { Button, Form, Stack } from "react-bootstrap";

interface SearchBarProps {
    isLoading: boolean,
    isFetched: boolean,
    onSubmit: (searchValue: string) => void;
}

const SearchBar = ({ isLoading, isFetched, onSubmit }: SearchBarProps) => {
    const [searchName, setSearchName] = useState("");

    const onInputChange = (val: string) => {
        setSearchName(val);
    }

    const onKeyDown = (e: React.KeyboardEvent) => {
        if (e.key === "Enter") {
            onSubmit(searchName);
        }
    }

    useEffect(() => {
        if (isFetched) {
            setSearchName("");
        }
    }, [isFetched])

    return (
        <Stack gap={1}>
            <Stack direction="horizontal" gap={3}>
                <Form.Control
                    className="me-auto"
                    placeholder="Search for a team, e.g. Liverpool, Arsenal"
                    value={searchName}
                    onChange={e => { onInputChange(e.target.value); }}
                    onKeyDown={e => { onKeyDown(e) }}
                    disabled={isLoading}
                />
                <Button
                    variant="secondary"
                    onClick={() => { onSubmit(searchName); }}
                    disabled={isLoading || searchName.length === 0}
                >
                    {isLoading ? "Loading..." : "Submit"}
                </Button>
            </Stack>
        </Stack>
    )
};

export default SearchBar;