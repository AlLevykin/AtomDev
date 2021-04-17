import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { Sidebarnav } from './Sidebarnav';
import { Topmenu } from './Topmenu';
import './Layout.css';

export class Layout extends Component {
    static displayName = Layout.name;

    render() {
        return (
            <div className="container-fluid container-v-fluid">
                <main role="main">
                    <div className="row">
                        <Sidebarnav />                        
                        <Topmenu />
                        <div className="col container-v-fluid main-container">  
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
