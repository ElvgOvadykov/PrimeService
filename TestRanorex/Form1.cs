using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimeService;

namespace TestRanorex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int value = Int32.Parse(textBox1.Text);
                if (value < 0)
                    textBox2.Text = "Incorrect Format";
                else
                    textBox2.Text = PrimeClass.isPrime(value).ToString();
            }
            catch
            {
                textBox2.Text = "Incorrect Format";
            }
        }
    }
}
