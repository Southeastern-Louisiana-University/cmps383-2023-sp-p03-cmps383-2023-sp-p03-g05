import React from "react";
import { Link } from "react-router-dom";
import './Navbar.css';
import {Container, Nav, NavDropdown} from "react-bootstrap";

const Navbar = () => {
  return (
    // <nav className="navbar navbar-container navbar-expand-md navbar-light align-items-center" style={{backgroundColor: "#0c8d21"}}>
    //   <div className="container-fluid d-flex">
    //   <Link className="navbar-brand" to="/">
    //     EnTrack
    //   </Link>
    //   <button
    //     className="navbar-toggler"
    //     type="button"
    //     data-bs-toggle="collapse"
    //     data-bs-target="#navbarNavDropdown"
    //     aria-controls="navbarNavDropdown"
    //     aria-expanded="false"
    //     aria-label="Toggle navigation"
    //   >
    //     <span className="navbar-toggler-icon"></span>
    //   </button>

    //   <div className="collapse navbar-collapse" id="navbarNavDropdown">
    //     <ul className="navbar-nav">
    //       <li className="nav-item active">
    //       <button className="navbar-toggler btn" type="button" >
    //         <Link className="nav-link" href="#home" to="/" >
    //           Home <span className="sr-only"></span>
    //         </Link>
    //       </button>
    //       </li>
    //       <li className="nav-item">
    //       <button className="navvar-toggler btn" type="button">
    //         <Link className="nav-link" href="#tickets" to="tickets">
    //           Book a Trip
    //         </Link>
    //       </button>
    //       </li>
    //       <li className="nav-item">
    //         <button className="navvar-toggler btn" type="button">
    //         <Link className="nav-link" href="#contact" to="contact" >
    //           Contact
    //         </Link>
    //       </button>
    //       </li>
    //       <li className="nav-item dropdown">
    //         {/* <a
    //           className="nav-link dropdown-toggle"
    //           href="#dropdown-menu"
    //           id="navbarDropdownMenuLink"
    //           data-toggle="dropdown"
    //           aria-haspopup="true"
    //           aria-expanded="false"
    //         > */}
    //           <button className="navvar-toggler btn" type="button">
    //             Login
    //           </button>
    //         {/* </a> */}
          

    //         {/* <div
    //           className="dropdown-menu"
    //           aria-labelledby="navbarDropdownMenuLink"
    //         >
    //           <a className="dropdown-item" href="#">
    //             Action
    //           </a>
    //           <a className="dropdown-item" href="#">
    //             Another action
    //           </a>
    //           <a className="dropdown-item" href="#">
    //             Something else here
    //           </a>
    //         </div> */}
    //       </li>
    //     </ul>
    //     </div>
    //   </div>
    // </nav>
        <Navbar bg="light" expand="lg">
        <Container>
          <Navbar.Brand href="#home">React-Bootstrap</Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="me-auto">
              <Nav.Link href="#home">Home</Nav.Link>
              <Nav.Link href="#link">Link</Nav.Link>
              <NavDropdown title="Dropdown" id="basic-nav-dropdown">
                <NavDropdown.Item href="#action/3.1">Action</NavDropdown.Item>
                <NavDropdown.Item href="#action/3.2">
                  Another action
                </NavDropdown.Item>
                <NavDropdown.Item href="#action/3.3">Something</NavDropdown.Item>
                <NavDropdown.Divider />
                <NavDropdown.Item href="#action/3.4">
                  Separated link
                </NavDropdown.Item>
              </NavDropdown>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
  );
};

export default Navbar;
