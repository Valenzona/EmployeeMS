using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_MS
{
    public partial class Form1 : Form
    {
        private object signup_password;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            User.Text = "  ";
            Password.Text = "  ";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (User.Text=="  " && Password.Text=="  ")
            {
                MessageBox.Show("Missing Information");
            }
            else if (User.Text=="Admin" && Password.Text == "Password")
            {
                Home H = new Home();
                H.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter Correct Username and Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_showPass.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }
    }
}
