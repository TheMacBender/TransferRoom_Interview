import { useState } from "react";
import { Button, Form, Stack } from "react-bootstrap";

interface SearchBarProps {
    onSubmit: (searchValue: string) => void;
}

const SearchBar = ({ onSubmit }: SearchBarProps) => {
    const [searchName, setSearchName] = useState("");

    const onInputChange = (val: string) => {
        setSearchName(val);
    }

    return (
        <Stack gap={1}>
            <Stack direction="horizontal" gap={3}>
                <Form.Control className="me-auto" placeholder="Search for a team..." value={searchName} onChange={e => onInputChange(e.target.value)}/>
                <Button variant="secondary" onClick={() => onSubmit(searchName)}>Submit</Button>
            </Stack>
        </Stack>
    )
};

export default SearchBar;