using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject.Classes
{
    public class Car
    {
        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }


        public void StartEngine()
        {
            Console.WriteLine("Brumm Brumm!");
        }


        public void ChangeColor(string color)
        {
            this.Color = color;
        }
    }
}
