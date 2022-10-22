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
            double num1 = double.Parse(a.Text);
            double num2 = double.Parse(b.Text);
            double num = num1 + num2;

            kq.Text = num.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num = double.Parse(a.Text) - double.Parse(b.Text);
            kq.Text = num.ToString();
        }
    }
}
