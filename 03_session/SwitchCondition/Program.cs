using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwitchCase();
            Console.ReadKey();
        }

        static void SwitchCase()
        {
            Console.Write("What is current season of the year? (P / V / R / Z): ");
            
            char seasonChar = char.Parse(Console.ReadLine());
          



            switch (seasonChar)
            {
                case 'P':
                    {
                        //textValue = "Spring";
                        Console.WriteLine("Its spring ...");
                        break;

                    }
                case 'V':
                    {
                        //textValue = "Spring";
                        Console.WriteLine("Its Summer ...");
                        break;

                    }
                case 'R':
                    {
                        //textValue = "Spring";
                        Console.WriteLine("Its Autumn ...");
                        break;

                    }
                case 'Z':
                    {
                        //textValue = "Spring";
                        Console.WriteLine("Its Winter ...");
                        break;

                    }

                default:
                    {
                        //textValue = "Spring";
                        Console.WriteLine("something went wrong ...");
                        break;

                    }
            }

           
        }
    }
}
