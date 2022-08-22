import React from 'react';
class Car extends React.component{
    constructor(props){
        super(props);
            this.state={brand:"Naturals"};
            this.state={Color:"Yellow"}
            this.state={type:"Mango"}
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
export default Car;