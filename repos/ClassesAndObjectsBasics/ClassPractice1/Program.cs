using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student();
            Student Student2 = new Student();

            //assigns values to Student1
            Student1.firstName = "Johnny";
            Student1.lastName = "Johnny";
            Student1.ssn = "111-11-111";
            Student1.studentId = "10928";

            //assigns values to Student2
            Student2.firstName = "Shutup";
            Student2.lastName = "Will";
            Student2.ssn = "123-45-678";
            Student2.studentId = "09876";

            Console.WriteLine("First Name is: {0}\nLast Name is: {1}\nSSN is: {2}\nStudent's ID is: {3}", Student1.firstName, Student1.lastName, Student1.ssn, Student1.studentId);
            Console.WriteLine("First Name is: {0}\nLast Name is: {1}\nSSN is: {2}\nStudent's ID is: {3}", Student2.firstName, Student2.lastName, Student2.ssn, Student2.studentId);
            Console.ReadKey();
        }
    }

    class Student
    {
        public string firstName;
        public string lastName;
        public string ssn;
        public string studentId;
    }

    class Player
    {

    }
}
