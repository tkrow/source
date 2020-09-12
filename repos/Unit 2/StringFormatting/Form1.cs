using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFormatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Currency (and output)
            double bankBalance = 12345.6789;
            string formattedBankBalance = String.Format("I have {0:C2} in the bank.", bankBalance);
            lblCurrencyTwoDemialPlaces.Text = formattedBankBalance;


            //Numeric To Three Decimal Places (and output)
            lblNumericFormatting.Text = String.Format("Numeric formatting for bank balance: {0:N3}", bankBalance);


            //Alignment - Right
            lblRightAlignment.Text = String.Format("Right alignment for bank balance: {0,30:C}", bankBalance);


            //Alignment - Left
            lblLeftAlignment.Text = String.Format("Left alignment for bank balance: {0,-30:C}", bankBalance);


            //Alignment - Left - Two Values
            lblLeftAlignmentTwoValues.Text = String.Format("Two values: {0,-30:C} {1,-30}", bankBalance, 567.89);
        }
    }
}
