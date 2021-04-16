import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { Sidebarnav } from './Sidebarnav';
import './Layout.css';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
    <div className="container-fluid container-v-fluid">
      <main role="main">
        <div className="row">
          <Sidebarnav />
          <div className="col container-v-fluid">
            <Container>
              {this.props.children}
            </Container>
          </div>       
        </div>
      </main>
    </div>
    );
  }
}
