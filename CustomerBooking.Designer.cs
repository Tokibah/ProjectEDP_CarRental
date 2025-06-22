using System;

namespace ProjectEDP
{
    partial class CustomerBooking
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
            this.PriceRESULT = new System.Windows.Forms.TextBox();
            this.TotalAmount = new System.Windows.Forms.Button();
            this.CarRateLabel = new System.Windows.Forms.Label();
            this.CarTypeLabel = new System.Windows.Forms.RichTextBox();
            this.NEXT = new System.Windows.Forms.Button();
            this.PREVIOUS = new System.Windows.Forms.Button();
            this.RentDate = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.RentalDateLabel = new System.Windows.Forms.Label();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.PickupLocationComboBox = new System.Windows.Forms.ComboBox();
            this.PickupLocationLabel = new System.Windows.Forms.Label();
            this.ReturnLocationLabel = new System.Windows.Forms.Label();
            this.ReturnLocationComboBox = new System.Windows.Forms.ComboBox();
            this.PaymentTypeGpBoxLabel = new System.Windows.Forms.GroupBox();
            this.TNGWallet = new System.Windows.Forms.RadioButton();
            this.FPXBanking = new System.Windows.Forms.RadioButton();
            this.QR = new System.Windows.Forms.RadioButton();
            this.CashPayment = new System.Windows.Forms.RadioButton();
            this.CarRateStatic = new System.Windows.Forms.TextBox();
            this.SubmitBtnRentBook = new System.Windows.Forms.Button();
            this.TypeOfCar = new System.Windows.Forms.PictureBox();
            this.CustBookingLabel = new System.Windows.Forms.Label();
            this.PaymentTypeGpBoxLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfCar)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceRESULT
            // 
            this.PriceRESULT.BackColor = System.Drawing.SystemColors.Control;
            this.PriceRESULT.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceRESULT.Location = new System.Drawing.Point(1031, 436);
            this.PriceRESULT.Margin = new System.Windows.Forms.Padding(4);
            this.PriceRESULT.Name = "PriceRESULT";
            this.PriceRESULT.Size = new System.Drawing.Size(132, 39);
            this.PriceRESULT.TabIndex = 39;
            // 
            // TotalAmount
            // 
            this.TotalAmount.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(785, 433);
            this.TotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(237, 47);
            this.TotalAmount.TabIndex = 38;
            this.TotalAmount.Text = "Total Amount, RM";
            this.TotalAmount.UseVisualStyleBackColor = true;
            this.TotalAmount.Click += new System.EventHandler(this.TotalAmount_Click_1);
            // 
            // CarRateLabel
            // 
            this.CarRateLabel.AutoSize = true;
            this.CarRateLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRateLabel.Location = new System.Drawing.Point(817, 389);
            this.CarRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CarRateLabel.Name = "CarRateLabel";
            this.CarRateLabel.Size = new System.Drawing.Size(198, 25);
            this.CarRateLabel.TabIndex = 37;
            this.CarRateLabel.Text = "Car Rate Per Hour, RM";
            this.CarRateLabel.Click += new System.EventHandler(this.CarRateLabel_Click);
            // 
            // CarTypeLabel
            // 
            this.CarTypeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CarTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarTypeLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarTypeLabel.Location = new System.Drawing.Point(183, 410);
            this.CarTypeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CarTypeLabel.Name = "CarTypeLabel";
            this.CarTypeLabel.Size = new System.Drawing.Size(163, 66);
            this.CarTypeLabel.TabIndex = 31;
            this.CarTypeLabel.Text = "";
            // 
            // NEXT
            // 
            this.NEXT.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEXT.Location = new System.Drawing.Point(387, 406);
            this.NEXT.Margin = new System.Windows.Forms.Padding(4);
            this.NEXT.Name = "NEXT";
            this.NEXT.Size = new System.Drawing.Size(127, 37);
            this.NEXT.TabIndex = 30;
            this.NEXT.Text = "Next";
            this.NEXT.UseVisualStyleBackColor = true;
            this.NEXT.Click += new System.EventHandler(this.NEXT_Click);
            // 
            // PREVIOUS
            // 
            this.PREVIOUS.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PREVIOUS.Location = new System.Drawing.Point(25, 406);
            this.PREVIOUS.Margin = new System.Windows.Forms.Padding(4);
            this.PREVIOUS.Name = "PREVIOUS";
            this.PREVIOUS.Size = new System.Drawing.Size(127, 37);
            this.PREVIOUS.TabIndex = 29;
            this.PREVIOUS.Text = "Previous";
            this.PREVIOUS.UseVisualStyleBackColor = true;
            this.PREVIOUS.Click += new System.EventHandler(this.PREVIOUS_Click);
            // 
            // RentDate
            // 
            this.RentDate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDate.Location = new System.Drawing.Point(563, 78);
            this.RentDate.Margin = new System.Windows.Forms.Padding(4);
            this.RentDate.Name = "RentDate";
            this.RentDate.Size = new System.Drawing.Size(315, 32);
            this.RentDate.TabIndex = 34;
            // 
            // ReturnDate
            // 
            this.ReturnDate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate.Location = new System.Drawing.Point(561, 143);
            this.ReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(315, 32);
            this.ReturnDate.TabIndex = 36;
            // 
            // RentalDateLabel
            // 
            this.RentalDateLabel.AutoSize = true;
            this.RentalDateLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalDateLabel.Location = new System.Drawing.Point(557, 49);
            this.RentalDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RentalDateLabel.Name = "RentalDateLabel";
            this.RentalDateLabel.Size = new System.Drawing.Size(112, 25);
            this.RentalDateLabel.TabIndex = 40;
            this.RentalDateLabel.Text = "Rental Date:";
            this.RentalDateLabel.Click += new System.EventHandler(this.RentalDateLabel_Click);
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateLabel.Location = new System.Drawing.Point(557, 114);
            this.ReturnDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(115, 25);
            this.ReturnDateLabel.TabIndex = 41;
            this.ReturnDateLabel.Text = "Return Date:";
            // 
            // PickupLocationComboBox
            // 
            this.PickupLocationComboBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickupLocationComboBox.FormattingEnabled = true;
            this.PickupLocationComboBox.Items.AddRange(new object[] {
            "Ayer Keroh",
            "",
            "",
            "Bukit Katil",
            "",
            "",
            "Durian Tunggal",
            "",
            "",
            "Masjid Tanah",
            "",
            "",
            "Bemban",
            "",
            "",
            "Merlimau",
            "",
            "",
            "Sungai Udang",
            "",
            "",
            "",
            "",
            "Batu Berendam",
            "",
            "",
            "Lubok China"});
            this.PickupLocationComboBox.Location = new System.Drawing.Point(564, 230);
            this.PickupLocationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PickupLocationComboBox.Name = "PickupLocationComboBox";
            this.PickupLocationComboBox.Size = new System.Drawing.Size(160, 33);
            this.PickupLocationComboBox.TabIndex = 42;
            // 
            // PickupLocationLabel
            // 
            this.PickupLocationLabel.AutoSize = true;
            this.PickupLocationLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickupLocationLabel.Location = new System.Drawing.Point(559, 202);
            this.PickupLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PickupLocationLabel.Name = "PickupLocationLabel";
            this.PickupLocationLabel.Size = new System.Drawing.Size(156, 25);
            this.PickupLocationLabel.TabIndex = 43;
            this.PickupLocationLabel.Text = "Pick Up Location:";
            // 
            // ReturnLocationLabel
            // 
            this.ReturnLocationLabel.AutoSize = true;
            this.ReturnLocationLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLocationLabel.Location = new System.Drawing.Point(559, 279);
            this.ReturnLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReturnLocationLabel.Name = "ReturnLocationLabel";
            this.ReturnLocationLabel.Size = new System.Drawing.Size(148, 25);
            this.ReturnLocationLabel.TabIndex = 45;
            this.ReturnLocationLabel.Text = "Return Location:";
            // 
            // ReturnLocationComboBox
            // 
            this.ReturnLocationComboBox.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLocationComboBox.FormattingEnabled = true;
            this.ReturnLocationComboBox.Items.AddRange(new object[] {
            "Ayer Keroh",
            "",
            "",
            "Bukit Katil",
            "",
            "",
            "Durian Tunggal",
            "",
            "",
            "Masjid Tanah",
            "",
            "",
            "Bemban",
            "",
            "",
            "Merlimau",
            "",
            "",
            "Sungai Udang",
            "",
            "",
            "",
            "",
            "Batu Berendam",
            "",
            "",
            "Lubok China"});
            this.ReturnLocationComboBox.Location = new System.Drawing.Point(564, 308);
            this.ReturnLocationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnLocationComboBox.Name = "ReturnLocationComboBox";
            this.ReturnLocationComboBox.Size = new System.Drawing.Size(160, 33);
            this.ReturnLocationComboBox.TabIndex = 44;
            // 
            // PaymentTypeGpBoxLabel
            // 
            this.PaymentTypeGpBoxLabel.Controls.Add(this.TNGWallet);
            this.PaymentTypeGpBoxLabel.Controls.Add(this.FPXBanking);
            this.PaymentTypeGpBoxLabel.Controls.Add(this.QR);
            this.PaymentTypeGpBoxLabel.Controls.Add(this.CashPayment);
            this.PaymentTypeGpBoxLabel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTypeGpBoxLabel.Location = new System.Drawing.Point(940, 49);
            this.PaymentTypeGpBoxLabel.Margin = new System.Windows.Forms.Padding(4);
            this.PaymentTypeGpBoxLabel.Name = "PaymentTypeGpBoxLabel";
            this.PaymentTypeGpBoxLabel.Padding = new System.Windows.Forms.Padding(4);
            this.PaymentTypeGpBoxLabel.Size = new System.Drawing.Size(224, 293);
            this.PaymentTypeGpBoxLabel.TabIndex = 46;
            this.PaymentTypeGpBoxLabel.TabStop = false;
            this.PaymentTypeGpBoxLabel.Text = "Payment Type";
            // 
            // TNGWallet
            // 
            this.TNGWallet.AutoSize = true;
            this.TNGWallet.Location = new System.Drawing.Point(13, 142);
            this.TNGWallet.Margin = new System.Windows.Forms.Padding(4);
            this.TNGWallet.Name = "TNGWallet";
            this.TNGWallet.Size = new System.Drawing.Size(146, 29);
            this.TNGWallet.TabIndex = 3;
            this.TNGWallet.TabStop = true;
            this.TNGWallet.Text = "TNG E-Wallet";
            this.TNGWallet.UseVisualStyleBackColor = true;
            // 
            // FPXBanking
            // 
            this.FPXBanking.AutoSize = true;
            this.FPXBanking.Location = new System.Drawing.Point(13, 105);
            this.FPXBanking.Margin = new System.Windows.Forms.Padding(4);
            this.FPXBanking.Name = "FPXBanking";
            this.FPXBanking.Size = new System.Drawing.Size(197, 29);
            this.FPXBanking.TabIndex = 2;
            this.FPXBanking.TabStop = true;
            this.FPXBanking.Text = "FPX Online Banking";
            this.FPXBanking.UseVisualStyleBackColor = true;
            // 
            // QR
            // 
            this.QR.AutoSize = true;
            this.QR.Location = new System.Drawing.Point(13, 68);
            this.QR.Margin = new System.Windows.Forms.Padding(4);
            this.QR.Name = "QR";
            this.QR.Size = new System.Drawing.Size(135, 29);
            this.QR.TabIndex = 1;
            this.QR.TabStop = true;
            this.QR.Text = "QR Payment";
            this.QR.UseVisualStyleBackColor = true;
            // 
            // CashPayment
            // 
            this.CashPayment.AutoSize = true;
            this.CashPayment.Location = new System.Drawing.Point(13, 31);
            this.CashPayment.Margin = new System.Windows.Forms.Padding(4);
            this.CashPayment.Name = "CashPayment";
            this.CashPayment.Size = new System.Drawing.Size(74, 29);
            this.CashPayment.TabIndex = 0;
            this.CashPayment.TabStop = true;
            this.CashPayment.Text = "Cash";
            this.CashPayment.UseVisualStyleBackColor = true;
            // 
            // CarRateStatic
            // 
            this.CarRateStatic.BackColor = System.Drawing.SystemColors.Control;
            this.CarRateStatic.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRateStatic.Location = new System.Drawing.Point(1031, 380);
            this.CarRateStatic.Margin = new System.Windows.Forms.Padding(4);
            this.CarRateStatic.Name = "CarRateStatic";
            this.CarRateStatic.Size = new System.Drawing.Size(132, 39);
            this.CarRateStatic.TabIndex = 47;
            this.CarRateStatic.TextChanged += new System.EventHandler(this.CarRateStatic_TextChanged);
            // 
            // SubmitBtnRentBook
            // 
            this.SubmitBtnRentBook.BackColor = System.Drawing.Color.SeaShell;
            this.SubmitBtnRentBook.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtnRentBook.Location = new System.Drawing.Point(1053, 484);
            this.SubmitBtnRentBook.Margin = new System.Windows.Forms.Padding(4);
            this.SubmitBtnRentBook.Name = "SubmitBtnRentBook";
            this.SubmitBtnRentBook.Size = new System.Drawing.Size(111, 62);
            this.SubmitBtnRentBook.TabIndex = 48;
            this.SubmitBtnRentBook.Text = "Submit";
            this.SubmitBtnRentBook.UseVisualStyleBackColor = false;
            this.SubmitBtnRentBook.Click += new System.EventHandler(this.SubmitBtnRentBook_Click_1);
            // 
            // TypeOfCar
            // 
            this.TypeOfCar.Location = new System.Drawing.Point(19, 40);
            this.TypeOfCar.Name = "TypeOfCar";
            this.TypeOfCar.Size = new System.Drawing.Size(488, 306);
            this.TypeOfCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TypeOfCar.TabIndex = 28;
            this.TypeOfCar.TabStop = false;
            // 
            // CustBookingLabel
            // 
            this.CustBookingLabel.AutoSize = true;
            this.CustBookingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustBookingLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustBookingLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustBookingLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CustBookingLabel.Location = new System.Drawing.Point(19, 10);
            this.CustBookingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustBookingLabel.Name = "CustBookingLabel";
            this.CustBookingLabel.Size = new System.Drawing.Size(226, 38);
            this.CustBookingLabel.TabIndex = 49;
            this.CustBookingLabel.Text = "Rental Booking";
            // 
            // CustomerBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 554);
            this.Controls.Add(this.CustBookingLabel);
            this.Controls.Add(this.SubmitBtnRentBook);
            this.Controls.Add(this.CarRateStatic);
            this.Controls.Add(this.PaymentTypeGpBoxLabel);
            this.Controls.Add(this.ReturnLocationLabel);
            this.Controls.Add(this.ReturnLocationComboBox);
            this.Controls.Add(this.PickupLocationLabel);
            this.Controls.Add(this.PickupLocationComboBox);
            this.Controls.Add(this.ReturnDateLabel);
            this.Controls.Add(this.RentalDateLabel);
            this.Controls.Add(this.PriceRESULT);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.RentDate);
            this.Controls.Add(this.CarRateLabel);
            this.Controls.Add(this.CarTypeLabel);
            this.Controls.Add(this.NEXT);
            this.Controls.Add(this.PREVIOUS);
            this.Controls.Add(this.TypeOfCar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerBooking";
            this.Text = "CustomerBooking";
            this.Load += new System.EventHandler(this.CustomerBooking_Load);
            this.PaymentTypeGpBoxLabel.ResumeLayout(false);
            this.PaymentTypeGpBoxLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PriceRESULT;
        private System.Windows.Forms.Button TotalAmount;
        private System.Windows.Forms.Label CarRateLabel;
        private System.Windows.Forms.RichTextBox CarTypeLabel;
        private System.Windows.Forms.Button NEXT;
        private System.Windows.Forms.Button PREVIOUS;
        private System.Windows.Forms.PictureBox TypeOfCar;
        private System.Windows.Forms.DateTimePicker RentDate;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Label RentalDateLabel;
        private System.Windows.Forms.Label ReturnDateLabel;
        private System.Windows.Forms.ComboBox PickupLocationComboBox;
        private System.Windows.Forms.Label PickupLocationLabel;
        private System.Windows.Forms.Label ReturnLocationLabel;
        private System.Windows.Forms.ComboBox ReturnLocationComboBox;
        private System.Windows.Forms.GroupBox PaymentTypeGpBoxLabel;
        private System.Windows.Forms.RadioButton TNGWallet;
        private System.Windows.Forms.RadioButton FPXBanking;
        private System.Windows.Forms.RadioButton QR;
        private System.Windows.Forms.RadioButton CashPayment;
        private System.Windows.Forms.TextBox CarRateStatic;
        private System.Windows.Forms.Button SubmitBtnRentBook;
        private System.Windows.Forms.Label CustBookingLabel;
    }
}