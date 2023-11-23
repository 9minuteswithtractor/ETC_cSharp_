using System;
using System.Linq;
using System.Windows.Forms;

namespace Loop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //DoWhileLoop();
            //ArrayExample();

            //ForEach();

            MultidimensionalArr();

        }

        private void WhileLoop()
        {
            int i = 1;
            string text = string.Empty;
            while (i <= 10)
            {
                text += $" {i.ToString()}";
                i++;
            }
            MessageBox.Show(text);

        }
        private void DoWhileLoop()
        {
            {
                string text = string.Empty;
                int i = 1;
                do
                {
                    i++;
                    text += $" {i.ToString()}";

                } while (i < 11);
                MessageBox.Show(text);
            }

            
        }

        private void ForLoop()
        {
            string text = string.Empty;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i);
                MessageBox.Show(text += $"{i.ToString()}");

            }
        }

        private string[] ArrayExample()
        {
            string[] cars = { "BMW" };
            cars.Append("Audi");

            MessageBox.Show(cars[0]);
            return cars;
        }


        private void ForEach()
        {
            string[] cars = ArrayExample();
            string text = string.Empty;
            foreach (string car in cars)
            {
                text += $"{car} ";
                
            }

            MessageBox.Show(text);
        }


        private void MultidimensionalArr()
        {
            Random rand = new Random();
            int[,] numbers = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    numbers[i, y] = rand.Next(1, 100);
                }

            }

            MessageBox.Show(numbers[5, 5].ToString());
        }
    }
}
