using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(randomNumGen(10));

            Console.ReadKey();
        }

        static int randomNumGen(int sides)
        {
            Random rand = new Random();
            int roll = rand.Next(1, sides + 1);
            return roll;
        }
    }
}
