namespace AdminBusesBooking.Forms.Routes
{
    partial class frmOriginalRoutes
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
            dgvRoutesList = new DataGridView();
            pnlUserListTitle = new Panel();
            label2 = new Label();
            pnlUserInfo = new Panel();
            lblRouteName = new Label();
            label6 = new Label();
            lblCityTo = new Label();
            panel1 = new Panel();
            label3 = new Label();
            CityTo = new Label();
            label4 = new Label();
            lblRouteType = new Label();
            label5 = new Label();
            lblCityFrom = new Label();
            label10 = new Label();
            label14 = new Label();
            lblCountryFrom = new Label();
            lblDistanceKm = new Label();
            lblPrice = new Label();
            lblCountryTo = new Label();
            word = new Label();
            label7 = new Label();
            label1 = new Label();
            txtDistanceKm = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            cbCountryFrom = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            btnSave = new AdminBusesBooking.Custom_Controls.CustomButton();
            btnClose = new AdminBusesBooking.Custom_Controls.CustomButton();
            txtPrice = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            cbCountryTo = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            cbCityFrom = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            cbCityTo = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            panel2 = new Panel();
            rbNational = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            rbInternational = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            label8 = new Label();
            pnlAddUser = new Panel();
            errorProvider1 = new ErrorProvider(components);
            pnlUserListAndInfo.SuspendLayout();
            pnlUserLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoutesList).BeginInit();
            pnlUserListTitle.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            panel2.SuspendLayout();
            pnlAddUser.SuspendLayout();
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
            pnlUserListAndInfo.Size = new Size(1433, 384);
            pnlUserListAndInfo.TabIndex = 9;
            // 
            // pnlUserLIst
            // 
            pnlUserLIst.Controls.Add(dgvRoutesList);
            pnlUserLIst.Controls.Add(pnlUserListTitle);
            pnlUserLIst.Dock = DockStyle.Fill;
            pnlUserLIst.Location = new Point(0, 0);
            pnlUserLIst.Margin = new Padding(3, 2, 3, 2);
            pnlUserLIst.Name = "pnlUserLIst";
            pnlUserLIst.Size = new Size(1054, 384);
            pnlUserLIst.TabIndex = 1;
            // 
            // dgvRoutesList
            // 
            dgvRoutesList.AllowUserToAddRows = false;
            dgvRoutesList.AllowUserToDeleteRows = false;
            dgvRoutesList.AllowUserToOrderColumns = true;
            dgvRoutesList.BackgroundColor = Color.FromArgb(35, 40, 50);
            dgvRoutesList.BorderStyle = BorderStyle.None;
            dgvRoutesList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvRoutesList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvRoutesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoutesList.Dock = DockStyle.Fill;
            dgvRoutesList.Location = new Point(0, 59);
            dgvRoutesList.Margin = new Padding(3, 2, 3, 2);
            dgvRoutesList.Name = "dgvRoutesList";
            dgvRoutesList.ReadOnly = true;
            dgvRoutesList.RowHeadersWidth = 51;
            dgvRoutesList.Size = new Size(1054, 325);
            dgvRoutesList.TabIndex = 1;
            dgvRoutesList.DataBindingComplete += dgvRoutesList_DataBindingComplete;
            // 
            // pnlUserListTitle
            // 
            pnlUserListTitle.BackColor = Color.FromArgb(35, 40, 50);
            pnlUserListTitle.Controls.Add(label2);
            pnlUserListTitle.Dock = DockStyle.Top;
            pnlUserListTitle.Location = new Point(0, 0);
            pnlUserListTitle.Margin = new Padding(3, 2, 3, 2);
            pnlUserListTitle.Name = "pnlUserListTitle";
            pnlUserListTitle.Size = new Size(1054, 59);
            pnlUserListTitle.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 1;
            label2.Text = "Routes List";
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlUserInfo.Controls.Add(lblRouteName);
            pnlUserInfo.Controls.Add(label6);
            pnlUserInfo.Controls.Add(lblCityTo);
            pnlUserInfo.Controls.Add(panel1);
            pnlUserInfo.Controls.Add(CityTo);
            pnlUserInfo.Controls.Add(label4);
            pnlUserInfo.Controls.Add(lblRouteType);
            pnlUserInfo.Controls.Add(label5);
            pnlUserInfo.Controls.Add(lblCityFrom);
            pnlUserInfo.Controls.Add(label10);
            pnlUserInfo.Controls.Add(label14);
            pnlUserInfo.Controls.Add(lblCountryFrom);
            pnlUserInfo.Controls.Add(lblDistanceKm);
            pnlUserInfo.Controls.Add(lblPrice);
            pnlUserInfo.Controls.Add(lblCountryTo);
            pnlUserInfo.Controls.Add(word);
            pnlUserInfo.Controls.Add(label7);
            pnlUserInfo.Dock = DockStyle.Right;
            pnlUserInfo.Location = new Point(1054, 0);
            pnlUserInfo.Margin = new Padding(3, 2, 3, 2);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(379, 384);
            pnlUserInfo.TabIndex = 0;
            pnlUserInfo.Visible = false;
            // 
            // lblRouteName
            // 
            lblRouteName.AutoSize = true;
            lblRouteName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRouteName.ForeColor = Color.DarkGray;
            lblRouteName.Location = new Point(133, 176);
            lblRouteName.Name = "lblRouteName";
            lblRouteName.Size = new Size(16, 21);
            lblRouteName.TabIndex = 40;
            lblRouteName.Text = "..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(5, 176);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 39;
            label6.Text = "Route Name :";
            // 
            // lblCityTo
            // 
            lblCityTo.AutoSize = true;
            lblCityTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCityTo.ForeColor = Color.DarkGray;
            lblCityTo.Location = new Point(134, 358);
            lblCityTo.Name = "lblCityTo";
            lblCityTo.Size = new Size(16, 21);
            lblCityTo.TabIndex = 38;
            lblCityTo.Text = "..";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 59);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 1;
            label3.Text = "Route Info";
            // 
            // CityTo
            // 
            CityTo.AutoSize = true;
            CityTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CityTo.ForeColor = Color.DarkGray;
            CityTo.Location = new Point(5, 358);
            CityTo.Name = "CityTo";
            CityTo.Size = new Size(59, 21);
            CityTo.TabIndex = 37;
            CityTo.Text = "CityTo :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(5, 83);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 21;
            label4.Text = "Route Type :";
            // 
            // lblRouteType
            // 
            lblRouteType.AutoSize = true;
            lblRouteType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRouteType.ForeColor = Color.DarkGray;
            lblRouteType.Location = new Point(134, 83);
            lblRouteType.Name = "lblRouteType";
            lblRouteType.Size = new Size(16, 21);
            lblRouteType.TabIndex = 24;
            lblRouteType.Text = "..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(5, 132);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 22;
            label5.Text = "Distance Km :";
            // 
            // lblCityFrom
            // 
            lblCityFrom.AutoSize = true;
            lblCityFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCityFrom.ForeColor = Color.DarkGray;
            lblCityFrom.Location = new Point(133, 314);
            lblCityFrom.Name = "lblCityFrom";
            lblCityFrom.Size = new Size(16, 21);
            lblCityFrom.TabIndex = 34;
            lblCityFrom.Text = "..";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(9, 222);
            label10.Name = "label10";
            label10.Size = new Size(110, 21);
            label10.TabIndex = 29;
            label10.Text = "CountryFrom :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DarkGray;
            label14.Location = new Point(4, 314);
            label14.Name = "label14";
            label14.Size = new Size(81, 21);
            label14.TabIndex = 33;
            label14.Text = "CityFrom :";
            // 
            // lblCountryFrom
            // 
            lblCountryFrom.AutoSize = true;
            lblCountryFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountryFrom.ForeColor = Color.DarkGray;
            lblCountryFrom.Location = new Point(134, 222);
            lblCountryFrom.Name = "lblCountryFrom";
            lblCountryFrom.Size = new Size(16, 21);
            lblCountryFrom.TabIndex = 30;
            lblCountryFrom.Text = "..";
            // 
            // lblDistanceKm
            // 
            lblDistanceKm.AutoSize = true;
            lblDistanceKm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistanceKm.ForeColor = Color.DarkGray;
            lblDistanceKm.Location = new Point(134, 130);
            lblDistanceKm.Name = "lblDistanceKm";
            lblDistanceKm.Size = new Size(16, 21);
            lblDistanceKm.TabIndex = 25;
            lblDistanceKm.Text = "..";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.DarkGray;
            lblPrice.Location = new Point(308, 83);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(16, 21);
            lblPrice.TabIndex = 28;
            lblPrice.Text = "..";
            // 
            // lblCountryTo
            // 
            lblCountryTo.AutoSize = true;
            lblCountryTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountryTo.ForeColor = Color.DarkGray;
            lblCountryTo.Location = new Point(133, 266);
            lblCountryTo.Name = "lblCountryTo";
            lblCountryTo.Size = new Size(16, 21);
            lblCountryTo.TabIndex = 32;
            lblCountryTo.Text = "..";
            // 
            // word
            // 
            word.AutoSize = true;
            word.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            word.ForeColor = Color.DarkGray;
            word.Location = new Point(4, 266);
            word.Name = "word";
            word.Size = new Size(88, 21);
            word.TabIndex = 31;
            word.Text = "CountryTo :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(248, 83);
            label7.Name = "label7";
            label7.Size = new Size(51, 21);
            label7.TabIndex = 27;
            label7.Text = "Price :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Route";
            // 
            // txtDistanceKm
            // 
            txtDistanceKm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDistanceKm.BackColor = Color.FromArgb(35, 40, 50);
            txtDistanceKm.BorderColor = Color.Gray;
            txtDistanceKm.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtDistanceKm.BorderSize = 5;
            txtDistanceKm.Font = new Font("Segoe UI", 20F);
            txtDistanceKm.ForeColor = Color.DarkGray;
            txtDistanceKm.Location = new Point(984, 142);
            txtDistanceKm.Margin = new Padding(3, 2, 3, 2);
            txtDistanceKm.Multiline = false;
            txtDistanceKm.Name = "txtDistanceKm";
            txtDistanceKm.Padding = new Padding(6, 5, 6, 5);
            txtDistanceKm.PasswordChar = false;
            txtDistanceKm.Size = new Size(271, 41);
            txtDistanceKm.TabIndex = 8;
            txtDistanceKm.Text = "Distance Km";
            txtDistanceKm.Texts = "Distance KM";
            txtDistanceKm.UnderlinedStyle = true;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Clapperboard;
            iconPictureBox1.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 41;
            iconPictureBox1.Location = new Point(931, 143);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(47, 41);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.EarthAfrica;
            iconPictureBox4.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 41;
            iconPictureBox4.Location = new Point(100, 143);
            iconPictureBox4.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(47, 41);
            iconPictureBox4.TabIndex = 14;
            iconPictureBox4.TabStop = false;
            // 
            // cbCountryFrom
            // 
            cbCountryFrom.BackColor = Color.DarkSlateBlue;
            cbCountryFrom.BorderColor = Color.White;
            cbCountryFrom.BorderSize = 0;
            cbCountryFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountryFrom.Font = new Font("Segoe UI", 20F);
            cbCountryFrom.ForeColor = Color.Silver;
            cbCountryFrom.IconColor = Color.Gainsboro;
            cbCountryFrom.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCountryFrom.ListTextColor = Color.DimGray;
            cbCountryFrom.Location = new Point(152, 145);
            cbCountryFrom.Margin = new Padding(3, 2, 3, 2);
            cbCountryFrom.MinimumSize = new Size(175, 22);
            cbCountryFrom.Name = "cbCountryFrom";
            cbCountryFrom.Size = new Size(271, 40);
            cbCountryFrom.TabIndex = 19;
            cbCountryFrom.Texts = "Start County";
            cbCountryFrom.OnSelectedIndexChanged += cbCountryFrom_OnSelectedIndexChanged;
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
            btnSave.Location = new Point(725, 292);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 38);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.WhiteSmoke;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
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
            btnClose.Location = new Point(438, 292);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(180, 38);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.TextColor = Color.WhiteSmoke;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            txtPrice.Location = new Point(984, 212);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Multiline = false;
            txtPrice.Name = "txtPrice";
            txtPrice.Padding = new Padding(6, 5, 6, 5);
            txtPrice.PasswordChar = false;
            txtPrice.Size = new Size(271, 46);
            txtPrice.TabIndex = 23;
            txtPrice.Text = "Price";
            txtPrice.Texts = "Price";
            txtPrice.UnderlinedStyle = true;
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
            iconPictureBox5.Location = new Point(931, 214);
            iconPictureBox5.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(47, 41);
            iconPictureBox5.TabIndex = 24;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Transparent;
            iconPictureBox6.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.City;
            iconPictureBox6.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 41;
            iconPictureBox6.Location = new Point(100, 214);
            iconPictureBox6.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(47, 41);
            iconPictureBox6.TabIndex = 25;
            iconPictureBox6.TabStop = false;
            // 
            // cbCountryTo
            // 
            cbCountryTo.Anchor = AnchorStyles.Top;
            cbCountryTo.BackColor = Color.DarkSlateBlue;
            cbCountryTo.BorderColor = Color.White;
            cbCountryTo.BorderSize = 0;
            cbCountryTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountryTo.Font = new Font("Segoe UI", 20F);
            cbCountryTo.ForeColor = Color.Silver;
            cbCountryTo.IconColor = Color.Gainsboro;
            cbCountryTo.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCountryTo.ListTextColor = Color.DimGray;
            cbCountryTo.Location = new Point(579, 146);
            cbCountryTo.Margin = new Padding(3, 2, 3, 2);
            cbCountryTo.MinimumSize = new Size(175, 22);
            cbCountryTo.Name = "cbCountryTo";
            cbCountryTo.Size = new Size(271, 40);
            cbCountryTo.TabIndex = 26;
            cbCountryTo.Texts = "Distant Country";
            cbCountryTo.OnSelectedIndexChanged += cbCountryTo_OnSelectedIndexChanged;
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
            iconPictureBox7.Location = new Point(527, 145);
            iconPictureBox7.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(47, 41);
            iconPictureBox7.TabIndex = 27;
            iconPictureBox7.TabStop = false;
            // 
            // cbCityFrom
            // 
            cbCityFrom.BackColor = Color.DarkSlateBlue;
            cbCityFrom.BorderColor = Color.White;
            cbCityFrom.BorderSize = 0;
            cbCityFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCityFrom.Font = new Font("Segoe UI", 20F);
            cbCityFrom.ForeColor = Color.Silver;
            cbCityFrom.IconColor = Color.Gainsboro;
            cbCityFrom.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCityFrom.ListTextColor = Color.DimGray;
            cbCityFrom.Location = new Point(152, 216);
            cbCityFrom.Margin = new Padding(3, 2, 3, 2);
            cbCityFrom.MinimumSize = new Size(175, 22);
            cbCityFrom.Name = "cbCityFrom";
            cbCityFrom.Size = new Size(271, 40);
            cbCityFrom.TabIndex = 28;
            cbCityFrom.Texts = "Start City";
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.Anchor = AnchorStyles.Top;
            iconPictureBox8.BackColor = Color.Transparent;
            iconPictureBox8.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.City;
            iconPictureBox8.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 41;
            iconPictureBox8.Location = new Point(527, 214);
            iconPictureBox8.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(47, 41);
            iconPictureBox8.TabIndex = 29;
            iconPictureBox8.TabStop = false;
            // 
            // cbCityTo
            // 
            cbCityTo.Anchor = AnchorStyles.Top;
            cbCityTo.BackColor = Color.DarkSlateBlue;
            cbCityTo.BorderColor = Color.White;
            cbCityTo.BorderSize = 0;
            cbCityTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCityTo.Font = new Font("Segoe UI", 20F);
            cbCityTo.ForeColor = Color.Silver;
            cbCityTo.IconColor = Color.Gainsboro;
            cbCityTo.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCityTo.ListTextColor = Color.DimGray;
            cbCityTo.Location = new Point(579, 216);
            cbCityTo.Margin = new Padding(3, 2, 3, 2);
            cbCityTo.MinimumSize = new Size(175, 22);
            cbCityTo.Name = "cbCityTo";
            cbCityTo.Size = new Size(271, 40);
            cbCityTo.TabIndex = 30;
            cbCityTo.Texts = "Distination City";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(rbNational);
            panel2.Controls.Add(rbInternational);
            panel2.Location = new Point(493, 57);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 69);
            panel2.TabIndex = 33;
            // 
            // rbNational
            // 
            rbNational.AutoSize = true;
            rbNational.Checked = true;
            rbNational.CheckedColor = Color.MediumSlateBlue;
            rbNational.Font = new Font("Segoe UI", 20F);
            rbNational.ForeColor = Color.DarkGray;
            rbNational.Location = new Point(239, 16);
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
            rbNational.CheckedChanged += rbNational_CheckedChanged;
            // 
            // rbInternational
            // 
            rbInternational.AutoSize = true;
            rbInternational.CheckedColor = Color.MediumSlateBlue;
            rbInternational.Font = new Font("Segoe UI", 20F);
            rbInternational.ForeColor = Color.DarkGray;
            rbInternational.Location = new Point(23, 16);
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
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDark;
            label8.Location = new Point(625, 20);
            label8.Name = "label8";
            label8.Size = new Size(149, 37);
            label8.TabIndex = 34;
            label8.Text = "Route Type";
            // 
            // pnlAddUser
            // 
            pnlAddUser.BackColor = Color.FromArgb(35, 40, 50);
            pnlAddUser.Controls.Add(label8);
            pnlAddUser.Controls.Add(panel2);
            pnlAddUser.Controls.Add(cbCityTo);
            pnlAddUser.Controls.Add(iconPictureBox8);
            pnlAddUser.Controls.Add(cbCityFrom);
            pnlAddUser.Controls.Add(iconPictureBox7);
            pnlAddUser.Controls.Add(cbCountryTo);
            pnlAddUser.Controls.Add(iconPictureBox6);
            pnlAddUser.Controls.Add(iconPictureBox5);
            pnlAddUser.Controls.Add(txtPrice);
            pnlAddUser.Controls.Add(btnClose);
            pnlAddUser.Controls.Add(btnSave);
            pnlAddUser.Controls.Add(cbCountryFrom);
            pnlAddUser.Controls.Add(iconPictureBox4);
            pnlAddUser.Controls.Add(iconPictureBox1);
            pnlAddUser.Controls.Add(txtDistanceKm);
            pnlAddUser.Controls.Add(label1);
            pnlAddUser.Dock = DockStyle.Top;
            pnlAddUser.Location = new Point(0, 0);
            pnlAddUser.Margin = new Padding(3, 2, 3, 2);
            pnlAddUser.Name = "pnlAddUser";
            pnlAddUser.Size = new Size(1433, 356);
            pnlAddUser.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmOriginalRoutes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(1433, 740);
            Controls.Add(pnlUserListAndInfo);
            Controls.Add(pnlAddUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmOriginalRoutes";
            Text = "frmOriginalRoutes";
            Load += frmOriginalRoutes_Load;
            pnlUserListAndInfo.ResumeLayout(false);
            pnlUserLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoutesList).EndInit();
            pnlUserListTitle.ResumeLayout(false);
            pnlUserListTitle.PerformLayout();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlAddUser.ResumeLayout(false);
            pnlAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUserListAndInfo;
        private Panel pnlUserLIst;
        private DataGridView dgvRoutesList;
        private Panel pnlUserListTitle;
        private Label label2;
        private Panel pnlUserInfo;
        private Label lblCityFrom;
        private Label label14;
        private Label lblCountryTo;
        private Label word;
        private Label lblCountryFrom;
        private Label label10;
        private Label lblPrice;
        private Label label7;
        private Label lblDistanceKm;
        private Label lblRouteType;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Custom_Controls.CustomTextBox txtPlateNumber;
        private Custom_Controls.CustomTextBox txtBusModel;
        private Label lblCityTo;
        private Label CityTo;
        private Label label1;
        private Custom_Controls.CustomTextBox txtDistanceKm;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Custom_Controls.CustomComboBox cbCountryFrom;
        private Custom_Controls.CustomButton btnSave;
        private Custom_Controls.CustomButton btnClose;
        public Custom_Controls.CustomTextBox txtPrice;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Custom_Controls.CustomComboBox cbCountryTo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Custom_Controls.CustomComboBox cbCityFrom;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private Custom_Controls.CustomComboBox cbCityTo;
        private Panel panel2;
        private Custom_Controls.CustomRadioButton rbNational;
        private Custom_Controls.CustomRadioButton rbInternational;
        private Label label8;
        private Panel pnlAddUser;
        private ErrorProvider errorProvider1;
        private Label label6;
        private Label lblRouteName;
    }
}