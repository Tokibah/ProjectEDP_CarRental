using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace ProjectEDP
{
    public partial class CustomerBooking : Form
    {
        private string username;
        private string password;

        public CustomerBooking(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            LoadAvailableCarsFromDatabase();
        }

        private Dictionary<string, Image> carImageMap = new Dictionary<string, Image>
        {
            { "Proton Saga", Properties.Resources.protonsaga},
            { "Honda Civic", Properties.Resources.hondacivic},
            { "Nissan Almera", Properties.Resources.nissanalmera},
            { "Hatchback", Properties.Resources.hatchback},
            { "Nissan Sentra", Properties.Resources.nissansentra},
            { "suv", Properties.Resources.hondasuv},
        };

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectEDP_CarRental\PrimeWheel.mdf;Integrated Security=True";

        private List<CarData> availableCars = new List<CarData>();
        private int currentCarIndex = 0;

        public class CarData
        {
            public string CarID { get; set; }
            public string Name { get; set; }
            public decimal PriceDay { get; set; }  // Changed from PriceHour
            public int Status { get; set; }
        }

        private void CustomerBooking_Load(object sender, EventArgs e)
        {
            LoadAvailableCarsFromDatabase();
            LoadCarDetailsFromDatabase();
        }

        private void LoadAvailableCarsFromDatabase()
        {
            availableCars.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Car_id, Name, PriceHour, Status FROM Car WHERE Status = 1 ORDER BY Name ASC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                    while (reader.Read())
                    {
                        string carNameFromDb = reader["Name"].ToString();
                        string standardizedCarName = textInfo.ToTitleCase(carNameFromDb.ToLower());

                        if (standardizedCarName.Equals("Suv", StringComparison.OrdinalIgnoreCase))
                        {
                            standardizedCarName = "suv";
                        }

                        availableCars.Add(new CarData
                        {
                            CarID = reader["Car_id"].ToString(),
                            Name = standardizedCarName,
                            PriceDay = reader["PriceHour"] != DBNull.Value ? Convert.ToDecimal(reader["PriceHour"]) : 0, // Still using PriceHour column
                            Status = reader["Status"] != DBNull.Value ? Convert.ToInt32(reader["Status"]) : 0
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available cars: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CarTypeLabel.Text = "Error Loading Cars";
                CarRateStatic.Text = "0.00";
                TypeOfCar.Image = null;
                return;
            }

            if (availableCars.Count == 0)
            {
                
                CarTypeLabel.Text = "No Cars Available";
                CarRateStatic.Text = "0.00";
                TypeOfCar.Image = null;
                currentCarIndex = 0;
                return;
            }

            currentCarIndex = 0;
        }

        private void LoadCarDetailsFromDatabase()
        {
            if (availableCars.Count == 0)
            {
                CarTypeLabel.Text = "No Cars Available";
                CarRateStatic.Text = "0.00";
                TypeOfCar.Image = null;
                return;
            }

            var car = availableCars[currentCarIndex];

            CarTypeLabel.Text = car.Name;
            CarTypeLabel.Visible = true;
            CarTypeLabel.ForeColor = Color.Black;

            CarRateStatic.Text = car.PriceDay.ToString("F2");

            Image carImage = null;
            if (carImageMap.TryGetValue(car.Name, out carImage))
            {
                TypeOfCar.Image = carImage;
            }
            else
            {
                MessageBox.Show($"No image found in resources for: {car.Name}", "Missing Image Mapping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TypeOfCar.Image = null;
            }
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            if (availableCars.Count == 0) return;

            if (currentCarIndex < availableCars.Count - 1)
            {
                currentCarIndex++;
                LoadCarDetailsFromDatabase();
            }
            else
            {
                MessageBox.Show("You are already at the last car.", "End of List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PREVIOUS_Click(object sender, EventArgs e)
        {
            if (availableCars.Count == 0) return;

            if (currentCarIndex > 0)
            {
                currentCarIndex--;
                LoadCarDetailsFromDatabase();
            }
            else
            {
                MessageBox.Show("You are already at the first car.", "Start of List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetCustomerId(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Cust_id FROM Customer WHERE Name = @name", conn);
                cmd.Parameters.AddWithValue("@name", username);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "-1";
            }
        }

        private string GetSelectedPaymentType()
        {
            if (CashPayment.Checked) return "Cash";
            if (QR.Checked) return "QR Payment";
            if (FPXBanking.Checked) return "FPX Online Banking";
            if (TNGWallet.Checked) return "TNG E-Wallet";
            return "Not selected";
        }

        private void TotalAmount_Click_1(object sender, EventArgs e)
        {
            if (availableCars.Count == 0)
            {
                MessageBox.Show("Cannot calculate amount. No cars available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime today = DateTime.Today;
            DateTime rentDate = RentDate.Value.Date;
            DateTime returnDate = ReturnDate.Value.Date;

            if (rentDate < today)
            {
                MessageBox.Show("Rental date cannot be in the past.");
                return;
            }

            if (returnDate <= rentDate)
            {
                MessageBox.Show("Return date must be after the rental date.");
                return;
            }

            TimeSpan duration = returnDate - rentDate;
            int totalDays = duration.Days;

            if (totalDays > 30)
            {
                MessageBox.Show("Maximum rental duration is 30 days.");
                return;
            }

            if (currentCarIndex < 0 || currentCarIndex >= availableCars.Count)
            {
                MessageBox.Show("Selected car is invalid for calculation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal ratePerDay = availableCars[currentCarIndex].PriceDay;
            decimal totalAmount = totalDays * ratePerDay;
            PriceRESULT.Text = totalAmount.ToString("F2");
        }

        private void SubmitBtnRentBook_Click_1(object sender, EventArgs e)
        {
            if (availableCars.Count == 0)
            {
                MessageBox.Show("No car is selected for booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string carName = CarTypeLabel.Text;
            string carIdToBook = availableCars[currentCarIndex].CarID;

            string pickup = PickupLocationComboBox.Text;
            string ret = ReturnLocationComboBox.Text;
            string payment = GetSelectedPaymentType();
            string amountText = PriceRESULT.Text;

            if (string.IsNullOrWhiteSpace(pickup) || string.IsNullOrWhiteSpace(ret))
            {
                MessageBox.Show("Please select both Pickup and Return locations.");
                return;
            }

            if (payment == "Not selected")
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            if (string.IsNullOrWhiteSpace(amountText) || !decimal.TryParse(amountText, out decimal parsedAmount) || parsedAmount <= 0)
            {
                MessageBox.Show("Please calculate a valid total amount before booking.");
                return;
            }

            if (availableCars[currentCarIndex].Status == 0)
            {
                MessageBox.Show("This car is no longer available for booking.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadAvailableCarsFromDatabase();
                return;
            }

            try
            {
                string bookingID = string.Empty;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string custID = GetCustomerId(username);
                    if (custID == "-1")
                    {
                        MessageBox.Show("Customer ID could not be retrieved. Please ensure your account exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bookingID = "BOOK_" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

                    string insertQuery = @"INSERT INTO Booking (Book_id, RentDate, ReturnDate, Cust_id, Car_id, Status)
                                         VALUES (@bookid, @rent, @return, @cust, @car, @bookingStatus)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@bookid", bookingID);
                    insertCmd.Parameters.AddWithValue("@rent", RentDate.Value);
                    insertCmd.Parameters.AddWithValue("@return", ReturnDate.Value);
                    insertCmd.Parameters.AddWithValue("@cust", custID);
                    insertCmd.Parameters.AddWithValue("@car", carIdToBook);
                    insertCmd.Parameters.AddWithValue("@bookingStatus", 0);
                    insertCmd.ExecuteNonQuery();

                    string updateQuery = "UPDATE Car SET Status = 0 WHERE Car_id = @carId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@carId", carIdToBook);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Booking confirmed and car status updated. Booking ID: " + bookingID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during booking: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaymentTypeGpBoxLabel_Enter(object sender, EventArgs e)
        {

        }
    }

    public static class SqlDataReaderExtensions
    {
        public static bool HasColumn(this SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
