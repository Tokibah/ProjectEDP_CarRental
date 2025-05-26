using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class CustomerBooking : Form
    {
        private List<string> carList = new List<string> { "Honda City", "Proton Saga", "Nissan Sentra" };
        private int currentCarIndex = 0;

        // Flat daily rental rate for all cars
        private decimal carRatePerDay = 150m;

        public CustomerBooking()
        {
            InitializeComponent();
        }

        private void CustomerBooking_Load(object sender, EventArgs e)
        {
            LoadCarDetails();
        }

        private void LoadCarDetails()
        {
            if (carList.Count == 0)
            {
                CarTypeLabel.Text = "No car available";
                TypeOfCar.Visible = false;
                return;
            }

            CarTypeLabel.Text = carList[currentCarIndex];
            TypeOfCar.Visible = true;
        }

        private void PREVIOUS_Click(object sender, EventArgs e)
        {
            if (currentCarIndex > 0)
            {
                currentCarIndex--;
                LoadCarDetails();
            }
        }

        private void NEXT_Click(object sender, EventArgs e)
        {
            if (currentCarIndex < carList.Count - 1)
            {
                currentCarIndex++;
                LoadCarDetails();
            }
        }

        private void TotalAmount_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime rentDate = RentDate.Value.Date;
            DateTime returnDate = ReturnDate.Value.Date;

            if (rentDate < today)
            {
                MessageBox.Show("Rental date cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (returnDate <= rentDate)
            {
                MessageBox.Show("Return date must be after the rental date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan duration = returnDate - rentDate;

            if (duration.TotalDays > 30)
            {
                MessageBox.Show("Maximum rental duration is 30 days.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = (decimal)duration.TotalDays * carRatePerDay;
            PriceRESULT.Text = totalAmount.ToString("F2");
        }

        private void SubmitBtnRentBook_Click(object sender, EventArgs e)
        {
            string car = CarTypeLabel.Text;
            string pickup = PickupLocationComboBox.Text;
            string ret = ReturnLocationComboBox.Text;
            string payment = GetSelectedPaymentType();
            string amount = PriceRESULT.Text;

            if (string.IsNullOrWhiteSpace(amount))
            {
                MessageBox.Show("Please calculate the total amount before submitting.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"Booking Confirmed:\nCar: {car}\nPickup: {pickup}\nReturn: {ret}\nPayment: {payment}\nTotal: RM {amount}",
                "Booking Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.Close();
        }

        private string GetSelectedPaymentType()
        {
            if (CashPayment.Checked) return "Cash";
            if (QR.Checked) return "QR Payment";
            if (FPXBanking.Checked) return "FPX Online Banking";
            if (TNGWallet.Checked) return "TNG E-Wallet";
            return "Not selected";
        }

        // Optional: empty handlers kept for events
        private void RentalDateLabel_Click(object sender, EventArgs e) { }
        private void CarRateLabel_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            LoadCarDetails();
        }
    }
}
