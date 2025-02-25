import React, { useState } from 'react';
import { Link } from 'react-router-dom'; // Import Link for navigation
import './Update.css'; // Ensure this file has the correct styles

const UpdateItem1 = () => {
  const [productId, setProductId] = useState('');
  const [productName, setProductName] = useState('');
  const [description, setDescription] = useState('');
  const [price, setPrice] = useState('');
  const [quantity, setQuantity] = useState('');
  const [message, setMessage] = useState('');

  const handleUpdate = (e) => {
    e.preventDefault();
    // Here you would call an API or update the item in the list
    console.log('Item Updated:', { productId, productName, description, price, quantity });
    setMessage('Item updated successfully!');
    setProductId('');
    setProductName('');
    setDescription('');
    setPrice('');
    setQuantity('');
  };

  return (
    <div className="update-item-container">
      <div className="form-container">
        <h2>Update Item</h2>
        <p className="info-text">Update the item details below.</p>

        <form onSubmit={handleUpdate}>
          <div className="form-group">
            <label htmlFor="productId">Product ID</label>
            <input
              type="text"
              id="productId"
              value={productId}
              onChange={(e) => setProductId(e.target.value)}
              required
              placeholder="Enter Product ID"
            />
          </div>
          
          <div className="form-group">
            <label htmlFor="productName">Product Name</label>
            <input
              type="text"
              id="productName"
              value={productName}
              onChange={(e) => setProductName(e.target.value)}
              required
            />
          </div>

          <div className="form-group">
            <label htmlFor="description">Description</label>
            <textarea
              id="description"
              value={description}
              onChange={(e) => setDescription(e.target.value)}
              required
            />
          </div>

          <div className="form-group">
            <label htmlFor="price">Price</label>
            <input
              type="number"
              id="price"
              value={price}
              onChange={(e) => setPrice(e.target.value)}
              required
            />
          </div>

          <div className="form-group">
            <label htmlFor="quantity">Quantity</label>
            <input
              type="number"
              id="quantity"
              value={quantity}
              onChange={(e) => setQuantity(e.target.value)}
              required
            />
          </div>

          <button type="submit" className="submit-btn1">Update Item</button>
        </form>

        {message && <p className="message">{message}</p>}
      </div>

      {/* Back to Dashboard Button */}
      <Link to="/dashboard">
        <button className="back-btn1">Back </button>
      </Link>
    </div>
  );
};

export default UpdateItem1;
