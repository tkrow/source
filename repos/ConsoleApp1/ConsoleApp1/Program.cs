using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // sets the type of the array, containing ten values in mixed order
            int[] myArray = { 1, 3, 5, 6, 2, 4, 8, 7, 10, 9 };

            orderFromSmallestToLargest(myArray);
            Console.ReadKey();
        }

        // order the array from smallest to largest
        static void orderFromSmallestToLargest(int[] myArray)
        { 
            for(int i = 0; i == myArray.Length; i++)
            {
                if (myArray[i] < myArray[i] + 1)
                {
                    myArray[i] = myArray[i] + 1;
                }
            }

            printArray(myArray);
        }

        // print out the whole array
        static void printArray(int[] myArray)
        {
            foreach(int num in myArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
