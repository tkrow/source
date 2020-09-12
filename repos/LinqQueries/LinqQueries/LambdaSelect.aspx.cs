using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqQueries
{
    public partial class LambdaSelect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var mylist = new List<int>(new int[] { 1, 2, 3, 4, 5 });

            // store the squares of these numbers:
            var squares = mylist.Select(num => num * num);


            // loop throuhg squares
            foreach(int number in squares)
            {
                Response.Write("number: " + number + "<br />");
            }

        }

    }

}