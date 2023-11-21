using ClassRecap.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassRecap
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DisplayExample1("John Doe", "Tesla");

            Console.ReadKey();
        }


        static void DisplayExample1(String name,String make)
        {
            Person p = CreateNewPerson(name, make);
            Car car = CreateNewCar(make);

            Console.WriteLine($"Hi my name is {p.Name} and I drive {car.Make}");
        }

        static Car CreateNewCar(String make)
        {
            Car car = new Car
            {
                Make = make,
                Model = "A3",

                Engine = 2.0,
                Price = 1450.30,


            };



            return car;

        }





        static Person CreateNewPerson(String name, String car)
        {
            Person person = new Person
            {

                Name = name,

                Gender = 'M',

                HasLicense = true,

                myNewCar = CreateNewCar(car)

            };

            return person;
        }
    } 
}

