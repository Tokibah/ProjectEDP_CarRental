using System;
using System.Windows.Forms;
using System.Data.SqlClient;


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
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectEDP_CarRental\PrimeWheel.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT * FROM Customer WHERE RTRIM(Name) = @username AND RTRIM(Password) = @password";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    CustomerBooking c_booking = new CustomerBooking(username, password);
                                    c_booking.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void LoginCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
