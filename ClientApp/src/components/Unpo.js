import React from 'react';
import { NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';

export const Unpo = () => {

    return (
        <p className="text-center">
            <NavLink tag={Link} to="/">
                <img src="logo.png" alt="Logo" />
            </NavLink>
        </p>
    );
}