using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Tax_OOPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount;
            int tip_percent, num_of_people;
            amount = double.Parse(textBox1.Text);
            tip_percent = int.Parse(textBox2.Text);
            num_of_people = int.Parse(textBox3.Text);
            Class1 obj = new Class1(amount, tip_percent, num_of_people);
            label7.Text = obj.calculateTpp().ToString();
            label8.Text = obj.calculateApp().ToString();
            label9.Text = obj.calculateTotal().ToString();

    }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rn = new Random();
            int R,B,G;
            R = rn.Next(0, 255);
            B = rn.Next(0, 255);
            G = rn.Next(0, 255);
            BackColor = Color.FromArgb(R, G, B);
        }
    }
}
