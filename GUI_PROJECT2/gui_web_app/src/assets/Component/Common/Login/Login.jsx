import React, { useState } from 'react';
import { useNavigate, Link } from 'react-router-dom';
import './Login.css';

const LoginPage1 = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log('Login submitted:', { email, password });
    navigate('/dashboard');
  };

  return (
    <div className="login-container">
      <div className="login-form">
        <h2 className="loginheader">YOU ARE WELCOME</h2>
        <form onSubmit={handleSubmit}>
          <div className="input-group">
            <label htmlFor="email">Email</label>
            <input
              type="email"
              id="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              required
            />
          </div>
          <div className="input-group">
            <label htmlFor="password">Password</label>
            <input
              type="password"
              id="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
            />
          </div>
          <button type="submit" className="login-btn">
            Login
          </button>
        </form>
        <div className="signup-link">
          <p>
            Don't have an account?{' '}
            <Link to="/create-account" className="signup-link-text">
              Sign up
            </Link>
          </p>
        </div>
        <div className="forget">
          <div className="fgtpassword">Forget Password?</div>
          <div>
            Remember Me
            <input className="chckbox" type="checkbox" />
          </div>
        </div>
      </div>
    </div>
  );
};

export default LoginPage1;
