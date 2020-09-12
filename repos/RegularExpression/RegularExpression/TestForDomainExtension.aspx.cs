using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class TestForDomainExtension : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string input = "southhills.edu";
            // string input = "southhills.edu";
            string input = ".edu";
            // string input = "Xedu";

            Regex myDomainExtension = new Regex(@"\.(com|edu|net|org|gov)$");

            Response.Write("myDomainExtension.IsMatch(input): " + myDomainExtension.IsMatch(input));

        }
    }
}