using System;


namespace VarConvertation
{
    class Program
    {
        static void Main(string[] args)
        {



            //object name = Question("Please enter Your name: ");
            //CheckDataType(name);

            //object age = Question("Please enter Your age: ");
            //CheckDataType(age);

            //int userAge = int.Parse(age.ToString());
            //CheckDataType(userAge);

            //string numAsString = "2423";
            //int otherNumAsString = Convert.ToInt32(numAsString);
            //Console.WriteLine(otherNumAsString);


            //string someNumAsString = "3232";

            //int otherInt;
            //bool successConvert = int.TryParse(otherNumAsString.ToString(someNumAsString), out otherInt);
            //Console.WriteLine(otherInt);

            //int easyConvert = int.Parse(someNumAsString);
            //CheckDataType(easyConvert);


            // TODO : Write several convertion routines

            // int.TryParse()
            StringToIntConvertion("20202020");

            StrToIntDirectConvertion("10101010");

            DoubleToIntConvertion(3.2423);

            Console.ReadKey();
        }


        static void StringToIntConvertion(string numAsStr)
        {

            int.TryParse(numAsStr, out int number);
            Console.WriteLine("We tried to parse {0} and we got {1}", numAsStr.GetType(), number.GetType());
            Console.WriteLine($"TryParse convertion result : {number}");
        }

        static void StrToIntDirectConvertion(string numAsStr)
        {
            int number = int.Parse(numAsStr);
            Console.WriteLine("Direct convertion result : {0}", number);

            //static void CheckDataType(Object variable)
            //{
            //    Console.WriteLine($"This variable with value '{variable}' type is : {variable.GetType()}");
            //}

            //static Object Question(string question)
            //{
            //    Console.Write(question);
            //    dynamic variable = Console.ReadLine();

            //    return variable;

            //}


        }


        static void DoubleToIntConvertion(double num)
        {
           
            int numAsInt = (int) num;
            Console.WriteLine(numAsInt);

        }
    }
}
