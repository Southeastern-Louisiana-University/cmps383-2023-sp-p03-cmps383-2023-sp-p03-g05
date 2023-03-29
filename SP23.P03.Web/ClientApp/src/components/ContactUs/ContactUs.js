import { Button } from "react-bootstrap";
const ContactUs = () => {
    return (
    <div className="container-fluid m-4 p-2">
        <div class="row">
            <h1>A representative will contact you about any questions or concerns!</h1>
        </div>
        <div class="row">
            <h3 class="text-muted">Please put in your contact information below</h3>
        </div>

        

        <form>

            <div class="row">

                <div class="col-4"></div>
                <div class="col-4">
                    <div class="form-group p-4">
                        <label for="emailAddress">Your Email Address:</label>
                        <input type="email" class="form-control" id="emailAddress" placeholder="name@example.com"></input>
                    </div>
                </div>

            </div>

            <div class="row">

                <div class="col-4"></div>
                <div class="col-4">
                    <div class="form-group p-4">
                        <div>Select your reason for contact below:</div>
                    <select class="form-control text-center">
                        <option>Cancelation</option>
                        <option>Lost Property</option>
                        <option>Other</option>
                    </select>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-4">

                </div>
                <div class="col-4">
                <div class="form-group">
                    <label for="textArea">Write your message here:</label>
                    <textarea class="form-control" id="textArea" rows="3"></textarea>
                </div>
                </div>
            </div>

            <div class="row pt-4">
                <div class="col-4">

                </div>
                <div class="col-4">
                    <Button class="btn" style={{backgroundColor: '#0fbebd', color: '#710000'}}>Submit</Button>
                </div>
            </div>

        </form>

        

    </div>
    );
}

export default ContactUs;