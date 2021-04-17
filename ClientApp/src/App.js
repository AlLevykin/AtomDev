import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Programs } from './components/Programs';
import { Students } from './components/Students';

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
          <Route exact path='/' component={Home} />
          <Route path='/programs' component={Programs} />
          <Route path='/students' component={Students} />
        </Layout>
      </EduOrgContext.Provider>
    );
  }
}
