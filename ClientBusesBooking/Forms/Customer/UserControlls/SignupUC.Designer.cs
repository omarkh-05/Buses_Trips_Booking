namespace ClientBusesBooking.Forms.Customer
{
    partial class SignupUC
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
            components = new System.ComponentModel.Container();
            label5 = new Label();
            llLogin = new LinkLabel();
            label4 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            label2 = new Label();
            btnSignIn = new AdminBusesBooking.Custom_Controls.CustomButton();
            txtPassword = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label = new Label();
            txtFullName = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            txtPhoneNumber = new MaskedTextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            txtConfirmPass = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            dtpDateOfBirth = new AdminBusesBooking.Custom_Controls.CustomDateTimePicker();
            label6 = new Label();
            cbNationality = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            label7 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AllowDrop = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 40F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(19, 24);
            label5.Name = "label5";
            label5.Size = new Size(354, 140);
            label5.TabIndex = 33;
            label5.Text = "  Welcom To \r\n     MrBus !";
            // 
            // llLogin
            // 
            llLogin.AutoSize = true;
            llLogin.BackColor = Color.Transparent;
            llLogin.Font = new Font("Segoe UI", 10.8F);
            llLogin.LinkColor = Color.FromArgb(255, 128, 0);
            llLogin.Location = new Point(225, 779);
            llLogin.Name = "llLogin";
            llLogin.Size = new Size(46, 20);
            llLogin.TabIndex = 32;
            llLogin.TabStop = true;
            llLogin.Text = "LogIn";
            llLogin.VisitedLinkColor = Color.FromArgb(128, 64, 0);
            llLogin.LinkClicked += llLogin_LinkClicked;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(124, 779);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 31;
            label4.Text = "Back To Login ";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox2.BackColor = Color.FromArgb(35, 40, 50);
            iconPictureBox2.ForeColor = Color.DarkGray;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.DarkGray;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(335, 547);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(37, 30);
            iconPictureBox2.TabIndex = 30;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.MouseEnter += iconPictureBox2_MouseEnter;
            iconPictureBox2.MouseLeave += iconPictureBox2_MouseLeave;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox3.BackColor = Color.FromArgb(35, 40, 50);
            iconPictureBox3.ForeColor = Color.Silver;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Phone;
            iconPictureBox3.IconColor = Color.Silver;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 37;
            iconPictureBox3.Location = new Point(336, 298);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(37, 42);
            iconPictureBox3.TabIndex = 29;
            iconPictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(19, 513);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(20, 271);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 27;
            label2.Text = "Mobile Number";
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.Bottom;
            btnSignIn.BackColor = Color.RoyalBlue;
            btnSignIn.BackgroundColor = Color.RoyalBlue;
            btnSignIn.BorderColor = Color.RoyalBlue;
            btnSignIn.BorderRadius = 20;
            btnSignIn.BorderSize = 0;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(77, 713);
            btnSignIn.Margin = new Padding(3, 2, 3, 2);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(241, 48);
            btnSignIn.TabIndex = 25;
            btnSignIn.Text = "SignIn";
            btnSignIn.TextColor = Color.White;
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(35, 40, 50);
            txtPassword.BorderColor = Color.FromArgb(255, 128, 0);
            txtPassword.BorderFocusColor = Color.Red;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Silver;
            txtPassword.Location = new Point(19, 538);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(6, 5, 6, 5);
            txtPassword.PasswordChar = true;
            txtPassword.Size = new Size(353, 49);
            txtPassword.TabIndex = 23;
            txtPassword.Text = "Password";
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = true;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(35, 40, 50);
            iconPictureBox1.ForeColor = Color.Silver;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.Silver;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(336, 216);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(37, 30);
            iconPictureBox1.TabIndex = 36;
            iconPictureBox1.TabStop = false;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Silver;
            label.Location = new Point(20, 182);
            label.Name = "label";
            label.Size = new Size(97, 25);
            label.TabIndex = 35;
            label.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.BackColor = Color.FromArgb(35, 40, 50);
            txtFullName.BorderColor = Color.FromArgb(255, 128, 0);
            txtFullName.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtFullName.BorderSize = 2;
            txtFullName.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.Silver;
            txtFullName.Location = new Point(20, 207);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Multiline = false;
            txtFullName.Name = "txtFullName";
            txtFullName.Padding = new Padding(13, 5, 6, 5);
            txtFullName.PasswordChar = false;
            txtFullName.Size = new Size(353, 49);
            txtFullName.TabIndex = 34;
            txtFullName.Text = "User Name";
            txtFullName.Texts = "";
            txtFullName.UnderlinedStyle = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top;
            txtPhoneNumber.BackColor = Color.FromArgb(35, 40, 50);
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI", 23.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = Color.DarkGray;
            txtPhoneNumber.Location = new Point(19, 298);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Mask = "(999) 000-000-000";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(320, 42);
            txtPhoneNumber.TabIndex = 37;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox4.BackColor = Color.FromArgb(35, 40, 50);
            iconPictureBox4.ForeColor = Color.DarkGray;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox4.IconColor = Color.DarkGray;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 30;
            iconPictureBox4.Location = new Point(335, 640);
            iconPictureBox4.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(37, 30);
            iconPictureBox4.TabIndex = 40;
            iconPictureBox4.TabStop = false;
            iconPictureBox4.MouseEnter += iconPictureBox4_MouseEnter;
            iconPictureBox4.MouseLeave += iconPictureBox4_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(19, 606);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 39;
            label1.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPass.BackColor = Color.FromArgb(35, 40, 50);
            txtConfirmPass.BorderColor = Color.FromArgb(255, 128, 0);
            txtConfirmPass.BorderFocusColor = Color.Red;
            txtConfirmPass.BorderSize = 2;
            txtConfirmPass.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPass.ForeColor = Color.Silver;
            txtConfirmPass.Location = new Point(19, 631);
            txtConfirmPass.Margin = new Padding(3, 2, 3, 2);
            txtConfirmPass.Multiline = false;
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Padding = new Padding(6, 5, 6, 5);
            txtConfirmPass.PasswordChar = true;
            txtConfirmPass.Size = new Size(353, 49);
            txtConfirmPass.TabIndex = 38;
            txtConfirmPass.Text = "Password";
            txtConfirmPass.Texts = "";
            txtConfirmPass.UnderlinedStyle = true;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top;
            dtpDateOfBirth.BorderColor = Color.PaleVioletRed;
            dtpDateOfBirth.BorderSize = 0;
            dtpDateOfBirth.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(19, 378);
            dtpDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            dtpDateOfBirth.MinimumSize = new Size(4, 35);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(354, 43);
            dtpDateOfBirth.SkinColor = Color.LightSlateGray;
            dtpDateOfBirth.TabIndex = 42;
            dtpDateOfBirth.TextColor = Color.White;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(20, 351);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 43;
            label6.Text = "Date Of Birth";
            // 
            // cbNationality
            // 
            cbNationality.BackColor = Color.DarkSlateBlue;
            cbNationality.BorderColor = Color.White;
            cbNationality.BorderSize = 0;
            cbNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNationality.Font = new Font("Segoe UI", 20F);
            cbNationality.ForeColor = Color.Silver;
            cbNationality.IconColor = Color.Gainsboro;
            cbNationality.ListBackColor = Color.FromArgb(230, 228, 245);
            cbNationality.ListTextColor = Color.DimGray;
            cbNationality.Location = new Point(19, 461);
            cbNationality.Margin = new Padding(3, 2, 3, 2);
            cbNationality.MinimumSize = new Size(175, 22);
            cbNationality.Name = "cbNationality";
            cbNationality.Size = new Size(353, 40);
            cbNationality.TabIndex = 44;
            cbNationality.Texts = "Nationality";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(19, 434);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 45;
            label7.Text = "Nationality";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SignupUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.LoginBack2;
            Controls.Add(label7);
            Controls.Add(cbNationality);
            Controls.Add(label6);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(iconPictureBox4);
            Controls.Add(label1);
            Controls.Add(txtConfirmPass);
            Controls.Add(iconPictureBox3);
            Controls.Add(txtPhoneNumber);
            Controls.Add(iconPictureBox1);
            Controls.Add(label);
            Controls.Add(txtFullName);
            Controls.Add(label5);
            Controls.Add(llLogin);
            Controls.Add(label4);
            Controls.Add(iconPictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSignIn);
            Controls.Add(txtPassword);
            Name = "SignupUC";
            Size = new Size(394, 817);
            Load += SignupUC_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private LinkLabel llLogin;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label3;
        private Label label2;
        private AdminBusesBooking.Custom_Controls.CustomButton btnSignIn;
        private AdminBusesBooking.Custom_Controls.CustomTextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label;
        private AdminBusesBooking.Custom_Controls.CustomTextBox txtFullName;
        private MaskedTextBox txtPhoneNumber;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label label1;
        private AdminBusesBooking.Custom_Controls.CustomTextBox txtConfirmPass;
        private AdminBusesBooking.Custom_Controls.CustomDateTimePicker dtpDateOfBirth;
        private Label label6;
        private AdminBusesBooking.Custom_Controls.CustomComboBox cbNationality;
        private Label label7;
        private ErrorProvider errorProvider1;
    }
}
