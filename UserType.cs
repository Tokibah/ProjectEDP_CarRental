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
    public partial class UserType : Form
    {
        public UserType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {

            AdminLogin admin_login = new AdminLogin();
            admin_login.Show();

            this.Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            LoginCustomer login_cust = new LoginCustomer();
            login_cust.Show();

            this.Hide();
        }

        private void Form1Title_Click(object sender, EventArgs e)
        {

        }
    }
}
