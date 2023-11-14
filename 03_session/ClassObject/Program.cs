using ClassObject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ObjExample();
            ObjExample2();

            Console.ReadKey();
        }
       public static Random randNum = new Random();


        private static void ObjExample()
        {
            Car newCar = FillValues();
            Console.WriteLine($"My new car is {newCar.Color} and It's {newCar.Model}.");
            Console.WriteLine($"My {newCar.Model} price was {newCar.Price}");
        }

        private static void ObjExample2()
        {
            Person person1 = CreateNewPerson();
            DisplayPersonInfo(person1);

            
        }


        private static void DisplayPersonInfo(Person p)
        {
            Console.WriteLine($"{p.Name} is driving {p.car.Model} and his D.O.B. is {p.DateOfBirth} ");
        }

        private static Car FillValues()
        {
            Car myCar = new Car();
            myCar.Model = "Audi";

            myCar.Year = 2015;
            myCar.Price = 1500.34M;
            myCar.Color = "green";
            return myCar;

        }


        private static Person CreateNewPerson()
        {
            

            Person person = new Person {
                Name = "John",
                Surname = "Wick",
                // TODO : Random Number
                DateOfBirth = new DateTime(randNum.Next(1980, 1990), randNum.Next(1, 13), 14, 00, 00, 00),
                Gender = 'M',
                IdNumber = "124432423-12313213",
                Nationality = "US",
                car = FillValues(),

            };

            return person;
        }
    }
}
