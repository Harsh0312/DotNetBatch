import React, { Component } from 'react';
//import { Provider } from 'react-redux'
import './Cycle1.css'
import Vehicle from './Vehicle';
export class Cycle extends Vehicle {
    constructor(props){
        super(props)
        this.state={Wheel:"2"}
    }
  render() {
    return (
      <div> My Cycle has two {this.state.Wheel} wheels</div>
    )
  }
}

export default Cycle;