import { Link } from "react-router-dom";
const HomeFooter = () => {
    return (
<>
    <footer className="page-footer font-small text-secondary pt-4" style={{ backgroundColor: '#f43f5e'}}>
    <div className="container-fluid text-center text-md-left" >
        <div className="row">
            <div className="col-md-6 mt-md-0 mt-3" style={{color:'white'}}>
                <h5 className="text-uppercase">Thank you for choosing EnTrack!</h5>
                <p>Here you can use rows and columns to organize your footer content.</p>
            </div>

            <hr className="clearfix w-100 d-md-none pb-0"/>

            <div className="col-md-3 mb-md-0 mb-3 " style={{color:'white'}}>
                <h5 className="text-uppercase">About EnTrack</h5>
                <ul className="list-unstyled">
                    <li><a href="#!" style={{ textDecoration: 'none', color:'white' }}>About Us</a></li>
                    <li><a href="#!" style={{ textDecoration: 'none', color:'white' }}>Careers</a></li>
                    <li><a href="#!" style={{ textDecoration: 'none', color:'white' }}>Membership Program</a></li>
                    <li><a href="#!" style={{ textDecoration: 'none', color:'white' }}>Mobile App</a></li>
                </ul>
            </div>

            <div className="col-md-3 mb-md-0 mb-3" style={{color:'white'}}>
                <h5 className="text-uppercase">Support</h5>
                <ul className="list-unstyled">
                    <li><a href="#!" style={{ textDecoration: 'none', color:'white'}}>Contact Us</a></li>
                    <li><a href="#!" style={{ textDecoration: 'none', color:'white' }}>Cancellations</a></li>
                </ul>
            </div>
        </div>
    </div>

    <div className="footer-copyright text-center py-3" style={{color:'white'}}>© 2023 Copyright:
        <a href="https://selu383-sp23-p03-g05.azurewebsites.net/" style={{ textDecoration: 'none', color:'white' }}> EnTrack</a>
    </div>

</footer>
</>
    );

}

export default HomeFooter;