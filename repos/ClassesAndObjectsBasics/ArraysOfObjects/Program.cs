using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of 10 students
            Student[] students = new Student[10];

            //students[0].FirstName = "Fred"; //No!
            //- this will throw an exception since the 
            //individual object is uninitialized
            //(slips past the compiler)

            //Initialize each one
            for(int i=0; i < students.Length; i++)
            {
                students[i] = new Student();
            }

            foreach(Student s in students)
            {
                students[] = new Student();
            }

            Console.ReadKey();
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
        //public Student(string firstName, string lastName, string ssn, double gpa)
        //{

            //Here, we will use the keyword 'this' to specify the data member
            //to refer to the parameter name, just use the parameter name.
            //this.FirstName = firstName;
            //this.LastName = lastName;
            //this.Ssn = ssn;
            //this.Gpa = gpa;
        //}

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
