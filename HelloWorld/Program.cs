namespace HelloWorld
{
    internal class Program
    {
        static void Main()
        {
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