namespace AdminBusesBooking.Forms.Bookings
{
    partial class frmmanageBookings
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
            panel1 = new Panel();
            btnSearch = new AdminBusesBooking.Custom_Controls.CustomButton();
            txtSearchFor = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            cbFilterBy = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            label1 = new Label();
            pnlUserListAndInfo = new Panel();
            pnlUserLIst = new Panel();
            dgvBookingsList = new DataGridView();
            pnlUserListTitle = new Panel();
            label2 = new Label();
            pnlUserInfo = new Panel();
            lblTotalAmount = new Label();
            label9 = new Label();
            label13 = new Label();
            lblDisabledCount = new Label();
            label11 = new Label();
            lblAdultCount = new Label();
            label8 = new Label();
            lblUserID = new Label();
            label12 = new Label();
            lblPaymentStatus = new Label();
            CityTo = new Label();
            lblCreatedAt = new Label();
            label16 = new Label();
            lblChildCount = new Label();
            lblPassengerCount = new Label();
            word = new Label();
            lblTravelDate = new Label();
            label10 = new Label();
            lblCustomerID = new Label();
            label7 = new Label();
            lblTripID = new Label();
            lblClass = new Label();
            lblTripType = new Label();
            l = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            pnlUserListAndInfo.SuspendLayout();
            pnlUserLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsList).BeginInit();
            pnlUserListTitle.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearchFor);
            panel1.Controls.Add(cbFilterBy);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1449, 124);
            panel1.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.MediumSlateBlue;
            btnSearch.BackgroundColor = Color.MediumSlateBlue;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 20;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1041, 60);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(164, 38);
            btnSearch.TabIndex = 53;
            btnSearch.Text = "Search";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchFor
            // 
            txtSearchFor.Anchor = AnchorStyles.Top;
            txtSearchFor.BackColor = Color.FromArgb(35, 40, 50);
            txtSearchFor.BorderColor = Color.MediumSlateBlue;
            txtSearchFor.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtSearchFor.BorderSize = 5;
            txtSearchFor.Font = new Font("Segoe UI", 20F);
            txtSearchFor.ForeColor = Color.DarkGray;
            txtSearchFor.Location = new Point(369, 52);
            txtSearchFor.Margin = new Padding(3, 2, 3, 2);
            txtSearchFor.Multiline = false;
            txtSearchFor.Name = "txtSearchFor";
            txtSearchFor.Padding = new Padding(6, 5, 6, 5);
            txtSearchFor.PasswordChar = false;
            txtSearchFor.Size = new Size(657, 46);
            txtSearchFor.TabIndex = 52;
            txtSearchFor.Text = "Search For";
            txtSearchFor.Texts = "Search For";
            txtSearchFor.UnderlinedStyle = true;
            txtSearchFor._TextChanged += txtSearchFor_Click;
            txtSearchFor.TextChanged += txtSearchFor_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.Anchor = AnchorStyles.Top;
            cbFilterBy.BackColor = Color.MediumSlateBlue;
            cbFilterBy.BorderColor = Color.White;
            cbFilterBy.BorderSize = 0;
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Segoe UI", 20F);
            cbFilterBy.ForeColor = Color.White;
            cbFilterBy.IconColor = Color.Gainsboro;
            cbFilterBy.Items.AddRange(new object[] { "Date", "Amount", "BookingID", "CustomerID" });
            cbFilterBy.ListBackColor = Color.FromArgb(230, 228, 245);
            cbFilterBy.ListTextColor = Color.DimGray;
            cbFilterBy.Location = new Point(122, 58);
            cbFilterBy.Margin = new Padding(3, 2, 3, 2);
            cbFilterBy.MinimumSize = new Size(175, 22);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(234, 40);
            cbFilterBy.TabIndex = 51;
            cbFilterBy.Texts = "Filter By";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 2;
            label1.Text = "Bookings Search";
            // 
            // pnlUserListAndInfo
            // 
            pnlUserListAndInfo.Controls.Add(pnlUserLIst);
            pnlUserListAndInfo.Controls.Add(pnlUserInfo);
            pnlUserListAndInfo.Dock = DockStyle.Fill;
            pnlUserListAndInfo.Location = new Point(0, 124);
            pnlUserListAndInfo.Margin = new Padding(3, 2, 3, 2);
            pnlUserListAndInfo.Name = "pnlUserListAndInfo";
            pnlUserListAndInfo.Size = new Size(1449, 651);
            pnlUserListAndInfo.TabIndex = 15;
            // 
            // pnlUserLIst
            // 
            pnlUserLIst.Controls.Add(dgvBookingsList);
            pnlUserLIst.Controls.Add(pnlUserListTitle);
            pnlUserLIst.Dock = DockStyle.Fill;
            pnlUserLIst.Location = new Point(0, 0);
            pnlUserLIst.Margin = new Padding(3, 2, 3, 2);
            pnlUserLIst.Name = "pnlUserLIst";
            pnlUserLIst.Size = new Size(1142, 651);
            pnlUserLIst.TabIndex = 1;
            // 
            // dgvBookingsList
            // 
            dgvBookingsList.AllowUserToAddRows = false;
            dgvBookingsList.AllowUserToDeleteRows = false;
            dgvBookingsList.AllowUserToOrderColumns = true;
            dgvBookingsList.BackgroundColor = Color.FromArgb(35, 40, 50);
            dgvBookingsList.BorderStyle = BorderStyle.None;
            dgvBookingsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBookingsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvBookingsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingsList.Dock = DockStyle.Fill;
            dgvBookingsList.Location = new Point(0, 59);
            dgvBookingsList.Margin = new Padding(3, 2, 3, 2);
            dgvBookingsList.Name = "dgvBookingsList";
            dgvBookingsList.ReadOnly = true;
            dgvBookingsList.RowHeadersWidth = 51;
            dgvBookingsList.Size = new Size(1142, 592);
            dgvBookingsList.TabIndex = 1;
            dgvBookingsList.DataBindingComplete += dgvBookingsList_DataBindingComplete;
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
            label2.Size = new Size(158, 32);
            label2.TabIndex = 1;
            label2.Text = "Bookings List";
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlUserInfo.Controls.Add(lblTotalAmount);
            pnlUserInfo.Controls.Add(label9);
            pnlUserInfo.Controls.Add(label13);
            pnlUserInfo.Controls.Add(lblDisabledCount);
            pnlUserInfo.Controls.Add(label11);
            pnlUserInfo.Controls.Add(lblAdultCount);
            pnlUserInfo.Controls.Add(label8);
            pnlUserInfo.Controls.Add(lblUserID);
            pnlUserInfo.Controls.Add(label12);
            pnlUserInfo.Controls.Add(lblPaymentStatus);
            pnlUserInfo.Controls.Add(CityTo);
            pnlUserInfo.Controls.Add(lblCreatedAt);
            pnlUserInfo.Controls.Add(label16);
            pnlUserInfo.Controls.Add(lblChildCount);
            pnlUserInfo.Controls.Add(lblPassengerCount);
            pnlUserInfo.Controls.Add(word);
            pnlUserInfo.Controls.Add(lblTravelDate);
            pnlUserInfo.Controls.Add(label10);
            pnlUserInfo.Controls.Add(lblCustomerID);
            pnlUserInfo.Controls.Add(label7);
            pnlUserInfo.Controls.Add(lblTripID);
            pnlUserInfo.Controls.Add(lblClass);
            pnlUserInfo.Controls.Add(lblTripType);
            pnlUserInfo.Controls.Add(l);
            pnlUserInfo.Controls.Add(label5);
            pnlUserInfo.Controls.Add(label4);
            pnlUserInfo.Controls.Add(panel2);
            pnlUserInfo.Dock = DockStyle.Right;
            pnlUserInfo.Location = new Point(1142, 0);
            pnlUserInfo.Margin = new Padding(3, 2, 3, 2);
            pnlUserInfo.Name = "pnlUserInfo";
            pnlUserInfo.Size = new Size(307, 651);
            pnlUserInfo.TabIndex = 0;
            pnlUserInfo.Visible = false;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.DarkGray;
            lblTotalAmount.Location = new Point(242, 129);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(16, 21);
            lblTotalAmount.TabIndex = 47;
            lblTotalAmount.Text = "..";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(115, 129);
            label9.Name = "label9";
            label9.Size = new Size(109, 21);
            label9.TabIndex = 46;
            label9.Text = "Total Amount :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkGray;
            label13.Location = new Point(5, 422);
            label13.Name = "label13";
            label13.Size = new Size(99, 21);
            label13.TabIndex = 45;
            label13.Text = "Child Count :";
            // 
            // lblDisabledCount
            // 
            lblDisabledCount.AutoSize = true;
            lblDisabledCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisabledCount.ForeColor = Color.DarkGray;
            lblDisabledCount.Location = new Point(153, 470);
            lblDisabledCount.Name = "lblDisabledCount";
            lblDisabledCount.Size = new Size(16, 21);
            lblDisabledCount.TabIndex = 44;
            lblDisabledCount.Text = "..";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkGray;
            label11.Location = new Point(5, 470);
            label11.Name = "label11";
            label11.Size = new Size(123, 21);
            label11.TabIndex = 43;
            label11.Text = "Disabled Count :";
            // 
            // lblAdultCount
            // 
            lblAdultCount.AutoSize = true;
            lblAdultCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdultCount.ForeColor = Color.DarkGray;
            lblAdultCount.Location = new Point(153, 373);
            lblAdultCount.Name = "lblAdultCount";
            lblAdultCount.Size = new Size(16, 21);
            lblAdultCount.TabIndex = 42;
            lblAdultCount.Text = "..";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(5, 373);
            label8.Name = "label8";
            label8.Size = new Size(100, 21);
            label8.TabIndex = 41;
            label8.Text = "Adult Count :";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.DarkGray;
            lblUserID.Location = new Point(153, 616);
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
            label12.Location = new Point(5, 616);
            label12.Name = "label12";
            label12.Size = new Size(64, 21);
            label12.TabIndex = 39;
            label12.Text = "UserID :";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentStatus.ForeColor = Color.DarkGray;
            lblPaymentStatus.Location = new Point(153, 519);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(16, 21);
            lblPaymentStatus.TabIndex = 38;
            lblPaymentStatus.Text = "..";
            // 
            // CityTo
            // 
            CityTo.AutoSize = true;
            CityTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CityTo.ForeColor = Color.DarkGray;
            CityTo.Location = new Point(5, 519);
            CityTo.Name = "CityTo";
            CityTo.Size = new Size(123, 21);
            CityTo.TabIndex = 37;
            CityTo.Text = "Payment Status :";
            // 
            // lblCreatedAt
            // 
            lblCreatedAt.AutoSize = true;
            lblCreatedAt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedAt.ForeColor = Color.DarkGray;
            lblCreatedAt.Location = new Point(153, 568);
            lblCreatedAt.Name = "lblCreatedAt";
            lblCreatedAt.Size = new Size(16, 21);
            lblCreatedAt.TabIndex = 36;
            lblCreatedAt.Text = "..";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DarkGray;
            label16.Location = new Point(5, 568);
            label16.Name = "label16";
            label16.Size = new Size(90, 21);
            label16.TabIndex = 35;
            label16.Text = "Created At :";
            // 
            // lblChildCount
            // 
            lblChildCount.AutoSize = true;
            lblChildCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChildCount.ForeColor = Color.DarkGray;
            lblChildCount.Location = new Point(153, 422);
            lblChildCount.Name = "lblChildCount";
            lblChildCount.Size = new Size(16, 21);
            lblChildCount.TabIndex = 34;
            lblChildCount.Text = "..";
            // 
            // lblPassengerCount
            // 
            lblPassengerCount.AutoSize = true;
            lblPassengerCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassengerCount.ForeColor = Color.DarkGray;
            lblPassengerCount.Location = new Point(153, 324);
            lblPassengerCount.Name = "lblPassengerCount";
            lblPassengerCount.Size = new Size(16, 21);
            lblPassengerCount.TabIndex = 32;
            lblPassengerCount.Text = "..";
            // 
            // word
            // 
            word.AutoSize = true;
            word.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            word.ForeColor = Color.DarkGray;
            word.Location = new Point(5, 324);
            word.Name = "word";
            word.Size = new Size(133, 21);
            word.TabIndex = 31;
            word.Text = "Passenger Count :";
            // 
            // lblTravelDate
            // 
            lblTravelDate.AutoSize = true;
            lblTravelDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTravelDate.ForeColor = Color.DarkGray;
            lblTravelDate.Location = new Point(153, 275);
            lblTravelDate.Name = "lblTravelDate";
            lblTravelDate.Size = new Size(16, 21);
            lblTravelDate.TabIndex = 30;
            lblTravelDate.Text = "..";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(5, 275);
            label10.Name = "label10";
            label10.Size = new Size(94, 21);
            label10.TabIndex = 29;
            label10.Text = "Travel Date :";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerID.ForeColor = Color.DarkGray;
            lblCustomerID.Location = new Point(153, 226);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(16, 21);
            lblCustomerID.TabIndex = 28;
            lblCustomerID.Text = "..";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(5, 226);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 27;
            label7.Text = "Customer ID :";
            // 
            // lblTripID
            // 
            lblTripID.AutoSize = true;
            lblTripID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTripID.ForeColor = Color.DarkGray;
            lblTripID.Location = new Point(153, 178);
            lblTripID.Name = "lblTripID";
            lblTripID.Size = new Size(16, 21);
            lblTripID.TabIndex = 26;
            lblTripID.Text = "..";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClass.ForeColor = Color.DarkGray;
            lblClass.Location = new Point(57, 129);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(16, 21);
            lblClass.TabIndex = 25;
            lblClass.Text = "..";
            // 
            // lblTripType
            // 
            lblTripType.AutoSize = true;
            lblTripType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTripType.ForeColor = Color.DarkGray;
            lblTripType.Location = new Point(153, 80);
            lblTripType.Name = "lblTripType";
            lblTripType.Size = new Size(16, 21);
            lblTripType.TabIndex = 24;
            lblTripType.Text = "..";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l.ForeColor = Color.DarkGray;
            l.Location = new Point(5, 178);
            l.Name = "l";
            l.Size = new Size(62, 21);
            l.TabIndex = 23;
            l.Text = "Trip ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(5, 129);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 22;
            label5.Text = "Class :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(5, 80);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 21;
            label4.Text = "Travel Type :";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(307, 59);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 1;
            label3.Text = "Book Info";
            // 
            // frmmanageBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlUserListAndInfo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmmanageBookings";
            Text = "frmmanageBookings";
            Load += frmmanageBookings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUserListAndInfo.ResumeLayout(false);
            pnlUserLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookingsList).EndInit();
            pnlUserListTitle.ResumeLayout(false);
            pnlUserListTitle.PerformLayout();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Custom_Controls.CustomButton btnSearch;
        private Custom_Controls.CustomComboBox cbFilterBy;
        private Label label1;
        private Panel pnlUserListAndInfo;
        private Panel pnlUserLIst;
        private DataGridView dgvBookingsList;
        private Panel pnlUserListTitle;
        private Label label2;
        private Panel pnlUserInfo;
        private Label lblUserID;
        private Label label12;
        private Label lblPaymentStatus;
        private Label CityTo;
        private Label lblCreatedAt;
        private Label label16;
        private Label lblChildCount;
        private Label lblPassengerCount;
        private Label word;
        private Label lblTravelDate;
        private Label label10;
        private Label lblCustomerID;
        private Label label7;
        private Label lblTripID;
        private Label lblClass;
        private Label lblTripType;
        private Label l;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Label label13;
        private Label lblDisabledCount;
        private Label label11;
        private Label lblAdultCount;
        private Label label8;
        private Label lblTotalAmount;
        private Label label9;
        private Custom_Controls.CustomTextBox txtSearchFor;
    }
}