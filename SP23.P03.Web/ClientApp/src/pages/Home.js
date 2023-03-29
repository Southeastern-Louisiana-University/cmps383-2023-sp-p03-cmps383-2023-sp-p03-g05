import Map from "../components/Map/Map";
import Stations from "../components/Stations";


const Home = () => {
    return  <>
              <div className="container-fluid m-4 p-4">

                {/* <div className="row m-4 p-2">
                  <div className="col">
                    <h1 class="display-1">EnTrack</h1>
                  </div>
                  <div className="col">
                    <h1 class="lead-4">Soon to be taking over Amtrack routes</h1>
                  </div>
                </div> */}





                <div className="row m-4 p-2">

                  <div className="col">
                    <Stations></Stations>
                  </div>

                </div>




              </div>
            </>;
  };
  
  export default Home;
