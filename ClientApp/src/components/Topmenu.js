import React from 'react';
//import { NavbarBrand } from './NavbarBrand';
import { ChooseOrgButton } from './ChooseOrgButton';

export const Topmenu = () => {

    return (
        <nav className="navbar navbar-light bg-light border-bottom border-secondary shadow">
            <div className="container-fluid">
                <h3 className="text-secondary">ГИС "ИСУПО ТО"</h3>
                <div className="d-flex">
                    <ChooseOrgButton />
                </div>
            </div>
        </nav>
    );
}