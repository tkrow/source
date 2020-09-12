using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIWidthLengthArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rectangle r1 = new Rectangle();

        private void processBtn_Click(object sender, EventArgs e)
        {
            string slength = lengthBox.Text;
            string swidth = widthBox.Text;
            double dlength = Convert.ToDouble(slength);
            double dwidth = Convert.ToDouble(swidth);

            r1.Length = dlength;
            r1.Width = dwidth;

            double dArea = r1.Area;
            string sArea = dArea.ToString();
            outputLbl.Text = sArea;
        }
    }

    class Rectangle
    {
        private double area;
        private double length;
        private double width;

        public double Area
        {
            get
            {
                this.area = Length * Width;
                return area;
            }
        }

        public double Length
        {
            get; set;
        }

        public double Width
        {
            get; set;
        }
    }
}
