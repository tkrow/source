using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "hello, world!";

            //print the "h"
            Console.WriteLine(greeting[0]);

            //print the ","
            Console.WriteLine(greeting[5]);

            //Now, using the Substring method:

            //Print just the word "world":
            Console.WriteLine("Print just the word 'world!': {0}", greeting.Substring(7));

            //Print just the "!"
            Console.WriteLine("Print just the '!': {0}", greeting.Substring(12));

            //Version 2 of the Substring(int, int)

            //Print just the word "hello"
            Console.WriteLine("Print just the 'hello': {0}", greeting.Substring(0, 5));

            //Print just the word "world"
            Console.WriteLine("Print just the 'world': {0}", greeting.Substring(7, 5));

            //Out of range error:
            //Console.WriteLine(greeting.Substring(20));        \\generates "developer is fucking retarted error"
            //ArgumentOutOfRange error




            //Basic handling of errors for Substring:
            int startingIndex = 20;
            int myLength = 6;

            //Only use if the startingIndex is less than the length:
            if(startingIndex < greeting.Length)
            {
                Console.WriteLine("Print just the 'hello': {0}", greeting.Substring(startingIndex));
            }
            else
            {
                Console.WriteLine("startingIndex is greater than length of string; please try again");
            }

            //2. length is too long
            int mySubstringLength = 10;

            //if the number for the length of the substring is greater than the overall length of the string
            if(mySubstringLength > greeting.Length)
            {
                Console.WriteLine("substring is too long");
            }


            if(mySubstringLength + startingIndex < greeting.Length)
            {
               
            }
            else
            {
                Console.WriteLine("You will exceed the bounds of the string.");
            }

            Console.ReadKey(true);
        }
    }
}
