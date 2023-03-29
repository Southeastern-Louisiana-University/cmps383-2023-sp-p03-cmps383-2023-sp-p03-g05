import { Container, Row, Col } from "react-bootstrap";
import HomeFooter from "../HomeFooter/HomeFooter";

const HomeLayout = () => {
    return (
        <>


<div class="container-fluid p-5" style={{width: '100%'}}>

  <div class="row justify-content-center">
    <hr></hr>
  </div>

  <div class="row justify-content-center" style={{width: '100%'}}>

      

        <div class="card text-white text-end m-4" style={{fontFamily: 'Arial', backgroundColor: '#f3eed9', borderColor: '#f3eed9', borderWidth: 'medium'}} >
          <img class="card-img" src="./assets/planyourtrip.jpg" alt="Card image" style={{maxHeight: '500px'}}></img>
          <div class="card-img-overlay">
              <div class="">
                <h1 class="card-title fw-bold m-1">Let Us Connect You To Your Destination</h1>
              </div>
          </div>
        </div>


  </div>

  <div class="row justify-content-center" style={{width: '100%'}}>

    <div class="col-3" style={{color: 'white'}}>

        <div class="card 2-75" style={{ borderWidth:'medium', borderColor: '#710000', border: 'rounded', backgroundColor: '#f43f5e', height: '800px'}}>
        <div class="card-img-top">
            <img class="card-img-top" src="./assets/trainstation1.jpg" alt="Card image cap"></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">We have over 40 destinations in our Pilot!</h5>
          <a href="#" class="btn" style={{backgroundColor: '#0fbebd', color: '#710000'}}>See Our Stations!</a>
        </div>
      </div>

    </div>

    <div class="col-3">

        <div class="card  "  style={{ borderWidth:'medium', borderColor: '#710000', border: 'rounded', backgroundColor: '#f43f5e', height: '800px'}}>
        <div class="card-img-top ">
            <img class="card-img-top "  src="./assets/trainfromabove.jpg" alt="Card image cap" ></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">Card title</h5>
          <p class="card-text">This card has supporting text below as a natural lead-in to additional content.</p>
        </div>
      </div>

    </div>

    <div class="col-3">

      <div class="card "  style={{ borderWidth:'medium', borderColor: '#710000', border: 'rounded', backgroundColor: '#f43f5e', height:'800px'}}> 
        <div class="card-img-top">
          <img class="card-img-top "  src=".\assets\splash.png" alt="Card image c" ></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">Card title</h5>
          <p class="card-text">Our well trained staff get you to your destination on time and hassle free!</p>
        </div>
      </div>

    </div>
  </div>

      <div class="row p-4 justify-content-center" style={{width: '100%'}}>
        <div class="col-4">

        <img src="./assets/google-play-logo.png" class="img-fluid" alt="..."></img>
        
        </div>
        <div class="col-4">
        
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
        
        </div>
      </div>

      <div class="row p-4" style={{width: '100%'}}>
        <div class="col">
        <HomeFooter></HomeFooter>
        </div>
      
      </div>

      

      {/* <div class="card border-dark 2-75" style={{ borderWidth:'medium', backgroundColor: '#f43f5e'}}>
        <div class="card-img-top">
            <img class="card-img-top float-left" src="./assets/trainstation1.jpg" alt="Card image cap" style={{maxHeight: '700px'}}></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">We have over 40 destinations in our Pilot!</h5>
          <a href="#" class="btn" style={{backgroundColor: '#0fbebd'}}>See Our Stations!</a>
        </div>
      </div>

      <div class="card border-dark "  style={{ borderWidth:'medium'}}>
        <div class="card-img-top ">
            <img class="card-img-top "  src="./assets/trainfromabove.jpg" alt="Card image cap" style={{maxHeight: '700px'}}></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">Card title</h5>
          <p class="card-text">This card has supporting text below as a natural lead-in to additional content.</p>
        </div>
      </div>

      <div class="card border-dark "  style={{ borderWidth:'medium'}}> 
        <div class="card-img-top">
        <img class="card-img-top" src="..." alt="Card image cap" style={{maxHeight: '700px'}}></img>
        </div>
        <div class="card-body">
          <h5 class="card-title">Card title</h5>
          <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
        </div>
      </div> */}


</div>

{/* <div class="container-fluid m-5 d-inline-flex" style={{borderWidth:'medium', maxWidth:'50%'}}>
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
</div> */}

        </>
    );
}

export default HomeLayout;
