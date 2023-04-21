import Map from "../components/Map/Map";
import { Form, Button } from "react-bootstrap";
import { useState } from "react";
import axios from "axios";

const Tickets = () => {

    const baseUrl = "https://selu383-sp23-p03-g05.azurewebsites.net"
    const [startLoc, setStartLoc] = useState([]);
    const [endLoc, setEndLoc] = useState([]);
    const [userName, setUsername] = useState('');

    const handleSubmit = (e) =>
{
    axios.get(`${baseUrl}/api/authentication/me`, { })
    .then((response) => {
        setUsername(response.data.id);
        
    });

    console.log(userName);

    axios.post(`${baseUrl}/api/tickets`, 
    {
        StartingTrainStation: startLoc, 
        EndingTrainStation: endLoc, 
        Passenger: userName, 
        DepartureTime: new Date()
    }).then(function (response) {
            console.log(response);
        }).catch(function (error) {
            console.log(error);
        });
    
}

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

                <div class="row m-4 p-4">
                <Form onSubmit={handleSubmit}>
                    <Form.Select aria-label="Default select example" onChange={setStartLoc}>
                        <option>Starting Location</option>
                        <option value="18">Baton Rouge</option>
                        <option value="11">New Orleans</option>
                        <option value="1">Hammond</option>
                        <option value="14">Jackson</option>
                    </Form.Select>
                    <Form.Select aria-label="Default select example" onChange={setEndLoc}>
                        <option>Ending Location</option>
                        <option value="18">Baton Rouge</option>
                        <option value="11">New Orleans</option>
                        <option value="1">Hammond</option>
                        <option value="14">Jackson</option>
                    </Form.Select>
                    <Button onClick={handleSubmit} type="submit">Submit</Button>
                </Form>
                </div>

            </div>
                
            </>;
  };
export default Tickets;