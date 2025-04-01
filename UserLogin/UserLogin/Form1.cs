using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelHello.Text = "Hello world ";
        }

        private void SetName_Click(object sender, EventArgs e)
        {
            labelHello.Text += "set button clicked ";
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            labelHello.Text += "Text has been cancled ";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
            labelHello.Text = "Now You are Logout..";
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
