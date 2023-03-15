
import './App.css';

import { BrowserRouter, Routes, Route } from "react-router-dom";
import ReactDOM from "react-dom/client";
import Home from "./pages/Home";

import Contact from "./pages/Contact";
import NoPage from "./pages/NoPage";

import Navbar from './components/Navbar/Navbar';
import Tickets from './pages/Tickets';


function App() {
  return (
    
    //Removed s in className to make them stop using the defualt react.
    <div className="App">
      <header class="border m-3 p-3">
        {/* <Home></Home> */}
        
        <BrowserRouter >
        <Navbar/>
          <Routes >
            {/* <Route path="/" element={<Layout />}> */}
              <Route index element={<Home />} />
              <Route path="tickets" element={<Tickets />} />
              <Route path="contact" element={<Contact />} />
              <Route path="*" element={<NoPage />} />
            {/* </Route> */}
          </Routes>
        </BrowserRouter>
      </header>
    </div>
  );
}

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<App />);

export default App;
