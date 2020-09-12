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
    public partial class InsertCarRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // 1. get connection string
                string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

                // 2. create the connection
                SqlConnection dbConnection =
                    new SqlConnection(connStr);

                // 3. open the connection
                dbConnection.Open();

                // 4. create a command based on a query
                string vin = txtVin.Text;
                string make = txtMake.Text;
                string model = txtModel.Text;
                string year = txtYear.Text;
                int isUnderInspection = Convert.ToInt32(chkInspected.Checked);

                // 5. Create query
                string query = string.Format("INSERT INTO cars (vin, make, model, year, isUnderInspection) " +
                    "VALUES ('{0}','{1}','{2}','{3}', {4});", vin, make, model, year, isUnderInspection);

                SqlCommand cmd = new SqlCommand(query, dbConnection);

                cmd.BeginExecuteNonQuery();

                // debug
                Response.Write("query: " + query);
            }

        }// end if(isPostBack)

    }// end Page_Load

}