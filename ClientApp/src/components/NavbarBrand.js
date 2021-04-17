import React from 'react';

import EduOrgContext from './EduOrgContext';

export const NavbarBrand = () => {
    return (
        <EduOrgContext.Consumer>
            {({orgName}) => (<span className="navbar-brand">{orgName}</span>)}
        </EduOrgContext.Consumer>
    );
}