using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddsandEnds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            string[] groceries = { "milk", "eggs", "cheese" };

            foreach (string grocery in groceries)
            {
                label1.Text += grocery + '\n';
            }

            // Date and Time Formatting
            label2.Text = "";
            string dateAndTime = String.Format("The date is {0:d} and the time is {0:t}", DateTime.Now);
            label2.Text = dateAndTime;
         
        }
    }
}
