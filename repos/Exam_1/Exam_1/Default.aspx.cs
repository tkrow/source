using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex == 0)
            {
                lblOutput.Text = "Please select a system.";
            }
            else
            {
                string lblOutputText = Convert.ToString(DropDownList1.SelectedItem);

                if(DropDownList1.SelectedIndex == 1)
                {
                    lblOutput.Text = "Thanks for selecting " + lblOutputText;
                }
                if (DropDownList1.SelectedIndex == 2)
                {
                    lblOutput.Text = "Thanks for selecting " + lblOutputText;
                }
                if (DropDownList1.SelectedIndex == 3)
                {
                    lblOutput.Text = "Thanks for selecting " + lblOutputText;
                }
                if (DropDownList1.SelectedIndex == 4)
                {
                    lblOutput.Text = "Thanks for selecting " + lblOutputText;
                }
            }
        }
    }
}