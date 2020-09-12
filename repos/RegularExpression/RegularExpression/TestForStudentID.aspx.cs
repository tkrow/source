using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegularExpression
{
    public partial class TestForStudentID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // SH student IDs can be either 4 or 6 characters
            string input = "1234";

            // Regex testForGoodStudentID = new Regex("(^[0-9]{4}$)|(^[0-9]{6}$)"); // works
            // Regex testForGoodStudentID = new Regex("^(([0-9]{4})|([0-9]{6}))$");    // works
            Regex testForGoodStudentID = new Regex("^([0-9]{4}|[0-9]{6})$");    // works - 1 grouping
            // Regex testForGoodStudentID = new Regex("(^[0-9]{4}|[0-9]{6}$)"); // no - tests for either
            // 4 characters at the beginning or 6 at the end


            Response.Write("testForGoodStudentID.IsMatch(input): " + testForGoodStudentID.IsMatch(input));


        }
    }
}