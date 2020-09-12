using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringManipulations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void containsButton_Click(object sender, EventArgs e)
        {
            string containsUserInput = containsInput.Text;
            string containsUserTestFor = containsTestFor.Text;
            string input = containsUserInput.ToLower();
            string test = containsUserTestFor.ToLower();

            bool contains = input.Contains(test);

            //Option 1
            //Outputs whether or not something is in the input
            //containsOutput.Text = Convert.ToString(contains);

            //Option 2
            //Outputs whether something is in the input or not
            //in text, not boolean
            if(contains)
            {
                containsOutput.Text = containsUserTestFor + " is in " + containsUserInput;
            }
            else
            {
                containsOutput.Text = containsUserTestFor + " is not in " + containsUserInput;
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string insertStringInput = insertInput.Text;
            string stringInserted = insertUserInput.Text;
            int insertIndex = Convert.ToInt32(insertLocation.Text);

            if (insertIndex > insertStringInput.Length)
            {
                MessageBox.Show("You cannot input strings too far away from the base sentence");
                insertIndex = 0;
            }
            else
            {
                string insertResult = insertStringInput.Insert(insertIndex, stringInserted);

                //Output
                InsertOutput.Text = String.Format("After insert: {0}", insertResult);
            }           
        }

        private void crtStringBuilder_Click(object sender, EventArgs e)
        {
            //int removeIndex1 = Convert.ToInt32(removeStringBuilder1.Text);
            //int removeIndex2 = Convert.ToInt32(removeStringBuilder2.Text);

            //1
            //StringBuilder sb = new StringBuilder(mainStringBuilder.Text);
            //find and remove specified index characters
            //sb.Remove(removeIndex1, removeIndex2);
            //stringBuilderOutput.Text = sb.ToString();


            //2
            //Here we initialize an SB object with no text
            StringBuilder myStringBuilder = new StringBuilder();


            //3 
            //myStringBuilder = stringBuilderInput.Text; //bad assignment

            //One way: "reconstruct" the SB object
            //myStringBuilder = new StringBuilder(mainStringBuilder.Text);

            //Another way:
            //Using the StringBuilder Append() method
            //myStringBuilder.AppendFormat("{0}", mainStringBuilder.Text);

            //Allow for placeholders
            myStringBuilder.AppendFormat("{0}{0}{0}", mainStringBuilder.Text);

            //Output
            stringBuilderOutput.Text = myStringBuilder.ToString();
        }
    }
}
