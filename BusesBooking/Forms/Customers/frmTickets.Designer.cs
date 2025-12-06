namespace AdminBusesBooking.Forms.Customers
{
    partial class frmTickets
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
            dgvTicketsList = new DataGridView();
            pnlUserListTitle = new Panel();
            label2 = new Label();
            pnlUserInfo = new Panel();
            lblPersonType = new Label();
            label6 = new Label();
            lblNationalID = new Label();
            label11 = new Label();
            lblGender = new Label();
            label9 = new Label();
            lblPassengerName = new Label();
            label8 = new Label();
            lblBookingID = new Label();
            label10 = new Label();
            lblQrCode = new Label();
            label7 = new Label();
            lblSeatNumber = new Label();
            lblIssueDate = new Label();
            l = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            pnlUserListAndInfo.SuspendLayout();
            pnlUserLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTicketsList).BeginInit();
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
            panel1.TabIndex = 0;
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
            txtSearchFor.Texts = "Search For";
            txtSearchFor.UnderlinedStyle = true;
            txtSearchFor._TextChanged += txtSearchFor_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.Anchor = AnchorStyles.Top;
            cbFilterBy.BackColor = Color.MediumSlateBlue;
            cbFilterBy.BorderColor = Color.White;
            cbFilterBy.BorderSize = 0;
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Segoe UI", 20F);
            cbFilterBy.ForeColor = Color.WhiteSmoke;
            cbFilterBy.IconColor = Color.Gainsboro;
            cbFilterBy.Items.AddRange(new object[] { "Date", "BookingID", "Name", "NationalID" });
            cbFilterBy.ListBackColor = Color.FromArgb(230, 228, 245);
            cbFilterBy.ListTextColor = Color.DimGray;
            cbFilterBy.Location = new Point(121, 58);
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
            label1.Size = new Size(169, 32);
            label1.TabIndex = 2;
            label1.Text = "Tickets Search";
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
            pnlUserListAndInfo.TabIndex = 12;
            // 
            // pnlUserLIst
            // 
            pnlUserLIst.Controls.Add(dgvTicketsList);
            pnlUserLIst.Controls.Add(pnlUserListTitle);
            pnlUserLIst.Dock = DockStyle.Fill;
            pnlUserLIst.Location = new Point(0, 0);
            pnlUserLIst.Margin = new Padding(3, 2, 3, 2);
            pnlUserLIst.Name = "pnlUserLIst";
            pnlUserLIst.Size = new Size(1142, 651);
            pnlUserLIst.TabIndex = 1;
            // 
            // dgvTicketsList
            // 
            dgvTicketsList.AllowUserToAddRows = false;
            dgvTicketsList.AllowUserToDeleteRows = false;
            dgvTicketsList.AllowUserToOrderColumns = true;
            dgvTicketsList.BackgroundColor = Color.FromArgb(35, 40, 50);
            dgvTicketsList.BorderStyle = BorderStyle.None;
            dgvTicketsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTicketsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTicketsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicketsList.Dock = DockStyle.Fill;
            dgvTicketsList.Location = new Point(0, 59);
            dgvTicketsList.Margin = new Padding(3, 2, 3, 2);
            dgvTicketsList.Name = "dgvTicketsList";
            dgvTicketsList.ReadOnly = true;
            dgvTicketsList.RowHeadersWidth = 51;
            dgvTicketsList.Size = new Size(1142, 592);
            dgvTicketsList.TabIndex = 1;
            dgvTicketsList.DataBindingComplete += dgvTickets_DataBindingComplete;
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
            label2.Size = new Size(133, 32);
            label2.TabIndex = 1;
            label2.Text = "Tickets List";
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlUserInfo.Controls.Add(lblPersonType);
            pnlUserInfo.Controls.Add(label6);
            pnlUserInfo.Controls.Add(lblNationalID);
            pnlUserInfo.Controls.Add(label11);
            pnlUserInfo.Controls.Add(lblGender);
            pnlUserInfo.Controls.Add(label9);
            pnlUserInfo.Controls.Add(lblPassengerName);
            pnlUserInfo.Controls.Add(label8);
            pnlUserInfo.Controls.Add(lblBookingID);
            pnlUserInfo.Controls.Add(label10);
            pnlUserInfo.Controls.Add(lblQrCode);
            pnlUserInfo.Controls.Add(label7);
            pnlUserInfo.Controls.Add(lblSeatNumber);
            pnlUserInfo.Controls.Add(lblIssueDate);
            pnlUserInfo.Controls.Add(l);
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
            // lblPersonType
            // 
            lblPersonType.AutoSize = true;
            lblPersonType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonType.ForeColor = Color.DarkGray;
            lblPersonType.Location = new Point(123, 298);
            lblPersonType.Name = "lblPersonType";
            lblPersonType.Size = new Size(16, 21);
            lblPersonType.TabIndex = 38;
            lblPersonType.Text = "..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(5, 298);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 37;
            label6.Text = "Person Type :";
            // 
            // lblNationalID
            // 
            lblNationalID.AutoSize = true;
            lblNationalID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNationalID.ForeColor = Color.DarkGray;
            lblNationalID.Location = new Point(123, 229);
            lblNationalID.Name = "lblNationalID";
            lblNationalID.Size = new Size(16, 21);
            lblNationalID.TabIndex = 36;
            lblNationalID.Text = "..";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkGray;
            label11.Location = new Point(5, 229);
            label11.Name = "label11";
            label11.Size = new Size(95, 21);
            label11.TabIndex = 35;
            label11.Text = "National ID :";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.ForeColor = Color.DarkGray;
            lblGender.Location = new Point(87, 159);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(16, 21);
            lblGender.TabIndex = 34;
            lblGender.Text = "..";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGray;
            label9.Location = new Point(5, 159);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 33;
            label9.Text = "Gender :";
            // 
            // lblPassengerName
            // 
            lblPassengerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassengerName.ForeColor = Color.DarkGray;
            lblPassengerName.Location = new Point(154, 89);
            lblPassengerName.Name = "lblPassengerName";
            lblPassengerName.Size = new Size(150, 58);
            lblPassengerName.TabIndex = 32;
            lblPassengerName.Text = "..";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(5, 89);
            label8.Name = "label8";
            label8.Size = new Size(133, 21);
            label8.TabIndex = 31;
            label8.Text = "Passenger Name :";
            // 
            // lblBookingID
            // 
            lblBookingID.AutoSize = true;
            lblBookingID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingID.ForeColor = Color.DarkGray;
            lblBookingID.Location = new Point(123, 508);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(16, 21);
            lblBookingID.TabIndex = 30;
            lblBookingID.Text = "..";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(5, 508);
            label10.Name = "label10";
            label10.Size = new Size(89, 21);
            label10.TabIndex = 29;
            label10.Text = "BookingID :";
            // 
            // lblQrCode
            // 
            lblQrCode.AutoSize = true;
            lblQrCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQrCode.ForeColor = Color.DarkGray;
            lblQrCode.Location = new Point(123, 438);
            lblQrCode.Name = "lblQrCode";
            lblQrCode.Size = new Size(16, 21);
            lblQrCode.TabIndex = 28;
            lblQrCode.Text = "..";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(5, 438);
            label7.Name = "label7";
            label7.Size = new Size(75, 21);
            label7.TabIndex = 27;
            label7.Text = "QR Data :";
            // 
            // lblSeatNumber
            // 
            lblSeatNumber.AutoSize = true;
            lblSeatNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeatNumber.ForeColor = Color.DarkGray;
            lblSeatNumber.Location = new Point(123, 581);
            lblSeatNumber.Name = "lblSeatNumber";
            lblSeatNumber.Size = new Size(16, 21);
            lblSeatNumber.TabIndex = 26;
            lblSeatNumber.Text = "..";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIssueDate.ForeColor = Color.DarkGray;
            lblIssueDate.Location = new Point(123, 368);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(16, 21);
            lblIssueDate.TabIndex = 24;
            lblIssueDate.Text = "..";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l.ForeColor = Color.DarkGray;
            l.Location = new Point(5, 578);
            l.Name = "l";
            l.Size = new Size(105, 21);
            l.TabIndex = 23;
            l.Text = "SeatNumber :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(5, 368);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 21;
            label4.Text = "Issue Date :";
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
            label3.Size = new Size(129, 32);
            label3.TabIndex = 1;
            label3.Text = "Ticket Info";
            // 
            // frmTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlUserListAndInfo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmTickets";
            Text = "frmTickets";
            Load += frmTickets_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlUserListAndInfo.ResumeLayout(false);
            pnlUserLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTicketsList).EndInit();
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
        private Label label1;
        private Panel pnlUserListAndInfo;
        private Panel pnlUserLIst;
        private DataGridView dgvTicketsList;
        private Panel pnlUserListTitle;
        private Label label2;
        private Panel pnlUserInfo;
        private Label lblBookingID;
        private Label label10;
        private Label lblQrCode;
        private Label label7;
        private Label lblSeatNumber;
        private Label lblIssueDate;
        private Label l;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Custom_Controls.CustomComboBox cbFilterBy;
        public Custom_Controls.CustomTextBox txtSearchFor;
        private Custom_Controls.CustomButton btnSearch;
        private Label lblPassengerName;
        private Label label8;
        private Label lblGender;
        private Label label9;
        private Label lblNationalID;
        private Label label11;
        private Label lblPersonType;
        private Label label6;
    }
}