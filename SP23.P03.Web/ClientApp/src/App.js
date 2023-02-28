import logo from './logo.svg';
import './App.css';
import { useState } from 'react';
import { Browser, router } from 'react-router-dom;'

export function Test() {
  const [count, setCount] = useState(0);

  function handleClick() {
    setCount(count + 1);
  }

  return (
      <button onClick={handleClick}> Clicked { count }</button>
  );
}


function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>

        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
        <p1>Testing</p1>
        <Test/>
        <Test/>
      </header>
    </div>
  );
}

export default App;
