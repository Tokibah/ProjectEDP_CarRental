using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void UsernameTxtBoxAdmin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubmitBtnLoginAdmin_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBoxAdmin.Text.Trim();
            string password = PasswordTxtBoxAdmin.Text.Trim();




            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                // Open AdminDashboard form
                AdminDashboard dashboard = new AdminDashboard();
                dashboard.Show();

                // Hide or close the current login form
                this.Hide();  // or this.Close(); if you want to terminate it
            }

        }

        private void PasswordTxtBoxAdmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
