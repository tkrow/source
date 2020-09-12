using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstEmptyWebApplicationDotNetFramework
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check for form submission (PostBack)
            if(IsPostBack)
            {
                /* Validate each field:
                if (CheckFirstName())
                {
                    Response.Write("Good first name submission");
                }
                */

                // Overall flag variable for submission
                bool goodFormSubmission = true;

                // A better way:
                bool goodFirstName = CheckFirstName();

                bool goodLastName = CheckLastName();

                bool goodRadioButtonSelection = CheckRadioButtonOptions();

                // Test each; display specific error messages if necessary
                if (!goodFirstName)
                {
                    lblFirstNameError.Visible = true;
                    lblFirstNameError.Text = "Please enter a valid first name.";
                    goodFormSubmission = false;
                }
                else
                {
                    lblFirstNameError.Visible = false;
                }

                if (!goodLastName)
                {
                    lblLastNameError.Visible = true;
                    lblLastNameError.Text = "Please enter a valid first name."; 
                    goodFormSubmission = false;
                }
                else
                {
                    lblLastNameError.Visible = false;
                }

                if(!goodRadioButtonSelection)
                {
                    lblRadioButtonListError.Visible = true;
                    lblRadioButtonListError.Text = "Please enter a radio button.";
                    goodFormSubmission = false;
                }

                // Validate form data
                /* One approach (becomes unruly with added form controls)
                if(goodFirstName && goodLastName && goodRadioButtonSelection)
                {
                    // thank the user
                }
                */

                // Second approach (simpler):
                if(goodFormSubmission)
                {
                    // Hide original form
                    form1.Visible = false;
                    pnlThankYou.Visible = true;

                    //Display thank you message
                    DisplayThankYouMessage();
                }

                // Hide original form
                form1.Visible = false;
                pnlThankYou.Visible = true;

                //Display in now visible Panel
                DisplayThankYouMessage();

                Response.Write(string.Format("Response.StatusCode: {0}<br />", Response.StatusCode));
                Response.Write("\n<br />");

                Response.Write(string.Format("Response.StatusDescription: {0}<br>", Response.StatusDescription));
                Response.Write("\n<br />");

                Response.Write("\n<br />");

                //Display form information


            }
        }

        protected void DisplayFormData(object sender, EventArgs e)
        {
            
            /*
            Response.Write("Hello from Default.aspx.cs!");
            Response.Write("\n<br />");

            Response.Write(string.Format("Response.StatusCode: {0}<br />", Response.StatusCode));
            Response.Write("\n<br />");

            Response.Write(string.Format("Response.StatusDescription: {0}<br>", Response.StatusDescription));
            Response.Write("\n<br />");

            Response.Write("\n<br />");
            */


            // Get Data from form submission:

            // Two ways
            // 1. Use the "Text" property of a TextBox control
            Response.Write("\n<br />");
            Response.Write("TextBox.Text: " + TextBox1.Text);

            // 2. Use the Request.Form object
            Response.Write("\n<br />");
            Response.Write("Request.Form[\"TextBox\"]" + Request.Form["TextBox1"]);


            // Using a RadioButtonList
            Response.Write("RadioButtonList1.SelectedIndex.ToString(): " + RadioButtonList1.SelectedIndex.ToString());
            Response.Write("\n<br />");

            Response.Write("RadioButtonList1.SelectedItem: " + RadioButtonList1.SelectedItem);
            Response.Write("\n<br />");

            Response.Write("RadioButtonList1.SelectedValue: " + RadioButtonList1.SelectedValue);
            Response.Write("\n<br />");

            }

        public void DisplayThankYouMessage()
        {
            lblDisplayFirstName.Text = "First Name: " + TextBox1.Text;
            lblDisplayLastName.Text = "Last Name: " + TextBox2.Text;
            lblDisplayRadioButtonOption.Text = "Radio Button Option: " + RadioButtonList1.SelectedItem;
        }

        public bool CheckFirstName()
        {
            // Basic test for existence
            if(TextBox1.Text != "")
            {
                return true;    // if this is true, control will exit function here
            }
            return false;   // implicit 'else'
        }

        public bool CheckLastName()
        {
            // Basic test for existence
            if (TextBox2.Text != "")
            {
                return true;    // if this is true, control will exit function here
            }
            return false;   // implicit 'else'
        }

        public bool CheckRadioButtonOptions()
        {
            // sbyte number = Convert.ToSByte(Request.Form["RadioButtonList1"]);

            if (RadioButtonList1.SelectedIndex == -1)
            {
                return true;    // if this is true, control will exit function here
            }
            return false;   // implicit 'else'
        }
    }
}