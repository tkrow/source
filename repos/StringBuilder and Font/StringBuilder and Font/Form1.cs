using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBuilder_and_Font
{
    public partial class Form1 : Form
    {
        public void twoStringBuilder(StringBuilder oldtitle, StringBuilder olddescription)
        {
            string title;
            string description;
            int titleLength = oldtitle.Length;
            int descriptionLength = olddescription.Length;

            if(oldtitle.Length > 25)
            {
                oldtitle.Remove(25, titleLength - 25);
                oldtitle.Insert(25, "...");
                title = oldtitle.ToString();
                titleLabel.Text = title;
            }
            else
            {
                title = oldtitle.ToString();
                titleLabel.Text = title;
            }

            if (olddescription.Length > 30)
            {
                olddescription.Remove(30, descriptionLength - 30);
                olddescription.Insert(30, "... To read more, subscribe to our service.");
                description = olddescription.ToString();
                descriptionLabel.Text = description;
            }
            else
            {
                olddescription.Insert(descriptionLength, " To read more, subscribe to our service.");
                description = olddescription.ToString();
                descriptionLabel.Text = description;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void descriptionBtn_Click(object sender, EventArgs e)
        {
            StringBuilder title = new StringBuilder(titleBox.Text, 25);
            StringBuilder description = new StringBuilder(descriptionBox.Text, 30);
            Font titleFont = new Font("Papyrus", 15);

            titleLabel.Font = titleFont;
            twoStringBuilder(title, description);
        }
    }
}
