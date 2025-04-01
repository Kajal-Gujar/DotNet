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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string id = textUserId.Text;
            string pass = textPassword.Text;

            if(id =="123" && pass == "12345")
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("User id or Password is Incorrect ... ");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUserId.Text = "";
            textPassword.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {


        }
    }
}
