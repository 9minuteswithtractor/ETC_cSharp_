using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfElseExample();

            TernanryCondition();

            Console.ReadKey();

        }

        private static void IfElseExample()
        {
            Console.Write("Please enter Your age? ");
            int.TryParse(Console.ReadLine(), out int userAge);


            if (userAge >= 60)
            {
                Console.WriteLine("You get to retire from work .");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine("You still have to work ");
            }
            else if (userAge > 0)
            {
                Console.WriteLine("You have whole life in front of You! ");

            } else
            {
                Console.WriteLine("Something went wrong ... ");
            }

        }


        private static void TernanryCondition()
        {

            Console.Write("Please enter Your age: ");
            int.TryParse(Console.ReadLine(), out int userAge);

            bool isAdult = userAge >= 18 ? true : false;

            Console.WriteLine($"User is adult : {isAdult}");

        }
    }
}
