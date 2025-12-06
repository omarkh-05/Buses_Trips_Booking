namespace AdminBusesBooking.Forms.Booking
{
    partial class frmBookings
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
            pnlPersonInfoBooking = new Panel();
            pnlPassengers = new Panel();
            pnlSaveAndClose = new Panel();
            btnTicketsInfoSave = new AdminBusesBooking.Custom_Controls.CustomButton();
            btnClose = new AdminBusesBooking.Custom_Controls.CustomButton();
            label2 = new Label();
            label1 = new Label();
            cbClass = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            btnSave = new AdminBusesBooking.Custom_Controls.CustomButton();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            cbTrip = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            cbStatus = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            panel2 = new Panel();
            rbNational = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            rbInternational = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            label8 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            dtpTravelDate = new AdminBusesBooking.Custom_Controls.CustomDateTimePicker();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            txtPhoneNumber = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            txtAdult = new NumericUpDown();
            pnlAddUser = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            cbPaymentMethod = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox11 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox10 = new FontAwesome.Sharp.IconPictureBox();
            txtDisabledPerson = new NumericUpDown();
            txtChild = new NumericUpDown();
            errorProvider1 = new ErrorProvider(components);
            pnlPersonInfoBooking.SuspendLayout();
            pnlSaveAndClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdult).BeginInit();
            pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDisabledPerson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlPersonInfoBooking
            // 
            pnlPersonInfoBooking.BackColor = Color.FromArgb(35, 40, 50);
            pnlPersonInfoBooking.Controls.Add(pnlPassengers);
            pnlPersonInfoBooking.Controls.Add(pnlSaveAndClose);
            pnlPersonInfoBooking.Dock = DockStyle.Fill;
            pnlPersonInfoBooking.Location = new Point(0, 306);
            pnlPersonInfoBooking.Margin = new Padding(3, 2, 3, 2);
            pnlPersonInfoBooking.Name = "pnlPersonInfoBooking";
            pnlPersonInfoBooking.Size = new Size(1449, 469);
            pnlPersonInfoBooking.TabIndex = 13;
            // 
            // pnlPassengers
            // 
            pnlPassengers.AutoScroll = true;
            pnlPassengers.Dock = DockStyle.Fill;
            pnlPassengers.Location = new Point(0, 0);
            pnlPassengers.Margin = new Padding(3, 2, 3, 2);
            pnlPassengers.Name = "pnlPassengers";
            pnlPassengers.Size = new Size(1449, 395);
            pnlPassengers.TabIndex = 86;
            // 
            // pnlSaveAndClose
            // 
            pnlSaveAndClose.Controls.Add(btnTicketsInfoSave);
            pnlSaveAndClose.Controls.Add(btnClose);
            pnlSaveAndClose.Dock = DockStyle.Bottom;
            pnlSaveAndClose.Location = new Point(0, 395);
            pnlSaveAndClose.Margin = new Padding(3, 2, 3, 2);
            pnlSaveAndClose.Name = "pnlSaveAndClose";
            pnlSaveAndClose.Size = new Size(1449, 74);
            pnlSaveAndClose.TabIndex = 85;
            // 
            // btnTicketsInfoSave
            // 
            btnTicketsInfoSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTicketsInfoSave.BackColor = Color.FromArgb(26, 150, 44);
            btnTicketsInfoSave.BackgroundColor = Color.FromArgb(26, 150, 44);
            btnTicketsInfoSave.BorderColor = Color.White;
            btnTicketsInfoSave.BorderRadius = 20;
            btnTicketsInfoSave.BorderSize = 0;
            btnTicketsInfoSave.FlatAppearance.BorderSize = 0;
            btnTicketsInfoSave.FlatStyle = FlatStyle.Flat;
            btnTicketsInfoSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTicketsInfoSave.ForeColor = Color.WhiteSmoke;
            btnTicketsInfoSave.Location = new Point(779, 16);
            btnTicketsInfoSave.Margin = new Padding(3, 2, 3, 2);
            btnTicketsInfoSave.Name = "btnTicketsInfoSave";
            btnTicketsInfoSave.Size = new Size(180, 38);
            btnTicketsInfoSave.TabIndex = 45;
            btnTicketsInfoSave.Text = "Save";
            btnTicketsInfoSave.TextColor = Color.WhiteSmoke;
            btnTicketsInfoSave.UseVisualStyleBackColor = false;
            btnTicketsInfoSave.Click += btnCompleteBooking_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.BackgroundColor = Color.FromArgb(192, 0, 0);
            btnClose.BorderColor = Color.White;
            btnClose.BorderRadius = 20;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.WhiteSmoke;
            btnClose.Location = new Point(485, 16);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 38);
            btnClose.TabIndex = 44;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.WhiteSmoke;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(1152, 273);
            label2.Name = "label2";
            label2.Size = new Size(251, 32);
            label2.TabIndex = 79;
            label2.Text = "Add Book Person Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(171, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Book Info";
            // 
            // cbClass
            // 
            cbClass.BackColor = Color.DarkSlateBlue;
            cbClass.BorderColor = Color.White;
            cbClass.BorderSize = 0;
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Font = new Font("Segoe UI", 20F);
            cbClass.ForeColor = Color.Silver;
            cbClass.IconColor = Color.Gainsboro;
            cbClass.Items.AddRange(new object[] { "Vip", "Normal", "Small", "Laxury" });
            cbClass.ListBackColor = Color.FromArgb(230, 228, 245);
            cbClass.ListTextColor = Color.DimGray;
            cbClass.Location = new Point(139, 129);
            cbClass.Margin = new Padding(3, 2, 3, 2);
            cbClass.MinimumSize = new Size(175, 22);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(271, 40);
            cbClass.TabIndex = 42;
            cbClass.Texts = "Class";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.FromArgb(26, 150, 44);
            btnSave.BackgroundColor = Color.FromArgb(26, 150, 44);
            btnSave.BorderColor = Color.White;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(638, 255);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 38);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.WhiteSmoke;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox5.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 41;
            iconPictureBox5.Location = new Point(984, 194);
            iconPictureBox5.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(47, 41);
            iconPictureBox5.TabIndex = 47;
            iconPictureBox5.TabStop = false;
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
            cbTrip.Location = new Point(579, 129);
            cbTrip.Margin = new Padding(3, 2, 3, 2);
            cbTrip.MinimumSize = new Size(175, 22);
            cbTrip.Name = "cbTrip";
            cbTrip.Size = new Size(335, 40);
            cbTrip.TabIndex = 48;
            cbTrip.Texts = "Trip";
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.Anchor = AnchorStyles.Top;
            iconPictureBox7.BackColor = Color.Transparent;
            iconPictureBox7.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Route;
            iconPictureBox7.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 41;
            iconPictureBox7.Location = new Point(527, 128);
            iconPictureBox7.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(47, 41);
            iconPictureBox7.TabIndex = 49;
            iconPictureBox7.TabStop = false;
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
            cbStatus.Location = new Point(139, 201);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.MinimumSize = new Size(175, 22);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(271, 40);
            cbStatus.TabIndex = 50;
            cbStatus.Texts = "Status";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(rbNational);
            panel2.Controls.Add(rbInternational);
            panel2.Location = new Point(513, 35);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 69);
            panel2.TabIndex = 51;
            // 
            // rbNational
            // 
            rbNational.AutoSize = true;
            rbNational.Checked = true;
            rbNational.CheckedColor = Color.MediumSlateBlue;
            rbNational.Font = new Font("Segoe UI", 20F);
            rbNational.ForeColor = Color.DarkGray;
            rbNational.Location = new Point(215, 16);
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
            rbInternational.Location = new Point(3, 16);
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
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(601, -2);
            label8.Name = "label8";
            label8.Size = new Size(149, 37);
            label8.TabIndex = 52;
            label8.Text = "Travel Type";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top;
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox2.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 41;
            iconPictureBox2.Location = new Point(527, 201);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(47, 41);
            iconPictureBox2.TabIndex = 57;
            iconPictureBox2.TabStop = false;
            // 
            // dtpTravelDate
            // 
            dtpTravelDate.Anchor = AnchorStyles.Top;
            dtpTravelDate.BorderColor = Color.DarkSlateBlue;
            dtpTravelDate.BorderSize = 0;
            dtpTravelDate.Font = new Font("Segoe UI", 15F);
            dtpTravelDate.Format = DateTimePickerFormat.Short;
            dtpTravelDate.Location = new Point(579, 205);
            dtpTravelDate.Margin = new Padding(3, 2, 3, 2);
            dtpTravelDate.MinimumSize = new Size(4, 35);
            dtpTravelDate.Name = "dtpTravelDate";
            dtpTravelDate.Size = new Size(336, 35);
            dtpTravelDate.SkinColor = Color.LightSlateGray;
            dtpTravelDate.TabIndex = 58;
            dtpTravelDate.TextColor = Color.White;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.ChessBishop;
            iconPictureBox4.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 41;
            iconPictureBox4.Location = new Point(87, 128);
            iconPictureBox4.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(47, 41);
            iconPictureBox4.TabIndex = 59;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Transparent;
            iconPictureBox6.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingLuggage;
            iconPictureBox6.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 41;
            iconPictureBox6.Location = new Point(87, 201);
            iconPictureBox6.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(47, 41);
            iconPictureBox6.TabIndex = 60;
            iconPictureBox6.TabStop = false;
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
            txtPhoneNumber.Location = new Point(1036, 123);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Multiline = false;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Padding = new Padding(6, 5, 6, 5);
            txtPhoneNumber.PasswordChar = false;
            txtPhoneNumber.Size = new Size(271, 46);
            txtPhoneNumber.TabIndex = 69;
            txtPhoneNumber.Texts = "Phone Number";
            txtPhoneNumber.UnderlinedStyle = true;
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
            iconPictureBox9.Location = new Point(984, 128);
            iconPictureBox9.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(47, 41);
            iconPictureBox9.TabIndex = 70;
            iconPictureBox9.TabStop = false;
            // 
            // txtAdult
            // 
            txtAdult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAdult.BackColor = Color.FromArgb(64, 64, 64);
            txtAdult.BorderStyle = BorderStyle.None;
            txtAdult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdult.ForeColor = Color.LightGray;
            txtAdult.Location = new Point(1036, 197);
            txtAdult.Margin = new Padding(3, 2, 3, 2);
            txtAdult.Name = "txtAdult";
            txtAdult.Size = new Size(52, 39);
            txtAdult.TabIndex = 74;
            txtAdult.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pnlAddUser
            // 
            pnlAddUser.BackColor = Color.FromArgb(35, 40, 50);
            pnlAddUser.Controls.Add(iconPictureBox1);
            pnlAddUser.Controls.Add(cbPaymentMethod);
            pnlAddUser.Controls.Add(label2);
            pnlAddUser.Controls.Add(iconPictureBox11);
            pnlAddUser.Controls.Add(iconPictureBox10);
            pnlAddUser.Controls.Add(txtDisabledPerson);
            pnlAddUser.Controls.Add(txtChild);
            pnlAddUser.Controls.Add(txtAdult);
            pnlAddUser.Controls.Add(iconPictureBox9);
            pnlAddUser.Controls.Add(txtPhoneNumber);
            pnlAddUser.Controls.Add(iconPictureBox6);
            pnlAddUser.Controls.Add(iconPictureBox4);
            pnlAddUser.Controls.Add(dtpTravelDate);
            pnlAddUser.Controls.Add(iconPictureBox2);
            pnlAddUser.Controls.Add(label8);
            pnlAddUser.Controls.Add(panel2);
            pnlAddUser.Controls.Add(cbStatus);
            pnlAddUser.Controls.Add(iconPictureBox7);
            pnlAddUser.Controls.Add(cbTrip);
            pnlAddUser.Controls.Add(iconPictureBox5);
            pnlAddUser.Controls.Add(btnSave);
            pnlAddUser.Controls.Add(cbClass);
            pnlAddUser.Controls.Add(label1);
            pnlAddUser.Dock = DockStyle.Top;
            pnlAddUser.Location = new Point(0, 0);
            pnlAddUser.Margin = new Padding(3, 2, 3, 2);
            pnlAddUser.Name = "pnlAddUser";
            pnlAddUser.Size = new Size(1449, 306);
            pnlAddUser.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            iconPictureBox1.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 41;
            iconPictureBox1.Location = new Point(984, 51);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(47, 41);
            iconPictureBox1.TabIndex = 81;
            iconPictureBox1.TabStop = false;
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
            cbPaymentMethod.Location = new Point(1036, 52);
            cbPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            cbPaymentMethod.MinimumSize = new Size(175, 22);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(286, 40);
            cbPaymentMethod.TabIndex = 80;
            cbPaymentMethod.Texts = "Payment Method";
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
            iconPictureBox11.Location = new Point(1207, 194);
            iconPictureBox11.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox11.Name = "iconPictureBox11";
            iconPictureBox11.Size = new Size(47, 41);
            iconPictureBox11.TabIndex = 78;
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
            iconPictureBox10.Location = new Point(1096, 194);
            iconPictureBox10.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox10.Name = "iconPictureBox10";
            iconPictureBox10.Size = new Size(47, 41);
            iconPictureBox10.TabIndex = 77;
            iconPictureBox10.TabStop = false;
            // 
            // txtDisabledPerson
            // 
            txtDisabledPerson.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDisabledPerson.BackColor = Color.FromArgb(64, 64, 64);
            txtDisabledPerson.BorderStyle = BorderStyle.None;
            txtDisabledPerson.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisabledPerson.ForeColor = Color.LightGray;
            txtDisabledPerson.Location = new Point(1259, 197);
            txtDisabledPerson.Margin = new Padding(3, 2, 3, 2);
            txtDisabledPerson.Name = "txtDisabledPerson";
            txtDisabledPerson.Size = new Size(52, 39);
            txtDisabledPerson.TabIndex = 76;
            // 
            // txtChild
            // 
            txtChild.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtChild.BackColor = Color.FromArgb(64, 64, 64);
            txtChild.BorderStyle = BorderStyle.None;
            txtChild.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChild.ForeColor = Color.LightGray;
            txtChild.Location = new Point(1149, 197);
            txtChild.Margin = new Padding(3, 2, 3, 2);
            txtChild.Name = "txtChild";
            txtChild.Size = new Size(52, 39);
            txtChild.TabIndex = 75;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlPersonInfoBooking);
            Controls.Add(pnlAddUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBookings";
            Text = "frmBookings";
            Load += frmBookings_Load;
            pnlPersonInfoBooking.ResumeLayout(false);
            pnlSaveAndClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdult).EndInit();
            pnlAddUser.ResumeLayout(false);
            pnlAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDisabledPerson).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPersonInfoBooking;
        private Label label1;
        private Custom_Controls.CustomComboBox cbClass;
        private Custom_Controls.CustomButton btnSave;
        private Custom_Controls.CustomButton btnClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Custom_Controls.CustomComboBox cbTrip;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Custom_Controls.CustomComboBox cbStatus;
        private Panel panel2;
        private Custom_Controls.CustomRadioButton rbNational;
        private Custom_Controls.CustomRadioButton rbInternational;
        private Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Custom_Controls.CustomDateTimePicker dtpTravelDate;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        public Custom_Controls.CustomTextBox txtPhoneNumber;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private NumericUpDown txtAdult;
        private Panel pnlAddUser;
        private NumericUpDown txtChild;
        private NumericUpDown txtDisabledPerson;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox10;
        private Label label2;
        private ErrorProvider errorProvider1;
        private Panel pnlPassengers;
        private Panel pnlSaveAndClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Custom_Controls.CustomComboBox cbPaymentMethod;
        private Custom_Controls.CustomButton btnTicketsInfoSave;
    }
}