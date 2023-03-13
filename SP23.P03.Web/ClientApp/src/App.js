import logo from './logo.svg';
import './App.css';
import { useState } from 'react';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import ReactDOM from "react-dom/client";
import Home from "./pages/Home";
import Layout from "./pages/Layout";
import Contact from "./pages/Contact";
import NoPage from "./pages/NoPage";
import bootstrap from 'bootstrap';
import { Link } from "react-router-dom";
import Navbar from './components/Navbar';


function App() {
  return (
    
    //Removed s in className to make them stop using the defualt react.
    <div clasName="App">
      <header class="border m-3 p-3" clasName="App-header">
        <Home></Home>
        <BrowserRouter >
          <Routes >
            <Route path="/" element={<Layout />}>
              <Route index element={<Home />} />
              <Route path="contact" element={<Contact />} />
              <Route path="*" element={<NoPage />} />
            </Route>
          </Routes>
        </BrowserRouter>
      </header>
    </div>
  );
}

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(<App />);

export default App;
