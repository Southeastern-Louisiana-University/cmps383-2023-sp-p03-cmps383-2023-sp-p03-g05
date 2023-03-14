function test(name)  {
  // const onClick = () => console.log('hi');
  var x = document.getElementById("startStation");
  x.value = name
  };

const Home = () => {
    return  <>
              <div className="container m-4 p-4">

                {/* <div className="row m-4 p-2">
                  <div className="col">
                    <h1 class="display-1">EnTrack</h1>
                  </div>
                  <div className="col">
                    <h1 class="lead-4">Soon to be taking over Amtrack routes</h1>
                  </div>
                </div> */}

                <div className="row m-4 p-2">

                  {/* <div className="col">
                    <h1 class="display-1">See our Stations</h1>
                  </div> */}

                <div class="col">
                  <img src="./assets/routes.png" alt="Workplace" usemap="#workmap"/>
                    <map name="workmap">
                      <area shape="circle" coords="122,37,5" alt="Fort Worth" href="BookATrip.htm"/>
                      <area shape="circle" coords="144,34,5" alt="Dallas"  onClick={test(this.name.value)} id="Dallas"/>
                      <area shape="circle" coords="119,59,5" alt="Cleburne" href="BookATrip.htm"/>
                      <area shape="circle" coords="151,42,5" alt="Mesquite" href="BookATrip.htm"/>
                    </map>
                </div>

                <div className="row m-4 p-2">

                  <div className="col">
                    <h1 class="display-1">See our Stations</h1>
                  </div>

                </div>

                </div>

                <div className="row m-4 p-2">
                  <div className="col">
                    <h1 class="display-1">Testing</h1>
                  </div>
                </div>

                <div class="input-group mb-3">
  <span class="input-group-text" id="basic-addon1">@</span>
  <input type="text" class="form-control" placeholder="Start Location" aria-label="Start Location" aria-describedby="basic-addon1" id="startStation"/>
</div>


              </div>
            </>;
  };
  
  export default Home;
