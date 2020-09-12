using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegularExpression
{
    public partial class TestForMultipleInstancesOfCharacterClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // test for proper end of SSN:
            // string input = "123-45-6789";   // good case

            string input = "123-45-6789";    // bad case

            // the following just tests for 1 digit at end
            // Regex testForLast4Digits = new Regex("[0-9]$");
            
            Regex testForLast4Digits = new Regex("[0-9]{4}$");

            Response.Write("testForLast4Digits.IsMatch(Input): " + testForLast4Digits.IsMatch(input));


            Regex testForlastGoodSSN = new Regex("^[0-9]{3}-[0-9]{2}-[0-9]{4}$");

            Response.Write("testForLastGoodSSN.IsMatch(input): " + testForlastGoodSSN.IsMatch(input));
        }
    }
}