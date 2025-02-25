import React from 'react';
import { Link, useNavigate } from 'react-router-dom'; // Import useNavigate for redirection
import './Dashboardpage.css'; // Ensure you have your dashboard styles

const Dashboard1 = () => {
    const navigate = useNavigate(); // Hook for navigation

    const handleLogout = () => {
        // You can clear authentication tokens or user session data here if necessary
        // For now, we'll simply navigate to the login page
        navigate('/');
    };

    return (
        <div className="dashboard-container">
            <div className="sidebar">
                <div className="sidebar-header">
                    <h2>Computer Shop</h2>
                </div>
                <div className="sidebar-menu">
                    <Link to="/add-item">
                        <button className="sidebar-button">Add To Stock</button>
                    </Link>

                    {/* Updated "Update Stock" button as a Link */}
                    <Link to="/update-item">
                        <button className="sidebar-button">Update Stock</button>
                    </Link>

                    <Link to="/delete-item">
                        <button className="sidebar-button">Delete Items</button>
                    </Link>

                    {/* Update About Us button to navigate to Contact Page */}
                    <Link to="/contact">
                        <button className="sidebar-button">About Us</button>
                    </Link>

                    <button className="sidebar-button">View My Stock</button>
                </div>

                {/* Logout Button */}
                <button className="sidebar-button" onClick={handleLogout}>Logout</button>
            </div>

            <div className="main-content">
                <header className="header">
                    <h1>Welcome To Arina Computers</h1>
                </header>
                <section className="statistics">
                    <div className="stat-card1">
                        <h3>Total Sales</h3>
                        <p>$10,500</p>
                    </div>
                    <div className="stat-card2">
                        <h3>Total Products</h3>
                        <p>120</p>
                    </div>
                    <div className="stat-card3">
                        <h3>Orders Today</h3>
                        <p>35</p>
                    </div>
                </section>

                <legend className='aboutus'>
                    
                        <h1 className='header'>What is Arina Computers</h1>
                        Arina Computers is a leading technology company specializing in the supply of high-quality computers, accessories, and tech solutions for both individual and business needs. Founded on the principles of innovation, reliability, and customer satisfaction, Arina Computers has earned a reputation as one of the most trusted names in the computer retail and service industry. Over the years, the company has grown from a small, local operation to a recognized player in the tech industry, providing cutting-edge products and services to a diverse range of clients.

                        At Arina Computers, we are committed to offering an extensive range of products, including desktops, laptops, gaming systems, and peripherals such as keyboards, mice, monitors, and printers. Our team carefully selects products from leading brands to ensure that our customers have access to the latest technology. Whether you are a student looking for an affordable laptop, a professional needing a powerful workstation, or a gamer seeking the ultimate gaming rig, Arina Computers has a solution that meets your needs.

                        Our business model is centered around providing excellent customer service. We believe in not only delivering high-quality products but also offering expert advice and after-sales support to ensure that customers get the most out of their purchases. The staff at Arina Computers are trained professionals who are passionate about technology and dedicated to helping clients make informed decisions when it comes to buying computers and related products.

                        Additionally, Arina Computers offers repair and maintenance services, ensuring that your equipment remains in top working condition throughout its life cycle. Our technicians are skilled in diagnosing and fixing a wide range of hardware and software issues, ensuring minimal downtime for your systems. Whether it's a hardware upgrade, software troubleshooting, or a full system repair, Arina Computers is your one-stop solution for all tech-related problems.

                        We also recognize the importance of sustainability and environmental responsibility. As part of our commitment to a greener future, we promote the recycling of old computer equipment and offer eco-friendly alternatives wherever possible. Our goal is to reduce e-waste while providing customers with high-performance products that are both durable and energy-efficient.

                        In summary, Arina Computers is dedicated to providing the best in technology, customer service, and sustainability. Our mission is to empower individuals and businesses by offering the tools they need to succeed in an increasingly digital world. Whether you are looking to purchase, repair, or maintain your computer systems, Arina Computers is the trusted partner you can count on for all your tech needs.
                   
                </legend>
            </div>

        </div>
    );
};

export default Dashboard1;
