namespace ClientBusesBooking.Forms.Booking
{
    partial class frmBookATrip
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            pnlMainBookPage = new Panel();
            btnSearch = new AdminBusesBooking.Custom_Controls.CustomButton();
            iconPictureBox11 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox10 = new FontAwesome.Sharp.IconPictureBox();
            txtDisabledPerson = new NumericUpDown();
            txtChild = new NumericUpDown();
            txtAdult = new NumericUpDown();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            txtPhoneNumber = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            dtpTravelDate = new AdminBusesBooking.Custom_Controls.CustomDateTimePicker();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            cbStatus = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            cbClass = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            cbTrip = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            cbPaymentMethod = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            rbNational = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            rbInternational = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            pnlTitle = new Panel();
            btnBack = new FontAwesome.Sharp.IconButton();
            errorProvider1 = new ErrorProvider(components);
            pnlMainBookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDisabledPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.LightGray;
            lblTitle.Location = new Point(6, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(171, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Add Book Info";
            // 
            // pnlMainBookPage
            // 
            pnlMainBookPage.Controls.Add(btnSearch);
            pnlMainBookPage.Controls.Add(iconPictureBox11);
            pnlMainBookPage.Controls.Add(iconPictureBox10);
            pnlMainBookPage.Controls.Add(txtDisabledPerson);
            pnlMainBookPage.Controls.Add(txtChild);
            pnlMainBookPage.Controls.Add(txtAdult);
            pnlMainBookPage.Controls.Add(iconPictureBox6);
            pnlMainBookPage.Controls.Add(iconPictureBox9);
            pnlMainBookPage.Controls.Add(txtPhoneNumber);
            pnlMainBookPage.Controls.Add(dtpTravelDate);
            pnlMainBookPage.Controls.Add(iconPictureBox5);
            pnlMainBookPage.Controls.Add(iconPictureBox4);
            pnlMainBookPage.Controls.Add(cbStatus);
            pnlMainBookPage.Controls.Add(iconPictureBox3);
            pnlMainBookPage.Controls.Add(cbClass);
            pnlMainBookPage.Controls.Add(iconPictureBox2);
            pnlMainBookPage.Controls.Add(cbTrip);
            pnlMainBookPage.Controls.Add(iconPictureBox1);
            pnlMainBookPage.Controls.Add(iconPictureBox7);
            pnlMainBookPage.Controls.Add(cbPaymentMethod);
            pnlMainBookPage.Controls.Add(rbNational);
            pnlMainBookPage.Controls.Add(rbInternational);
            pnlMainBookPage.Controls.Add(pnlTitle);
            pnlMainBookPage.Dock = DockStyle.Fill;
            pnlMainBookPage.Location = new Point(0, 0);
            pnlMainBookPage.Name = "pnlMainBookPage";
            pnlMainBookPage.Size = new Size(394, 817);
            pnlMainBookPage.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CornflowerBlue;
            btnSearch.BackgroundColor = Color.CornflowerBlue;
            btnSearch.BorderColor = Color.FromArgb(255, 128, 0);
            btnSearch.BorderRadius = 20;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 20F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(119, 687);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 55);
            btnSearch.TabIndex = 100;
            btnSearch.Text = "Search";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // iconPictureBox11
            // 
            iconPictureBox11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox11.BackColor = Color.Transparent;
            iconPictureBox11.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox11.IconChar = FontAwesome.Sharp.IconChar.AccessibleIcon;
            iconPictureBox11.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox11.IconSize = 41;
            iconPictureBox11.Location = new Point(282, 453);
            iconPictureBox11.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox11.Name = "iconPictureBox11";
            iconPictureBox11.Size = new Size(46, 41);
            iconPictureBox11.TabIndex = 99;
            iconPictureBox11.TabStop = false;
            // 
            // iconPictureBox10
            // 
            iconPictureBox10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox10.BackColor = Color.Transparent;
            iconPictureBox10.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox10.IconChar = FontAwesome.Sharp.IconChar.Child;
            iconPictureBox10.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox10.IconSize = 41;
            iconPictureBox10.Location = new Point(147, 453);
            iconPictureBox10.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox10.Name = "iconPictureBox10";
            iconPictureBox10.Size = new Size(46, 41);
            iconPictureBox10.TabIndex = 98;
            iconPictureBox10.TabStop = false;
            // 
            // txtDisabledPerson
            // 
            txtDisabledPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDisabledPerson.BackColor = Color.FromArgb(64, 64, 64);
            txtDisabledPerson.BorderStyle = BorderStyle.None;
            txtDisabledPerson.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisabledPerson.ForeColor = Color.LightGray;
            txtDisabledPerson.Location = new Point(334, 456);
            txtDisabledPerson.Margin = new Padding(3, 2, 3, 2);
            txtDisabledPerson.Name = "txtDisabledPerson";
            txtDisabledPerson.Size = new Size(51, 39);
            txtDisabledPerson.TabIndex = 97;
            // 
            // txtChild
            // 
            txtChild.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtChild.BackColor = Color.FromArgb(64, 64, 64);
            txtChild.BorderStyle = BorderStyle.None;
            txtChild.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChild.ForeColor = Color.LightGray;
            txtChild.Location = new Point(200, 456);
            txtChild.Margin = new Padding(3, 2, 3, 2);
            txtChild.Name = "txtChild";
            txtChild.Size = new Size(51, 39);
            txtChild.TabIndex = 96;
            // 
            // txtAdult
            // 
            txtAdult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAdult.BackColor = Color.FromArgb(64, 64, 64);
            txtAdult.BorderStyle = BorderStyle.None;
            txtAdult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdult.ForeColor = Color.LightGray;
            txtAdult.Location = new Point(52, 456);
            txtAdult.Margin = new Padding(3, 2, 3, 2);
            txtAdult.Name = "txtAdult";
            txtAdult.Size = new Size(51, 39);
            txtAdult.TabIndex = 95;
            txtAdult.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox6.BackColor = Color.Transparent;
            iconPictureBox6.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox6.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 41;
            iconPictureBox6.Location = new Point(3, 453);
            iconPictureBox6.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(46, 41);
            iconPictureBox6.TabIndex = 94;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox9.BackColor = Color.Transparent;
            iconPictureBox9.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.PhoneSquare;
            iconPictureBox9.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 41;
            iconPictureBox9.Location = new Point(6, 384);
            iconPictureBox9.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(44, 41);
            iconPictureBox9.TabIndex = 93;
            iconPictureBox9.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPhoneNumber.BackColor = Color.FromArgb(35, 40, 50);
            txtPhoneNumber.BorderColor = Color.Gray;
            txtPhoneNumber.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtPhoneNumber.BorderSize = 5;
            txtPhoneNumber.Font = new Font("Segoe UI", 20F);
            txtPhoneNumber.ForeColor = Color.DarkGray;
            txtPhoneNumber.Location = new Point(52, 379);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Multiline = false;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Padding = new Padding(6, 5, 6, 5);
            txtPhoneNumber.PasswordChar = false;
            txtPhoneNumber.Size = new Size(333, 46);
            txtPhoneNumber.TabIndex = 92;
            txtPhoneNumber.Texts = "Phone Number";
            txtPhoneNumber.UnderlinedStyle = true;
            // 
            // dtpTravelDate
            // 
            dtpTravelDate.Anchor = AnchorStyles.Top;
            dtpTravelDate.BorderColor = Color.DarkSlateBlue;
            dtpTravelDate.BorderSize = 0;
            dtpTravelDate.Font = new Font("Segoe UI", 15F);
            dtpTravelDate.Format = DateTimePickerFormat.Short;
            dtpTravelDate.Location = new Point(52, 322);
            dtpTravelDate.Margin = new Padding(3, 2, 3, 2);
            dtpTravelDate.MinimumSize = new Size(4, 35);
            dtpTravelDate.Name = "dtpTravelDate";
            dtpTravelDate.Size = new Size(333, 35);
            dtpTravelDate.SkinColor = Color.LightSlateGray;
            dtpTravelDate.TabIndex = 91;
            dtpTravelDate.TextColor = Color.White;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.Anchor = AnchorStyles.Top;
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox5.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 41;
            iconPictureBox5.Location = new Point(6, 318);
            iconPictureBox5.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(41, 41);
            iconPictureBox5.TabIndex = 90;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.Anchor = AnchorStyles.Top;
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingLuggage;
            iconPictureBox4.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 41;
            iconPictureBox4.Location = new Point(3, 257);
            iconPictureBox4.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(44, 41);
            iconPictureBox4.TabIndex = 89;
            iconPictureBox4.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.DarkSlateBlue;
            cbStatus.BorderColor = Color.White;
            cbStatus.BorderSize = 0;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 20F);
            cbStatus.ForeColor = Color.Silver;
            cbStatus.IconColor = Color.Gainsboro;
            cbStatus.Items.AddRange(new object[] { "On going", "Canceled", "Changed", "Soon", "Pending" });
            cbStatus.ListBackColor = Color.FromArgb(230, 228, 245);
            cbStatus.ListTextColor = Color.DimGray;
            cbStatus.Location = new Point(52, 257);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.MinimumSize = new Size(175, 22);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(333, 40);
            cbStatus.TabIndex = 88;
            cbStatus.Texts = "Status";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Top;
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.ChessBishop;
            iconPictureBox3.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 41;
            iconPictureBox3.Location = new Point(3, 193);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(44, 41);
            iconPictureBox3.TabIndex = 87;
            iconPictureBox3.TabStop = false;
            // 
            // cbClass
            // 
            cbClass.BackColor = Color.DarkSlateBlue;
            cbClass.BorderColor = Color.White;
            cbClass.BorderSize = 0;
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Enabled = false;
            cbClass.Font = new Font("Segoe UI", 20F);
            cbClass.ForeColor = Color.Silver;
            cbClass.IconColor = Color.Gainsboro;
            cbClass.Items.AddRange(new object[] { "Vip", "Normal", "Small", "Laxury" });
            cbClass.ListBackColor = Color.FromArgb(230, 228, 245);
            cbClass.ListTextColor = Color.DimGray;
            cbClass.Location = new Point(52, 194);
            cbClass.Margin = new Padding(3, 2, 3, 2);
            cbClass.MinimumSize = new Size(175, 22);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(333, 40);
            cbClass.TabIndex = 86;
            cbClass.Texts = "Class";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top;
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Route;
            iconPictureBox2.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 41;
            iconPictureBox2.Location = new Point(3, 130);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(44, 41);
            iconPictureBox2.TabIndex = 85;
            iconPictureBox2.TabStop = false;
            // 
            // cbTrip
            // 
            cbTrip.Anchor = AnchorStyles.Top;
            cbTrip.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cbTrip.BackColor = Color.DarkSlateBlue;
            cbTrip.BorderColor = Color.White;
            cbTrip.BorderSize = 0;
            cbTrip.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrip.Font = new Font("Segoe UI", 20F);
            cbTrip.ForeColor = Color.Silver;
            cbTrip.IconColor = Color.Gainsboro;
            cbTrip.Items.AddRange(new object[] { "BigBus", "SmallBus", "TinyBus", "Car" });
            cbTrip.ListBackColor = Color.FromArgb(230, 228, 245);
            cbTrip.ListTextColor = Color.DimGray;
            cbTrip.Location = new Point(52, 131);
            cbTrip.Margin = new Padding(3, 2, 3, 2);
            cbTrip.MinimumSize = new Size(175, 22);
            cbTrip.Name = "cbTrip";
            cbTrip.Size = new Size(333, 40);
            cbTrip.TabIndex = 84;
            cbTrip.Texts = "Trip";
            cbTrip.OnSelectedIndexChanged += cbTrip_OnSelectedIndexChanged;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            iconPictureBox1.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 41;
            iconPictureBox1.Location = new Point(3, 527);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(44, 41);
            iconPictureBox1.TabIndex = 83;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.Anchor = AnchorStyles.Top;
            iconPictureBox7.BackColor = Color.Transparent;
            iconPictureBox7.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.EarthAfrica;
            iconPictureBox7.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 41;
            iconPictureBox7.Location = new Point(3, 61);
            iconPictureBox7.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(44, 41);
            iconPictureBox7.TabIndex = 82;
            iconPictureBox7.TabStop = false;
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbPaymentMethod.BackColor = Color.DarkSlateBlue;
            cbPaymentMethod.BorderColor = Color.White;
            cbPaymentMethod.BorderSize = 0;
            cbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPaymentMethod.Font = new Font("Segoe UI", 20F);
            cbPaymentMethod.ForeColor = Color.Silver;
            cbPaymentMethod.IconColor = Color.Gainsboro;
            cbPaymentMethod.Items.AddRange(new object[] { "Visa", "Master Card", "Qliq", "Cash" });
            cbPaymentMethod.ListBackColor = Color.FromArgb(230, 228, 245);
            cbPaymentMethod.ListTextColor = Color.DimGray;
            cbPaymentMethod.Location = new Point(52, 527);
            cbPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            cbPaymentMethod.MinimumSize = new Size(175, 22);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(333, 40);
            cbPaymentMethod.TabIndex = 81;
            cbPaymentMethod.Texts = "Payment Method";
            // 
            // rbNational
            // 
            rbNational.AutoSize = true;
            rbNational.Checked = true;
            rbNational.CheckedColor = Color.MediumSlateBlue;
            rbNational.Font = new Font("Segoe UI", 20F);
            rbNational.ForeColor = Color.DarkGray;
            rbNational.Location = new Point(250, 61);
            rbNational.Margin = new Padding(3, 2, 3, 2);
            rbNational.MinimumSize = new Size(0, 16);
            rbNational.Name = "rbNational";
            rbNational.Padding = new Padding(9, 0, 0, 0);
            rbNational.Size = new Size(141, 41);
            rbNational.TabIndex = 32;
            rbNational.TabStop = true;
            rbNational.Text = "national";
            rbNational.UnCheckedColor = Color.Gray;
            rbNational.UseVisualStyleBackColor = true;
            // 
            // rbInternational
            // 
            rbInternational.AutoSize = true;
            rbInternational.CheckedColor = Color.MediumSlateBlue;
            rbInternational.Font = new Font("Segoe UI", 20F);
            rbInternational.ForeColor = Color.DarkGray;
            rbInternational.Location = new Point(52, 61);
            rbInternational.Margin = new Padding(3, 2, 3, 2);
            rbInternational.MinimumSize = new Size(0, 16);
            rbInternational.Name = "rbInternational";
            rbInternational.Padding = new Padding(9, 0, 0, 0);
            rbInternational.Size = new Size(195, 41);
            rbInternational.TabIndex = 31;
            rbInternational.Text = "International";
            rbInternational.UnCheckedColor = Color.Gray;
            rbInternational.UseVisualStyleBackColor = true;
            rbInternational.CheckedChanged += rbInternational_CheckedChanged;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(35, 45, 50);
            pnlTitle.Controls.Add(btnBack);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(394, 45);
            pnlTitle.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.IconChar = FontAwesome.Sharp.IconChar.Forward;
            btnBack.IconColor = Color.White;
            btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBack.IconSize = 32;
            btnBack.Location = new Point(343, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 29);
            btnBack.TabIndex = 2;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBookATrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 45, 55);
            ClientSize = new Size(394, 817);
            Controls.Add(pnlMainBookPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBookATrip";
            Text = "frmBookATrip";
            Load += frmBookATrip_Load;
            pnlMainBookPage.ResumeLayout(false);
            pnlMainBookPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDisabledPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdult).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlMainBookPage;
        private Panel pnlTitle;
        private AdminBusesBooking.Custom_Controls.CustomRadioButton rbNational;
        private AdminBusesBooking.Custom_Controls.CustomRadioButton rbInternational;
        private AdminBusesBooking.Custom_Controls.CustomComboBox cbPaymentMethod;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private AdminBusesBooking.Custom_Controls.CustomComboBox cbTrip;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private AdminBusesBooking.Custom_Controls.CustomComboBox cbClass;
        private AdminBusesBooking.Custom_Controls.CustomComboBox cbStatus;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private AdminBusesBooking.Custom_Controls.CustomDateTimePicker dtpTravelDate;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        public AdminBusesBooking.Custom_Controls.CustomTextBox txtPhoneNumber;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox10;
        private NumericUpDown txtDisabledPerson;
        private NumericUpDown txtChild;
        private NumericUpDown txtAdult;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private AdminBusesBooking.Custom_Controls.CustomButton btnSearch;
        private ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}