using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class CustomerBooking : Form
    {
        // Define the list of available cars - ONLY Saga, Civic, Sentra
        private List<string> carList = new List<string> {
            "Proton Saga",   // Index 0
            "Honda Civic",   // Index 1
            "Nissan Sentra"  // Index 2
        };
        private int currentCarIndex = 0; // Starts at Proton Saga (Index 0)

        // Dictionary to store car images (Car Name -> Image Object)
        private Dictionary<string, Image> carImages = new Dictionary<string, Image>();

        // Dictionary to store car rates per hour (Car Name -> Rate)
        private Dictionary<string, decimal> carRatesPerHour = new Dictionary<string, decimal>();

        public CustomerBooking()
        {
            InitializeComponent();

            // Bind event handlers to controls
            this.Load += CustomerBooking_Load;
            this.NEXT.Click += NEXT_Click;
            this.PREVIOUS.Click += PREVIOUS_Click;
            this.TotalAmount.Click += TotalAmount_Click;
            this.SubmitBtnRentBook.Click += SubmitBtnRentBook_Click;
        }

        private void CustomerBooking_Load(object sender, EventArgs e)
        {
            // --- IMPORTANT: Ensure these image files are added to your Project's Resources ---
            // In Solution Explorer -> Double-click Properties -> Go to 'Resources' tab.
            // Click 'Add Resource' -> 'Add Existing File...' and select your images.
            // Make sure their names here match the names you give them in Resources (e.g., 'saga', 'civic', 'sentra').
            try
            {
                carImages["Proton Saga"] = Properties.Resources.saga;
                carImages["Honda Civic"] = Properties.Resources.civic; // This line requires 'civic' image resource
                carImages["Nissan Sentra"] = Properties.Resources.sentra;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading one or more car images. Please ensure 'saga', 'civic', and 'sentra' are correctly added to your project's Resources (Properties -> Resources tab) with the exact names.\n\nError: " + ex.Message,
                    "Image Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            // Define car rates per hour
            carRatesPerHour["Proton Saga"] = 15.00m; // Adjust these rates as needed
            carRatesPerHour["Honda Civic"] = 25.00m;
            carRatesPerHour["Nissan Sentra"] = 20.00m;

            // Load details for the initial car (Proton Saga)
            LoadCarDetails();
        }

        private void LoadCarDetails()
        {
            if (carList.Count == 0)
            {
                CarTypeLabel.Text = "No car available";
                CarRateStatic.Text = ""; // Clear rate display
                TypeOfCar.Visible = false;
                return;
            }

            string selectedCar = carList[currentCarIndex];
            CarTypeLabel.Text = selectedCar; // Update the car name label

            // Display the car's hourly rate
            if (carRatesPerHour.ContainsKey(selectedCar))
            {
                CarRateStatic.Text = carRatesPerHour[selectedCar].ToString("F2");
            }
            else
            {
                CarRateStatic.Text = "N/A"; // Rate not found
                MessageBox.Show($"Hourly rate for '{selectedCar}' is not defined in the application's configuration.", "Configuration Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Display the car image
            if (carImages.ContainsKey(selectedCar) && carImages[selectedCar] != null)
            {
                TypeOfCar.Image = carImages[selectedCar];
                TypeOfCar.SizeMode = PictureBoxSizeMode.StretchImage; // Ensures image fits the PictureBox
                TypeOfCar.Visible = true;
            }
            else
            {
                // This message will specifically tell you if the Civic image is the problem
                MessageBox.Show(
                    $"Image for '{selectedCar}' was not found or failed to load from Properties.Resources. Please verify it's correctly added and named ('civic').",
                    "Image Missing/Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                TypeOfCar.Image = null; // Clear any previous image
                TypeOfCar.Visible = false;
            }

            System.Diagnostics.Debug.WriteLine($"Current Index: {currentCarIndex}, Car: {carList[currentCarIndex]}");
        }

        private void PREVIOUS_Click(object sender, EventArgs e)
        {
            // Wrap around to the last car if at the first car
            if (carList.Count == 0) return;
            currentCarIndex = (currentCarIndex - 1 + carList.Count) % carList.Count;
            LoadCarDetails();
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            // Wrap around to the first car if at the last car
            if (carList.Count == 0) return;
            currentCarIndex = (currentCarIndex + 1) % carList.Count;
            LoadCarDetails();
        }

        private void TotalAmount_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today; // Only date component of today
            DateTime rentDate = RentDate.Value;     // Full DateTime from RentDate picker
            DateTime returnDate = ReturnDate.Value; // Full DateTime from ReturnDate picker

            // Date validation
            if (rentDate < today)
            {
                MessageBox.Show("Rental date cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (returnDate <= rentDate)
            {
                MessageBox.Show("Return date must be after the rental date and time.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan duration = returnDate - rentDate;

            // Enforce maximum rental duration (e.g., 30 days)
            if (duration.TotalHours > (30 * 24)) // 30 days * 24 hours/day
            {
                MessageBox.Show("Maximum rental duration is 30 days.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the hourly rate for the currently selected car
            string selectedCar = carList[currentCarIndex];
            decimal ratePerHour = 0m;

            if (carRatesPerHour.ContainsKey(selectedCar))
            {
                ratePerHour = carRatesPerHour[selectedCar];
            }
            else
            {
                MessageBox.Show($"Hourly rate for '{selectedCar}' is not configured. Cannot calculate total amount.", "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate total amount
            decimal totalAmount = (decimal)duration.TotalHours * ratePerHour;
            PriceRESULT.Text = totalAmount.ToString("F2"); // Display with 2 decimal places
        }

        private void SubmitBtnRentBook_Click(object sender, EventArgs e)
        {
            string car = CarTypeLabel.Text;
            string pickup = PickupLocationComboBox.Text;
            string ret = ReturnLocationComboBox.Text;
            string payment = GetSelectedPaymentType();
            string amount = PriceRESULT.Text;

            // Input validation before confirming booking
            if (string.IsNullOrWhiteSpace(pickup))
            {
                MessageBox.Show("Please select a Pickup Location.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ret))
            {
                MessageBox.Show("Please select a Return Location.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (payment == "Not selected")
            {
                MessageBox.Show("Please select a Payment Type (Cash, QR, FPX, TNG E-Wallet).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that an amount has been calculated and is valid
            if (string.IsNullOrWhiteSpace(amount) || !decimal.TryParse(amount, out decimal parsedAmount) || parsedAmount <= 0)
            {
                MessageBox.Show("Please calculate the Total Amount first, and ensure it's a valid positive number.", "Missing or Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Display booking confirmation
            MessageBox.Show(
                $"Booking Confirmed:\n\nCar: {car}\nRental Date: {RentDate.Value.ToShortDateString()} @ {RentDate.Value.ToShortTimeString()}\nReturn Date: {ReturnDate.Value.ToShortDateString()} @ {ReturnDate.Value.ToShortTimeString()}\n\nPickup Location: {pickup}\nReturn Location: {ret}\nPayment Type: {payment}\nTotal Amount: RM {amount}",
                "Booking Successful!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close(); // Close the booking form after successful submission
        }

        // Helper method to determine selected payment type
        private string GetSelectedPaymentType()
        {
            if (CashPayment.Checked) return "Cash";
            if (QR.Checked) return "QR Payment";
            if (FPXBanking.Checked) return "FPX Online Banking";
            if (TNGWallet.Checked) return "TNG E-Wallet";
            return "Not selected"; // If no payment option is selected
        }

        
        private void CarRateStatic_TextChanged(object sender, EventArgs e) { }
        private void TotalAmount_Click_1(object sender, EventArgs e) { /* This might be a duplicate event handler binding if TotalAmount.Click is also used */ }
        private void RentalDateLabel_Click(object sender, EventArgs e) { }
        private void CarRateLabel_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void TypeOfCar_Click(object sender, EventArgs e) { }
    }
}