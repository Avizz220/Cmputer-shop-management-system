import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import "./Signinform.css";

const SignInForm1 = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const navigate = useNavigate();

  const handleSignIn = (e) => {
    e.preventDefault();
    console.log("Username:", username);
    console.log("Password:", password);
  };

  return (
    <div className="signin-container">
      <div className="signin-form">
        <h2>Welcome Back</h2>
        <p className="subtitle">Sign in to continue</p>
        <form onSubmit={handleSignIn}>
          <div className="input-group">
            <label htmlFor="username">Username</label>
            <input
              type="text"
              id="username"
              placeholder="Enter your username"
              value={username}
              onChange={(e) => setUsername(e.target.value)}
              required
            />
          </div>
          <div className="input-group">
            <label htmlFor="password">Password</label>
            <input
              type="password"
              id="password"
              placeholder="Enter your password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              required
            />
          </div>
          <div className="actions">
            <a href="#" className="forgot-password">
              Forgot Password?
            </a>
          </div>
          <button type="submit" className="signin-btn">
            Sign In
          </button>
        </form>
        <p className="create-account">
          Don’t have an account?{" "}
          <span
            className="create-link"
            onClick={() => navigate("/create-account")}
          >
            Create one
          </span>
        </p>
      </div>
    </div>
  );
};

export default SignInForm1;
