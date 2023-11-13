using System;
using System.IO;

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


            // TODO: strings
            StringDataType();


            // TODO: int
            IntDataType();


            //TODO: bool
            BoolDataType();


            //TODO: char
            CharDataType();



            Console.ReadKey();
        }

        private static void StringDataType()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("01 - string");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Your name: ");

            try
            {
            string userName = Console.ReadLine();
            Console.WriteLine("Hi and nice to meet You {0}!", userName);
            Console.WriteLine("Your name is type : {0}", userName.GetType());
                GC.Collect();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            // TODO : freeing RAM memory

        }

        private static void IntDataType()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("02 - int");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Your age: ");
            // TODO: int.Parse

            try
            {
            int? userAge = int.Parse(Console.ReadLine());
            Console.WriteLine($"No way! I'm also {userAge}");
            Console.WriteLine("You age type is : {0}", userAge.GetType());
            GC.Collect();

            } catch (Exception ex)
            {
                Console.WriteLine("Ivalid data type! Please enter number as Your age!");
            }
            ////////////////////////////////////////////////

            
        }

        private static void BoolDataType()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("03 - bool");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Do You have driving license: ");

            try
            {
            string userInput = Console.ReadLine();
            bool? hasLicense = userInput.ToLower().StartsWith("y") ? true : false;
            Console.WriteLine($"User has driving license : {hasLicense}");
            Console.WriteLine("The data type of hasLicense variable is : {0}", hasLicense.GetType());

                // TODO : Garbage Collection
                GC.Collect();
            } catch (Exception ex)
            {
                Console.WriteLine("Please enter Yes or No ...");
            }

            // TODO: ternary operator 
            ////////////////////////////////////////////////////////////////////////

        }

        private static void CharDataType()
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("04 - char");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("What size T-shirt You usally wear?(S,M,L): ");

            try
            {
                char tShirtSize = char.Parse(Console.ReadLine());
                Console.WriteLine("Nice! Your are wearing size: {0}", tShirtSize);


            }
            catch
            {
                Console.WriteLine("Input must be one char long");
            }
        }
    }
}