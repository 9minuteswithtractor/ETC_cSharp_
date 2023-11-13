using System;
using System.Collections.Concurrent;
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
             *  bool
             *  char
             *  double
             *  DateTime
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


            //TODO: double
            DoubleDataType();


            //TODO: DateTime
            DateTimeDataType();

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
                Console.WriteLine("Data type of your name is : {0}", userName.GetType());
                GC.Collect();

            }
            catch (Exception ex)
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
                Console.WriteLine("Your age type is : {0}", userAge.GetType());
                GC.Collect();

            }
            catch (Exception ex)
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter Yes or No ...");
            }

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
                char tShirtSize = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine("Nice! Your are wearing size: {0}", tShirtSize);
                Console.WriteLine("The data type of T-shirt size variable is : {0}", tShirtSize.GetType());


            }
            catch
            {
                Console.WriteLine("Input must be one char long");
            }
        }
        
        private static void DoubleDataType()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("05 - double");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("What is Your hight?(cm): ");

            try
            {
                double? userHight = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nice! Your hight is {userHight}cm");
                Console.WriteLine("The dataType of user hight is : {0}", userHight.GetType());
                GC.Collect();

            } catch (Exception ex)
            {
                Console.WriteLine("Please enter number as Your hight!");
            }
        }

        private static void DateTimeDataType()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("06 - DateTime");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            try
            {

                DateTime now = DateTime.Now;
                Console.WriteLine("Now is {0}", now.ToString("ddd dd MMM HH:mm"));
                Console.WriteLine("The data type of DateTime variable is : {0}", now.GetType());


            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not display date / time data ...");
            }

        }
    }
}