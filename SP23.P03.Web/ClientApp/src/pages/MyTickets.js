import { useState } from "react";
import { useEffect } from "react";
import axios from "axios";
import { Table, Row, Col } from 'react-bootstrap'


const MyTickets = () => {
const baseUrl = "https://selu383-sp23-p03-g05.azurewebsites.net"

const [ticket, setTicket] = useState([]);

useEffect(() => {
    axios.get(`${baseUrl}/api/tickets/GetAllForUser`)
    .then(response => 
        {
            setTicket(response.data);
        })
}, [])

return (
    <>
    <Table>
        <Row>
            <Col>
        {ticket.map((ticket) => {
            return (
                
                <div>
                    {ticket}
                </div>
                
            )
        })}
            </Col>
        </Row>
    </Table>
    </>
);

}

export default MyTickets;