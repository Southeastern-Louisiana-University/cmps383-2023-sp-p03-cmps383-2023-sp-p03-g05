import { useState } from "react";
import { useEffect } from "react";
import axios from "axios";
import { Table } from "react-bootstrap";
import { Row } from "react-bootstrap";
import { Col } from "react-bootstrap";


const MyTickets = () => {
const baseUrl = "localhost:/3000"

const [ticket, setTicket] = useState([]);

useEffect(() => {
    axios.get(`${baseUrl}/api/tickets/GetAllForUser`)
    .then(response => 
        {
            setTicket(response.data);
        })
})

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