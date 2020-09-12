using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XML_Loading
{
    public partial class XML_BookReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(MapPath("~/Books.xml"));
            GridView1.DataSource = dataSet.Tables[0];
            GridView1.DataBind();
        }
    }
}