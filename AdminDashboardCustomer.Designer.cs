namespace ProjectEDP
{
    partial class AdminDashboardCustomer
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
            this.primeWheelDataSet = new ProjectEDP.PrimeWheelDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new ProjectEDP.PrimeWheelDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new ProjectEDP.PrimeWheelDataSetTableAdapters.TableAdapterManager();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custidL = new System.Windows.Forms.Label();
            this.DeleteB = new System.Windows.Forms.Button();
            this.toBookingB = new System.Windows.Forms.Button();
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.bookingIDLabel = new System.Windows.Forms.Label();
            this.BookingManagementLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.primeWheelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // primeWheelDataSet
            // 
            this.primeWheelDataSet.DataSetName = "PrimeWheelDataSet";
            this.primeWheelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.primeWheelDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjectEDP.PrimeWheelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(28, 77);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(647, 363);
            this.customerDataGridView.TabIndex = 1;
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cust_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cust_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // custidL
            // 
            this.custidL.AutoSize = true;
            this.custidL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custidL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.custidL.Location = new System.Drawing.Point(871, 82);
            this.custidL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.custidL.Name = "custidL";
            this.custidL.Size = new System.Drawing.Size(130, 25);
            this.custidL.TabIndex = 56;
            this.custidL.Text = "Customer ID";
            this.custidL.Click += new System.EventHandler(this.custidL_Click);
            // 
            // DeleteB
            // 
            this.DeleteB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteB.Location = new System.Drawing.Point(701, 163);
            this.DeleteB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteB.Name = "DeleteB";
            this.DeleteB.Size = new System.Drawing.Size(73, 32);
            this.DeleteB.TabIndex = 55;
            this.DeleteB.Text = "Delete";
            this.DeleteB.UseVisualStyleBackColor = true;
            this.DeleteB.Click += new System.EventHandler(this.DeleteB_Click);
            // 
            // toBookingB
            // 
            this.toBookingB.Location = new System.Drawing.Point(1093, 415);
            this.toBookingB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toBookingB.Name = "toBookingB";
            this.toBookingB.Size = new System.Drawing.Size(74, 24);
            this.toBookingB.TabIndex = 57;
            this.toBookingB.Text = "Booking";
            this.toBookingB.UseVisualStyleBackColor = true;
            this.toBookingB.Click += new System.EventHandler(this.toBookingB_Click);
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
            this.DashboardLabel.TabIndex = 58;
            this.DashboardLabel.Text = "Admin Dashboard";
            // 
            // bookingIDLabel
            // 
            this.bookingIDLabel.AutoSize = true;
            this.bookingIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookingIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingIDLabel.Location = new System.Drawing.Point(695, 77);
            this.bookingIDLabel.Name = "bookingIDLabel";
            this.bookingIDLabel.Size = new System.Drawing.Size(182, 31);
            this.bookingIDLabel.TabIndex = 60;
            this.bookingIDLabel.Text = "Customer ID :";
            // 
            // BookingManagementLabel
            // 
            this.BookingManagementLabel.AutoSize = true;
            this.BookingManagementLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BookingManagementLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookingManagementLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingManagementLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BookingManagementLabel.Location = new System.Drawing.Point(15, 38);
            this.BookingManagementLabel.Name = "BookingManagementLabel";
            this.BookingManagementLabel.Size = new System.Drawing.Size(238, 27);
            this.BookingManagementLabel.TabIndex = 61;
            this.BookingManagementLabel.Text = "(Customer Management)";
            // 
            // AdminDashboardCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 450);
            this.Controls.Add(this.BookingManagementLabel);
            this.Controls.Add(this.bookingIDLabel);
            this.Controls.Add(this.DashboardLabel);
            this.Controls.Add(this.toBookingB);
            this.Controls.Add(this.custidL);
            this.Controls.Add(this.DeleteB);
            this.Controls.Add(this.customerDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminDashboardCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboardCustomer";
            this.Load += new System.EventHandler(this.AdminDashboardCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primeWheelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PrimeWheelDataSet primeWheelDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private PrimeWheelDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private PrimeWheelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label custidL;
        private System.Windows.Forms.Button DeleteB;
        private System.Windows.Forms.Button toBookingB;
        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Label bookingIDLabel;
        private System.Windows.Forms.Label BookingManagementLabel;
    }
}