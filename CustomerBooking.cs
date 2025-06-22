using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; // This might not be strictly necessary anymore since we're not loading from file paths
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
            // Ensure these event handlers are correctly wired in the Designer too
            this.NEXT.Click += NEXT_Click;
            this.PREVIOUS.Click += PREVIOUS_Click;
            this.TotalAmount.Click += TotalAmount_Click;
            this.SubmitBtnRentBook.Click += SubmitBtnRentBook_Click;

            // Load cars when the form initializes
            // Calling this in the constructor ensures that availableCars list is populated
            // before any other operations might try to access it.
            // It's also called in CustomerBooking_Load, so you can keep it there,
            // but this ensures data is ready immediately if needed.
            LoadAvailableCarsFromDatabase();
        }

        // This dictionary now holds the mapping from car names (from DB) to their
        // corresponding images loaded from ProjectEDP.Properties.Resources.
        private Dictionary<string, Image> carImageMap = new Dictionary<string, Image>
        {
            { "Proton Saga", Properties.Resources.protonsaga}, // Corrected based on image name
            { "Honda Civic", Properties.Resources.hondacivic}, // Corrected based on image name
            { "Nissan Almera", Properties.Resources.nissanalmera}, // Corrected based on image name
            { "Hatchback", Properties.Resources.Hatchback},
            { "Nissan Sentra", Properties.Resources.nissansentra}, // Corrected based on image name
            { "SUV", Properties.Resources.suv},
            // Add other car names and their corresponding image resources here
        };

        private string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\ProjectEDP_CarRental\PrimeWheel.mdf;Integrated Security=True";

        private List<CarData> availableCars = new List<CarData>();
        private int currentCarIndex = 0;

        public class CarData
        {
            public string CarID { get; set; }
            public string Name { get; set; }
            public decimal PriceHour { get; set; }
            // ImagePath is removed as it's no longer in the database and not needed for direct image loading
            public int Status { get; set; }
        }

        private void CustomerBooking_Load(object sender, EventArgs e)
        {
            // If LoadAvailableCarsFromDatabase is called in the constructor,
            // calling it here again will just refresh the list.
            // It's good to keep if data might change between constructor and Load event.
            // If you called it in the constructor, you can optionally remove it from here.
            // However, keeping it doesn't harm.
            LoadAvailableCarsFromDatabase();
            // Ensure the initial car details are displayed on load
            LoadCarDetailsFromDatabase();
        }

        private void LoadAvailableCarsFromDatabase()
        {
            availableCars.Clear(); // Clear the list to avoid duplicate entries on subsequent loads

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    // Select only columns that exist in your Car table and filter by Status = 1
                    string query = "SELECT Car_id, Name, PriceHour, Status FROM Car WHERE Status = 1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        availableCars.Add(new CarData
                        {
                            CarID = reader["Car_id"].ToString(),
                            Name = reader["Name"].ToString(),
                            PriceHour = reader["PriceHour"] != DBNull.Value ? Convert.ToDecimal(reader["PriceHour"]) : 0,
                            Status = reader["Status"] != DBNull.Value ? Convert.ToInt32(reader["Status"]) : 0
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available cars: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear display if there's a database error
                CarTypeLabel.Text = "Error Loading Cars";
                CarRateStatic.Text = "0.00";
                TypeOfCar.Image = null;
                return; // Exit if cars couldn't be loaded
            }

            if (availableCars.Count == 0)
            {
                MessageBox.Show("No available cars at the moment.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarTypeLabel.Text = "No Cars Available";
                CarRateStatic.Text = "0.00";
                TypeOfCar.Image = null; // Clear any previously displayed image
                currentCarIndex = 0; // Reset index
                return;
            }

            // If cars are loaded, ensure the index is valid and display the first car
            currentCarIndex = 0; // Start at the first car
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

            CarRateStatic.Text = car.PriceHour.ToString("F2");

            Image carImage = null;
            if (carImageMap.TryGetValue(car.Name, out carImage))
            {
                TypeOfCar.Image = carImage;
            }
            else
            {
                MessageBox.Show($"No image found in resources for: {car.Name}", "Missing Image Mapping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TypeOfCar.Image = null; // Set to null if no image found to avoid displaying previous car's image
            }
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            if (availableCars.Count == 0) return; // Cannot navigate if no cars are loaded
            currentCarIndex = (currentCarIndex + 1) % availableCars.Count;
            LoadCarDetailsFromDatabase();
        }

        private void PREVIOUS_Click(object sender, EventArgs e)
        {
            if (availableCars.Count == 0) return; // Cannot navigate if no cars are loaded
            currentCarIndex = (currentCarIndex - 1 + availableCars.Count) % availableCars.Count;
            LoadCarDetailsFromDatabase();
        }

        private void TotalAmount_Click(object sender, EventArgs e)
        {
            // Ensure there's an available car selected before calculating total
            if (availableCars.Count == 0)
            {
                MessageBox.Show("Cannot calculate amount. No cars available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            if (duration.TotalHours > (30 * 24)) // 30 days in hours
            {
                MessageBox.Show("Maximum rental duration is 30 days.");
                return;
            }

            // Ensure the currentCarIndex is valid before accessing availableCars
            if (currentCarIndex < 0 || currentCarIndex >= availableCars.Count)
            {
                MessageBox.Show("Selected car is invalid for calculation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal ratePerHour = availableCars[currentCarIndex].PriceHour;
            decimal totalAmount = (decimal)duration.TotalHours * ratePerHour;
            PriceRESULT.Text = totalAmount.ToString("F2");
        }

        private void SubmitBtnRentBook_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (availableCars.Count == 0)
            {
                MessageBox.Show("No car is selected for booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string carName = CarTypeLabel.Text; // Use carName for display purposes
            string carIdToBook = availableCars[currentCarIndex].CarID; // Use CarID for database operations

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

            // Ensure the car is still available right before booking (status = 1)
            // Re-check status from the current availableCars list, or consider re-fetching from DB for real-time check.
            // For simplicity, we'll check the loaded status.
            if (availableCars[currentCarIndex].Status == 0)
            {
                MessageBox.Show("This car is no longer available for booking.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Optionally, reload available cars to refresh the list
                LoadAvailableCarsFromDatabase();
                return;
            }

            try
            {
                string bookingID = string.Empty; // Initialize bookingID
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                   
                    string custID = GetCustomerId(username);
                    if (custID == "-1")
                    {
                        MessageBox.Show("Customer ID could not be retrieved. Please ensure your account exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    bookingID = "BOOK_" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

                    // Insert into Booking table
                    string insertQuery = @"INSERT INTO Booking (Book_id, RentDate, ReturnDate, Cust_id, Car_id, Status)
                                         VALUES (@bookid, @rent, @return, @cust, @car, @bookingStatus)"; // Status for booking itself
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@bookid", bookingID);
                    insertCmd.Parameters.AddWithValue("@rent", RentDate.Value);
                    insertCmd.Parameters.AddWithValue("@return", ReturnDate.Value);
                    insertCmd.Parameters.AddWithValue("@cust", custID);
                    insertCmd.Parameters.AddWithValue("@car", carIdToBook);
                    insertCmd.Parameters.AddWithValue("@bookingStatus", 0); // Assuming 0 means "Pending" or "Booked" for the booking status
                    insertCmd.ExecuteNonQuery();

                    // Update Car status to unavailable (Status = 0)
                    string updateQuery = "UPDATE Car SET Status = 0 WHERE Car_id = @carId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@carId", carIdToBook);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Booking confirmed and car status updated. Booking ID: " + bookingID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the booking form after successful booking
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
        // It's good practice to remove handlers that do nothing,
        // or ensure they are hooked up to actual UI events if needed.
        private void CarRateStatic_TextChanged(object sender, EventArgs e) { }
        private void TotalAmount_Click_1(object sender, EventArgs e) { } // Duplicate, consider removing this one if TotalAmount_Click is the main one
        private void RentalDateLabel_Click(object sender, EventArgs e) { }
        private void CarRateLabel_Click(object sender, EventArgs e) { }
        private void SubmitBtnRentBook_Click_1(object sender, EventArgs e) { } // Duplicate, consider removing this one if SubmitBtnRentBook_Click is the main one
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