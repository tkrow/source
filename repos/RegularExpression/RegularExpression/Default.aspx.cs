using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input = "I already know my abc's";

            string pattern = "abc";

            Regex myRegex = new Regex(pattern);

            //test for "abc" in "I know about my abc's"
            Response.Write("myRegex.IsMatch(input): " + myRegex.IsMatch(input));


            //not a match for the following:
            string badPattern = "123";

            Regex myRegexBadPattern = new Regex(badPattern);

            Response.Write("myRegexBadPattern.IsMatch(input): " + myRegexBadPattern.IsMatch(input));
        }
    }
}