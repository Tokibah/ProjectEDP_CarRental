using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectEDP
{
    public partial class AdminDashboard : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ashwin\Desktop\ProjectEDP_CarRental\PrimeWheel.mdf;Integrated Security=True";

        private string selectedBookingId = string.Empty;

        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load;
            this.SubmitB.Click += SubmitB_Click;
            this.StatusCB.SelectedIndexChanged += StatusCB_SelectedIndexChanged;
            this.bookingDataGridView.CellClick += bookingDataGridView_CellClick;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadBookingsIntoDataGridView();
            PopulateStatusComboBox();
            SubmitB.Enabled = false;
            bookidL.Text = string.Empty; // Just the ID, or empty if none selected
        }

        private void LoadBookingsIntoDataGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Book_id, RentDate, ReturnDate, Cust_id, Car_id, Status FROM Booking";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bookingDataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateStatusComboBox()
        {
            StatusCB.Items.Clear();
            StatusCB.Items.Add("Pending");
            StatusCB.Items.Add("Complete");
            StatusCB.Items.Add("Cancelled");

            StatusCB.SelectedIndex = 0;
        }

        private void bookingDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < bookingDataGridView.Rows.Count)
            {
                DataGridViewRow row = bookingDataGridView.Rows[e.RowIndex];

                DataGridViewCell bookIdCell = null;
                DataGridViewCell statusCell = null;

                // Robust column lookup for Book_id
                if (bookingDataGridView.Columns.Contains("Book_id"))
                {
                    bookIdCell = row.Cells["Book_id"];
                }
                else
                {
                    foreach (DataGridViewColumn col in bookingDataGridView.Columns)
                    {
                        if (col.DataPropertyName == "Book_id" || col.HeaderText == "Book_id" || col.Name == "Book_id")
                        {
                            bookIdCell = row.Cells[col.Index];
                            break;
                        }
                    }
                }

                // Robust column lookup for Status
                if (bookingDataGridView.Columns.Contains("Status"))
                {
                    statusCell = row.Cells["Status"];
                }
                else
                {
                    foreach (DataGridViewColumn col in bookingDataGridView.Columns)
                    {
                        if (col.DataPropertyName == "Status" || col.HeaderText == "Status" || col.Name == "Status")
                        {
                            statusCell = row.Cells[col.Index];
                            break;
                        }
                    }
                }

                if (bookIdCell != null && bookIdCell.Value != null)
                {
                    selectedBookingId = bookIdCell.Value.ToString();
                    bookidL.Text = selectedBookingId; // Just the ID

                    SubmitB.Enabled = true;

                    if (statusCell != null && statusCell.Value != null)
                    {
                        if (int.TryParse(statusCell.Value.ToString(), out int currentStatus))
                        {
                            if (currentStatus >= 0 && currentStatus < StatusCB.Items.Count)
                            {
                                StatusCB.SelectedIndex = currentStatus;
                            }
                        }
                    }
                }
                else
                {
                    selectedBookingId = string.Empty;
                    bookidL.Text = string.Empty;
                    SubmitB.Enabled = false;
                    MessageBox.Show("Could not retrieve Book_id from selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                selectedBookingId = string.Empty;
                bookidL.Text = string.Empty;
                SubmitB.Enabled = false;
            }
        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedBookingId))
            {
                MessageBox.Show("Please select a booking from the table first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (StatusCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a new Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStatusText = StatusCB.SelectedItem.ToString();
            int newBookingStatus;

            switch (selectedStatusText)
            {
                case "Pending":
                    newBookingStatus = 0;
                    break;
                case "Complete":
                    newBookingStatus = 1;
                    break;
                case "Cancelled":
                    newBookingStatus = 2;
                    break;
                default:
                    MessageBox.Show("Invalid status selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            string carIdAssociatedWithBooking = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check current booking status
                    string statusCheckQuery = "SELECT Status, Car_id FROM Booking WHERE Book_id = @bookId";
                    SqlCommand checkCmd = new SqlCommand(statusCheckQuery, conn);
                    checkCmd.Parameters.AddWithValue("@bookId", selectedBookingId);

                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Booking not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int currentStatus = Convert.ToInt32(reader["Status"]);
                        carIdAssociatedWithBooking = reader["Car_id"].ToString();

                        if (currentStatus != 0)
                        {
                            MessageBox.Show("Only bookings with status 'Pending' can be updated.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Proceed with update
                    string updateBookingQuery = "UPDATE Booking SET Status = @newStatus WHERE Book_id = @bookId";
                    SqlCommand updateBookingCmd = new SqlCommand(updateBookingQuery, conn);
                    updateBookingCmd.Parameters.AddWithValue("@newStatus", newBookingStatus);
                    updateBookingCmd.Parameters.AddWithValue("@bookId", selectedBookingId);
                    updateBookingCmd.ExecuteNonQuery();

                    if (newBookingStatus == 1) // Complete
                    {
                        string updateCarStatusQuery = "UPDATE Car SET Status = 1 WHERE Car_id = @carId";
                        SqlCommand updateCarCmd = new SqlCommand(updateCarStatusQuery, conn);
                        updateCarCmd.Parameters.AddWithValue("@carId", carIdAssociatedWithBooking);
                        updateCarCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Booking {selectedBookingId} updated to '{selectedStatusText}'.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBookingsIntoDataGridView();
                    selectedBookingId = string.Empty;
                    bookidL.Text = string.Empty;
                    SubmitB.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking/car status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void StatusCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Add logic here if needed
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadBookingsIntoDataGridView();
            selectedBookingId = string.Empty;
            bookidL.Text = string.Empty;
            SubmitB.Enabled = false;
        }

        private void bookingDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void toCustB_Click(object sender, EventArgs e)
        {
            AdminDashboardCustomer customerForm = new AdminDashboardCustomer();
            customerForm.Show();
            this.Hide();
        }

        private void SubmitB_Click_1(object sender, EventArgs e)
        {

        }
    }
}