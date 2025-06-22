using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

            this.NEXT.Click += NEXT_Click;
            this.PREVIOUS.Click += PREVIOUS_Click;
            this.TotalAmount.Click += TotalAmount_Click;
            this.SubmitBtnRentBook.Click += SubmitBtnRentBook_Click;
        }

        private Dictionary<string, string> carImageMap = new Dictionary<string, string>
{
    { "Honda Civic", "C:\\DITP2123\\ProjectEDP_CarRental\\CarImages\\civic.png" },
    { "Proton Saga", "C:\\DITP2123\\ProjectEDP_CarRental\\CarImages\\saga.jpg" },
    { "Nissan Sentra", "C:\\DITP2123\\ProjectEDP_CarRental\\CarImages\\sentra.jpg" },
    { "Nissan Almera", "C:\\DITP2123\\ProjectEDP_CarRental\\CarImages\\almera.jpg" },
    { "SUV", "C:\\DITP2123\\ProjectEDP_CarRental\\CarImages\\suv.png" },
    { "Hatchback", "C:\\DITP2123\\ProjectEDP_CarRental\\CarImages\\Hatchback.png" }, 
    // Add more mappings as needed
    //precommit
};


        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DITP2123\ProjectEDP_CarRental\PrimeWheel.mdf;Integrated Security=True";
        private List<CarData> availableCars = new List<CarData>();
        private int currentCarIndex = 0;

        public class CarData
        {
            public string CarID { get; set; }
            public string Name { get; set; }
            public decimal PriceHour { get; set; }
            public string ImagePath { get; set; }
            public int Status { get; set; }
        }


        private void CustomerBooking_Load(object sender, EventArgs e)
        {
            LoadAvailableCarsFromDatabase();
        }

        private void LoadAvailableCarsFromDatabase()
        {
            availableCars.Clear();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM Car";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    availableCars.Add(new CarData
                    {
                        CarID = reader["Car_id"].ToString(),
                        Name = reader["Name"].ToString(),
                        PriceHour = reader["PriceHour"] != DBNull.Value ? Convert.ToDecimal(reader["PriceHour"]) : 0,
                        ImagePath = reader["CarImage"] != DBNull.Value ? reader["CarImage"].ToString() : string.Empty,
                        Status = reader["Status"] != DBNull.Value ? Convert.ToInt32(reader["Status"]) : 0
                    });

                }

                reader.Close();
            }

            if (availableCars.Count == 0)
            {
                MessageBox.Show("No available cars at the moment.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            currentCarIndex = 0;
            LoadCarDetailsFromDatabase();
        }

        private void LoadCarDetailsFromDatabase()
        {
            if (availableCars.Count == 0) return;

            var car = availableCars[currentCarIndex];

            // Display full car name
            CarTypeLabel.Text = car.Name;
            CarTypeLabel.Visible = true;
            CarTypeLabel.ForeColor = Color.Black;

            // Display price
            CarRateStatic.Text = car.PriceHour.ToString("F2");

            // Get image filename from dictionary
            string imageFileName;
            Image carImage = null;

            if (carImageMap.TryGetValue(car.Name, out imageFileName))
            {
                string imagePath = Path.Combine(Application.StartupPath, "CarImages", imageFileName);

                if (File.Exists(imagePath))
                {
                    carImage = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"Image not found: {imagePath}", "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"No image mapping found for: {car.Name}", "Missing Mapping", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            TypeOfCar.Image = carImage;
            TypeOfCar.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void NEXT_Click(object sender, EventArgs e)
        {
            if (availableCars.Count == 0) return;
            currentCarIndex = (currentCarIndex + 1) % availableCars.Count;
            LoadCarDetailsFromDatabase();
        }

        private void PREVIOUS_Click(object sender, EventArgs e)
        {
            if (availableCars.Count == 0) return;
            currentCarIndex = (currentCarIndex - 1 + availableCars.Count) % availableCars.Count;
            LoadCarDetailsFromDatabase();
        }

        private void TotalAmount_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime rentDate = RentDate.Value;
            DateTime returnDate = ReturnDate.Value;

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
            if (duration.TotalHours > (30 * 24))
            {
                MessageBox.Show("Maximum rental duration is 30 days.");
                return;
            }

            decimal ratePerHour = availableCars[currentCarIndex].PriceHour;
            decimal totalAmount = (decimal)duration.TotalHours * ratePerHour;
            PriceRESULT.Text = totalAmount.ToString("F2");
        }

        private void SubmitBtnRentBook_Click(object sender, EventArgs e)
        {
            string car = CarTypeLabel.Text;
            string pickup = PickupLocationComboBox.Text;
            string ret = ReturnLocationComboBox.Text;
            string payment = GetSelectedPaymentType();
            string amount = PriceRESULT.Text;

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

            if (string.IsNullOrWhiteSpace(amount) || !decimal.TryParse(amount, out decimal parsedAmount) || parsedAmount <= 0)
            {
                MessageBox.Show("Please calculate a valid total amount.");
                return;
            }

            if (availableCars[currentCarIndex].Status == 0)
            {
                MessageBox.Show("This car is not available for booking.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    var selectedCar = availableCars[currentCarIndex];
                    string custID = GetCustomerId(username);

                    string bookingID = "BOOK_" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

                    string insertQuery = @"INSERT INTO Booking (Book_id, RentDate, ReturnDate, Cust_id, Car_id, Status)
                                           VALUES (@bookid, @rent, @return, @cust, @car, 0)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@bookid", bookingID);
                    insertCmd.Parameters.AddWithValue("@rent", RentDate.Value);
                    insertCmd.Parameters.AddWithValue("@return", ReturnDate.Value);
                    insertCmd.Parameters.AddWithValue("@cust", custID);
                    insertCmd.Parameters.AddWithValue("@car", selectedCar.CarID);
                    insertCmd.ExecuteNonQuery();

                    string updateQuery = "UPDATE Car SET Status = 0 WHERE Car_id = @carId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@carId", selectedCar.CarID);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Booking confirmed and car status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during booking: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCustomerId(string username)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
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

        // Empty handlers (optional cleanup)
        private void CarRateStatic_TextChanged(object sender, EventArgs e) { }
        private void TotalAmount_Click_1(object sender, EventArgs e) { }
        private void RentalDateLabel_Click(object sender, EventArgs e) { }
        private void CarRateLabel_Click(object sender, EventArgs e) { }


        private void SubmitBtnRentBook_Click_1(object sender, EventArgs e)
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
