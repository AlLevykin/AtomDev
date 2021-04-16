import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div className="mt-3">
        <h1 className="text-secondary">Главная</h1>        
      </div>
    );
  }
}
