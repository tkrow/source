using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationControlOrdering
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitOrder_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int amountOrderedBoxValue;
                string amountOrderedBoxText = amountOrderedBox.Text;

                foreach (char a in amountOrderedBoxText)
                {
                    if (a == ' ')
                    {
                        orderConfirmation.Text = "Please do not use spaces.";
                        break;
                    }
                    else
                    {
                        foreach (char b in amountOrderedBoxText)
                        {
                            if (b == '0' | b == '1'| b == '2' | b == '3' | b == '4' | b == '5' | b == '6' | b == '7' | b == '8' | b == '9')
                            {
                                amountOrderedBoxValue = Convert.ToInt16(amountOrderedBoxText);

                                if (amountOrderedBoxValue > 99 || amountOrderedBoxValue < 1)
                                {
                                    orderConfirmation.Text = "Please enter an amount between 1 and 99.";
                                }
                                else
                                {
                                    if (subscriptionList.SelectedIndex == -1)
                                    {
                                        orderConfirmation.Text = "Please select one of two order options.";
                                    }
                                    else
                                    {                                 
                                        orderConfirmation.Text = "You have ordered " + amountOrderedBoxValue + " " + Label2.Text + "." +
                                            "You have chosen to " + subscriptionList.SelectedValue + ".";
                                    }
                                }                       
                            }
                            else
                            {
                                orderConfirmation.Text = "Please enter an amount between 1 and 99.";
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                orderConfirmation.Text = "Please enter an amount between 1 and 99.";

            }
        }
    }
}