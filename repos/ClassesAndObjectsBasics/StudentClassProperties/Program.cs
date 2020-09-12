using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student class instantaition (student1 and student2)
            //Student student1 = new Student();
            //Student student2 = new Student();
            Student student3 = new Student("Tim", "Krow", "123456789", 3.5);

            //Student1
            //student1.FirstName = "Frank";
            //student1.LastName = "Werth";
            //student1.Ssn = "75641986";
            //student1.Gpa = 4;

            //Student2
            //student2.FirstName = "Robert";
            //.LastName = "SpeedWagon";
            //student2.Ssn = "198573628";
            //student2.Gpa = 4;

            //Console.WriteLine("{0} {1}    ssn: {2}    gpa: {3}", student1.FirstName, student1.LastName, student1.Ssn, student1.Gpa);
            //Console.WriteLine("{0} {1}    ssn: {2}    gpa: {3}", student2.FirstName, student2.LastName, student2.Ssn, student2.Gpa);
            
            Console.ReadKey();
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
}
