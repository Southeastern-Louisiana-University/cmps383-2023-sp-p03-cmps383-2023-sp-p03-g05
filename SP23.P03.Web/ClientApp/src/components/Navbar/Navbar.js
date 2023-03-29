import React from "react";
import { Link } from "react-router-dom";
import './Navbar.css';

const Navbar = () => {
  return (
    <nav className="navbar navbar-container navbar-expand-md navbar-light" style={{backgroundColor: "#0c8d21"}}>
      <div className="container-fluid">
      <Link className="navbar-brand" to="/">
        EnTrack
      </Link>
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

      <div className="collapse navbar-collapse justify-content-end align-center" id="navbarNavDropdown">
        <ul className="navbar-nav">
          <li className="nav-item active">
          <button className="navvar-toggler btn" type="button" >
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
          <li className="nav-item dropdown">
            {/* <a
              className="nav-link dropdown-toggle"
              href="#dropdown-menu"
              id="navbarDropdownMenuLink"
              data-toggle="dropdown"
              aria-haspopup="true"
              aria-expanded="false"
            > */}
              <button className="navvar-toggler btn" type="button">
                Login
              </button>
            {/* </a> */}
          

            {/* <div
              className="dropdown-menu"
              aria-labelledby="navbarDropdownMenuLink"
            >
              <a className="dropdown-item" href="#">
                Action
              </a>
              <a className="dropdown-item" href="#">
                Another action
              </a>
              <a className="dropdown-item" href="#">
                Something else here
              </a>
            </div> */}
          </li>
        </ul>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
