import React from 'react';
import { NavbarBrand } from './NavbarBrand';
import { ChooseOrgButton } from './ChooseOrgButton';

export const Topmenu = () => {

    return (
        <nav className="navbar navbar-light bg-light border-bottom border-secondary shadow">
            <div className="container-fluid">
                <NavbarBrand />
                <div className="d-flex">
                    <ChooseOrgButton />
                </div>
            </div>
        </nav>
    );
}