using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public static int lowNum(int[] num)
        {
            int lowNum = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[1] < lowNum)
                {
                    lowNum = num[i];
                }
            }
            return lowNum;
        }

        //find the lowest number in an array of numbers
        public static void findLowNum(int[] num)
        {
            //sets the first number in array to the lowest
             int lowNum = num[0];

            //if lower number found, reset the lowest number
            for (int i = 1; i < num.Length; i++)
            {
                if ( num[i] < lowNum)
                {
                    //sets the number currently examined as the new lowest number
                    lowNum = num[i];
                }
            }
            //after the loop output lowest number:
            Console.WriteLine("The lowNum is : {0}.", lowNum);
        }

        static void Main(string[] args)
        {
            int[] myNum = { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45};

            findLowNum(myNum);
            Console.WriteLine(lowNum(myNum));
            Console.ReadKey();
        }
    }
}
