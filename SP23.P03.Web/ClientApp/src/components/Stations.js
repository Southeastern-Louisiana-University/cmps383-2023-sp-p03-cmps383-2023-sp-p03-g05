import React from 'react'
import { Table, Row, Col } from 'react-bootstrap'
import { useEffect } from 'react'
import { useState } from 'react'
import axios from 'axios';

const baseUrl = "https://selu383-sp23-p03-g05.azurewebsites.net"
const Stations = () => {
    const [station, setStation] = useState([]);

    useEffect(() => {
        axios.get(`${baseUrl}/api/stations`)
        .then(response => 
            {
                setStation(response.data);
            })
    }, [])

    return (
        <>
        <Table>
            <Row>
                <Col>
            {station.map((station) => {
                return (
                    
                    <div>
                        {station.name}
                    </div>
                    
                )
            })}
                </Col>
            </Row>
        </Table>
        </>
    );
}
export default Stations;