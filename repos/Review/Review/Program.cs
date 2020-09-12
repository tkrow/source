using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    class Program
    {
        //passes a randomly rolled integer into the different methods
        public static int Roll(int maxSides)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, maxSides + 1);
            return num;
        }

        //practice for making a simple method
        public static void showSeats(int roomnum, int seats) 
        {
            Console.WriteLine("Room {0} has {1} seats." ,roomnum, seats);
        }

        //practice for adding numbers within a method and no return
        public static void addWithoutReturn(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}",num1, num2, sum);
        }

        //practice for adding numbers withing a method with return
        public static int addWithReturn(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
            return sum;
        }

        static void Main(string[] args)
        {
            showSeats(1, 12);
            showSeats(2, 14);
            addWithoutReturn(Roll(43), Roll(32));
            addWithReturn(Roll(53), Roll(951));

            int mysum = addWithReturn(Roll(5), Roll(9));

            Console.ReadKey();
        }
    }
}
