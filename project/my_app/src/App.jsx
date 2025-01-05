import { useState } from 'react';
import './App.css';
import { Login1 } from './Components/Common/Login/LOGIN.JSX';


function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <Login1  /> 
    </>
  );
}

export default App;
