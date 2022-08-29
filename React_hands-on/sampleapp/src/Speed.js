import React from "react";
const Speed= ({speed}) =>{
    return(
        <p>The speed is {speed}</p>
    );
}
 function Engine({name}){
    return(
        <h1>Engine {name}</h1>
    );
}
export  {Speed,Engine};
