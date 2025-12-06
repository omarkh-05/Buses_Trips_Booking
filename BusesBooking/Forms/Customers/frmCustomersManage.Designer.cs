namespace AdminBusesBooking.Forms.Customers
{
    partial class frmCustomersManage
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
            dgvCustomerInfo = new DataGridView();
            pnlUserListTitle = new Panel();
            label2 = new Label();
            pnlUserInfo = new Panel();
            lblStatus = new Label();
            label13 = new Label();
            lblDateOfBirth = new Label();
            label12 = new Label();
            lblNationality = new Label();
            label10 = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            pnlAddUser = new Panel();
            txtPhoneNumber = new MaskedTextBox();
            dtpDateOfBirth = new AdminBusesBooking.Custom_Controls.CustomDateTimePicker();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            txtEmail = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            cbNationality = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            panel2 = new Panel();
            rbNotActive = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            rbActive = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtPassword = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            txtFullName = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            btnClose = new AdminBusesBooking.Custom_Controls.CustomButton();
            btnSave = new AdminBusesBooking.Custom_Controls.CustomButton();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            pnlUserListAndInfo.SuspendLayout();
            pnlUserLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfo).BeginInit();
            pnlUserListTitle.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            panel1.SuspendLayout();
            pnlAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
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
            pnlUserListAndInfo.TabIndex = 5;
            // 
            // pnlUserLIst
            // 
            pnlUserLIst.Controls.Add(dgvCustomerInfo);
            pnlUserLIst.Controls.Add(pnlUserListTitle);
            pnlUserLIst.Dock = DockStyle.Fill;
            pnlUserLIst.Location = new Point(0, 0);
            pnlUserLIst.Margin = new Padding(3, 2, 3, 2);
            pnlUserLIst.Name = "pnlUserLIst";
            pnlUserLIst.Size = new Size(1142, 419);
            pnlUserLIst.TabIndex = 1;
            // 
            // dgvCustomerInfo
            // 
            dgvCustomerInfo.AllowUserToAddRows = false;
            dgvCustomerInfo.AllowUserToDeleteRows = false;
            dgvCustomerInfo.AllowUserToOrderColumns = true;
            dgvCustomerInfo.BackgroundColor = Color.FromArgb(35, 40, 50);
            dgvCustomerInfo.BorderStyle = BorderStyle.None;
            dgvCustomerInfo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCustomerInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCustomerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerInfo.Dock = DockStyle.Fill;
            dgvCustomerInfo.Location = new Point(0, 59);
            dgvCustomerInfo.Margin = new Padding(3, 2, 3, 2);
            dgvCustomerInfo.Name = "dgvCustomerInfo";
            dgvCustomerInfo.ReadOnly = true;
            dgvCustomerInfo.RowHeadersWidth = 51;
            dgvCustomerInfo.Size = new Size(1142, 360);
            dgvCustomerInfo.TabIndex = 1;
            dgvCustomerInfo.DataBindingComplete += dgvCustomerInfo_DataBindingComplete;
            // 
            // pnlUserListTitle
            // 
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
            label2.Size = new Size(173, 32);
            label2.TabIndex = 1;
            label2.Text = "Customers List";
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlUserInfo.Controls.Add(lblStatus);
            pnlUserInfo.Controls.Add(label13);
            pnlUserInfo.Controls.Add(lblDateOfBirth);
            pnlUserInfo.Controls.Add(label12);
            pnlUserInfo.Controls.Add(lblNationality);
            pnlUserInfo.Controls.Add(label10);
            pnlUserInfo.Controls.Add(lblPhoneNumber);
            pnlUserInfo.Controls.Add(lblEmail);
            pnlUserInfo.Controls.Add(lblFullName);
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
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkGray;
            lblStatus.Location = new Point(135, 338);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 21);
            lblStatus.TabIndex = 34;
            lblStatus.Text = "..";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkGray;
            label13.Location = new Point(8, 338);
            label13.Name = "label13";
            label13.Size = new Size(59, 21);
            label13.TabIndex = 33;
            label13.Text = "Status :";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfBirth.ForeColor = Color.DarkGray;
            lblDateOfBirth.Location = new Point(135, 290);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(16, 21);
            lblDateOfBirth.TabIndex = 32;
            lblDateOfBirth.Text = "..";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkGray;
            label12.Location = new Point(8, 290);
            label12.Name = "label12";
            label12.Size = new Size(86, 21);
            label12.TabIndex = 31;
            label12.Text = "Birth Date :";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNationality.ForeColor = Color.DarkGray;
            lblNationality.Location = new Point(135, 238);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(16, 21);
            lblNationality.TabIndex = 30;
            lblNationality.Text = "..";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(8, 238);
            label10.Name = "label10";
            label10.Size = new Size(93, 21);
            label10.TabIndex = 29;
            label10.Text = "Nationality :";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.ForeColor = Color.DarkGray;
            lblPhoneNumber.Location = new Point(135, 187);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(16, 21);
            lblPhoneNumber.TabIndex = 26;
            lblPhoneNumber.Text = "..";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.DarkGray;
            lblEmail.Location = new Point(92, 134);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(16, 21);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "..";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.DarkGray;
            lblFullName.Location = new Point(94, 82);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(16, 21);
            lblFullName.TabIndex = 24;
            lblFullName.Text = "..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(-4, 187);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 23;
            label6.Text = "Phone Number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(8, 134);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 22;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(0, 82);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 21;
            label4.Text = "Full Name :";
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
            label3.Size = new Size(169, 32);
            label3.TabIndex = 1;
            label3.Text = "Customer Info";
            // 
            // pnlAddUser
            // 
            pnlAddUser.Controls.Add(txtPhoneNumber);
            pnlAddUser.Controls.Add(dtpDateOfBirth);
            pnlAddUser.Controls.Add(iconPictureBox9);
            pnlAddUser.Controls.Add(iconPictureBox8);
            pnlAddUser.Controls.Add(iconPictureBox7);
            pnlAddUser.Controls.Add(txtEmail);
            pnlAddUser.Controls.Add(cbNationality);
            pnlAddUser.Controls.Add(panel2);
            pnlAddUser.Controls.Add(iconPictureBox4);
            pnlAddUser.Controls.Add(iconPictureBox2);
            pnlAddUser.Controls.Add(iconPictureBox1);
            pnlAddUser.Controls.Add(txtPassword);
            pnlAddUser.Controls.Add(txtFullName);
            pnlAddUser.Controls.Add(btnClose);
            pnlAddUser.Controls.Add(btnSave);
            pnlAddUser.Controls.Add(label1);
            pnlAddUser.Dock = DockStyle.Top;
            pnlAddUser.Location = new Point(0, 0);
            pnlAddUser.Margin = new Padding(3, 2, 3, 2);
            pnlAddUser.Name = "pnlAddUser";
            pnlAddUser.Size = new Size(1449, 356);
            pnlAddUser.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top;
            txtPhoneNumber.BackColor = Color.FromArgb(35, 40, 50);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 20F);
            txtPhoneNumber.ForeColor = Color.DarkGray;
            txtPhoneNumber.Location = new Point(497, 160);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Mask = "(999) 000-000-000";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(272, 43);
            txtPhoneNumber.TabIndex = 26;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top;
            dtpDateOfBirth.BorderColor = Color.PaleVioletRed;
            dtpDateOfBirth.BorderSize = 0;
            dtpDateOfBirth.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(895, 161);
            dtpDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            dtpDateOfBirth.MinimumSize = new Size(4, 35);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(272, 43);
            dtpDateOfBirth.SkinColor = Color.LightSlateGray;
            dtpDateOfBirth.TabIndex = 25;
            dtpDateOfBirth.TextColor = Color.White;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.Anchor = AnchorStyles.Top;
            iconPictureBox9.BackColor = Color.Transparent;
            iconPictureBox9.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            iconPictureBox9.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 41;
            iconPictureBox9.Location = new Point(843, 160);
            iconPictureBox9.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(47, 41);
            iconPictureBox9.TabIndex = 24;
            iconPictureBox9.TabStop = false;
            // 
            // iconPictureBox8
            // 
            iconPictureBox8.Anchor = AnchorStyles.Top;
            iconPictureBox8.BackColor = Color.Transparent;
            iconPictureBox8.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Phone;
            iconPictureBox8.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox8.IconSize = 41;
            iconPictureBox8.Location = new Point(444, 160);
            iconPictureBox8.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox8.Name = "iconPictureBox8";
            iconPictureBox8.Size = new Size(47, 41);
            iconPictureBox8.TabIndex = 23;
            iconPictureBox8.TabStop = false;
            // 
            // iconPictureBox7
            // 
            iconPictureBox7.Anchor = AnchorStyles.Top;
            iconPictureBox7.BackColor = Color.Transparent;
            iconPictureBox7.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.At;
            iconPictureBox7.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox7.IconSize = 41;
            iconPictureBox7.Location = new Point(843, 74);
            iconPictureBox7.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox7.Name = "iconPictureBox7";
            iconPictureBox7.Size = new Size(47, 41);
            iconPictureBox7.TabIndex = 21;
            iconPictureBox7.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.FromArgb(35, 40, 50);
            txtEmail.BorderColor = Color.Gray;
            txtEmail.BorderFocusColor = Color.Red;
            txtEmail.BorderSize = 5;
            txtEmail.Font = new Font("Segoe UI", 20F);
            txtEmail.ForeColor = Color.DarkGray;
            txtEmail.Location = new Point(895, 74);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(6, 5, 6, 5);
            txtEmail.PasswordChar = false;
            txtEmail.Size = new Size(271, 41);
            txtEmail.TabIndex = 20;
            txtEmail.Text = "Email";
            txtEmail.Texts = "Email";
            txtEmail.UnderlinedStyle = true;
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
            cbNationality.Location = new Point(98, 160);
            cbNationality.Margin = new Padding(3, 2, 3, 2);
            cbNationality.MinimumSize = new Size(175, 22);
            cbNationality.Name = "cbNationality";
            cbNationality.Size = new Size(271, 40);
            cbNationality.TabIndex = 19;
            cbNationality.Texts = "Nationality";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(rbNotActive);
            panel2.Controls.Add(rbActive);
            panel2.Controls.Add(iconPictureBox6);
            panel2.Controls.Add(iconPictureBox5);
            panel2.Location = new Point(1202, 74);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 127);
            panel2.TabIndex = 18;
            // 
            // rbNotActive
            // 
            rbNotActive.AutoSize = true;
            rbNotActive.CheckedColor = Color.MediumSlateBlue;
            rbNotActive.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbNotActive.ForeColor = Color.DarkGray;
            rbNotActive.Location = new Point(54, 90);
            rbNotActive.Margin = new Padding(3, 2, 3, 2);
            rbNotActive.MinimumSize = new Size(0, 16);
            rbNotActive.Name = "rbNotActive";
            rbNotActive.Padding = new Padding(9, 0, 0, 0);
            rbNotActive.Size = new Size(153, 36);
            rbNotActive.TabIndex = 21;
            rbNotActive.TabStop = true;
            rbNotActive.Text = "Not Active";
            rbNotActive.UnCheckedColor = Color.Gray;
            rbNotActive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.CheckedColor = Color.MediumSlateBlue;
            rbActive.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbActive.ForeColor = Color.DarkGray;
            rbActive.Location = new Point(54, 2);
            rbActive.Margin = new Padding(3, 2, 3, 2);
            rbActive.MinimumSize = new Size(0, 16);
            rbActive.Name = "rbActive";
            rbActive.Padding = new Padding(9, 0, 0, 0);
            rbActive.Size = new Size(106, 36);
            rbActive.TabIndex = 19;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UnCheckedColor = Color.Gray;
            rbActive.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.Transparent;
            iconPictureBox6.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconPictureBox6.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.IconSize = 41;
            iconPictureBox6.Location = new Point(2, 87);
            iconPictureBox6.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(47, 41);
            iconPictureBox6.TabIndex = 20;
            iconPictureBox6.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconPictureBox5.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 41;
            iconPictureBox5.Location = new Point(2, 0);
            iconPictureBox5.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(47, 41);
            iconPictureBox5.TabIndex = 19;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.EarthAfrica;
            iconPictureBox4.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 41;
            iconPictureBox4.Location = new Point(46, 160);
            iconPictureBox4.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(47, 41);
            iconPictureBox4.TabIndex = 14;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top;
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 41;
            iconPictureBox2.Location = new Point(444, 74);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(47, 41);
            iconPictureBox2.TabIndex = 11;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 41;
            iconPictureBox1.Location = new Point(46, 74);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(47, 41);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.BackColor = Color.FromArgb(35, 40, 50);
            txtPassword.BorderColor = Color.Gray;
            txtPassword.BorderFocusColor = Color.Red;
            txtPassword.BorderSize = 5;
            txtPassword.Font = new Font("Segoe UI", 20F);
            txtPassword.ForeColor = Color.DarkGray;
            txtPassword.Location = new Point(497, 74);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(6, 5, 6, 5);
            txtPassword.PasswordChar = false;
            txtPassword.Size = new Size(271, 46);
            txtPassword.TabIndex = 9;
            txtPassword.Text = "Password";
            txtPassword.Texts = "Password";
            txtPassword.UnderlinedStyle = true;
            txtPassword.Click += txtPassword_Click;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(35, 40, 50);
            txtFullName.BorderColor = Color.Gray;
            txtFullName.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtFullName.BorderSize = 5;
            txtFullName.Font = new Font("Segoe UI", 20F);
            txtFullName.ForeColor = Color.DarkGray;
            txtFullName.Location = new Point(98, 74);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Multiline = false;
            txtFullName.Name = "txtFullName";
            txtFullName.Padding = new Padding(6, 5, 6, 5);
            txtFullName.PasswordChar = false;
            txtFullName.Size = new Size(271, 41);
            txtFullName.TabIndex = 8;
            txtFullName.Texts = "Full Name";
            txtFullName.UnderlinedStyle = true;
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
            btnClose.Size = new Size(164, 38);
            btnClose.TabIndex = 2;
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
            btnSave.Location = new Point(726, 292);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextColor = Color.WhiteSmoke;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Customer";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmCustomersManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlUserListAndInfo);
            Controls.Add(pnlAddUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCustomersManage";
            Text = "frmCustomers";
            Load += frmCustomersManage_Load;
            pnlUserListAndInfo.ResumeLayout(false);
            pnlUserLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfo).EndInit();
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUserListAndInfo;
        private Panel pnlUserLIst;
        private DataGridView dgvCustomerInfo;
        private Panel pnlUserListTitle;
        private Label label2;
        private Panel pnlUserInfo;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblFullName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Panel pnlAddUser;
        private Custom_Controls.CustomComboBox cbNationality;
        private Panel panel2;
        private Custom_Controls.CustomRadioButton rbNotActive;
        private Custom_Controls.CustomRadioButton rbActive;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Custom_Controls.CustomTextBox txtPassword;
        private Custom_Controls.CustomTextBox txtFullName;
        private Custom_Controls.CustomButton btnClose;
        private Custom_Controls.CustomButton btnSave;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private Custom_Controls.CustomTextBox txtEmail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private Custom_Controls.CustomDateTimePicker dtpDateOfBirth;
        private Label lblNationality;
        private Label label10;
        private Label lblDateOfBirth;
        private Label label12;
        private Label lblStatus;
        private Label label13;
        private ErrorProvider errorProvider1;
        private MaskedTextBox txtPhoneNumber;
    }
}