using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class TestForPatternAtBeginning : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input = "abcdef";

            // Test for "abc" at beginning of input:
            Regex myAbcAtBeginning = new Regex("^abc");

            Regex myAbcAtBeginningBadPattern = new Regex("^def");

            Response.Write("myAbcAtBeginning.IsMatch(input): " + myAbcAtBeginning.IsMatch(input));


            // "bcd" is in there, but not at the beginning:
            Response.Write("myAbcAtBeginningBadPattern.IsMatch(input): " + myAbcAtBeginningBadPattern.IsMatch(input));
        }
    }
}