using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIClassBasics
{
    public partial class Form1 : Form
    {
        //Create Student object here
        Student s;

        public Form1()
        {
            InitializeComponent();
        }

        private void saveStdntBtn_Click(object sender, EventArgs e)
        {
            //Change this to use data coming from form controls
            //instead of this hard coded example
            //s = new Student("Fred", "Funk", "123-45-6789", 4.0);
        }

        private void displayStdntBtn_Click(object sender, EventArgs e)
        {

        }
    }


    class Student
    {
        //Data members
        //aka Instance members
        //aka fields
        private string firstName;
        private string lastName;
        private string ssn;
        private double gpa;

        //Constructors
        //1. Default Constructor:


        //2. One that sets all 4 data members:
        //In this case, the name of the data members are 
        //the same names as the parameters
        public Student(string firstName, string lastName, string ssn, double gpa)
        {

            //Here, we will use the keyword 'this' to specify the data member
            //to refer to the parameter name, just use the parameter name.
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Gpa = gpa;
        }

        //Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Ssn
        {
            get
            {
                return ssn;
            }
            set
            {
                if (value.Length > 0 && value.Length >= 9)
                {
                    ssn = value;
                }
                else
                {
                    ssn = "Please enter a valid fucking ssn you cunt.";
                }
            }
        }

        public double Gpa
        {
            get
            {
                return gpa;
            }
            set
            {
                if (value > 0 && value <= 4)
                {
                    gpa = value;
                }
            }
        }
    }
}
