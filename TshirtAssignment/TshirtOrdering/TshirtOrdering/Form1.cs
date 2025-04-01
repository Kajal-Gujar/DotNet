using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TshirtOrdering
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int quantity;
            bool Promo;
            int price;
            int gst = 18;

            string address;

            if (textBox2.Text =="")
            {
                MessageBox.Show("Enter Quantity");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Enter price ");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Enter Address ");
            }
        }
    }
}
