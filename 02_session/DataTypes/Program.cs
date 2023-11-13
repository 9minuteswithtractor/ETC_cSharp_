using System;

namespace DataTpypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;

            // TODO: Data Types :
            /**
             *  string
             *  int
             *  double
             *  char
             *  bool
             *  long
             * 
             */

            Console.WriteLine("DataTypes:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("01 - string");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Hi and nice to meet You {0}!", userName);
            Console.WriteLine("Your name is type : {0}", userName.GetType());

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("02 - int");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Your age: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine($"No way! I'm also {userAge} and my name is {userName}");
            Console.WriteLine("You age type is : {0}", userAge.GetType());

            Console.ReadKey();
        }
    }
}