using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research_Various_String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //the Contains() method as requested
            string words = "South Hills School of Business and Technology";
            string word = "School";
            bool w = words.Contains(word);

            if (w == true)
            {
                Console.WriteLine("'School' is somewhere in this sentence.");
            }
            else
            {
                Console.WriteLine("I messed up somewhere here.");
            }
            Console.ReadKey();


            //the ToLower() method as requested
            string caps = "WHY SO SERIOUS";
            Console.WriteLine(caps.ToLower());
            Console.ReadKey();


            //the Split() method as requested
            string food = "Milk,Eggs,Bread,Cheese";
            string[] Ingredients = food.Split(',');
            Console.WriteLine(Ingredients[0]);
            Console.WriteLine(Ingredients[1]);
            Console.WriteLine(Ingredients[2]);
            Console.WriteLine(Ingredients[3]);


            Console.ReadKey();
        }
    }
}
