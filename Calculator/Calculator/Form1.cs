using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        int counter = 0;
        double num1 = 0;
        double num2 = 0;
        string op = "";
        calculator1 c1 = new calculator1();
        public Calc()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (counter == 0)
            {
                num1 = double.Parse(button.Text);
                label1.Text += num1;
            }
            else if (counter == 1)
            {
                num2 = double.Parse(button.Text);
                label1.Text += num2;
            }

            counter++;

            if(button.Text == "=")
            {
                c1.num1 = num1;
                c1.num2 = num2;
                switch (op)
                {
                    case "+":
                        Result.Text = c1.Add().ToString();
                        break;
                    case "-":
                        Result.Text = c1.Minus().ToString();
                        break;
                    case "*":
                        Result.Text = c1.Multiply().ToString();
                        break;
                    case "/":
                        Result.Text = c1.Divide().ToString();
                        break;
                }
            }
        }

        private void reset(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text = "0";
            label1.Text = "";
            Application.Restart();
        }

        private void op_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            op = button.Text;

            if (op == "+")
            {
                label1.Text += $" + ";
            }
            else if(op == "-")
            {
                label1.Text += " - ";
                
            }
            else if (op == "*")
            {
                label1.Text += " * ";
                
            }
            else if (op == "/")
            {
                label1.Text += " / ";
                
            }
            else
            {

            }
        }
    }
}
