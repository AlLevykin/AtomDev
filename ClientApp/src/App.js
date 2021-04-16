import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Realty } from './components/Realty';
import { HumanResources } from './components/HumanResources';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/human-resources' component={HumanResources} />
        <Route path='/realty' component={Realty} />
      </Layout>
    );
  }
}
