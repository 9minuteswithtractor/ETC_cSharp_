﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritence.Classes
{
    public class Cat : Animal
    {
        public string Type {  get; set; }

        public void Speak()
        {
            MessageBox.Show("Meow");
        }
    }
}