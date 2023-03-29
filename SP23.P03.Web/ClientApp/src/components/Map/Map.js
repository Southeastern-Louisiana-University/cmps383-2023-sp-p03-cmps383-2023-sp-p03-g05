import React from 'react'
// import { useState } from 'react';

function Test(event)  {

    // const [count, setCount] = useState(0);
    console.log("test");


    
    // if(count % 2 === 0) {
        var x = document.getElementById("startStation");
    // }
    // else {
        //x = document.getElementById("endStation");
    // }
    // setCount(count + 1);

    x.value = event.target.id;


  
    };

const Map = () => {
    return (
        <>

                  <img src="./assets/routes.png" alt="Workplace" usemap="#workmap" class="img-fluid border border-info m-2"/>
                  <map name="workmap">
                      <area shape="circle" coords="122,37,5" alt="Fort Worth" href="#" onClick={Test} id="Fort Worth"/>
                      <area shape="circle" coords="144,34,5" alt="Dallas" href="#" onClick={Test} id="Dallas"/>
                      <area shape="circle" coords="119,59,5" alt="Cleburne" href="#" onClick={Test} id="Cleburne"/>
                      <area shape="circle" coords="151,42,5" alt="Mesquite" href="#" onClick={Test} id="Mesquite"/>

                      <area shape="circle" coords="455,180,5" alt="New Orleans" href="#" onClick={Test} id="New Orleans"/>
                      <area shape="circle" coords="443,59,5" alt="Jackson" href="#" onClick={Test} id="Jackson"/>
                      <area shape="circle" coords="212,197,5" alt="Houston" href="#" onClick={Test} id="Houston"/>
                      <area shape="circle" coords="65,215,5" alt="San Antonio" href="#" onClick={Test} id="San Antonio"/>
                  </map>
                  <div>

                  </div>
        </>

    );

};
export default Map;