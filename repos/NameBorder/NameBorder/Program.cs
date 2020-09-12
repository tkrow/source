using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameBorder
{
    class Program
    {
        public static void DisplayWithStarBorder(int number)
        {
            const int EXTRA_STARS = 4;
            int numberOfStars = 0;
            int input = number;


            for (int i = 0; i < number; i++)
            {
                int divisor = number / 10;

                if (divisor > 0)
                {
                    numberOfStars++;
                    Console.WriteLine("divisor is: {0}", divisor);
                    number = divisor;
                }
                else
                {

                }               
            }

            for (int j = 0; j < numberOfStars + EXTRA_STARS - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n*{0}*", input);

            for (int j = 0; j < numberOfStars + EXTRA_STARS - 1; j++)
            {
                Console.Write("*");
            }
        }
        
        static void Main(string[] args)
        {
            DisplayWithStarBorder(123);

            Console.ReadKey();
        }
    }
}