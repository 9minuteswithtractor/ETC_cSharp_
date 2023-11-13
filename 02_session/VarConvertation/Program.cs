using System;


namespace VarConvertation
{
    class Program
    {
        static void Main(string[] args)
        {
            object name = Question("Please enter Your name: ");
            CheckDataType(name);

            object age = Question("Please enter Your age: ");
            CheckDataType(age);

            int userAge = int.Parse(age.ToString());
            CheckDataType(userAge);

            string numAsString = "2423";
            int otherNumAsString = Convert.ToInt32(numAsString);
            Console.WriteLine(otherNumAsString);


            string someNumAsString = "3232";

            int otherInt;
            bool successConvert = int.TryParse(otherNumAsString.ToString(someNumAsString), out otherInt);
            Console.WriteLine(otherInt);

            int easyConvert = int.Parse(someNumAsString);
            CheckDataType(easyConvert);


            Console.ReadKey();
        }


        static void CheckDataType(Object variable)
        {
            Console.WriteLine($"This variable with value '{variable}' type is : {variable.GetType()}");
        }

        static Object Question(string question)
        {
            Console.Write(question);
            dynamic variable = Console.ReadLine();

            return variable;

        }
    }
}
