import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Programs } from './components/Programs';
import { Admissions } from './components/Admissions';
import { Applications } from './components/Applications';
import { Students } from './components/Students';
import { Analytics } from './components/Analytics';
import { Maps } from './components/Maps';

import EduOrgContext from './components/EduOrgContext';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  constructor(props) {
    super(props);

    this.toggleOrg = (orgName) => {
      this.setState(() => ({
        orgName: orgName
      }));
    };

    this.state = {
      orgName: "Асиновский техникум промышленной индустрии и сервиса",
      toggleOrg: this.toggleOrg,
    };
  }  

  render () {
    return (
      <EduOrgContext.Provider value={this.state}>
        <Layout>
          <Route exact path='/' component={Analytics} />
          <Route exact path='/home' component={Home} />          
          <Route path='/programs' component={Programs} />
          <Route path='/admissions' component={Admissions} /> 
          <Route path='/applications' component={Applications} />                    
          <Route path='/students' component={Students} />
          <Route path='/analytics' component={Analytics} />     
          <Route path='/maps' component={Maps} />                 
        </Layout>
      </EduOrgContext.Provider>
    );
  }
}
