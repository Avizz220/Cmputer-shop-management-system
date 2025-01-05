import React, { useState } from "react";
import "./Login.css";

export function Login1() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    alert(`Email: ${email}, Password: ${password}`);
  };

  return (
  
      <div className="login-wrapper">
        <div className="login-card">
          <div className="center">
            <h2>Welcome To Sampath Computers</h2>

            <form onSubmit={handleSubmit}>
              <div className="input-group">
                <label>Email</label>
                <input
                  type="email"
                  placeholder="Enter your email"
                  value={email}
                  onChange={(e) => setEmail(e.target.value)}
                  required
                />
              </div>
              <div className="input-group">
                <label>Password</label>
                <input
                  type="password"
                  placeholder="Enter your password"
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
                  required
                />
              </div>
              <button type="submit" className="login-button">
                Login
              </button>
              <div className="login-footer">
                <a href="/forgot-password">Forgot password?</a>
                <span> | </span>
                <a href="/register">Create an account</a>
              </div>
            </form>
          </div>
        </div>
      
    </div>
  );
}
