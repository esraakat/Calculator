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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, add, product;

            number1 = Convert.ToInt16(textBox1.Text);
            number2 = Convert.ToInt16(textBox2.Text);
            add = number1 + number2;
            product = number1 * number2;

            label4.Text = Convert.ToString(add);
            label6.Text = Convert.ToString(product);
        }
    }
}
