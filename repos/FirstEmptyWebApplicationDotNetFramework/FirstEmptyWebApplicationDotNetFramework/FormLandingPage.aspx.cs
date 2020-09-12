using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstEmptyWebApplicationDotNetFramework
{
    public partial class FormLandingPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Request.Form[\"TextBox\"]" + Request.Form["TextBox1"]);

            // Getting values from Radio Buttons
            Response.Write("Request.Form[\"RadioButton1\"]: " + Request.Form["RadioButton1"]);


            
        }
    }
}