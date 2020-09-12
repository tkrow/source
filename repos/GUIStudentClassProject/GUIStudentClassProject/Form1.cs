using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIStudentClassProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Student s1;

        private void InputBtn_Click(object sender, EventArgs e)
        {
            string firstname = firstNameBox.Text;
            string lastname = lastNameBox.Text;
            string ssn = ssnBox.Text;
            string tgpa = gpaBox.Text;
            double dgpa = Convert.ToDouble(tgpa);

            s1 = new Student(firstname, lastname, ssn, dgpa);
        }

        private void OutputBtn_Click(object sender, EventArgs e)
        {
            string firstname = s1.FirstName;
            string lastname = s1.LastName;
            string ssn = s1.Ssn;
            double dgpa = s1.Gpa;
            string tgpa = dgpa.ToString();

            firstNameLabel.Text = firstname;
            lastNameLabel.Text = lastname;
            ssnLabel.Text = ssn;
            gpaLabel.Text = tgpa;
        }
    }

    class Student
    {
        private string firstName;
        private string lastName;
        private string ssn;
        private double gpa;

        public Student(string FirstName, string LastName, string Ssn, double Gpa)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.ssn = Ssn;
            this.gpa = Gpa;
        }

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
                ssn = value;
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
                gpa = value;
            }
        }

        //Methods
        public string ToString()
        {
            // Return all data from any given Student object:
            string data = null;
            data += "FirstName: " + FirstName;
            data += "\nLastName: " + LastName;
            data += "\nSsn: " + Ssn;
            data += "\nGpa: " + Gpa;

            //be sure to return!
            return data;
        }

    }
}
