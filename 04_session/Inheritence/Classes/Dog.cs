using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritence.Classes
{
    public class Dog : Animal
    {
        public int Age {  get; set; }

        public string Breed {  get; set; }  


        public void Bark()
        {
            MessageBox.Show($" {Breed} Dog is barking!");
        }
    }
}
