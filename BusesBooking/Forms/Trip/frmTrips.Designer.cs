namespace AdminBusesBooking.Forms.Trip
{
    partial class frmTrips
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
            pnlUserListAndInfo = new Panel();
            pnlUserLIst = new Panel();
            dgvTripsList = new DataGridView();
            pnlUserListTitle = new Panel();
            label2 = new Label();
            pnlUserInfo = new Panel();
            lblTripDate = new Label();
            label10 = new Label();
            lblRoute = new Label();
            l = new Label();
            lblClass = new Label();
            label15 = new Label();
            lblUserID = new Label();
            label12 = new Label();
            lblPrice = new Label();
            CityTo = new Label();
            lblAvailableSeat = new Label();
            label16 = new Label();
            lblArrivalTime = new Label();
            label14 = new Label();
            lblDepartureTime = new Label();
            word = new Label();
            lblBus = new Label();
            label7 = new Label();
            lblStatus = new Label();
            lblTripType = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pnlAddUser = new Panel();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            txtPrice = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            cbClass = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            label11 = new Label();
            DepartureTime = new MaskedTextBox();
            ArrivalTime = new MaskedTextBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            dtpTripDate = new AdminBusesBooking.Custom_Controls.CustomDateTimePicker();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label9 = new Label();
            label6 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            panel2 = new Panel();
            rbNational = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            rbInternational = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            cbBuses = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            cbRoutes = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            btnClose = new AdminBusesBooking.Custom_Controls.CustomButton();
            btnSave = new AdminBusesBooking.Custom_Controls.CustomButton();
            cbStatus = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            errorProvider1 = new ErrorProvider(components);
            pnlUserListAndInfo.SuspendLayout();
            pnlUserLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTripsList).BeginInit();
            pnlUserListTitle.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            panel1.SuspendLayout();
            pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlUserListAndInfo
            // 
            pnlUserListAndInfo.Controls.Add(pnlUserLIst);
            pnlUserListAndInfo.Controls.Add(pnlUserInfo);
            pnlUserListAndInfo.Dock = DockStyle.Fill;
            pnlUserListAndInfo.Location = new Point(0, 356);
            pnlUserListAndInfo.Margin = new Padding(3, 2, 3, 2);
            pnlUserListAndInfo.Name = "pnlUserListAndInfo";
            pnlUserListAndInfo.Size = new Size(1449, 419);
            pnlUserListAndInfo.TabIndex = 11;
            // 
            // pnlUserLIst
            // 
            pnlUserLIst.Controls.Add(dgvTripsList);
            pnlUserLIst.Controls.Add(pnlUserListTitle);
            pnlUserLIst.Dock = DockStyle.Fill;
            pnlUserLIst.Location = new Point(0, 0);
            pnlUserLIst.Margin = new Padding(3, 2, 3, 2);
            pnlUserLIst.Name = "pnlUserLIst";
            pnlUserLIst.Size = new Size(1142, 419);
            pnlUserLIst.TabIndex = 1;
            // 
            // dgvTripsList
            // 
            dgvTripsList.AllowUserToAddRows = false;
            dgvTripsList.AllowUserToDeleteRows = false;
            dgvTripsList.AllowUserToOrderColumns = true;
            dgvTripsList.BackgroundColor = Color.FromArgb(35, 40, 50);
            dgvTripsList.BorderStyle = BorderStyle.None;
            dgvTripsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTripsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTripsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTripsList.Dock = DockStyle.Fill;
            dgvTripsList.Location = new Point(0, 59);
            dgvTripsList.Margin = new Padding(3, 2, 3, 2);
            dgvTripsList.Name = "dgvTripsList";
            dgvTripsList.ReadOnly = true;
            dgvTripsList.RowHeadersWidth = 51;
            dgvTripsList.Size = new Size(1142, 360);
            dgvTripsList.TabIndex = 1;
            dgvTripsList.DataBindingComplete += dgvTripsList_DataBindingComplete;
            // 
            // pnlUserListTitle
            // 
            pnlUserListTitle.BackColor = Color.FromArgb(35, 40, 50);
            pnlUserListTitle.Controls.Add(label2);
            pnlUserListTitle.Dock = DockStyle.Top;
            pnlUserListTitle.Location = new Point(0, 0);
            pnlUserListTitle.Margin = new Padding(3, 2, 3, 2);
            pnlUserListTitle.Name = "pnlUserListTitle";
            pnlUserListTitle.Size = new Size(1142, 59);
            pnlUserListTitle.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 1;
            label2.Text = "Trips List";
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlUserInfo.Controls.Add(lblTripDate);
            pnlUserInfo.Controls.Add(label10);
            pnlUserInfo.Controls.Add(lblRoute);
            pnlUserInfo.Controls.Add(l);
            pnlUserInfo.Controls.Add(lblClass);
            pnlUserInfo.Controls.Add(label15);
            pnlUserInfo.Controls.Add(lblUserID);
            pnlUserInfo.Controls.Add(label12);
            pnlUserInfo.Controls.Add(lblPrice);
            pnlUserInfo.Controls.Add(CityTo);
            pnlUserInfo.Controls.Add(lblAvailableSeat);
            pnlUserInfo.Controls.Add(label16);
            pnlUserInfo.Controls.Add(lblArrivalTime);
            pnlUserInfo.Controls.Add(label14);
            pnlUserInfo.Controls.Add(lblDepartureTime);
            pnlUserInfo.Controls.Add(word);
            pnlUserInfo.Controls.Add(lblBus);
            pnlUserInfo.Controls.Add(label7);
            pnlUserInfo.Controls.Add(lblStatus);
            pnlUserInfo.Controls.Add(lblTripType);
            pnlUserInfo.Controls.Add(label5);
            pnlUserInfo.Controls.Add(label4);
            pnlUserInfo.Controls.Add(panel1);
            pnlUserInfo.Dock = DockStyle.Right;
            pnlUserInfo.Location = new Point(1142, 0);
            pnlUserInfo.Margin = new Padding(3, 2, 3, 2);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(307, 419);
            pnlUserInfo.TabIndex = 0;
            pnlUserInfo.Visible = false;
            // 
            // lblTripDate
            // 
            lblTripDate.AutoSize = true;
            lblTripDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTripDate.ForeColor = Color.DarkGray;
            lblTripDate.Location = new Point(100, 147);
            lblTripDate.Name = "lblTripDate";
            lblTripDate.Size = new Size(16, 21);
            lblTripDate.TabIndex = 48;
            lblTripDate.Text = "..";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(9, 147);
            label10.Name = "label10";
            label10.Size = new Size(79, 21);
            label10.TabIndex = 47;
            label10.Text = "Trip Date :";
            // 
            // lblRoute
            // 
            lblRoute.AllowDrop = true;
            lblRoute.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoute.ForeColor = Color.DarkGray;
            lblRoute.Location = new Point(162, 188);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(135, 61);
            lblRoute.TabIndex = 46;
            lblRoute.Text = "..";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l.ForeColor = Color.DarkGray;
            l.Location = new Point(9, 188);
            l.Name = "l";
            l.Size = new Size(136, 21);
            l.TabIndex = 45;
            l.Text = "Route / TripName:";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClass.ForeColor = Color.DarkGray;
            lblClass.Location = new Point(245, 108);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(16, 21);
            lblClass.TabIndex = 42;
            lblClass.Text = "..";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkGray;
            label15.Location = new Point(184, 108);
            label15.Name = "label15";
            label15.Size = new Size(53, 21);
            label15.TabIndex = 41;
            label15.Text = "Class :";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.DarkGray;
            lblUserID.Location = new Point(255, 68);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(16, 21);
            lblUserID.TabIndex = 40;
            lblUserID.Text = "..";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkGray;
            label12.Location = new Point(180, 68);
            label12.Name = "label12";
            label12.Size = new Size(64, 21);
            label12.TabIndex = 39;
            label12.Text = "UserID :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.DarkGray;
            lblPrice.Location = new Point(150, 346);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(16, 21);
            lblPrice.TabIndex = 38;
            lblPrice.Text = "..";
            // 
            // CityTo
            // 
            CityTo.AutoSize = true;
            CityTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CityTo.ForeColor = Color.DarkGray;
            CityTo.Location = new Point(9, 346);
            CityTo.Name = "CityTo";
            CityTo.Size = new Size(51, 21);
            CityTo.TabIndex = 37;
            CityTo.Text = "Price :";
            // 
            // lblAvailableSeat
            // 
            lblAvailableSeat.AutoSize = true;
            lblAvailableSeat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableSeat.ForeColor = Color.DarkGray;
            lblAvailableSeat.Location = new Point(150, 386);
            lblAvailableSeat.Name = "lblAvailableSeat";
            lblAvailableSeat.Size = new Size(16, 21);
            lblAvailableSeat.TabIndex = 36;
            lblAvailableSeat.Text = "..";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DarkGray;
            label16.Location = new Point(9, 386);
            label16.Name = "label16";
            label16.Size = new Size(114, 21);
            label16.TabIndex = 35;
            label16.Text = "Available Seat :";
            // 
            // lblArrivalTime
            // 
            lblArrivalTime.AutoSize = true;
            lblArrivalTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArrivalTime.ForeColor = Color.DarkGray;
            lblArrivalTime.Location = new Point(150, 307);
            lblArrivalTime.Name = "lblArrivalTime";
            lblArrivalTime.Size = new Size(16, 21);
            lblArrivalTime.TabIndex = 34;
            lblArrivalTime.Text = "..";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DarkGray;
            label14.Location = new Point(8, 307);
            label14.Name = "label14";
            label14.Size = new Size(101, 21);
            label14.TabIndex = 33;
            label14.Text = "Arrival Time :";
            // 
            // lblDepartureTime
            // 
            lblDepartureTime.AutoSize = true;
            lblDepartureTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartureTime.ForeColor = Color.DarkGray;
            lblDepartureTime.Location = new Point(150, 267);
            lblDepartureTime.Name = "lblDepartureTime";
            lblDepartureTime.Size = new Size(16, 21);
            lblDepartureTime.TabIndex = 32;
            lblDepartureTime.Text = "..";
            // 
            // word
            // 
            word.AutoSize = true;
            word.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            word.ForeColor = Color.DarkGray;
            word.Location = new Point(8, 267);
            word.Name = "word";
            word.Size = new Size(125, 21);
            word.TabIndex = 31;
            word.Text = "Departure Time :";
            // 
            // lblBus
            // 
            lblBus.AutoSize = true;
            lblBus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBus.ForeColor = Color.DarkGray;
            lblBus.Location = new Point(66, 227);
            lblBus.Name = "lblBus";
            lblBus.Size = new Size(16, 21);
            lblBus.TabIndex = 28;
            lblBus.Text = "..";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(9, 227);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 27;
            label7.Text = "Bus :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkGray;
            lblStatus.Location = new Point(100, 108);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 21);
            lblStatus.TabIndex = 25;
            lblStatus.Text = "..";
            // 
            // lblTripType
            // 
            lblTripType.AutoSize = true;
            lblTripType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTripType.ForeColor = Color.DarkGray;
            lblTripType.Location = new Point(100, 68);
            lblTripType.Name = "lblTripType";
            lblTripType.Size = new Size(16, 21);
            lblTripType.TabIndex = 24;
            lblTripType.Text = "..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(9, 108);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 22;
            label5.Text = "Status :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(8, 68);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 21;
            label4.Text = "Trip Type :";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 59);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 1;
            label3.Text = "Trip Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(105, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Trip";
            // 
            // pnlAddUser
            // 
            pnlAddUser.BackColor = Color.FromArgb(35, 40, 50);
            pnlAddUser.Controls.Add(iconPictureBox5);
            pnlAddUser.Controls.Add(txtPrice);
            pnlAddUser.Controls.Add(iconPictureBox9);
            pnlAddUser.Controls.Add(cbClass);
            pnlAddUser.Controls.Add(label11);
            pnlAddUser.Controls.Add(DepartureTime);
            pnlAddUser.Controls.Add(ArrivalTime);
            pnlAddUser.Controls.Add(iconPictureBox6);
            pnlAddUser.Controls.Add(iconPictureBox4);
            pnlAddUser.Controls.Add(dtpTripDate);
            pnlAddUser.Controls.Add(iconPictureBox2);
            pnlAddUser.Controls.Add(label9);
            pnlAddUser.Controls.Add(label6);
            pnlAddUser.Controls.Add(iconPictureBox1);
            pnlAddUser.Controls.Add(label8);
            pnlAddUser.Controls.Add(panel2);
            pnlAddUser.Controls.Add(cbBuses);
            pnlAddUser.Controls.Add(iconPictureBox7);
            pnlAddUser.Controls.Add(cbRoutes);
            pnlAddUser.Controls.Add(btnClose);
            pnlAddUser.Controls.Add(btnSave);
            pnlAddUser.Controls.Add(cbStatus);
            pnlAddUser.Controls.Add(iconPictureBox3);
            pnlAddUser.Controls.Add(label1);
            pnlAddUser.Dock = DockStyle.Top;
            pnlAddUser.Location = new Point(0, 0);
            pnlAddUser.Margin = new Padding(3, 2, 3, 2);
            pnlAddUser.Name = "pnlAddUser";
            pnlAddUser.Size = new Size(1449, 356);
            pnlAddUser.TabIndex = 10;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            iconPictureBox5.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 41;
            iconPictureBox5.Location = new Point(934, 217);
            iconPictureBox5.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(47, 41);
            iconPictureBox5.TabIndex = 74;
            iconPictureBox5.TabStop = false;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrice.BackColor = Color.FromArgb(35, 40, 50);
            txtPrice.BorderColor = Color.Gray;
            txtPrice.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtPrice.BorderSize = 5;
            txtPrice.Font = new Font("Segoe UI", 20F);
            txtPrice.ForeColor = Color.DarkGray;
            txtPrice.Location = new Point(990, 212);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Multiline = false;
            txtPrice.Name = "txtPrice";
            txtPrice.Padding = new Padding(6, 5, 6, 5);
            txtPrice.PasswordChar = false;
            txtPrice.Size = new Size(271, 46);
            txtPrice.TabIndex = 73;
            txtPrice.Texts = "0";
            txtPrice.UnderlinedStyle = true;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.Anchor = AnchorStyles.Top;
            iconPictureBox9.BackColor = Color.Transparent;
            iconPictureBox9.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Chess;
            iconPictureBox9.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 41;
            iconPictureBox9.Location = new Point(527, 217);
            iconPictureBox9.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(47, 41);
            iconPictureBox9.TabIndex = 72;
            iconPictureBox9.TabStop = false;
            // 
            // cbClass
            // 
            cbClass.Anchor = AnchorStyles.Top;
            cbClass.BackColor = Color.DarkSlateBlue;
            cbClass.BorderColor = Color.White;
            cbClass.BorderSize = 0;
            cbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClass.Font = new Font("Segoe UI", 20F);
            cbClass.ForeColor = Color.Silver;
            cbClass.IconColor = Color.Gainsboro;
            cbClass.Items.AddRange(new object[] { "Vip", "Normal", "Small" });
            cbClass.ListBackColor = Color.FromArgb(230, 228, 245);
            cbClass.ListTextColor = Color.DimGray;
            cbClass.Location = new Point(579, 218);
            cbClass.Margin = new Padding(3, 2, 3, 2);
            cbClass.MinimumSize = new Size(175, 22);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(271, 40);
            cbClass.TabIndex = 71;
            cbClass.Texts = "Class";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDark;
            label11.Location = new Point(639, 32);
            label11.Name = "label11";
            label11.Size = new Size(124, 37);
            label11.TabIndex = 70;
            label11.Text = "Trip Date";
            // 
            // DepartureTime
            // 
            DepartureTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DepartureTime.BackColor = Color.LightSlateGray;
            DepartureTime.BorderStyle = BorderStyle.None;
            DepartureTime.Font = new Font("Segoe UI", 20F);
            DepartureTime.ForeColor = Color.FromArgb(224, 224, 224);
            DepartureTime.Location = new Point(987, 68);
            DepartureTime.Margin = new Padding(3, 2, 3, 2);
            DepartureTime.Mask = "00:00";
            DepartureTime.Name = "DepartureTime";
            DepartureTime.Size = new Size(274, 36);
            DepartureTime.TabIndex = 63;
            DepartureTime.TextAlign = HorizontalAlignment.Center;
            DepartureTime.ValidatingType = typeof(DateTime);
            // 
            // ArrivalTime
            // 
            ArrivalTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ArrivalTime.BackColor = Color.LightSlateGray;
            ArrivalTime.BorderStyle = BorderStyle.None;
            ArrivalTime.Font = new Font("Segoe UI", 20F);
            ArrivalTime.ForeColor = Color.FromArgb(224, 224, 224);
            ArrivalTime.Location = new Point(987, 148);
            ArrivalTime.Margin = new Padding(3, 2, 3, 2);
            ArrivalTime.Mask = "00:00";
            ArrivalTime.Name = "ArrivalTime";
            ArrivalTime.Size = new Size(274, 36);
            ArrivalTime.TabIndex = 62;
            ArrivalTime.TextAlign = HorizontalAlignment.Center;
            ArrivalTime.ValidatingType = typeof(DateTime);
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Transparent;
            iconPictureBox6.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.BusSimple;
            iconPictureBox6.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 41;
            iconPictureBox6.Location = new Point(100, 217);
            iconPictureBox6.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(47, 41);
            iconPictureBox6.TabIndex = 60;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Info;
            iconPictureBox4.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 41;
            iconPictureBox4.Location = new Point(100, 143);
            iconPictureBox4.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(47, 41);
            iconPictureBox4.TabIndex = 59;
            iconPictureBox4.TabStop = false;
            // 
            // dtpTripDate
            // 
            dtpTripDate.Anchor = AnchorStyles.Top;
            dtpTripDate.BorderColor = Color.DarkSlateBlue;
            dtpTripDate.BorderSize = 0;
            dtpTripDate.Font = new Font("Segoe UI", 15F);
            dtpTripDate.Format = DateTimePickerFormat.Short;
            dtpTripDate.Location = new Point(579, 71);
            dtpTripDate.Margin = new Padding(3, 2, 3, 2);
            dtpTripDate.MinimumSize = new Size(4, 35);
            dtpTripDate.Name = "dtpTripDate";
            dtpTripDate.Size = new Size(272, 35);
            dtpTripDate.SkinColor = Color.LightSlateGray;
            dtpTripDate.TabIndex = 58;
            dtpTripDate.TextColor = Color.White;
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
            iconPictureBox2.Location = new Point(527, 65);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(47, 41);
            iconPictureBox2.TabIndex = 57;
            iconPictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(1033, 110);
            label9.Name = "label9";
            label9.Size = new Size(158, 37);
            label9.TabIndex = 56;
            label9.Text = "Arrival Time";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(1003, 32);
            label6.Name = "label6";
            label6.Size = new Size(201, 37);
            label6.TabIndex = 55;
            label6.Text = "Departure Time";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarMinus;
            iconPictureBox1.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 41;
            iconPictureBox1.Location = new Point(934, 143);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(47, 41);
            iconPictureBox1.TabIndex = 53;
            iconPictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(206, 32);
            label8.Name = "label8";
            label8.Size = new Size(124, 37);
            label8.TabIndex = 52;
            label8.Text = "Trip Type";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbNational);
            panel2.Controls.Add(rbInternational);
            panel2.Location = new Point(100, 56);
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
            rbNational.Location = new Point(215, 13);
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
            rbInternational.Location = new Point(3, 13);
            rbInternational.Margin = new Padding(3, 2, 3, 2);
            rbInternational.MinimumSize = new Size(0, 16);
            rbInternational.Name = "rbInternational";
            rbInternational.Padding = new Padding(9, 0, 0, 0);
            rbInternational.Size = new Size(195, 41);
            rbInternational.TabIndex = 31;
            rbInternational.Text = "International";
            rbInternational.UnCheckedColor = Color.Gray;
            rbInternational.UseVisualStyleBackColor = true;
            // 
            // cbBuses
            // 
            cbBuses.BackColor = Color.DarkSlateBlue;
            cbBuses.BorderColor = Color.White;
            cbBuses.BorderSize = 0;
            cbBuses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuses.Font = new Font("Segoe UI", 20F);
            cbBuses.ForeColor = Color.Silver;
            cbBuses.IconColor = Color.Gainsboro;
            cbBuses.ListBackColor = Color.FromArgb(230, 228, 245);
            cbBuses.ListTextColor = Color.DimGray;
            cbBuses.Location = new Point(152, 217);
            cbBuses.Margin = new Padding(3, 2, 3, 2);
            cbBuses.MinimumSize = new Size(175, 22);
            cbBuses.Name = "cbBuses";
            cbBuses.Size = new Size(271, 40);
            cbBuses.TabIndex = 50;
            cbBuses.Texts = "Bus";
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
            iconPictureBox7.Location = new Point(527, 143);
            iconPictureBox7.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(47, 41);
            iconPictureBox7.TabIndex = 49;
            iconPictureBox7.TabStop = false;
            // 
            // cbRoutes
            // 
            cbRoutes.Anchor = AnchorStyles.Top;
            cbRoutes.BackColor = Color.DarkSlateBlue;
            cbRoutes.BorderColor = Color.White;
            cbRoutes.BorderSize = 0;
            cbRoutes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoutes.Font = new Font("Segoe UI", 20F);
            cbRoutes.ForeColor = Color.Silver;
            cbRoutes.IconColor = Color.Gainsboro;
            cbRoutes.ListBackColor = Color.FromArgb(230, 228, 245);
            cbRoutes.ListTextColor = Color.DimGray;
            cbRoutes.Location = new Point(579, 145);
            cbRoutes.Margin = new Padding(3, 2, 3, 2);
            cbRoutes.MinimumSize = new Size(175, 22);
            cbRoutes.Name = "cbRoutes";
            cbRoutes.Size = new Size(271, 40);
            cbRoutes.TabIndex = 48;
            cbRoutes.Texts = "Route";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.BackgroundColor = Color.FromArgb(192, 0, 0);
            btnClose.BorderColor = Color.White;
            btnClose.BorderRadius = 20;
            btnClose.BorderSize = 0;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.WhiteSmoke;
            btnClose.Location = new Point(462, 300);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 38);
            btnClose.TabIndex = 44;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.WhiteSmoke;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(26, 150, 44);
            btnSave.BackgroundColor = Color.FromArgb(26, 150, 44);
            btnSave.BorderColor = Color.White;
            btnSave.BorderRadius = 20;
            btnSave.BorderSize = 0;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(749, 300);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 38);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.WhiteSmoke;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            cbStatus.Items.AddRange(new object[] { "On Going", "Stopped", "Break", "Done" });
            cbStatus.ListBackColor = Color.FromArgb(230, 228, 245);
            cbStatus.ListTextColor = Color.DimGray;
            cbStatus.Location = new Point(152, 145);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.MinimumSize = new Size(175, 22);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(271, 40);
            cbStatus.TabIndex = 42;
            cbStatus.Texts = "Status";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            iconPictureBox3.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 41;
            iconPictureBox3.Location = new Point(934, 65);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(47, 41);
            iconPictureBox3.TabIndex = 41;
            iconPictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlUserListAndInfo);
            Controls.Add(pnlAddUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTrips";
            Text = "frmTrips";
            Load += frmTrips_Load;
            pnlUserListAndInfo.ResumeLayout(false);
            pnlUserLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTripsList).EndInit();
            pnlUserListTitle.ResumeLayout(false);
            pnlUserListTitle.PerformLayout();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAddUser.ResumeLayout(false);
            pnlAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUserListAndInfo;
        private Panel pnlUserLIst;
        private DataGridView dgvTripsList;
        private Panel pnlUserListTitle;
        private Label label2;
        private Panel pnlUserInfo;
        private Label lblPrice;
        private Label CityTo;
        private Label lblArrivalTime;
        private Label label14;
        private Label lblDepartureTime;
        private Label word;
        private Label lblBus;
        private Label label7;
        private Label lblStatus;
        private Label lblTripType;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel pnlAddUser;
        private Custom_Controls.CustomDateTimePicker dtpTripDate;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label9;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label8;
        private Panel panel2;
        private Custom_Controls.CustomRadioButton rbNational;
        private Custom_Controls.CustomRadioButton rbInternational;
        private Custom_Controls.CustomComboBox cbBuses;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Custom_Controls.CustomComboBox cbRoutes;
        private Custom_Controls.CustomButton btnClose;
        private Custom_Controls.CustomButton btnSave;
        private Custom_Controls.CustomComboBox cbStatus;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label lblAvailableSeat;
        private Label label16;
        private Label lblUserID;
        private Label label12;
        private ErrorProvider errorProvider1;
        private MaskedTextBox ArrivalTime;
        private MaskedTextBox DepartureTime;
        private Label label11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private Custom_Controls.CustomComboBox cbClass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        public Custom_Controls.CustomTextBox txtPrice;
        private Label lblRoute;
        private Label l;
        private Label lblClass;
        private Label label15;
        private Label lblTripDate;
        private Label label10;
    }
}