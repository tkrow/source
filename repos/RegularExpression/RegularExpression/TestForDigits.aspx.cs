using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class TestForDigits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input = "1 good dog";

            // Test for a range for any digit 0 through 9
            Regex myDigitAnywhere = new Regex("[0-9]");

            Response.Write("myDigitAnywhere.IsMatch(input): " + myDigitAnywhere.IsMatch(input));


            Regex myDigitAnywhereBadPattern = new Regex("[2-9]");

            Response.Write("myDigitAnywhereBadPattern.IsMatch(input): " + myDigitAnywhereBadPattern.IsMatch(input));
        }
    }
}