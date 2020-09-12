using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace LinqQueries
{
    public partial class LINQtoSQL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["myDatabaseConnectionString"].ConnectionString;

            DataClasses1DataContext db = new DataClasses1DataContext(connStr);

            // LINQ syntax:
            var query = from record in db.GetTable<Car>()
                        select record;

            GridView1.DataSource = query;

            // Be sure to DataBind()!
            GridView1.DataBind();
        }
    }
}