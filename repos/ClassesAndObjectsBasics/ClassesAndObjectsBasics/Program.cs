using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car object instantiation
            Car myCar = new Car();

            //assign a Make to myCar
            myCar.Make = "Toyota";
            //retrieve the Make for myCar
            Console.WriteLine("myCar.Make: {0}", myCar.Make);

            //assign a Model to myCar
            myCar.Model = "Highlander";
            //retrieve the Model for myCar
            Console.WriteLine("myCar.Model: {0}", myCar.Model);


            //Person class instantaition:
            Person me = new Person();

            //this will use the property's 'get' directive
            me.LastName = "Funk";
            Console.WriteLine("me.LastName: {0}", me.LastName);

            
            Console.ReadKey();
        }
    }

    class Person
    {
        //Here, we will make data members private, and their corresponding properties public
        private string lastName;
        private string firstName;
        private byte age;

        //Properties to access those data members:
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
    }

    //Here,we have the data members as 'public'
    //which is the easiest way to declare them.
    //However, this has its drawbacks.
    class Car
    {
        //Members can be variables and mehtods declared inside of a class

        //Data member is another name for a variable declared inide of a class

        //Properties of each and every Car object:
        public string Make;
        public string Model;
    }

    
}