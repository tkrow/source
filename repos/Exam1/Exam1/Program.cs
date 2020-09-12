using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        public static void PrintMultiple(string text, int prints)
        {
            for(int i = 0; i < prints; i++)
            {
                Console.WriteLine(text);
            }
        }

        static void Main(string[] args)
        {
            string text = "Hello World";
            int prints = 4;

            PrintMultiple(text, prints);

            Console.ReadKey();
        }
    }
}
