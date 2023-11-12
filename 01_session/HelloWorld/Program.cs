using System.Text.Json;

namespace HelloWorld
{
    internal class Program
    {

        static void Main()
        {
            // This is a LINE COMMENT

            /*
             *  This is
             *     A
             *     BLOCK COMMENT
             */
            
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Heisan, developer!");
            Console.Write("Please enter Your name: ");
            string userName = Console.ReadLine();

            GreetUser(userName);
            Console.ReadKey();
        }

        static void GreetUser(string userName)
        {
            Console.WriteLine($"Hello and Welcome to this C# course, {userName}!");
        }
    }
}