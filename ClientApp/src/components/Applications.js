import React, { useState } from 'react';
import { TabContent, TabPane, Nav, NavItem, NavLink } from 'reactstrap';
import { ApplicationsList } from './ApplicationsList';
import classnames from 'classnames';

export const Applications = () => {

    const [activeTab, setActiveTab] = useState("6");

    const toggle = tab => {
      if(activeTab !== tab) setActiveTab(tab);
    }

    return (
        <div className="mt-5">
        <h3 className="text-secondary mb-3">Приёмные кампании

        <a className="btn btn-outline-secondary ms-2">
          <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-house-fill me-2 ms-2" viewBox="0 0 16 16">
            <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"/>
            <path d="M8 4a.5.5 0 0 1 .5.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3A.5.5 0 0 1 8 4z"/>
          </svg>
          Начать приёмную кампанию
        </a>
        
        </h3>

        <Nav tabs>
            <NavItem>
            <NavLink
                className={classnames({ active: activeTab === '1' })}
                onClick={() => { toggle('1'); }}
            >
                2015
            </NavLink>
            </NavItem>
            <NavItem>
            <NavLink
                className={classnames({ active: activeTab === '2' })}
                onClick={() => { toggle('2'); }}
            >
                2016
            </NavLink>
            </NavItem>
            <NavItem>
            <NavLink
                className={classnames({ active: activeTab === '3' })}
                onClick={() => { toggle('3'); }}
            >
                2017
            </NavLink>
            </NavItem>    
            <NavItem>
            <NavLink
                className={classnames({ active: activeTab === '4' })}
                onClick={() => { toggle('4'); }}
            >
                2018
            </NavLink>
            </NavItem>   
            <NavItem>
            <NavLink
                className={classnames({ active: activeTab === '5' })}
                onClick={() => { toggle('5'); }}
            >
                2019
            </NavLink>
            </NavItem>  
            <NavItem>
            <NavLink
                className={classnames({ active: activeTab === '6' })}
                onClick={() => { toggle('6'); }}
            >
                2020
            </NavLink>
            </NavItem>   
        </Nav>
        <TabContent activeTab={activeTab}>
            <TabPane tabId="1">
                <ApplicationsList year="2015"></ApplicationsList>
            </TabPane>
            <TabPane tabId="2">
                <ApplicationsList year="2016"></ApplicationsList>
            </TabPane>
            <TabPane tabId="3">
                <ApplicationsList year="2017"></ApplicationsList>
            </TabPane>
            <TabPane tabId="4">
                <ApplicationsList year="2018"></ApplicationsList>
            </TabPane>
            <TabPane tabId="5">
                <ApplicationsList year="2019"></ApplicationsList>
            </TabPane>
            <TabPane tabId="6">
                <ApplicationsList year="2020"></ApplicationsList>
            </TabPane>                        
        </TabContent>

        </div>        
    );
}