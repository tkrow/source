using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballStats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creates the arrays for each column
            string[] name = { "Tom Brady", "Philip Rivers", "Matthew Stafford", "Drew Brees", "Ben Roethlisberger" };
            string[] team = { "NE", "LAC", "DET", "NO", "PIT" };
            int[] yard = { 4577, 4515, 4446, 4434, 4251 };
            double[] yarda = { 7.88, 7.85, 7.87, 8.09, 7.58 };
            int[] touchdown = { 32, 28, 29, 23, 28 };
            int[] interception = { 8, 10, 10, 8, 14 };
            int[] salary = { 4000000, 10000000, 9500000, 10200000, 12000000 };

            //prints out the values of each array according to the player
            lblPlayerStats1.Text = String.Format("{0} {1,29} {2,30} {3,38} {4,40} {5,43} {6,42" +
                "}", name[0], team[0], yard[0], yarda[0], touchdown[0], interception[0], salary[0]);
            lblPlayerStats2.Text = String.Format("{0} {1,26} {2,30} {3,38} {4,40} {5,43} {6,42" +
                "}", name[1], team[1], yard[1], yarda[1], touchdown[1], interception[1], salary[1]);
            lblPlayerStats3.Text = String.Format("{0} {1,18} {2,30} {3,38} {4,40} {5,43} {6,42" +
                "}", name[2], team[2], yard[2], yarda[2], touchdown[2], interception[2], salary[2]);
            lblPlayerStats4.Text = String.Format("{0} {1,27} {2,30} {3,39} {4,40} {5,43} {6,42" +
                "}", name[3], team[3], yard[3], yarda[3], touchdown[3], interception[3], salary[3]);
            lblPlayerStats5.Text = String.Format("{0} {1,16} {2,30} {3,39} {4,40} {5,43} {6,42" +
                "}", name[4], team[4], yard[4], yarda[4], touchdown[4], interception[4], salary[4]);
        }
    }
}
