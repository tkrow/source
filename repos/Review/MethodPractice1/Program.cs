using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1
{
    class Program
    {
        private static void findHighestNumber(double[] num)
        {
            double number = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if(num[i] > number)
                {
                    number = num[i];
                }
            }
            Console.WriteLine("The biggest number is {0}.", number);
        }

        private static void reverseIntArray(int[] num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
        }

        private static void doubleMyNumbers(double[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                double value = num[i] * 2;
                Console.WriteLine("The double of {0} is {1}.", num[i], value);
            }       
        }

        private static int subtract(int num1, int num2)
        {
            int sub = num1 - num2;
            return sub;
        }

        private static int subtractAbsoluteValue(int num1, int num2)
        {
            if (num1 < num2)
            {
                int sub = num2 - num1;
                return sub;
            }
            else
            {
                int sub = num1 - num2;
                return sub;
            }
        }

        static void Main(string[] args)
        {
            double[] Dnum = { 1.3, 2.1, 3.7, 4.9, 5.3};
            int[] Inum = { 1, 2, 3, 4, 5 };

            findHighestNumber(Dnum);
            doubleMyNumbers(Dnum);
            Console.WriteLine("The difference of 14 and 5 is " + subtract(14, 5));
            Console.WriteLine("The difference of 6 and 10 is " + subtractAbsoluteValue(6, 10));
            reverseIntArray(Inum);

            Console.ReadKey();
        }
    }
}
