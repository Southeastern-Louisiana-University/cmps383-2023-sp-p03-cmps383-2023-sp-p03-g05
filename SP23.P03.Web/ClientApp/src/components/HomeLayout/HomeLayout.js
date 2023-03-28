import { Container, Row, Col } from "react-bootstrap";

const HomeLayout = () => {
    return (
        <>
<div class="container-fluid p-4" >
    <div class="card bg-dark text-white text-end m-4" style={{fontFamily: 'Arial', borderWidth:'medium'}} >
        <img class="card-img" src="./assets/planyourtrip.jpg" alt="Card image" style={{maxHeight: '700px'}}></img>
        <div class="card-img-overlay">
            <div class="">
            <h1 class="card-title fw-bold m-1">Let Us Connect You To Your Destination</h1>
            </div>
        </div>
    </div>
</div>

<div class="container-fluid p-5">
    <div class="card-group">
      <div class="card border-dark" style={{maxWidth: '33%', borderWidth:'medium', backgroundColor: '#f43f5e'}}>
        <div class="card-img-top">
            <img class="card-img-top float-left" src="./assets/trainstation1.jpg" alt="Card image cap" style={{maxHeight: '700px'}}></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">See Our Stations</h5>
          <p class="card-text">We have over 40 destinations in our Pilot!</p>
        </div>
      </div>
      <div class="card border-dark "  style={{maxWidth: '33%', borderWidth:'medium'}}>
        <div class="card-img-top ">
            <img class="card-img-top "  src="./assets/trainfromabove.jpg" alt="Card image cap" style={{maxHeight: '700px'}}></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">Card title</h5>
          <p class="card-text">This card has supporting text below as a natural lead-in to additional content.</p>
        </div>
      </div>
      <div class="card border-dark "  style={{maxWidth: '33%', borderWidth:'medium'}}> 
        <div class="card-img-top">
        <img class="card-img-top" src="..." alt="Card image cap" style={{maxHeight: '700px'}}></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">Card title</h5>
          <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
        </div>
      </div>
    </div>
</div>

<div class="container-fluid m-5 d-inline-flex" style={{borderWidth:'medium', maxWidth:'50%'}}>
    <Row>
        <Col>
            <img src="./assets/google-play-logo.png" class="img-fluid" alt="..."></img>
        </Col>
        <Col>
        <div class="card-body">
            <br></br>
            <h2 class="card-title">
                Download Our App
            </h2>
            <div class="card-text">
                <hr></hr>
                <p2 class="text-muted">Now available for android!</p2>
            </div>

        </div>

        </Col>
    </Row>
</div>
        </>
    );
}

export default HomeLayout;
