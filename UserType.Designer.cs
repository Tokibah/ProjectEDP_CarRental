namespace ProjectEDP
{
    partial class UserType
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
            this.Customer = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.Form1Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Form1Title2 = new System.Windows.Forms.Label();
            this.HotelIMG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HotelIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer
            // 
            this.Customer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(773, 226);
            this.Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(193, 62);
            this.Customer.TabIndex = 1;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(773, 336);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(193, 62);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Form1Title
            // 
            this.Form1Title.AutoSize = true;
            this.Form1Title.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1Title.Location = new System.Drawing.Point(16, 23);
            this.Form1Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Form1Title.Name = "Form1Title";
            this.Form1Title.Size = new System.Drawing.Size(250, 56);
            this.Form1Title.TabIndex = 3;
            this.Form1Title.Text = "PrimeWheels\r\n";
            this.Form1Title.Click += new System.EventHandler(this.Form1Title_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(732, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose User Type";
            // 
            // Form1Title2
            // 
            this.Form1Title2.AutoSize = true;
            this.Form1Title2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1Title2.Location = new System.Drawing.Point(115, 69);
            this.Form1Title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Form1Title2.Name = "Form1Title2";
            this.Form1Title2.Size = new System.Drawing.Size(348, 56);
            this.Form1Title2.TabIndex = 6;
            this.Form1Title2.Text = "Car Rental Service\r\n";
            // 
            // HotelIMG
            // 
            this.HotelIMG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HotelIMG.Image = global::ProjectEDP.Properties.Resources._299854321_571182288130301_6584559507016416073_n;
            this.HotelIMG.Location = new System.Drawing.Point(43, 132);
            this.HotelIMG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HotelIMG.Name = "HotelIMG";
            this.HotelIMG.Size = new System.Drawing.Size(393, 349);
            this.HotelIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HotelIMG.TabIndex = 4;
            this.HotelIMG.TabStop = false;
            // 
            // UserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 554);
            this.Controls.Add(this.Form1Title2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HotelIMG);
            this.Controls.Add(this.Form1Title);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Customer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSelection";
            ((System.ComponentModel.ISupportInitialize)(this.HotelIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.PictureBox HotelIMG;
        private System.Windows.Forms.Label Form1Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Form1Title2;
    }
}

