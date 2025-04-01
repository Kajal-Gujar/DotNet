using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register Successful ..");
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            txtsurname.Text = "";
            txtname.Text = "";
            txtcourse.Text = "";
            txtemail.Text = "";
            
        }
    }
}
