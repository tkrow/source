using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseConnection
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1. get connection string
            string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

            // 2. create the connection
            SqlConnection dbConnection =
                new SqlConnection(connStr);

            // 3. open the connection
            dbConnection.Open();

            // 4. create a command based on a query
            //    including the connection string
            SqlCommand cmd = new SqlCommand("select * from Cars", dbConnection);

            // 5. execute the command/query
            SqlDataReader reader = cmd.ExecuteReader();

            // 6. Loop through and display:
            lcDataReader.Text = "<table style='border: 2px solid black;'>";

            lcDataReader.Text += "<tr>";
            lcDataReader.Text += "<th>Vin #</th>";
            lcDataReader.Text += "<th>Make</th>";
            lcDataReader.Text += "<th>Model</th>";
            lcDataReader.Text += "<th>Year</th>";
            lcDataReader.Text += "</tr>";

            while (reader.Read())
            {
                lcDataReader.Text += "\n<tr>";
                lcDataReader.Text += "\n<td> " + reader["vin"] + "</td>";
                lcDataReader.Text += "\n<td> " + reader["make"] + "</td>";
                lcDataReader.Text += "\n<td> " + reader["model"] + "</td>";
                lcDataReader.Text += "\n<td> " + reader["year"] + "</td>";
                lcDataReader.Text += "\n</tr>";
            }

            lcDataReader.Text += "\n</table>";

            // Close the connection
            dbConnection.Close();
        }
    }
}