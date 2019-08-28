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
        public Calc()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Result.Text = Result.Text + button.Text;
        }

        private void symbol(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        }
    }
}
