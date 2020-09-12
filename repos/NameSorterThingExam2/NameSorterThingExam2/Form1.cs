using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSorterThingExam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            //sets the initial value for the textbox input
            string name = nameBox.Text;


            //sets the input to lowercase to (hopefully) reduce errors
            string lname = name.ToLower();


            //removes any spaces put before or after the text input
            string tname = lname.Trim();


            //works through whether or not the overanalyzed and edited string 
            //has 'Mr.' or 'Mrs.'
            if (lname.Contains("mr.") || (lname.Contains("mrs.")))
            {
                outputLbl.Text = "Thank you for your input.";
            }
            else
            {
                outputLbl.Text = "Please enter a title.";
            }
        }
    }
}
