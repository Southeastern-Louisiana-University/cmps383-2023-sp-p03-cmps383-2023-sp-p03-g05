import Navbar from "../components/Navbar";

const Home = () => {
    return  <>
              <div className="container m-4 p-4">

                <Navbar></Navbar>

                <div className="row m-4 p-2">
                  <div className="col">
                    <h1 class="display-1">EnTrack</h1>
                  </div>
                  <div className="col">
                    <h1 class="lead-4">Soon to be taking over Amtrack routes</h1>
                  </div>
                </div>

                <div className="row m-4 p-2">
                  <div className="col">
                    <h1 class="display-1">See our Routes</h1>
                  </div>
                  {/* <div className="col">
                    <img src="../assets/routes.png" class="img-fluid float-end" alt="Train routes"/>
                  </div> */}
                  <div class="col">
                  <img src="./assets/routes.png" alt="Workplace" usemap="#workmap"/>
                    <map name="workmap">
                      <area shape="rect" coords="34,44,270,350" alt="Computer" href="computer.htm"/>
                      <area shape="rect" coords="290,172,333,250" alt="Phone" href="phone.htm"/>
                      <area shape="circle" coords="337,300,44" alt="Cup of coffee" href="coffee.htm"/>
                    </map>
                  </div>
                </div>

                <div className="row m-4 p-2">
                  <div className="col">
                    <h1 class="display-1">Testing</h1>
                  </div>
                </div>

              </div>
            </>;
  };
  
  export default Home;
