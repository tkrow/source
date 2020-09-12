using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWIthPersonAndStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.firstName = "Fred";
            s1.studentId = "007";
        }
    }

    class Person
    {
        //Data members
        public string firstName = "no first name set";
        public string lastName = "no last name set";
        public string ssn = "no ssn set";
    }

    //
    class Student : Person
    {
        //Data members
        public string studentId;
        public double gpa;
    }
}
