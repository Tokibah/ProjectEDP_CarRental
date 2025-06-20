using System;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class LoginCustomer : Form
    {
        public LoginCustomer()
        {
            InitializeComponent();
        }

        private void PasswordTxtBoxCust_TextChanged(object sender, EventArgs e)
        {
            // Optional: Live validation or input masking
        }

        private void SubmitBtnLoginCust_Click(object sender, EventArgs e)
        {
            string username = UsernameTxtBoxCust.Text.Trim();
            string password = PasswordTxtBoxCust.Text.Trim();

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
                // Pass the data to CustomerBooking
                CustomerBooking c_booking = new CustomerBooking(username, password);
                c_booking.Show();
                this.Hide();
            }
        }

        private void CustomerLoginLogo_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTxtBoxCust_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerLoginLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
