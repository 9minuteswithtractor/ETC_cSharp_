using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRecap.Classes
{
    public class Car
    {
        public string Make { get;set;}  

        public string Model {get;set;}
        
        public double Engine { get;set;}

        public double Price {  get;set;}


        public void Drive()
        {
            Console.WriteLine($"This {this.Make}");
        }


    }
}
