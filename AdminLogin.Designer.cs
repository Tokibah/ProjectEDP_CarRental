namespace ProjectEDP
{
    partial class AdminLogin
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
            this.AdminLoginLabel = new System.Windows.Forms.Label();
            this.SubmitBtnLoginAdmin = new System.Windows.Forms.Button();
            this.PasswordTxtBoxAdmin = new System.Windows.Forms.TextBox();
            this.LogInPasswordAdminLabel = new System.Windows.Forms.Label();
            this.UsernameTxtBoxAdmin = new System.Windows.Forms.TextBox();
            this.LogInUsernameAdminLabel = new System.Windows.Forms.Label();
            this.PasswordIconAdmin = new System.Windows.Forms.PictureBox();
            this.UsernameIconAdmin = new System.Windows.Forms.PictureBox();
            this.CustomerLoginLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIconAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameIconAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminLoginLabel
            // 
            this.AdminLoginLabel.AutoSize = true;
            this.AdminLoginLabel.BackColor = System.Drawing.SystemColors.Control;
            this.AdminLoginLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminLoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLoginLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AdminLoginLabel.Location = new System.Drawing.Point(369, 34);
            this.AdminLoginLabel.Name = "AdminLoginLabel";
            this.AdminLoginLabel.Size = new System.Drawing.Size(151, 29);
            this.AdminLoginLabel.TabIndex = 28;
            this.AdminLoginLabel.Text = "Admin Login";
            // 
            // SubmitBtnLoginAdmin
            // 
            this.SubmitBtnLoginAdmin.BackColor = System.Drawing.Color.SeaShell;
            this.SubmitBtnLoginAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtnLoginAdmin.Location = new System.Drawing.Point(398, 363);
            this.SubmitBtnLoginAdmin.Name = "SubmitBtnLoginAdmin";
            this.SubmitBtnLoginAdmin.Size = new System.Drawing.Size(83, 50);
            this.SubmitBtnLoginAdmin.TabIndex = 27;
            this.SubmitBtnLoginAdmin.Text = "Submit";
            this.SubmitBtnLoginAdmin.UseVisualStyleBackColor = false;
            this.SubmitBtnLoginAdmin.Click += new System.EventHandler(this.SubmitBtnLoginAdmin_Click);
            // 
            // PasswordTxtBoxAdmin
            // 
            this.PasswordTxtBoxAdmin.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBoxAdmin.Location = new System.Drawing.Point(351, 308);
            this.PasswordTxtBoxAdmin.Name = "PasswordTxtBoxAdmin";
            this.PasswordTxtBoxAdmin.Size = new System.Drawing.Size(193, 27);
            this.PasswordTxtBoxAdmin.TabIndex = 24;
            this.PasswordTxtBoxAdmin.TextChanged += new System.EventHandler(this.PasswordTxtBoxAdmin_TextChanged);
            // 
            // LogInPasswordAdminLabel
            // 
            this.LogInPasswordAdminLabel.AutoSize = true;
            this.LogInPasswordAdminLabel.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInPasswordAdminLabel.Location = new System.Drawing.Point(347, 285);
            this.LogInPasswordAdminLabel.Name = "LogInPasswordAdminLabel";
            this.LogInPasswordAdminLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogInPasswordAdminLabel.Size = new System.Drawing.Size(74, 20);
            this.LogInPasswordAdminLabel.TabIndex = 23;
            this.LogInPasswordAdminLabel.Text = "Password:";
            // 
            // UsernameTxtBoxAdmin
            // 
            this.UsernameTxtBoxAdmin.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtBoxAdmin.Location = new System.Drawing.Point(351, 242);
            this.UsernameTxtBoxAdmin.Name = "UsernameTxtBoxAdmin";
            this.UsernameTxtBoxAdmin.Size = new System.Drawing.Size(193, 27);
            this.UsernameTxtBoxAdmin.TabIndex = 22;
            this.UsernameTxtBoxAdmin.TextChanged += new System.EventHandler(this.UsernameTxtBoxAdmin_TextChanged);
            // 
            // LogInUsernameAdminLabel
            // 
            this.LogInUsernameAdminLabel.AutoSize = true;
            this.LogInUsernameAdminLabel.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInUsernameAdminLabel.Location = new System.Drawing.Point(347, 219);
            this.LogInUsernameAdminLabel.Name = "LogInUsernameAdminLabel";
            this.LogInUsernameAdminLabel.Size = new System.Drawing.Size(78, 20);
            this.LogInUsernameAdminLabel.TabIndex = 21;
            this.LogInUsernameAdminLabel.Text = "Username:";
            // 
            // PasswordIconAdmin
            // 
            this.PasswordIconAdmin.Image = global::ProjectEDP.Properties.CarImages.password_148;
            this.PasswordIconAdmin.Location = new System.Drawing.Point(320, 308);
            this.PasswordIconAdmin.Name = "PasswordIconAdmin";
            this.PasswordIconAdmin.Size = new System.Drawing.Size(25, 25);
            this.PasswordIconAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordIconAdmin.TabIndex = 26;
            this.PasswordIconAdmin.TabStop = false;
            // 
            // UsernameIconAdmin
            // 
            this.UsernameIconAdmin.Image = global::ProjectEDP.Properties.CarImages.Sample_User_Icon;
            this.UsernameIconAdmin.Location = new System.Drawing.Point(320, 242);
            this.UsernameIconAdmin.Name = "UsernameIconAdmin";
            this.UsernameIconAdmin.Size = new System.Drawing.Size(25, 25);
            this.UsernameIconAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsernameIconAdmin.TabIndex = 25;
            this.UsernameIconAdmin.TabStop = false;
            // 
            // CustomerLoginLogo
            // 
            this.CustomerLoginLogo.Image = global::ProjectEDP.Properties.CarImages.clipart__person_icon__cliparts_15;
            this.CustomerLoginLogo.Location = new System.Drawing.Point(398, 82);
            this.CustomerLoginLogo.Name = "CustomerLoginLogo";
            this.CustomerLoginLogo.Size = new System.Drawing.Size(90, 112);
            this.CustomerLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerLoginLogo.TabIndex = 20;
            this.CustomerLoginLogo.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.AdminLoginLabel);
            this.Controls.Add(this.SubmitBtnLoginAdmin);
            this.Controls.Add(this.PasswordIconAdmin);
            this.Controls.Add(this.UsernameIconAdmin);
            this.Controls.Add(this.PasswordTxtBoxAdmin);
            this.Controls.Add(this.LogInPasswordAdminLabel);
            this.Controls.Add(this.UsernameTxtBoxAdmin);
            this.Controls.Add(this.LogInUsernameAdminLabel);
            this.Controls.Add(this.CustomerLoginLogo);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIconAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameIconAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminLoginLabel;
        private System.Windows.Forms.Button SubmitBtnLoginAdmin;
        private System.Windows.Forms.PictureBox PasswordIconAdmin;
        private System.Windows.Forms.PictureBox UsernameIconAdmin;
        private System.Windows.Forms.TextBox PasswordTxtBoxAdmin;
        private System.Windows.Forms.Label LogInPasswordAdminLabel;
        private System.Windows.Forms.TextBox UsernameTxtBoxAdmin;
        private System.Windows.Forms.Label LogInUsernameAdminLabel;
        private System.Windows.Forms.PictureBox CustomerLoginLogo;
    }
}