import React, { Component } from 'react'

export class Cycle extends Component {
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