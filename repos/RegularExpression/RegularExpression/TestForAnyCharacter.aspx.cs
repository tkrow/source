using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class TestForAnyCharacter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string input = "";
            string input = "s";

            // Tests just one character
            Regex characterAnywhere = new Regex(".");

            Response.Write("characterAnywhere.IsMatch(input): " + characterAnywhere.IsMatch(input));
        }
    }
}