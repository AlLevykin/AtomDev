import React from 'react';
import { Container, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { Logo } from './Logo';
import './Layout.css';

export const Sidebarnav = () => {

    return (
        <div className="container-v-fluid bg-light border-end border-secondary shadow sidebar">
            <Container>
                <Logo />
                <hr />
                <ul className="navbar-nav flex-grow">
                    <NavItem>
                        <NavLink tag={Link} className="btn btn-outline-secondary btn-sm text-start m-1" to="/">
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-house-fill me-2 ms-2" viewBox="0 0 16 16">
                                <path fillRule="evenodd" d="m8 3.293 6 6V13.5a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 13.5V9.293l6-6zm5-.793V6l-2-2V2.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5z"/>
                                <path fillRule="evenodd" d="M7.293 1.5a1 1 0 0 1 1.414 0l6.647 6.646a.5.5 0 0 1-.708.708L8 2.207 1.354 8.854a.5.5 0 1 1-.708-.708L7.293 1.5z"/>
                            </svg>
                            Об организации
                        </NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="btn btn-outline-secondary btn-sm text-start m-1" to="/programs">
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-journal-bookmark me-2 ms-2" viewBox="0 0 16 16">
                                <path d="M8 1.783C7.015.936 5.587.81 4.287.94c-1.514.153-3.042.672-3.994 1.105A.5.5 0 0 0 0 2.5v11a.5.5 0 0 0 .707.455c.882-.4 2.303-.881 3.68-1.02 1.409-.142 2.59.087 3.223.877a.5.5 0 0 0 .78 0c.633-.79 1.814-1.019 3.222-.877 1.378.139 2.8.62 3.681 1.02A.5.5 0 0 0 16 13.5v-11a.5.5 0 0 0-.293-.455c-.952-.433-2.48-.952-3.994-1.105C10.413.809 8.985.936 8 1.783z"/>
                            </svg>
                            Программы
                        </NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="btn btn-outline-secondary btn-sm text-start m-1" to="/students">
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-person-fill me-2 ms-2" viewBox="0 0 16 16">
                                <path d="M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"/>
                            </svg>
                            Студенты
                        </NavLink>
                    </NavItem>
                </ul>
            </Container>
        </div>
    );
}