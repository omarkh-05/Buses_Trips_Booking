namespace AdminBusesBooking.Forms.Buses_And_Drivers
{
    partial class frmBuses
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
            dgvBusesList = new DataGridView();
            pnlUserListTitle = new Panel();
            label2 = new Label();
            pnlUserInfo = new Panel();
            lblDriverID = new Label();
            label9 = new Label();
            lblYearOfManufacture = new Label();
            label16 = new Label();
            lblStatus = new Label();
            label14 = new Label();
            lblClass = new Label();
            word = new Label();
            lblCapacity = new Label();
            label10 = new Label();
            lblCategory = new Label();
            label7 = new Label();
            lblPlateNumber = new Label();
            lblBusNumber = new Label();
            lblBusModel = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pnlAddUser = new Panel();
            cbDriverID = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            cbStatus = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            cbClass = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            cbCategory = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            txtPlateNumber = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            dtpYearofmanufacture = new AdminBusesBooking.Custom_Controls.CustomDateTimePicker();
            btnClose = new AdminBusesBooking.Custom_Controls.CustomButton();
            btnSave = new AdminBusesBooking.Custom_Controls.CustomButton();
            cbCapacity = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtBusModel = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            txtBusNumber = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            pnlUserListAndInfo.SuspendLayout();
            pnlUserLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusesList).BeginInit();
            pnlUserListTitle.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            panel1.SuspendLayout();
            pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            pnlUserListAndInfo.TabIndex = 7;
            // 
            // pnlUserLIst
            // 
            pnlUserLIst.Controls.Add(dgvBusesList);
            pnlUserLIst.Controls.Add(pnlUserListTitle);
            pnlUserLIst.Dock = DockStyle.Fill;
            pnlUserLIst.Location = new Point(0, 0);
            pnlUserLIst.Margin = new Padding(3, 2, 3, 2);
            pnlUserLIst.Name = "pnlUserLIst";
            pnlUserLIst.Size = new Size(1142, 419);
            pnlUserLIst.TabIndex = 1;
            // 
            // dgvBusesList
            // 
            dgvBusesList.AllowUserToAddRows = false;
            dgvBusesList.AllowUserToDeleteRows = false;
            dgvBusesList.AllowUserToOrderColumns = true;
            dgvBusesList.BackgroundColor = Color.FromArgb(35, 40, 50);
            dgvBusesList.BorderStyle = BorderStyle.None;
            dgvBusesList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBusesList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBusesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBusesList.Dock = DockStyle.Fill;
            dgvBusesList.Location = new Point(0, 59);
            dgvBusesList.Margin = new Padding(3, 2, 3, 2);
            dgvBusesList.Name = "dgvBusesList";
            dgvBusesList.ReadOnly = true;
            dgvBusesList.RowHeadersWidth = 51;
            dgvBusesList.Size = new Size(1142, 360);
            dgvBusesList.TabIndex = 1;
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
            label2.Size = new Size(120, 32);
            label2.TabIndex = 1;
            label2.Text = "Buses List";
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlUserInfo.Controls.Add(lblDriverID);
            pnlUserInfo.Controls.Add(label9);
            pnlUserInfo.Controls.Add(lblYearOfManufacture);
            pnlUserInfo.Controls.Add(label16);
            pnlUserInfo.Controls.Add(lblStatus);
            pnlUserInfo.Controls.Add(label14);
            pnlUserInfo.Controls.Add(lblClass);
            pnlUserInfo.Controls.Add(word);
            pnlUserInfo.Controls.Add(lblCapacity);
            pnlUserInfo.Controls.Add(label10);
            pnlUserInfo.Controls.Add(lblCategory);
            pnlUserInfo.Controls.Add(label7);
            pnlUserInfo.Controls.Add(lblPlateNumber);
            pnlUserInfo.Controls.Add(lblBusNumber);
            pnlUserInfo.Controls.Add(lblBusModel);
            pnlUserInfo.Controls.Add(label6);
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
            // lblDriverID
            // 
            lblDriverID.AutoSize = true;
            lblDriverID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDriverID.ForeColor = Color.DarkGray;
            lblDriverID.Location = new Point(234, 382);
            lblDriverID.Name = "lblDriverID";
            lblDriverID.Size = new Size(16, 21);
            lblDriverID.TabIndex = 38;
            lblDriverID.Text = "..";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(148, 382);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 37;
            label9.Text = "DriverID :";
            // 
            // lblYearOfManufacture
            // 
            lblYearOfManufacture.AutoSize = true;
            lblYearOfManufacture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYearOfManufacture.ForeColor = Color.DarkGray;
            lblYearOfManufacture.Location = new Point(178, 338);
            lblYearOfManufacture.Name = "lblYearOfManufacture";
            lblYearOfManufacture.Size = new Size(16, 21);
            lblYearOfManufacture.TabIndex = 36;
            lblYearOfManufacture.Text = "..";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DarkGray;
            label16.Location = new Point(0, 338);
            label16.Name = "label16";
            label16.Size = new Size(160, 21);
            label16.TabIndex = 35;
            label16.Text = "Year Of Manufacture :";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkGray;
            lblStatus.Location = new Point(80, 382);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 21);
            lblStatus.TabIndex = 34;
            lblStatus.Text = "..";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DarkGray;
            label14.Location = new Point(9, 382);
            label14.Name = "label14";
            label14.Size = new Size(59, 21);
            label14.TabIndex = 33;
            label14.Text = "Status :";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClass.ForeColor = Color.DarkGray;
            lblClass.Location = new Point(137, 297);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(16, 21);
            lblClass.TabIndex = 32;
            lblClass.Text = "..";
            // 
            // word
            // 
            word.AutoSize = true;
            word.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            word.ForeColor = Color.DarkGray;
            word.Location = new Point(9, 297);
            word.Name = "word";
            word.Size = new Size(53, 21);
            word.TabIndex = 31;
            word.Text = "Class :";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCapacity.ForeColor = Color.DarkGray;
            lblCapacity.Location = new Point(137, 251);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(16, 21);
            lblCapacity.TabIndex = 30;
            lblCapacity.Text = "..";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(9, 251);
            label10.Name = "label10";
            label10.Size = new Size(76, 21);
            label10.TabIndex = 29;
            label10.Text = "Capacity :";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.DarkGray;
            lblCategory.Location = new Point(137, 206);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(16, 21);
            lblCategory.TabIndex = 28;
            lblCategory.Text = "..";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(9, 206);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 27;
            label7.Text = "Category :";
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlateNumber.ForeColor = Color.DarkGray;
            lblPlateNumber.Location = new Point(137, 160);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(16, 21);
            lblPlateNumber.TabIndex = 26;
            lblPlateNumber.Text = "..";
            // 
            // lblBusNumber
            // 
            lblBusNumber.AutoSize = true;
            lblBusNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBusNumber.ForeColor = Color.DarkGray;
            lblBusNumber.Location = new Point(137, 114);
            lblBusNumber.Name = "lblBusNumber";
            lblBusNumber.Size = new Size(16, 21);
            lblBusNumber.TabIndex = 25;
            lblBusNumber.Text = "..";
            // 
            // lblBusModel
            // 
            lblBusModel.AutoSize = true;
            lblBusModel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBusModel.ForeColor = Color.DarkGray;
            lblBusModel.Location = new Point(136, 68);
            lblBusModel.Name = "lblBusModel";
            lblBusModel.Size = new Size(16, 21);
            lblBusModel.TabIndex = 24;
            lblBusModel.Text = "..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(9, 160);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 23;
            label6.Text = "Plate Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(9, 114);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 22;
            label5.Text = "Bus Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(8, 68);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 21;
            label4.Text = "BusModel :";
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
            label3.Size = new Size(103, 32);
            label3.TabIndex = 1;
            label3.Text = "Bus Info";
            // 
            // pnlAddUser
            // 
            pnlAddUser.BackColor = Color.FromArgb(35, 40, 50);
            pnlAddUser.Controls.Add(cbDriverID);
            pnlAddUser.Controls.Add(iconPictureBox9);
            pnlAddUser.Controls.Add(cbStatus);
            pnlAddUser.Controls.Add(iconPictureBox8);
            pnlAddUser.Controls.Add(cbClass);
            pnlAddUser.Controls.Add(iconPictureBox7);
            pnlAddUser.Controls.Add(cbCategory);
            pnlAddUser.Controls.Add(iconPictureBox6);
            pnlAddUser.Controls.Add(iconPictureBox5);
            pnlAddUser.Controls.Add(txtPlateNumber);
            pnlAddUser.Controls.Add(dtpYearofmanufacture);
            pnlAddUser.Controls.Add(btnClose);
            pnlAddUser.Controls.Add(btnSave);
            pnlAddUser.Controls.Add(cbCapacity);
            pnlAddUser.Controls.Add(iconPictureBox4);
            pnlAddUser.Controls.Add(iconPictureBox3);
            pnlAddUser.Controls.Add(iconPictureBox2);
            pnlAddUser.Controls.Add(iconPictureBox1);
            pnlAddUser.Controls.Add(txtBusModel);
            pnlAddUser.Controls.Add(txtBusNumber);
            pnlAddUser.Controls.Add(label1);
            pnlAddUser.Dock = DockStyle.Top;
            pnlAddUser.Location = new Point(0, 0);
            pnlAddUser.Margin = new Padding(3, 2, 3, 2);
            pnlAddUser.Name = "pnlAddUser";
            pnlAddUser.Size = new Size(1449, 356);
            pnlAddUser.TabIndex = 6;
            // 
            // cbDriverID
            // 
            cbDriverID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbDriverID.BackColor = Color.DarkSlateBlue;
            cbDriverID.BorderColor = Color.White;
            cbDriverID.BorderSize = 0;
            cbDriverID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDriverID.Font = new Font("Segoe UI", 20F);
            cbDriverID.ForeColor = Color.Silver;
            cbDriverID.IconColor = Color.Gainsboro;
            cbDriverID.ListBackColor = Color.FromArgb(230, 228, 245);
            cbDriverID.ListTextColor = Color.DimGray;
            cbDriverID.Location = new Point(986, 216);
            cbDriverID.Margin = new Padding(3, 2, 3, 2);
            cbDriverID.MinimumSize = new Size(175, 22);
            cbDriverID.Name = "cbDriverID";
            cbDriverID.Size = new Size(271, 40);
            cbDriverID.TabIndex = 33;
            cbDriverID.Texts = "Driver ID";
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox9.BackColor = Color.Transparent;
            iconPictureBox9.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.PersonCircleExclamation;
            iconPictureBox9.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 41;
            iconPictureBox9.Location = new Point(934, 214);
            iconPictureBox9.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(47, 41);
            iconPictureBox9.TabIndex = 32;
            iconPictureBox9.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.Anchor = AnchorStyles.Top;
            cbStatus.BackColor = Color.DarkSlateBlue;
            cbStatus.BorderColor = Color.White;
            cbStatus.BorderSize = 0;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Segoe UI", 20F);
            cbStatus.ForeColor = Color.Silver;
            cbStatus.IconColor = Color.Gainsboro;
            cbStatus.Items.AddRange(new object[] { "Ready", "Out Of Service", "On Repairing", "On Work" });
            cbStatus.ListBackColor = Color.FromArgb(230, 228, 245);
            cbStatus.ListTextColor = Color.DimGray;
            cbStatus.Location = new Point(579, 216);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.MinimumSize = new Size(175, 22);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(271, 40);
            cbStatus.TabIndex = 30;
            cbStatus.Texts = "Status";
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.Anchor = AnchorStyles.Top;
            iconPictureBox8.BackColor = Color.Transparent;
            iconPictureBox8.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.ChessBishop;
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
            // cbClass
            // 
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
            cbClass.Location = new Point(152, 216);
            cbClass.Margin = new Padding(3, 2, 3, 2);
            cbClass.MinimumSize = new Size(175, 22);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(271, 40);
            cbClass.TabIndex = 28;
            cbClass.Texts = "Class";
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.Anchor = AnchorStyles.Top;
            iconPictureBox7.BackColor = Color.Transparent;
            iconPictureBox7.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Bus;
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
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Top;
            cbCategory.BackColor = Color.DarkSlateBlue;
            cbCategory.BorderColor = Color.White;
            cbCategory.BorderSize = 0;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Font = new Font("Segoe UI", 20F);
            cbCategory.ForeColor = Color.Silver;
            cbCategory.IconColor = Color.Gainsboro;
            cbCategory.Items.AddRange(new object[] { "BigBus", "SmallBus", "TinyBus", "Car" });
            cbCategory.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCategory.ListTextColor = Color.DimGray;
            cbCategory.Location = new Point(579, 146);
            cbCategory.Margin = new Padding(3, 2, 3, 2);
            cbCategory.MinimumSize = new Size(175, 22);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(271, 40);
            cbCategory.TabIndex = 26;
            cbCategory.Texts = "Category";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Transparent;
            iconPictureBox6.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.Chess;
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
            // iconPictureBox5
            // 
            iconPictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Clapperboard;
            iconPictureBox5.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 41;
            iconPictureBox5.Location = new Point(934, 72);
            iconPictureBox5.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(47, 41);
            iconPictureBox5.TabIndex = 24;
            iconPictureBox5.TabStop = false;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPlateNumber.BackColor = Color.FromArgb(35, 40, 50);
            txtPlateNumber.BorderColor = Color.Gray;
            txtPlateNumber.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtPlateNumber.BorderSize = 5;
            txtPlateNumber.Font = new Font("Segoe UI", 20F);
            txtPlateNumber.ForeColor = Color.DarkGray;
            txtPlateNumber.Location = new Point(986, 68);
            txtPlateNumber.Margin = new Padding(3, 2, 3, 2);
            txtPlateNumber.Multiline = false;
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Padding = new Padding(6, 5, 6, 5);
            txtPlateNumber.PasswordChar = false;
            txtPlateNumber.Size = new Size(271, 46);
            txtPlateNumber.TabIndex = 23;
            txtPlateNumber.Text = "Plate Number";
            txtPlateNumber.Texts = "Bus Plate";
            txtPlateNumber.UnderlinedStyle = true;
            // 
            // dtpYearofmanufacture
            // 
            dtpYearofmanufacture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpYearofmanufacture.BorderColor = Color.DarkSlateBlue;
            dtpYearofmanufacture.BorderSize = 0;
            dtpYearofmanufacture.Font = new Font("Segoe UI", 15F);
            dtpYearofmanufacture.Format = DateTimePickerFormat.Short;
            dtpYearofmanufacture.Location = new Point(986, 148);
            dtpYearofmanufacture.Margin = new Padding(3, 2, 3, 2);
            dtpYearofmanufacture.MinimumSize = new Size(4, 35);
            dtpYearofmanufacture.Name = "dtpYearofmanufacture";
            dtpYearofmanufacture.Size = new Size(272, 35);
            dtpYearofmanufacture.SkinColor = Color.LightSlateGray;
            dtpYearofmanufacture.TabIndex = 22;
            dtpYearofmanufacture.TextColor = Color.White;
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
            // cbCapacity
            // 
            cbCapacity.BackColor = Color.DarkSlateBlue;
            cbCapacity.BorderColor = Color.White;
            cbCapacity.BorderSize = 0;
            cbCapacity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCapacity.Font = new Font("Segoe UI", 20F);
            cbCapacity.ForeColor = Color.Silver;
            cbCapacity.IconColor = Color.Gainsboro;
            cbCapacity.Items.AddRange(new object[] { "50", "30", "26", "10", "7" });
            cbCapacity.ListBackColor = Color.FromArgb(230, 228, 245);
            cbCapacity.ListTextColor = Color.DimGray;
            cbCapacity.Location = new Point(152, 145);
            cbCapacity.Margin = new Padding(3, 2, 3, 2);
            cbCapacity.MinimumSize = new Size(175, 22);
            cbCapacity.Name = "cbCapacity";
            cbCapacity.Size = new Size(271, 40);
            cbCapacity.TabIndex = 19;
            cbCapacity.Texts = "Capacity";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Chair;
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
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            iconPictureBox3.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 41;
            iconPictureBox3.Location = new Point(934, 143);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(47, 41);
            iconPictureBox3.TabIndex = 13;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconPictureBox2.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 41;
            iconPictureBox2.Location = new Point(100, 72);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(47, 41);
            iconPictureBox2.TabIndex = 11;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top;
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Clapperboard;
            iconPictureBox1.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 41;
            iconPictureBox1.Location = new Point(527, 72);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(47, 41);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // txtBusModel
            // 
            txtBusModel.BackColor = Color.FromArgb(35, 40, 50);
            txtBusModel.BorderColor = Color.Gray;
            txtBusModel.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtBusModel.BorderSize = 5;
            txtBusModel.Font = new Font("Segoe UI", 20F);
            txtBusModel.ForeColor = Color.DarkGray;
            txtBusModel.Location = new Point(152, 68);
            txtBusModel.Margin = new Padding(3, 2, 3, 2);
            txtBusModel.Multiline = false;
            txtBusModel.Name = "txtBusModel";
            txtBusModel.Padding = new Padding(6, 5, 6, 5);
            txtBusModel.PasswordChar = false;
            txtBusModel.Size = new Size(271, 46);
            txtBusModel.TabIndex = 9;
            txtBusModel.Text = "Bus Model";
            txtBusModel.Texts = "Bus Model";
            txtBusModel.UnderlinedStyle = true;
            // 
            // txtBusNumber
            // 
            txtBusNumber.Anchor = AnchorStyles.Top;
            txtBusNumber.BackColor = Color.FromArgb(35, 40, 50);
            txtBusNumber.BorderColor = Color.Gray;
            txtBusNumber.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtBusNumber.BorderSize = 5;
            txtBusNumber.Font = new Font("Segoe UI", 20F);
            txtBusNumber.ForeColor = Color.DarkGray;
            txtBusNumber.Location = new Point(579, 72);
            txtBusNumber.Margin = new Padding(3, 2, 3, 2);
            txtBusNumber.Multiline = false;
            txtBusNumber.Name = "txtBusNumber";
            txtBusNumber.Padding = new Padding(6, 5, 6, 5);
            txtBusNumber.PasswordChar = false;
            txtBusNumber.Size = new Size(271, 41);
            txtBusNumber.TabIndex = 8;
            txtBusNumber.Text = "Bus Number";
            txtBusNumber.Texts = "Bus Number";
            txtBusNumber.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Bus";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmBuses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlUserListAndInfo);
            Controls.Add(pnlAddUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmBuses";
            Text = "frmBuses";
            Load += frmBuses_Load;
            pnlUserListAndInfo.ResumeLayout(false);
            pnlUserLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBusesList).EndInit();
            pnlUserListTitle.ResumeLayout(false);
            pnlUserListTitle.PerformLayout();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAddUser.ResumeLayout(false);
            pnlAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUserListAndInfo;
        private Panel pnlUserLIst;
        private Panel pnlUserListTitle;
        private Label label2;
        private Panel pnlUserInfo;
        private Label lblPlateNumber;
        private Label lblBusNumber;
        private Label lblBusModel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Panel pnlAddUser;
        private Custom_Controls.CustomDateTimePicker dtpYearofmanufacture;
        private Custom_Controls.CustomButton btnClose;
        private Custom_Controls.CustomButton btnSave;
        private Custom_Controls.CustomComboBox cbCapacity;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Custom_Controls.CustomTextBox txtBusModel;
        private Custom_Controls.CustomTextBox txtBusNumber;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Custom_Controls.CustomTextBox txtPlateNumber;
        private Custom_Controls.CustomComboBox cbCategory;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private Custom_Controls.CustomComboBox cbClass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Custom_Controls.CustomComboBox cbStatus;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private Label lblYearOfManufacture;
        private Label label16;
        private Label lblStatus;
        private Label label14;
        private Label lblClass;
        private Label word;
        private Label lblCapacity;
        private Label label10;
        private Label lblCategory;
        private Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private ErrorProvider errorProvider1;
        private Label lblDriverID;
        private Label label9;
        private Custom_Controls.CustomComboBox cbDriverID;
        private DataGridView dgvBusesList;
    }
}