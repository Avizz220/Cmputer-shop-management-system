import React, { useState } from 'react';
import { Link } from 'react-router-dom'; // Import Link from react-router-dom
import './Delete.css';

const DeleteItems1 = () => {
  const [itemId, setItemId] = useState('');
  const [reason, setReason] = useState('');
  const [deletionDate, setDeletionDate] = useState('');
  const [itemList, setItemList] = useState([
    { id: '001', name: 'Laptop' },
    { id: '002', name: 'Desktop' },
    { id: '003', name: 'Monitor' },
    { id: '004', name: 'Keyboard' },
  ]);
  const [message, setMessage] = useState('');

  const handleDelete = () => {
    const updatedItems = itemList.filter((item) => item.id !== itemId);
    if (updatedItems.length === itemList.length) {
      setMessage('Item not found.');
    } else {
      setItemList(updatedItems);
      setMessage(`Item deleted successfully! Reason: ${reason}, Date: ${deletionDate}`);
    }
    setItemId('');
    setReason('');
    setDeletionDate('');
  };

  return (
    <div className="delete-item-container">
      <div className="form-container">
        <h2>Delete Item</h2>
        <p className="info-text">Select the item ID you want to delete from the list below.</p>
        <select
          value={itemId}
          onChange={(e) => setItemId(e.target.value)}
          className="item-select"
        >
          <option value="">--Select Item--</option>
          {itemList.map((item) => (
            <option key={item.id} value={item.id}>
              {item.name}
            </option>
          ))}
        </select>

        {/* Input for Reason for Deletion */}
        <div className="input-group">
          <label htmlFor="reason">Reason for Deletion:</label>
          <input
            type="text"
            id="reason"
            value={reason}
            onChange={(e) => setReason(e.target.value)}
            placeholder="Enter reason"
          />
        </div>
        <br/>
        <br/>

        {/* Input for Date of Deletion */}
        <div className="input-group">
          <label htmlFor="deletion-date">Date of Deletion:</label>
          <input
            type="date"
            id="deletion-date"
            value={deletionDate}
            onChange={(e) => setDeletionDate(e.target.value)}
          />
          
        </div>

        <button onClick={handleDelete} className="delete-btn">
          Delete Item
        </button>

        {message && <p className="message">{message}</p>}

        {/* Back to Home Button */}
        <Link to="/dashboard">
          <button className="back-btn2">Back to Home</button>
        </Link>
      </div>
    </div>
  );
};

export default DeleteItems1;
