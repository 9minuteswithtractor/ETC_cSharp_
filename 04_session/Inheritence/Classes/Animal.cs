using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritence.Classes
{
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            MessageBox.Show($"{Name} is eating...");
        }
    }
}
