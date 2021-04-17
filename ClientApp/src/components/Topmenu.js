import React from 'react';
//import { NavbarBrand } from './NavbarBrand';
import { ChooseOrgButton } from './ChooseOrgButton';
import './Layout.css';

export const Topmenu = () => {

    return (
        <nav className="navbar navbar-light bg-light border-bottom border-secondary shadow fixed-top topmenu">
            <div className="container-fluid">
                <h3 className="text-secondary">ГИС "ИСУПО ТО"</h3>
                <div className="d-flex">
                    <ChooseOrgButton />
                </div>
            </div>
        </nav>
    );
}