using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classe_telecomando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = "1";
            canale(num);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num = "2";
            canale(num);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num = "3";
            canale(num);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num = "4";
            canale(num);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num = "5";
            canale(num);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string num = "6";
            canale(num);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string num = "7";
            canale(num);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string num = "8";
            canale(num);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string num = "9";
            canale(num);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string num = "0";
            canale(num);
        }

        public void canale(string num)
        {
            if (label1.Text == null)
            {
                label1.Text = num;
            }
            else
            {
                int a = int.Parse(label1.Text) * 10;
                a = a + int.Parse(num);
                label1.Text = Convert.ToString(a);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Class1 uno = new Class1();
            textBox1.Text=Convert.ToString(uno.getcanale());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
