import React from 'react';
class Fruit extends React.Component{
    constructor(props){
        super(props);
            this.state={brand:"Naturals",Color:"Yellow",type:"Mango"};     
        }
    
        render()
        {
            return(
                <div>
                    <h1>My Fruit is {this.state.type}</h1>
                </div>
            );
        
            
        }
}
export default Fruit;