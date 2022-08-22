import React from 'react';
class Car extends React.component{
    constructor(props){
        super(props);
            this.state={brand:"Ford"};
            this.state={carname:"Ford"};
            this.state={carbrandName:"Ford"};
            this.state={make:"Ford"};
            this.state={model:"Ford"};
            this.state={brand:"Tata"};
        }
    
        render()
        {
            return(
                <div>
                    <h1>My Car</h1>
                </div>
            );
        
            
        }
}
export default Car;