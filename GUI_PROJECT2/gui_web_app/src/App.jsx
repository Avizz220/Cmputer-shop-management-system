import React from "react";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import LoginPage1 from "./assets/Component/Common/Login/Login";
import Dashboard1 from "./assets/Component/Common/Dashboard/Dashboardpage";
import AddItem1 from "./assets/Component/Common/Additem/Add";
import DeleteItems1 from "./assets/Component/Common/Deleteitem/Delete";
import ContactPage1 from "./assets/Component/Common/Contactus/Contact";
import UpdateItem1 from "./assets/Component/Common/Updateitem/Update";
import SignInForm1 from "./assets/Component/Common/Signin/Signinform";
import CreateAccount1 from "./assets/Component/Common/Createaccount/Createacc";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<LoginPage1 />} />
        <Route path="/dashboard" element={<Dashboard1 />} />
        <Route path="/add-item" element={<AddItem1 />} />
        <Route path="/delete-item" element={<DeleteItems1 />} />
        <Route path="/contact" element={<ContactPage1 />} />
        <Route path="/update-item" element={<UpdateItem1 />} />
        <Route path="/signup" element={<CreateAccount1 />} />
        <Route path="/create-account" element={<CreateAccount1 />} />
      </Routes>
    </Router>
  );
}

export default App;