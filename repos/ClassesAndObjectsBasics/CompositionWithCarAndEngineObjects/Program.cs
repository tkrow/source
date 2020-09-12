using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionWithCarAndEngineObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            // "Primitive" data member setting:
            myCar.make = "Subaru";
            myCar.model = "Impreza WRX";
            // Setting myCar's engine's data:


            // myCar.engine = new Engine();  // we could do this here,
            // but we will instatiate the Engine in a constructor

            // Example 1 - all data members are public
            myCar.engine.displacementInCC = 2466;


            // Example 2
            // Example where myCar's Engine is public,
            // but the Engine's name is private:
            myCar.engine.setName("EJ25");

            // output myCar's enigne's name:
            Console.WriteLine("myCar.engine.getName(): {0}", myCar.engine.getName());



            // Example 3
            // where myCar's Engine is private (now known as EngineAsPrivate)

            // set name:
            myCar.getEngineAsPrivate().setName("EJ25");

            Console.WriteLine("myCar.getEnigineAsPrivate().getName():", myCar.getEngineAsPrivate().getName());

            Console.ReadKey();
        }
    }

    class Car
    {
        public string make;
        public string model;
        // Using Composition by having an Engine as a data member:
        // (Note: having two Engines here is just  to demonstrate
        // the difference between public and private objects.)
        public Engine engine;   // Note: be sure to instantiate this somewhere!
        private EngineAsPrivate engineAsPrivate;

        // Constructor
        public Car()
        {
            engine = new Engine();  // we can instantiate its Engine here
            engineAsPrivate = new EngineAsPrivate();
        }

        // get/set EngineAsPrivate
        public EngineAsPrivate getEngineAsPrivate()
        {

        }

    }

    class EngineAsPrivate
    {
        private string name;
        // get/set name

        // set:
        public void setName(string name)
        {
            this.name = name;
        }
        // get:
        public string getName()
        {
            return name;
        }
    }

    class Engine
    {
        // should eventually be private data members
        private string name;
        public int numberOfCylinders;
        public int displacementInCC;

        // get/set name:
        
        // set:
        public void setName(string name)
        {
            this.name = name;
        }
        // get:
        public string getName()
        {
            return name;
        }
    }
}
