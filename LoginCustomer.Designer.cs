namespace ProjectEDP
{
    partial class LoginCustomer
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
            this.UsernameTxtBoxCust = new System.Windows.Forms.TextBox();
            this.LogInUsernameCustLabel = new System.Windows.Forms.Label();
            this.PasswordTxtBoxCust = new System.Windows.Forms.TextBox();
            this.LogInPasswordCustLabel = new System.Windows.Forms.Label();
            this.SubmitBtnLoginCust = new System.Windows.Forms.Button();
            this.CustomerLoginLabel = new System.Windows.Forms.Label();
            this.PasswordIconCust = new System.Windows.Forms.PictureBox();
            this.UsernameIconCusr = new System.Windows.Forms.PictureBox();
            this.CustomerLoginLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIconCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameIconCusr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTxtBoxCust
            // 
            this.UsernameTxtBoxCust.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtBoxCust.Location = new System.Drawing.Point(351, 242);
            this.UsernameTxtBoxCust.Name = "UsernameTxtBoxCust";
            this.UsernameTxtBoxCust.Size = new System.Drawing.Size(193, 27);
            this.UsernameTxtBoxCust.TabIndex = 13;
            // 
            // LogInUsernameCustLabel
            // 
            this.LogInUsernameCustLabel.AutoSize = true;
            this.LogInUsernameCustLabel.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInUsernameCustLabel.Location = new System.Drawing.Point(347, 219);
            this.LogInUsernameCustLabel.Name = "LogInUsernameCustLabel";
            this.LogInUsernameCustLabel.Size = new System.Drawing.Size(78, 20);
            this.LogInUsernameCustLabel.TabIndex = 12;
            this.LogInUsernameCustLabel.Text = "Username:";
            // 
            // PasswordTxtBoxCust
            // 
            this.PasswordTxtBoxCust.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBoxCust.Location = new System.Drawing.Point(351, 308);
            this.PasswordTxtBoxCust.Name = "PasswordTxtBoxCust";
            this.PasswordTxtBoxCust.Size = new System.Drawing.Size(193, 27);
            this.PasswordTxtBoxCust.TabIndex = 15;
            this.PasswordTxtBoxCust.TextChanged += new System.EventHandler(this.PasswordTxtBoxCust_TextChanged);
            // 
            // LogInPasswordCustLabel
            // 
            this.LogInPasswordCustLabel.AutoSize = true;
            this.LogInPasswordCustLabel.Font = new System.Drawing.Font("Nirmala Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInPasswordCustLabel.Location = new System.Drawing.Point(347, 285);
            this.LogInPasswordCustLabel.Name = "LogInPasswordCustLabel";
            this.LogInPasswordCustLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogInPasswordCustLabel.Size = new System.Drawing.Size(74, 20);
            this.LogInPasswordCustLabel.TabIndex = 14;
            this.LogInPasswordCustLabel.Text = "Password:";
            // 
            // SubmitBtnLoginCust
            // 
            this.SubmitBtnLoginCust.BackColor = System.Drawing.Color.SeaShell;
            this.SubmitBtnLoginCust.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtnLoginCust.Location = new System.Drawing.Point(398, 363);
            this.SubmitBtnLoginCust.Name = "SubmitBtnLoginCust";
            this.SubmitBtnLoginCust.Size = new System.Drawing.Size(83, 50);
            this.SubmitBtnLoginCust.TabIndex = 18;
            this.SubmitBtnLoginCust.Text = "Submit";
            this.SubmitBtnLoginCust.UseVisualStyleBackColor = false;
            this.SubmitBtnLoginCust.Click += new System.EventHandler(this.SubmitBtnLoginCust_Click);
            // 
            // CustomerLoginLabel
            // 
            this.CustomerLoginLabel.AutoSize = true;
            this.CustomerLoginLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerLoginLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomerLoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLoginLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CustomerLoginLabel.Location = new System.Drawing.Point(356, 36);
            this.CustomerLoginLabel.Name = "CustomerLoginLabel";
            this.CustomerLoginLabel.Size = new System.Drawing.Size(188, 29);
            this.CustomerLoginLabel.TabIndex = 19;
            this.CustomerLoginLabel.Text = "Customer Login";
            // 
            // PasswordIconCust
            // 
            this.PasswordIconCust.Image = global::ProjectEDP.Properties.Resources.password_148;
            this.PasswordIconCust.Location = new System.Drawing.Point(320, 308);
            this.PasswordIconCust.Name = "PasswordIconCust";
            this.PasswordIconCust.Size = new System.Drawing.Size(25, 25);
            this.PasswordIconCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordIconCust.TabIndex = 17;
            this.PasswordIconCust.TabStop = false;
            // 
            // UsernameIconCusr
            // 
            this.UsernameIconCusr.Image = global::ProjectEDP.Properties.Resources.Sample_User_Icon;
            this.UsernameIconCusr.Location = new System.Drawing.Point(320, 242);
            this.UsernameIconCusr.Name = "UsernameIconCusr";
            this.UsernameIconCusr.Size = new System.Drawing.Size(25, 25);
            this.UsernameIconCusr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsernameIconCusr.TabIndex = 16;
            this.UsernameIconCusr.TabStop = false;
            // 
            // CustomerLoginLogo
            // 
            this.CustomerLoginLogo.Image = global::ProjectEDP.Properties.Resources.clipart__person_icon__cliparts_15;
            this.CustomerLoginLogo.Location = new System.Drawing.Point(398, 82);
            this.CustomerLoginLogo.Name = "CustomerLoginLogo";
            this.CustomerLoginLogo.Size = new System.Drawing.Size(90, 112);
            this.CustomerLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerLoginLogo.TabIndex = 0;
            this.CustomerLoginLogo.TabStop = false;
            // 
            // LoginCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.CustomerLoginLabel);
            this.Controls.Add(this.SubmitBtnLoginCust);
            this.Controls.Add(this.PasswordIconCust);
            this.Controls.Add(this.UsernameIconCusr);
            this.Controls.Add(this.PasswordTxtBoxCust);
            this.Controls.Add(this.LogInPasswordCustLabel);
            this.Controls.Add(this.UsernameTxtBoxCust);
            this.Controls.Add(this.LogInUsernameCustLabel);
            this.Controls.Add(this.CustomerLoginLogo);
            this.Name = "LoginCustomer";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIconCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameIconCusr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerLoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CustomerLoginLogo;
        private System.Windows.Forms.TextBox UsernameTxtBoxCust;
        private System.Windows.Forms.Label LogInUsernameCustLabel;
        private System.Windows.Forms.TextBox PasswordTxtBoxCust;
        private System.Windows.Forms.Label LogInPasswordCustLabel;
        private System.Windows.Forms.PictureBox UsernameIconCusr;
        private System.Windows.Forms.PictureBox PasswordIconCust;
        private System.Windows.Forms.Button SubmitBtnLoginCust;
        private System.Windows.Forms.Label CustomerLoginLabel;
    }
}