using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("r1.Length: {0}", r1.Length);

            //Set the length of r1:
            r1.Length = 5;
            Console.WriteLine("r1.Length: {0}", r1.Length);

            //Set the width  of r1:
            r1.Width = 10;
            Console.WriteLine("r1.Width: {0}", r1.Width);

            //set area of r1:
            r1.SetArea();
            //Console.WriteLine("r1.area: {0}", r1.area);
            //cannot

            Console.WriteLine("r1.Area: {0}", r1.Area);

            //Attempt to set the area
            //r1.Area = 99



            //Using get and set methods

            //Set the length using the set method for Rectangle:
            r1.setLength(12); //logical equivalent of: r1.Length


            Console.ReadKey();
        }
    }

    class Rectangle
    {
        //Data Members
        private int length;
        private int width;
        private int area;   //should only be set with a calculation

        //Constructors

        //Properties
        public int Length
        {
            get; set;
        }

        public int Width
        {
            get; set;
        }

        public int Area
        {
            get
            {
                return area;
            }
        }

        //set the area
        public void SetArea()
        {
            area = Length * Width;
        }

        //Alternative to using properties
        //Using getter and setter methods

        //Length get and set
        
        //"get" method
        public void setLength(int Length)
        {
            this.length = length;
        }
        //"set" method
        public 
    }
}