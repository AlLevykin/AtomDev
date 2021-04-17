import React from 'react';
import { Container, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { Unpo } from './Unpo';
import './Layout.css';

export const Sidebarnav = () => {

    return (
        <div className="container-v-fluid bg-light border-end border-secondary shadow sidebar">
            <Container>
                <Unpo />
                <hr />
                <ul className="navbar-nav flex-grow">
                    <NavItem>
                        <NavLink tag={Link} className="btn btn-outline-secondary btn-sm text-start m-1" to="/home">
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
                            Образовательные программы
                        </NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="btn btn-outline-secondary btn-sm text-start m-1" to="/admissions">
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-person-fill me-2 ms-2" viewBox="0 0 16 16">
                                <path d="M11 8a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"/>
                                <path d="M14 14V4.5L9.5 0H4a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2zM9.5 3A1.5 1.5 0 0 0 11 4.5h2v9.255S12 12 8 12s-5 1.755-5 1.755V2a1 1 0 0 1 1-1h5.5v2z"/>
                            </svg>
                            Планы приёма
                        </NavLink>
                    </NavItem>  
                    <NavItem>
                        <NavLink tag={Link} className="btn btn-outline-secondary btn-sm text-start m-1" to="/applications">
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-person-fill me-2 ms-2" viewBox="0 0 16 16">
                                <path d="M1 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H1zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"/>
                                <path fillRule="evenodd" d="M13.5 5a.5.5 0 0 1 .5.5V7h1.5a.5.5 0 0 1 0 1H14v1.5a.5.5 0 0 1-1 0V8h-1.5a.5.5 0 0 1 0-1H13V5.5a.5.5 0 0 1 .5-.5z"/>
                            </svg>
                            Приёмные кампании
                        </NavLink>
                    </NavItem>                                      
                    <NavItem>
                        <NavLink tag={Link} className="btn btn-outline-secondary btn-sm text-start m-1" to="/students">
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-person-fill me-2 ms-2" viewBox="0 0 16 16">
                                <path d="M7 14s-1 0-1-1 1-4 5-4 5 3 5 4-1 1-1 1H7zm4-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"/>
                                <path fillRule="evenodd" d="M5.216 14A2.238 2.238 0 0 1 5 13c0-1.355.68-2.75 1.936-3.72A6.325 6.325 0 0 0 5 9c-4 0-5 3-5 4s1 1 1 1h4.216z"/>
                                <path d="M4.5 8a2.5 2.5 0 1 0 0-5 2.5 2.5 0 0 0 0 5z"/>
                            </svg>
                            Контингент
                        </NavLink>
                    </NavItem>
                    <NavItem>
                        <NavLink tag={Link} className="btn btn-outline-secondary btn-sm text-start m-1" to="/analytics">
                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-person-fill me-2 ms-2" viewBox="0 0 16 16">
                                <path fillRule="evenodd" d="M0 0h1v15h15v1H0V0zm10 3.5a.5.5 0 0 1 .5-.5h4a.5.5 0 0 1 .5.5v4a.5.5 0 0 1-1 0V4.9l-3.613 4.417a.5.5 0 0 1-.74.037L7.06 6.767l-3.656 5.027a.5.5 0 0 1-.808-.588l4-5.5a.5.5 0 0 1 .758-.06l2.609 2.61L13.445 4H10.5a.5.5 0 0 1-.5-.5z"/>
                            </svg>
                            Аналитика
                        </NavLink>
                    </NavItem>                                         
                </ul>
            </Container>
        </div>
    );
}