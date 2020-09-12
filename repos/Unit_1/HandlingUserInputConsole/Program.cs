using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingUserInputConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //this program asks the user for the num of children they have

            //try to convert conosle input to an integer
            long numberOfChildren = -1;

            Console.WriteLine("How many children do you have?");

            // Option # 1
            //get user input, attempt to assign to 'numberOfChildren' variable
            //numberOfChildren = Console.ReadLine(); // can't work
            //L and R sides need the same data type           

            //Option # 2
            //Take any input and try converting it
            //numberOfChildren = Convert.ToInt32(Console.ReadLine());

            //Option # 3
            //Using Parse() method
            //This wont work sometimes. If user enters a string, program crashes
            //numberOfChildren = Int32.Parse(Console.ReadLine());

            //Option # 4
            //Using TryParse() method
            //Note: If TryParse() fails to convert data to appropriate type program does not crash
            //create variable that represents conversion success or failure
            bool successfulConversion = false;

            successfulConversion = Int64.TryParse(Console.ReadLine(), out numberOfChildren);

            //Output
            if (successfulConversion = true)
            {
                Console.WriteLine("You have {0} children.", numberOfChildren);
            }
            else
            {
                Console.WriteLine("You did not enter a valid number.");
                Console.WriteLine("You have {0} children.", numberOfChildren);
            }
            
            Console.ReadKey();
        }
    }
}
