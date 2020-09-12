using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class TestForPAtternAtEnd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input = "abcdef";

            // Test for "abc" at beginning of input:
            // ^ tests for match at the beginning
            Regex myDefAtEnd = new Regex("def$");

            Regex myDefAtEndBadPattern = new Regex("cde$");

            Response.Write("myDefAtEnd.IsMatch(input): " + myDefAtEnd.IsMatch(input));


            // "cde" is in there, but not at the beginning:
            Response.Write("myDefAtEndBadPattern.IsMatch(input): " + myDefAtEndBadPattern.IsMatch(input));
        }
    }
}