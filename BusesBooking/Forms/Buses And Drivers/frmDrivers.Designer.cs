namespace AdminBusesBooking.Forms.Buses_And_Drivers
{
    partial class frmDrivers
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
            dgvDriversLIst = new DataGridView();
            pnlUserListTitle = new Panel();
            label2 = new Label();
            pnlUserInfo = new Panel();
            lblStatus = new Label();
            lblRank = new Label();
            lblDriverName = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pbDriverInfoImg = new AdminBusesBooking.Custom_Controls.CirclePicBox();
            panel1 = new Panel();
            label3 = new Label();
            pnlAddUser = new Panel();
            dtpDateOfBirth = new AdminBusesBooking.Custom_Controls.CustomDateTimePicker();
            btnClose = new AdminBusesBooking.Custom_Controls.CustomButton();
            btnSave = new AdminBusesBooking.Custom_Controls.CustomButton();
            cbRank = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            panel2 = new Panel();
            rbNotActive = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            rbActive = new AdminBusesBooking.Custom_Controls.CustomRadioButton();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtDiscription = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            txtDriverName = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            llRemoveImg = new Label();
            llSetImg = new Label();
            pbDriverImg = new AdminBusesBooking.Custom_Controls.CirclePicBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            pnlUserListAndInfo.SuspendLayout();
            pnlUserLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDriversLIst).BeginInit();
            pnlUserListTitle.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDriverInfoImg).BeginInit();
            panel1.SuspendLayout();
            pnlAddUser.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDriverImg).BeginInit();
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
            pnlUserLIst.Controls.Add(dgvDriversLIst);
            pnlUserLIst.Controls.Add(pnlUserListTitle);
            pnlUserLIst.Dock = DockStyle.Fill;
            pnlUserLIst.Location = new Point(0, 0);
            pnlUserLIst.Margin = new Padding(3, 2, 3, 2);
            pnlUserLIst.Name = "pnlUserLIst";
            pnlUserLIst.Size = new Size(1142, 419);
            pnlUserLIst.TabIndex = 1;
            // 
            // dgvDriversLIst
            // 
            dgvDriversLIst.AllowUserToAddRows = false;
            dgvDriversLIst.AllowUserToDeleteRows = false;
            dgvDriversLIst.AllowUserToOrderColumns = true;
            dgvDriversLIst.BackgroundColor = Color.FromArgb(35, 40, 50);
            dgvDriversLIst.BorderStyle = BorderStyle.None;
            dgvDriversLIst.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDriversLIst.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDriversLIst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDriversLIst.Dock = DockStyle.Fill;
            dgvDriversLIst.Location = new Point(0, 59);
            dgvDriversLIst.Margin = new Padding(3, 2, 3, 2);
            dgvDriversLIst.Name = "dgvDriversLIst";
            dgvDriversLIst.ReadOnly = true;
            dgvDriversLIst.RowHeadersWidth = 51;
            dgvDriversLIst.Size = new Size(1142, 360);
            dgvDriversLIst.TabIndex = 1;
            dgvDriversLIst.DataBindingComplete += dgvDriversLIst_DataBindingComplete;
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
            label2.Size = new Size(134, 32);
            label2.TabIndex = 1;
            label2.Text = "Drivers List";
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlUserInfo.Controls.Add(lblStatus);
            pnlUserInfo.Controls.Add(lblRank);
            pnlUserInfo.Controls.Add(lblDriverName);
            pnlUserInfo.Controls.Add(label6);
            pnlUserInfo.Controls.Add(label5);
            pnlUserInfo.Controls.Add(label4);
            pnlUserInfo.Controls.Add(pbDriverInfoImg);
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
            lblStatus.Location = new Point(152, 362);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 21);
            lblStatus.TabIndex = 26;
            lblStatus.Text = "..";
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRank.ForeColor = Color.DarkGray;
            lblRank.Location = new Point(109, 298);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(16, 21);
            lblRank.TabIndex = 25;
            lblRank.Text = "..";
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDriverName.ForeColor = Color.DarkGray;
            lblDriverName.Location = new Point(109, 232);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Size = new Size(16, 21);
            lblDriverName.TabIndex = 24;
            lblDriverName.Text = "..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(3, 362);
            label6.Name = "label6";
            label6.Size = new Size(124, 21);
            label6.TabIndex = 23;
            label6.Text = "Created By User:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(54, 298);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 22;
            label5.Text = "Rank :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(0, 232);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 21;
            label4.Text = "DriverName :";
            // 
            // pbDriverInfoImg
            // 
            pbDriverInfoImg.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pbDriverInfoImg.BorderColor = Color.CadetBlue;
            pbDriverInfoImg.BorderColor2 = Color.LightSteelBlue;
            pbDriverInfoImg.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pbDriverInfoImg.BorderSize = 2;
            pbDriverInfoImg.GradientAngle = 50F;
            pbDriverInfoImg.Location = new Point(76, 71);
            pbDriverInfoImg.Margin = new Padding(3, 2, 3, 2);
            pbDriverInfoImg.Name = "pbDriverInfoImg";
            pbDriverInfoImg.Size = new Size(156, 156);
            pbDriverInfoImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDriverInfoImg.TabIndex = 20;
            pbDriverInfoImg.TabStop = false;
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
            label3.Size = new Size(130, 32);
            label3.TabIndex = 1;
            label3.Text = "Driver Info";
            // 
            // pnlAddUser
            // 
            pnlAddUser.Controls.Add(dtpDateOfBirth);
            pnlAddUser.Controls.Add(btnClose);
            pnlAddUser.Controls.Add(btnSave);
            pnlAddUser.Controls.Add(cbRank);
            pnlAddUser.Controls.Add(panel2);
            pnlAddUser.Controls.Add(iconPictureBox4);
            pnlAddUser.Controls.Add(iconPictureBox3);
            pnlAddUser.Controls.Add(iconPictureBox2);
            pnlAddUser.Controls.Add(iconPictureBox1);
            pnlAddUser.Controls.Add(txtDiscription);
            pnlAddUser.Controls.Add(txtDriverName);
            pnlAddUser.Controls.Add(llRemoveImg);
            pnlAddUser.Controls.Add(llSetImg);
            pnlAddUser.Controls.Add(pbDriverImg);
            pnlAddUser.Controls.Add(label1);
            pnlAddUser.Dock = DockStyle.Top;
            pnlAddUser.Location = new Point(0, 0);
            pnlAddUser.Margin = new Padding(3, 2, 3, 2);
            pnlAddUser.Name = "pnlAddUser";
            pnlAddUser.Size = new Size(1449, 356);
            pnlAddUser.TabIndex = 4;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Anchor = AnchorStyles.Top;
            dtpDateOfBirth.BorderColor = Color.DarkSlateBlue;
            dtpDateOfBirth.BorderSize = 0;
            dtpDateOfBirth.Font = new Font("Segoe UI", 15F);
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(579, 164);
            dtpDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            dtpDateOfBirth.MinimumSize = new Size(4, 35);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(272, 35);
            dtpDateOfBirth.SkinColor = Color.LightSlateGray;
            dtpDateOfBirth.TabIndex = 22;
            dtpDateOfBirth.TextColor = Color.White;
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
            // cbRank
            // 
            cbRank.BackColor = Color.DarkSlateBlue;
            cbRank.BorderColor = Color.White;
            cbRank.BorderSize = 0;
            cbRank.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRank.Font = new Font("Segoe UI", 20F);
            cbRank.ForeColor = Color.Silver;
            cbRank.IconColor = Color.Gainsboro;
            cbRank.Items.AddRange(new object[] { "BigBus", "SmallBus", "TinyBus", "Car" });
            cbRank.ListBackColor = Color.FromArgb(230, 228, 245);
            cbRank.ListTextColor = Color.DimGray;
            cbRank.Location = new Point(152, 159);
            cbRank.Margin = new Padding(3, 2, 3, 2);
            cbRank.MinimumSize = new Size(175, 22);
            cbRank.Name = "cbRank";
            cbRank.Size = new Size(271, 40);
            cbRank.TabIndex = 19;
            cbRank.Texts = "Rank";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(rbNotActive);
            panel2.Controls.Add(rbActive);
            panel2.Controls.Add(iconPictureBox6);
            panel2.Controls.Add(iconPictureBox5);
            panel2.Location = new Point(915, 72);
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
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            iconPictureBox4.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 41;
            iconPictureBox4.Location = new Point(100, 158);
            iconPictureBox4.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(47, 41);
            iconPictureBox4.TabIndex = 14;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Top;
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            iconPictureBox3.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 41;
            iconPictureBox3.Location = new Point(527, 158);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(47, 41);
            iconPictureBox3.TabIndex = 13;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top;
            iconPictureBox2.BackColor = Color.Transparent;
            iconPictureBox2.ForeColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            iconPictureBox2.IconColor = SystemColors.ControlDarkDark;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 41;
            iconPictureBox2.Location = new Point(527, 72);
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
            iconPictureBox1.Location = new Point(100, 72);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(47, 41);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // txtDiscription
            // 
            txtDiscription.Anchor = AnchorStyles.Top;
            txtDiscription.BackColor = Color.FromArgb(35, 40, 50);
            txtDiscription.BorderColor = Color.Gray;
            txtDiscription.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtDiscription.BorderSize = 5;
            txtDiscription.Font = new Font("Segoe UI", 20F);
            txtDiscription.ForeColor = Color.DarkGray;
            txtDiscription.Location = new Point(579, 72);
            txtDiscription.Margin = new Padding(3, 2, 3, 2);
            txtDiscription.Multiline = false;
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Padding = new Padding(6, 5, 6, 5);
            txtDiscription.PasswordChar = false;
            txtDiscription.Size = new Size(271, 46);
            txtDiscription.TabIndex = 9;
            txtDiscription.Texts = "Discription";
            txtDiscription.UnderlinedStyle = true;
            // 
            // txtDriverName
            // 
            txtDriverName.BackColor = Color.FromArgb(35, 40, 50);
            txtDriverName.BorderColor = Color.Gray;
            txtDriverName.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtDriverName.BorderSize = 5;
            txtDriverName.Font = new Font("Segoe UI", 20F);
            txtDriverName.ForeColor = Color.DarkGray;
            txtDriverName.Location = new Point(152, 72);
            txtDriverName.Margin = new Padding(3, 2, 3, 2);
            txtDriverName.Multiline = false;
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Padding = new Padding(6, 5, 6, 5);
            txtDriverName.PasswordChar = false;
            txtDriverName.Size = new Size(271, 41);
            txtDriverName.TabIndex = 8;
            txtDriverName.Text = "Driver Name";
            txtDriverName.Texts = "Driver Name";
            txtDriverName.UnderlinedStyle = true;
            // 
            // llRemoveImg
            // 
            llRemoveImg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            llRemoveImg.AutoSize = true;
            llRemoveImg.Cursor = Cursors.Hand;
            llRemoveImg.Font = new Font("Segoe UI", 13.8F);
            llRemoveImg.ForeColor = Color.Firebrick;
            llRemoveImg.Location = new Point(1241, 247);
            llRemoveImg.Name = "llRemoveImg";
            llRemoveImg.Size = new Size(115, 25);
            llRemoveImg.TabIndex = 7;
            llRemoveImg.Text = "Remove Img";
            llRemoveImg.Click += llRemoveImg_Click;
            // 
            // llSetImg
            // 
            llSetImg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            llSetImg.AutoSize = true;
            llSetImg.Cursor = Cursors.Hand;
            llSetImg.Font = new Font("Segoe UI", 13.8F);
            llSetImg.ForeColor = Color.Gainsboro;
            llSetImg.Location = new Point(1251, 212);
            llSetImg.Name = "llSetImg";
            llSetImg.Size = new Size(95, 25);
            llSetImg.TabIndex = 6;
            llSetImg.Text = "Set Image";
            llSetImg.Click += llSetImg_Click;
            // 
            // pbDriverImg
            // 
            pbDriverImg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbDriverImg.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pbDriverImg.BorderColor = Color.CornflowerBlue;
            pbDriverImg.BorderColor2 = Color.SlateBlue;
            pbDriverImg.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pbDriverImg.BorderSize = 2;
            pbDriverImg.GradientAngle = 50F;
            pbDriverImg.Location = new Point(1208, 44);
            pbDriverImg.Margin = new Padding(3, 2, 3, 2);
            pbDriverImg.Name = "pbDriverImg";
            pbDriverImg.Size = new Size(181, 181);
            pbDriverImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDriverImg.TabIndex = 3;
            pbDriverImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Driver";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDrivers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlUserListAndInfo);
            Controls.Add(pnlAddUser);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmDrivers";
            Text = "frmDrivers";
            Load += frmDrivers_Load;
            pnlUserListAndInfo.ResumeLayout(false);
            pnlUserLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDriversLIst).EndInit();
            pnlUserListTitle.ResumeLayout(false);
            pnlUserListTitle.PerformLayout();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDriverInfoImg).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAddUser.ResumeLayout(false);
            pnlAddUser.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDriverImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUserListAndInfo;
        private Panel pnlUserLIst;
        private DataGridView dgvDriversLIst;
        private Panel pnlUserListTitle;
        private Label label2;
        private Panel pnlUserInfo;
        private Label lblStatus;
        private Label lblRank;
        private Label lblDriverName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Panel pnlAddUser;
        private Custom_Controls.CustomComboBox cbRank;
        private Panel panel2;
        private Custom_Controls.CustomRadioButton rbNotActive;
        private Custom_Controls.CustomRadioButton rbActive;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Custom_Controls.CustomTextBox txtDiscription;
        private Custom_Controls.CustomTextBox txtDriverName;
        private Label llRemoveImg;
        private Label llSetImg;
        private Custom_Controls.CirclePicBox pbDriverImg;
        private Label label1;
        private Custom_Controls.CustomButton btnClose;
        private Custom_Controls.CustomButton btnSave;
        private Custom_Controls.CustomDateTimePicker dtpDateOfBirth;
        private Custom_Controls.CirclePicBox pbDriverInfoImg;
        private ErrorProvider errorProvider1;
        private OpenFileDialog openFileDialog1;
    }
}