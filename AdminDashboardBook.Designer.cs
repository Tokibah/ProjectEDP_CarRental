namespace ProjectEDP
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.primeWheelDataSet = new ProjectEDP.PrimeWheelDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new ProjectEDP.PrimeWheelDataSetTableAdapters.BookingTableAdapter();
            this.tableAdapterManager = new ProjectEDP.PrimeWheelDataSetTableAdapters.TableAdapterManager();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitB = new System.Windows.Forms.Button();
            this.StatusCB = new System.Windows.Forms.ComboBox();
            this.bookidL = new System.Windows.Forms.Label();
            this.toCustB = new System.Windows.Forms.Button();
            this.bookingIDLabel = new System.Windows.Forms.Label();
            this.BookingManagementLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.primeWheelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DashboardLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DashboardLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DashboardLabel.Location = new System.Drawing.Point(23, 9);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(208, 29);
            this.DashboardLabel.TabIndex = 50;
            this.DashboardLabel.Text = "Admin Dashboard";
            // 
            // primeWheelDataSet
            // 
            this.primeWheelDataSet.DataSetName = "PrimeWheelDataSet";
            this.primeWheelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.primeWheelDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjectEDP.PrimeWheelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(28, 77);
            this.bookingDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookingDataGridView.MultiSelect = false;
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.ReadOnly = true;
            this.bookingDataGridView.RowHeadersWidth = 51;
            this.bookingDataGridView.RowTemplate.Height = 24;
            this.bookingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingDataGridView.Size = new System.Drawing.Size(647, 363);
            this.bookingDataGridView.TabIndex = 51;
            this.bookingDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RentDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "RentDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ReturnDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "ReturnDate";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cust_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cust_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Car_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Car_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // SubmitB
            // 
            this.SubmitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitB.Location = new System.Drawing.Point(701, 163);
            this.SubmitB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.Size = new System.Drawing.Size(73, 32);
            this.SubmitB.TabIndex = 52;
            this.SubmitB.Text = "Submit";
            this.SubmitB.UseVisualStyleBackColor = true;
            this.SubmitB.Click += new System.EventHandler(this.SubmitB_Click_1);
            // 
            // StatusCB
            // 
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.Location = new System.Drawing.Point(701, 127);
            this.StatusCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(136, 21);
            this.StatusCB.TabIndex = 53;
            this.StatusCB.Text = "Choose Status";
            // 
            // bookidL
            // 
            this.bookidL.AutoSize = true;
            this.bookidL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidL.ForeColor = System.Drawing.Color.Blue;
            this.bookidL.Location = new System.Drawing.Point(852, 82);
            this.bookidL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookidL.Name = "bookidL";
            this.bookidL.Size = new System.Drawing.Size(84, 25);
            this.bookidL.TabIndex = 54;
            this.bookidL.Text = "Book Id";
            // 
            // toCustB
            // 
            this.toCustB.Location = new System.Drawing.Point(1093, 415);
            this.toCustB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toCustB.Name = "toCustB";
            this.toCustB.Size = new System.Drawing.Size(74, 24);
            this.toCustB.TabIndex = 58;
            this.toCustB.Text = "Customer";
            this.toCustB.UseVisualStyleBackColor = true;
            this.toCustB.Click += new System.EventHandler(this.toCustB_Click);
            // 
            // bookingIDLabel
            // 
            this.bookingIDLabel.AutoSize = true;
            this.bookingIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookingIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingIDLabel.Location = new System.Drawing.Point(695, 77);
            this.bookingIDLabel.Name = "bookingIDLabel";
            this.bookingIDLabel.Size = new System.Drawing.Size(162, 31);
            this.bookingIDLabel.TabIndex = 59;
            this.bookingIDLabel.Text = "Booking ID :";
            // 
            // BookingManagementLabel
            // 
            this.BookingManagementLabel.AutoSize = true;
            this.BookingManagementLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BookingManagementLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookingManagementLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingManagementLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BookingManagementLabel.Location = new System.Drawing.Point(17, 38);
            this.BookingManagementLabel.Name = "BookingManagementLabel";
            this.BookingManagementLabel.Size = new System.Drawing.Size(223, 27);
            this.BookingManagementLabel.TabIndex = 60;
            this.BookingManagementLabel.Text = "(Booking Management)";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.BookingManagementLabel);
            this.Controls.Add(this.bookingIDLabel);
            this.Controls.Add(this.toCustB);
            this.Controls.Add(this.bookidL);
            this.Controls.Add(this.StatusCB);
            this.Controls.Add(this.SubmitB);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(this.DashboardLabel);
            this.Name = "AdminDashboard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primeWheelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DashboardLabel;
        private PrimeWheelDataSet primeWheelDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private PrimeWheelDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private PrimeWheelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button SubmitB;
        private System.Windows.Forms.ComboBox StatusCB;
        private System.Windows.Forms.Label bookidL;
        private System.Windows.Forms.Button toCustB;
        private System.Windows.Forms.Label bookingIDLabel;
        private System.Windows.Forms.Label BookingManagementLabel;
    }
}