using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*using System.Data.SqlClient;
using System.Data;

namespace MY_DESKTOP_APP
{
    public class Function_db
    {
        protected SqlConnection getconnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-6AKQJ9L\\SQLEXPRESS;database=computershop;integrated security=True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void SetData(String query)
        {
            SqlConnection con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data stored successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MY_DESKTOP_APP
{
    public class Function_db
    {
        // Method to establish the database connection
        protected SqlConnection getconnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-6AKQJ9L\\SQLEXPRESS;database=computershop;integrated security=True";
            return con;
        }

        // Method to fetch data from the database
        public DataSet getData(String query)
        {
            SqlConnection con = getconnection(); // Get the connection
            SqlCommand cmd = new SqlCommand();  // Create a command object
            cmd.CommandText = query;           // Assign the query text
            cmd.Connection = con;              // Associate the command with the connection
            SqlDataAdapter da = new SqlDataAdapter(cmd); // Create a data adapter
            DataSet ds = new DataSet();        // Create a dataset to hold the results
            da.Fill(ds);                       // Fill the dataset with the query results
            return ds;                         // Return the dataset
        }

        // Method to insert, update, or delete data in the database
        public void SetData(String query)
        {
            SqlConnection con = getconnection(); // Get the connection
            SqlCommand cmd = new SqlCommand();  // Create a command object
            cmd.Connection = con;              // Associate the command with the connection
            con.Open();                        // Open the connection
            cmd.CommandText = query;           // Assign the query text
            cmd.ExecuteNonQuery();             // Execute the query
            con.Close();                       // Close the connection
            MessageBox.Show("Data stored successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

