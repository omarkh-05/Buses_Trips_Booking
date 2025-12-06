namespace ClientBusesBooking.Forms.Booking
{
    partial class TicketInfoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtPersonType = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            iconPictureBox12 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            rbMale = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            rbFemale = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            label1 = new Label();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtNationalID = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            txtSeatNumber = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            txtPassengerName = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPersonType);
            groupBox1.Controls.Add(iconPictureBox12);
            groupBox1.Controls.Add(iconPictureBox3);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(iconPictureBox8);
            groupBox1.Controls.Add(iconPictureBox1);
            groupBox1.Controls.Add(txtNationalID);
            groupBox1.Controls.Add(txtSeatNumber);
            groupBox1.Controls.Add(txtPassengerName);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(375, 341);
            groupBox1.TabIndex = 94;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ticket";
            // 
            // txtPersonType
            // 
            txtPersonType.BackColor = Color.FromArgb(35, 40, 50);
            txtPersonType.BorderColor = Color.Gray;
            txtPersonType.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtPersonType.BorderSize = 5;
            txtPersonType.Enabled = false;
            txtPersonType.Font = new Font("Segoe UI", 20F);
            txtPersonType.ForeColor = Color.DarkGray;
            txtPersonType.Location = new Point(56, 275);
            txtPersonType.Margin = new Padding(3, 2, 3, 2);
            txtPersonType.Multiline = false;
            txtPersonType.Name = "txtPersonType";
            txtPersonType.Padding = new Padding(6, 5, 6, 5);
            txtPersonType.PasswordChar = false;
            txtPersonType.Size = new Size(271, 46);
            txtPersonType.TabIndex = 93;
            txtPersonType.Texts = "Person Type";
            txtPersonType.UnderlinedStyle = true;
            // 
            // iconPictureBox12
            // 
            iconPictureBox12.BackColor = Color.Transparent;
            iconPictureBox12.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox12.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            iconPictureBox12.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox12.IconSize = 41;
            iconPictureBox12.Location = new Point(5, 25);
            iconPictureBox12.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox12.Name = "iconPictureBox12";
            iconPictureBox12.Size = new Size(47, 41);
            iconPictureBox12.TabIndex = 87;
            iconPictureBox12.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox3.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 41;
            iconPictureBox3.Location = new Point(4, 280);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(47, 41);
            iconPictureBox3.TabIndex = 92;
            iconPictureBox3.TabStop = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.CheckedColor = Color.MediumSlateBlue;
            rbMale.Font = new Font("Segoe UI", 20F);
            rbMale.ForeColor = Color.DarkGray;
            rbMale.Location = new Point(136, 215);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.MinimumSize = new Size(0, 16);
            rbMale.Name = "rbMale";
            rbMale.Padding = new Padding(9, 0, 0, 0);
            rbMale.Size = new Size(103, 41);
            rbMale.TabIndex = 33;
            rbMale.Text = "Male";
            rbMale.UnCheckedColor = Color.Gray;
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Checked = true;
            rbFemale.CheckedColor = Color.MediumSlateBlue;
            rbFemale.Font = new Font("Segoe UI", 20F);
            rbFemale.ForeColor = Color.DarkGray;
            rbFemale.Location = new Point(245, 215);
            rbFemale.Margin = new Padding(3, 2, 3, 2);
            rbFemale.MinimumSize = new Size(0, 16);
            rbFemale.Name = "rbFemale";
            rbFemale.Padding = new Padding(9, 0, 0, 0);
            rbFemale.Size = new Size(129, 41);
            rbFemale.TabIndex = 34;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UnCheckedColor = Color.Gray;
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(4, 217);
            label1.Name = "label1";
            label1.Size = new Size(117, 37);
            label1.TabIndex = 90;
            label1.Text = "Gender :";
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.BackColor = Color.Transparent;
            iconPictureBox8.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            iconPictureBox8.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 41;
            iconPictureBox8.Location = new Point(4, 81);
            iconPictureBox8.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(47, 41);
            iconPictureBox8.TabIndex = 83;
            iconPictureBox8.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Chair;
            iconPictureBox1.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 41;
            iconPictureBox1.Location = new Point(5, 147);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(47, 41);
            iconPictureBox1.TabIndex = 89;
            iconPictureBox1.TabStop = false;
            // 
            // txtNationalID
            // 
            txtNationalID.BackColor = Color.FromArgb(35, 40, 50);
            txtNationalID.BorderColor = Color.Gray;
            txtNationalID.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtNationalID.BorderSize = 5;
            txtNationalID.Font = new Font("Segoe UI", 20F);
            txtNationalID.ForeColor = Color.DarkGray;
            txtNationalID.Location = new Point(56, 81);
            txtNationalID.Margin = new Padding(3, 2, 3, 2);
            txtNationalID.Multiline = false;
            txtNationalID.Name = "txtNationalID";
            txtNationalID.Padding = new Padding(6, 5, 6, 5);
            txtNationalID.PasswordChar = false;
            txtNationalID.Size = new Size(271, 46);
            txtNationalID.TabIndex = 82;
            txtNationalID.Texts = "National ID";
            txtNationalID.UnderlinedStyle = true;
            // 
            // txtSeatNumber
            // 
            txtSeatNumber.BackColor = Color.FromArgb(35, 40, 50);
            txtSeatNumber.BorderColor = Color.Gray;
            txtSeatNumber.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtSeatNumber.BorderSize = 5;
            txtSeatNumber.Enabled = false;
            txtSeatNumber.Font = new Font("Segoe UI", 20F);
            txtSeatNumber.ForeColor = Color.DarkGray;
            txtSeatNumber.Location = new Point(56, 142);
            txtSeatNumber.Margin = new Padding(3, 2, 3, 2);
            txtSeatNumber.Multiline = false;
            txtSeatNumber.Name = "txtSeatNumber";
            txtSeatNumber.Padding = new Padding(6, 5, 6, 5);
            txtSeatNumber.PasswordChar = false;
            txtSeatNumber.Size = new Size(271, 46);
            txtSeatNumber.TabIndex = 88;
            txtSeatNumber.Text = "Seat Number";
            txtSeatNumber.Texts = "Seat Number";
            txtSeatNumber.UnderlinedStyle = true;
            // 
            // txtPassengerName
            // 
            txtPassengerName.BackColor = Color.FromArgb(35, 40, 50);
            txtPassengerName.BorderColor = Color.Gray;
            txtPassengerName.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtPassengerName.BorderSize = 5;
            txtPassengerName.Font = new Font("Segoe UI", 20F);
            txtPassengerName.ForeColor = Color.DarkGray;
            txtPassengerName.Location = new Point(56, 20);
            txtPassengerName.Margin = new Padding(3, 2, 3, 2);
            txtPassengerName.Multiline = false;
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.Padding = new Padding(6, 5, 6, 5);
            txtPassengerName.PasswordChar = false;
            txtPassengerName.Size = new Size(271, 46);
            txtPassengerName.TabIndex = 86;
            txtPassengerName.Texts = "Passenger Name";
            txtPassengerName.UnderlinedStyle = true;
            // 
            // TicketInfoUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 45, 55);
            Controls.Add(groupBox1);
            Name = "TicketInfoUC";
            Size = new Size(386, 354);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox12;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private AdminBusesBooking.Custom_Controls.CustomRadioButton rbMale;
        private AdminBusesBooking.Custom_Controls.CustomRadioButton rbFemale;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public AdminBusesBooking.Custom_Controls.CustomTextBox txtNationalID;
        public AdminBusesBooking.Custom_Controls.CustomTextBox txtSeatNumber;
        public AdminBusesBooking.Custom_Controls.CustomTextBox txtPassengerName;
        public AdminBusesBooking.Custom_Controls.CustomTextBox txtPersonType;
    }
}
