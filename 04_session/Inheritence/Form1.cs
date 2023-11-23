using Inheritence.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritence
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.Name = "Timy";
            animal.Eat();


            Dog dog = new Dog
            {
                
                Age = 2,
                Breed = "Husky",
            };

            dog.Bark();

            dog.Name = "Woofy";
            dog.Eat();


            Cat cat = new Cat
            { 
                Name = "Kitty",
                Type = "Ragdoll",
            };

            cat.Speak();
            cat.Eat();
        }
    }
}
