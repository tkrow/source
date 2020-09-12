using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationBasics
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Page.Validate();
            }

            // Only check if in PostBack:
            if (Page.IsValid)
            {
                Response.Write("Page is valid.");
            }
            else
            {
                Response.Write("Page is not valid.");
            }
        }

        public void validateLastName(object source, ServerValidateEventArgs args)
        {
            if (txtLastName.Text == "")
            {
                args.IsValid = false;
            }
        }
    }
}