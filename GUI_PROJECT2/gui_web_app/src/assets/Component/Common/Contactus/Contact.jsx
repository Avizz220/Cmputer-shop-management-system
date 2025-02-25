import React, { useState } from 'react';
import { Link } from 'react-router-dom'; // Import Link from react-router-dom
import './Contact.css';

const ContactPage1 = () => {
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [message, setMessage] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault();
    // Handle the form submission logic here
    console.log('Message Sent:', { name, email, message });
    // Reset form after submission
    setName('');
    setEmail('');
    setMessage('');
  };

  return (
    <div className="contact-container">
      <div className="contact-content">
        <h1>Contact Us</h1>
        <p>If you have any questions, feel free to reach out to us!</p>

        <form onSubmit={handleSubmit} className="contact-form">
          <div className="form-group">
            <label htmlFor="name">Full Name</label>
            <input
              type="text"
              id="name"
              value={name}
              onChange={(e) => setName(e.target.value)}
              required
              placeholder="Your Full Name"
            />
          </div>

          <div className="form-group">
            <label htmlFor="email">Email</label>
            <input
              type="email"
              id="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              required
              placeholder="Your Email Address"
            />
          </div>

          <div className="form-group">
            <label htmlFor="message">Message</label>
            <textarea
              id="message"
              value={message}
              onChange={(e) => setMessage(e.target.value)}
              required
              placeholder="Your Message"
            ></textarea>
          </div>

          <button type="submit" className="submit-btn3">Send Message</button>
        </form>

        {/* Back to Home Button inside the contact box */}
        <Link to="/dashboard">
          <button className="back-btn3">Back to Home</button>
        </Link>
      </div>

      <div className="contact-info">
        <h2>Our Address</h2>
        <p>Arina Computers, 123 Tech Avenue, Silicon Valley, CA</p>
        <h2>Phone</h2>
        <p>+1 (800) 123-4567</p>
        <h2>Email</h2>
        <p>contact@arinacomputers.com</p>
      </div>
    </div>
  );
};

export default ContactPage1;
