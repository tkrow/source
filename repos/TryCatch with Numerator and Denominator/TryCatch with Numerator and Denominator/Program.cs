using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_with_Numerator_and_Denominator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoodNumer = false;
            bool isGoodDenom = false;

            while (!isGoodNumer)
            {
                try
                {
                    Console.WriteLine("Please enter a Numerator.");
                    int numerator = int.Parse(Console.ReadLine());

                    isGoodNumer = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Way to go. You made 3 hours of work useless you f****** idiot.");
                }
            }

            while (!isGoodDenom)
            {
                try
                {
                    Console.WriteLine("Please enter a Denominator.");
                    int denominator = int.Parse(Console.ReadLine());

                    if (denominator > 0)
                    {
                        isGoodDenom = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a denominator greater than 0.");
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Way to go. You made 3 hours of work useless you f****** idiot.");
                }
            }


            Console.ReadKey();
        }
    }
}
