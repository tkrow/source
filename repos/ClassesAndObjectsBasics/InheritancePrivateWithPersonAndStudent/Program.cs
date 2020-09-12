using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrivateWithPersonAndStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            //s1.firstName = "Fred";    //no longer public
            //s1.studentId = "007";     //no longer public

            s1.FirstName = "Fred";
            s1.StudentId = "007";

            Console.WriteLine("s1.ToString(): {0}", s1.ToString());

            Console.ReadKey();
        }
    }

    class Person
    {
        //Data members
        private string firstName = "no first name set";
        private string lastName = "no last name set";
        protected string ssn = "no ssn set";

        //Accesors and Mutators
        public string FirstName
        {
            get; set;
        }
    }

    //
    class Student : Person
    {
        //Data members
        private string studentId;
        private double gpa;

        //Get / Set
        public string StudentId
        {
            get
            {
                return StudentId;
            }

            set
            {
                studentId = value;
            }
        }

        //methods
        public string ToString()
        {
            return "studentId: " + studentId + "\n gpa: " + gpa + "\n ssn: " + ssn;
        }
    }
}

