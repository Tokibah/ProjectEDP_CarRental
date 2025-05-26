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
    public partial class AdminDashboard : Form
    {

        public AdminDashboard()
        {
            InitializeComponent();
            
            /*try
            {
                // Create dataset and table adapters
                PrimeWheelDataSet ds = new PrimeWheelDataSet();

                var customerAdapter = new PrimeWheelDataSetTableAdapters.CustomerTableAdapter();
                var carAdapter = new PrimeWheelDataSetTableAdapters.CarTableAdapter();
                var bookingAdapter = new PrimeWheelDataSetTableAdapters.BookingTableAdapter();

                // Fill the related tables
                bookingAdapter.Fill(ds.Booking);

                // ---------- Insert Customer ----------
                PrimeWheelDataSet.CustomerRow customerRow = ds.Customer.NewCustomerRow();
                customerRow.Cust_id = "C01";
                customerRow.Name = "John Doe";
                customerRow.Password = "pass123";
                ds.Customer.AddCustomerRow(customerRow);
                customerAdapter.Update(ds.Customer);

                // ---------- Insert Car ----------
                PrimeWheelDataSet.CarRow carRow = ds.Car.NewCarRow();
                carRow.Car_id = "CA01";
                carRow.Name = "Toyota Vios";
                carRow.PriceHour = 10;
                carRow.PriceDay = 70;
                carRow.Status = 1; // Example: 1 = available
                ds.Car.AddCarRow(carRow);
                carAdapter.Update(ds.Car);

                // ---------- Insert Booking ----------
                PrimeWheelDataSet.BookingRow bookingRow = ds.Booking.NewBookingRow();
                bookingRow.Book_id = "B01";
                bookingRow.RentDate = DateTime.Now;
                bookingRow.ReturnDate = DateTime.Now.AddDays(3);
                bookingRow.Cust_id = "C01";
                bookingRow.Car_id = "CA01";
                bookingRow.Status = 0; // 0 = Pending
                ds.Booking.AddBookingRow(bookingRow);
                bookingAdapter.Update(ds.Booking);

                MessageBox.Show("Customer, Car, and Booking inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }*/

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'primeWheelDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.primeWheelDataSet.Booking);
            StatusCB.Items.AddRange(new[] { "Pending", "Complete" });
            bookingDataGridView.SelectionChanged += bookingDataGridView_SelectionChanged;




        }

        private void bookingDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (bookingDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = bookingDataGridView.SelectedRows[0];

                var bookid = selectedRow.Cells[0].Value;
                if (bookid != null)
                {
                    bookidL.Text = bookid.ToString();
                }

                var status = selectedRow.Cells[5].Value;
                if (status != null)
                {
                    if(status.ToString() == "0")
                    {
                        StatusCB.Text = "Pending";
                    }else
                    {
                        StatusCB.Text = "Complete";
                    }
                    
                }
            }
        }

        private void SubmitB_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedBookId = bookidL.Text;
                int newStatus = StatusCB.Text == "Complete" ? 1 : 0;

                // Create dataset and adapter again
                PrimeWheelDataSet ds = new PrimeWheelDataSet();
                var bookingAdapter = new PrimeWheelDataSetTableAdapters.BookingTableAdapter();
                bookingAdapter.Fill(ds.Booking);

                // Find the matching booking row
                var bookingRow = ds.Booking.FirstOrDefault(b => b.Book_id == selectedBookId);

                if (bookingRow != null)
                {
                    bookingRow.Status = newStatus;
                    bookingAdapter.Update(ds.Booking);
                    MessageBox.Show("Booking status updated successfully!");

                    // Refresh DataGridView
                    this.bookingTableAdapter.Fill(this.primeWheelDataSet.Booking);
                }
                else
                {
                    MessageBox.Show("Booking not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message);
            }
        }
    }
}
