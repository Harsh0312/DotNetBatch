import React from "react";
class Engine extends React.Component{
    constructor(props){
        super(props);
        this.state={brand:"tata",model:"xyz"};
    }
    render(){
        return(
            <div>
            <h1>My Car {this.state.brand}</h1>
            </div>
        );

    }
}
export default Engine;