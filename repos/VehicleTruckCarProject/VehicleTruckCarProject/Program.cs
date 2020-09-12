using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTruckCarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();

            Truck t1 = new Truck();

            Console.WriteLine("{0}", c1.CarString(true, true, 4, "Chevy", "Cruze", 2014, 12345, 123456, false));
            Console.WriteLine("{0}", t1.TruckString(true, true, 16));

            Console.ReadKey(true);
        }
    }

    class Vehicle
    {
        private bool hasWheels;
        private bool hasEngine;

        public bool HasWheels
        {
            get
            {
                return hasWheels;
            }
            set
            {
                hasWheels = value;
            }
        }

        public bool HasEngine
        {
            get
            {
                return hasEngine;
            }
            set
            {
                hasEngine = value;
            }
        }
    }

    class Car : Vehicle
    {
        private int numberOfWheels;
        private string make;
        private string model;
        private int year;
        private int currentValue;
        private int currentMileage;
        private bool underInspection;

        public int NumberOfWheels
        {
            get
            {
                return numberOfWheels;
            }
            set
            {
                numberOfWheels = value;
            }
        }

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public int CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
            }
        }

        public int CurrentMileage
        {
            get
            {
                return currentMileage;
            }
            set
            {
                currentMileage = value;
            }
        }

        public bool UnderInspection
        {
            get
            {
                return UnderInspection;
            }
            set
            {
                underInspection = value;
            }
        }

        public string CarString(bool hasWheels, bool hasEngine, int numberOfWheels, string make, string model, int year, int currentValue, int currentMileage, bool underInspection)
        {
            string data = null;

            data += "HasWheels: " + hasWheels;
            data += "\nHasEngine: " + hasEngine;
            data += "\nNumberOfWheels: " + numberOfWheels;
            data += "\nMake: " + make;
            data += "\nModel: " + model;
            data += "\nYear: " + year;
            data += "\nCurrentValue: " + currentValue;
            data += "\nCurrentMileage: " + currentMileage;
            data += "\nUnderInspection: " + underInspection;

            return data;
        }
    }

    class Truck : Vehicle
    {
        private int numberOfWheels;   

        public int NumberOfWheels
        {
            get
            {
                return numberOfWheels;
            }
            set
            {
                numberOfWheels = value;
            }
        }

        public string TruckString(bool hasWheels, bool hasEngine, int numberOfWheels)
        {
            string data = null;

            data += "\nHasWheels: " + hasWheels;
            data += "\nHasEngine: " + hasEngine;
            data += "\nNumberOfWheels: " + numberOfWheels;

            return data;
        }
    }
}

