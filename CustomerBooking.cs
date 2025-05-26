using System;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class CustomerBooking : Form
    {
        private string username;
        private string password;

        // Constructor that accepts username and password
        public CustomerBooking(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void CustomerBooking_Load(object sender, EventArgs e)
        {
            // Example: show username in a label (you need to add a Label called welcomeLabel)
            // welcomeLabel.Text = $"Welcome, {username}!";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RentalDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void CarRateLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaymentTypeGpBoxLabel_Enter(object sender, EventArgs e)
        {

        }
    }
}
