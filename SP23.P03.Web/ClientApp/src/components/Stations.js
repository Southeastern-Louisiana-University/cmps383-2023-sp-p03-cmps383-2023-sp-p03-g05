import React from 'react'
import { Table, Row, Col } from 'react-bootstrap'
import { useEffect } from 'react'
import { useState } from 'react'
import axios from 'axios'

const baseUrl = "/api"
const Stations = () => {
    const [station, setStation] = useState([]);

    useEffect(() => {
        axios.get(`${baseUrl}/stations`)
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