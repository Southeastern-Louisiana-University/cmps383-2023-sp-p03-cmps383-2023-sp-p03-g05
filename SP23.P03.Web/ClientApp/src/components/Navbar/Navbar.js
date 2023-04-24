import React from "react";
import { Link } from "react-router-dom";
import './Navbar.css';
import { Button} from "react-bootstrap";
import LoginModal from "../LoginModal/LoginModal";

const Navbar = () => {
  const [modalShow, setModalShow] = React.useState(false);

  return (
    
    <nav className="navbar navbar-container navbar-expand-md navbar-light align-items-center" style={{backgroundColor: "#f43f5e"}}>
      <div className="container-fluid d-flex">

      <Button style={{backgroundColor: '#ffffff', borderWidth: '0px', padding: '5px', height: '80px', width: '140px'}}>
        <Link className="navbar-brand" to="/">
        <img src="./assets/EnTrackLogo_Light.png" alt="" width="100%" height="100%"></img>
        </Link>
      </Button>

      {/* <Link className="navbar-brand" to="/">
        EnTrack
      </Link> */}
      <button
        className="navbar-toggler"
        type="button"
        data-bs-toggle="collapse"
        data-bs-target="#navbarNavDropdown"
        aria-controls="navbarNavDropdown"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span className="navbar-toggler-icon"></span>
      </button>

      <div className="collapse navbar-collapse" id="navbarNavDropdown">
        <ul className="navbar-nav">
          <li className="nav-item active">
          <button className="navbar-toggler btn" type="button" >
            <Link className="nav-link" href="#home" to="/" >
              Home <span className="sr-only"></span>
            </Link>
          </button>
          </li>
          <li className="nav-item">
          <button className="navvar-toggler btn" type="button">
            <Link className="nav-link" href="#tickets" to="tickets">
              Book a Trip
            </Link>
          </button>
          </li>
          <li className="nav-item">
          <button className="navvar-toggler btn" type="button">
            <Link className="nav-link" href="#contact" to="contact" >
              Contact
            </Link>
          </button>
          </li>

          <li>
            <button className="navvar-toggler btn" type="button">
              <Link className="nav-link" onClick={() => setModalShow(true)}>
                Login
              </Link>
            </button>
            <LoginModal
              show={modalShow}
              onHide={() => setModalShow(false)}
            />
          </li>

          <li className='nav-item'>
          <button className="navvar-toggler btn" type="button">
            <Link className="nav-link" href="#MyTickets" to="myTickets" >
              My Tickets
            </Link>
          </button>
          </li>

        </ul>
        </div>
      </div>
    </nav>

  );
};

export default Navbar;
