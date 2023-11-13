using System;


namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoTryCatch();
        }

        private static void DemoTryCatch()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Your age: ");
                    int userAge = int.Parse(Console.ReadLine());


                    Console.WriteLine("\nAwesome!");
                    Console.WriteLine($"I'm too {userAge}!");
                    break;


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please enter the right data type! ");
                    Console.WriteLine(ex.Message);
                }
            }

           

            Console.ReadKey();
        }
    }
}
