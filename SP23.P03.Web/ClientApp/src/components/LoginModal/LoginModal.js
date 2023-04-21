import Button from 'react-bootstrap/Button';
import Modal from 'react-bootstrap/Modal';
import Form from 'react-bootstrap/Form';
import { useState } from 'react';
import axios from 'axios';



export function LoginModal(props) {
const baseUrl = "https://selu383-sp23-p03-g05.azurewebsites.net"

const [username, setUsername] = useState('');
const [password, setPassword] = useState('');

const handleSubmit = (e) =>
{
    axios.post(`${baseUrl}/api/authentication/login`, { username, password })
    .then((response) => {
        console.log(response.data.userName);
        
    });
    
}

    return (
        <Modal
        {...props}
        size="lg"
        aria-labelledby="contained-modal-title-vcenter"
        centered
      >
        <Modal.Header closeButton>
          <Modal.Title id="contained-modal-title-vcenter">
            Login
          </Modal.Title>
        </Modal.Header>
        <Modal.Body>
            <Form onSubmit = {handleSubmit}>
                <Form.Group className="mb-3" controlId="Username">
                  <Form.Label>Username</Form.Label>
                  <Form.Control
                    onChange = {(e) => setUsername(e.target.value)}
                    type="username"
                    placeholder="Username"
                    autoFocus
                  />
                </Form.Group>
                <Form.Group className="mb-3" controlId="Password">
                  <Form.Label>Password</Form.Label>
                  <Form.Control
                    onChange = {(e) => setPassword(e.target.value)}
                    type="password"
                    placeholder="Password"
                    autoFocus
                  />
                </Form.Group>
            </Form>
        </Modal.Body>
        <Modal.Footer>
          <Button onClick={props.onHide}>Close</Button>
          <Button onClick={handleSubmit} type="submit">Submit</Button>
        </Modal.Footer>
      </Modal>
    );
}



export default LoginModal;