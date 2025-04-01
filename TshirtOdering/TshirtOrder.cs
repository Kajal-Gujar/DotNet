using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TshirtOdering
{
    public partial class TshirtOrder : Form

    {

        public static int price = 0;


        public TshirtOrder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TshirtOrder_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (small.Checked== true)
            {
                price = 125;

            }
            else if (medium.Checked== true)
            {
                price = 175;
            }
            else if(large.Checked== true)
            {
                price = 250;
            }
            int q = Convert.ToInt32(quantity.Text);
            price = price * q;
            int gst = (price / 100) * 9;
             price += gst;
            if (promotion.Text == "trueblue")
            {
                int discount = price / 10;
                price -= discount;

            }
            total_price.Text = "Total Price :";
            total_price.Text += price;
            

        }

        private void total_price_Click(object sender, EventArgs e)
        {

        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
