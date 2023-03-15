import Map from "../components/Map/Map";

const Tickets = () => {
    return  <>
            <div class="container">

                <div class="row m-4 p-4">

                    <div class="col">
                        <h1>Select a city for your starting location</h1>
                    </div>

                </div>

                <div class="row m-4 p-4">
                    
                    <div class="col">
                        <Map></Map>
                    </div>

                </div>

                <div class="row m-4 p-4">
                    
                    <div class="col-3"></div>

                    <div class="col-6">
                        <div class="input-group ">
                            <span class="input-group-text" id="basic-addon1">Start Location</span>
                            <input type="text" class="form-control" placeholder="Start Location" aria-label="Start Location" aria-describedby="basic-addon1" id="startStation"/>
                        </div>
                    </div>
                    


                </div>

                <div class="row m-4 p-4">
                    
                    <div class="col-3"></div>

                    <div class="col-6">
                        <div class="input-group">
                            <span class="input-group-text" id="basic-addon1">End Location</span>
                            <input type="text" class="form-control" placeholder="End Location" aria-label="Start Location" aria-describedby="basic-addon1" id="endStation"/>
                        </div>
                    </div>
                    


                </div>

            </div>
                
            </>;
  };
export default Tickets;