namespace AdminBusesBooking.Forms.Customers
{
    partial class frmPayments
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
            pnlUserListAndInfo = new Panel();
            pnlUserLIst = new Panel();
            dgvPaymentsList = new DataGridView();
            pnlUserListTitle = new Panel();
            label2 = new Label();
            pnlUserInfo = new Panel();
            lblBookingID = new Label();
            label8 = new Label();
            lblAmount = new Label();
            label10 = new Label();
            lblIsRefunded = new Label();
            label7 = new Label();
            lblPaymentMethod = new Label();
            lblPaymentDate = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            btnSearch = new AdminBusesBooking.Custom_Controls.CustomButton();
            txtSearchFor = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            cbFilterBy = new AdminBusesBooking.Custom_Controls.CustomComboBox();
            label1 = new Label();
            pnlUserListAndInfo.SuspendLayout();
            pnlUserLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentsList).BeginInit();
            pnlUserListTitle.SuspendLayout();
            pnlUserInfo.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            pnlUserListAndInfo.TabIndex = 14;
            // 
            // pnlUserLIst
            // 
            pnlUserLIst.Controls.Add(dgvPaymentsList);
            pnlUserLIst.Controls.Add(pnlUserListTitle);
            pnlUserLIst.Dock = DockStyle.Fill;
            pnlUserLIst.Location = new Point(0, 0);
            pnlUserLIst.Margin = new Padding(3, 2, 3, 2);
            pnlUserLIst.Name = "pnlUserLIst";
            pnlUserLIst.Size = new Size(1142, 651);
            pnlUserLIst.TabIndex = 1;
            // 
            // dgvPaymentsList
            // 
            dgvPaymentsList.AllowUserToAddRows = false;
            dgvPaymentsList.AllowUserToDeleteRows = false;
            dgvPaymentsList.AllowUserToOrderColumns = true;
            dgvPaymentsList.BackgroundColor = Color.FromArgb(35, 40, 50);
            dgvPaymentsList.BorderStyle = BorderStyle.None;
            dgvPaymentsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPaymentsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPaymentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaymentsList.Dock = DockStyle.Fill;
            dgvPaymentsList.Location = new Point(0, 59);
            dgvPaymentsList.Margin = new Padding(3, 2, 3, 2);
            dgvPaymentsList.Name = "dgvPaymentsList";
            dgvPaymentsList.ReadOnly = true;
            dgvPaymentsList.RowHeadersWidth = 51;
            dgvPaymentsList.Size = new Size(1142, 592);
            dgvPaymentsList.TabIndex = 1;
            dgvPaymentsList.DataBindingComplete += dgvCustomerInfo_DataBindingComplete;
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
            label2.Size = new Size(163, 32);
            label2.TabIndex = 1;
            label2.Text = "Payments List";
            // 
            // pnlUserInfo
            // 
            pnlUserInfo.BackColor = Color.FromArgb(35, 40, 45);
            pnlUserInfo.Controls.Add(lblBookingID);
            pnlUserInfo.Controls.Add(label8);
            pnlUserInfo.Controls.Add(lblAmount);
            pnlUserInfo.Controls.Add(label10);
            pnlUserInfo.Controls.Add(lblIsRefunded);
            pnlUserInfo.Controls.Add(label7);
            pnlUserInfo.Controls.Add(lblPaymentMethod);
            pnlUserInfo.Controls.Add(lblPaymentDate);
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
            // lblBookingID
            // 
            lblBookingID.AutoSize = true;
            lblBookingID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookingID.ForeColor = Color.DarkGray;
            lblBookingID.Location = new Point(160, 470);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(16, 21);
            lblBookingID.TabIndex = 32;
            lblBookingID.Text = "..";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGray;
            label8.Location = new Point(5, 470);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 31;
            label8.Text = "BookingID :";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.ForeColor = Color.DarkGray;
            lblAmount.Location = new Point(160, 381);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(16, 21);
            lblAmount.TabIndex = 30;
            lblAmount.Text = "..";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkGray;
            label10.Location = new Point(5, 381);
            label10.Name = "label10";
            label10.Size = new Size(73, 21);
            label10.TabIndex = 29;
            label10.Text = "Amount :";
            // 
            // lblIsRefunded
            // 
            lblIsRefunded.AutoSize = true;
            lblIsRefunded.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIsRefunded.ForeColor = Color.DarkGray;
            lblIsRefunded.Location = new Point(160, 292);
            lblIsRefunded.Name = "lblIsRefunded";
            lblIsRefunded.Size = new Size(16, 21);
            lblIsRefunded.TabIndex = 28;
            lblIsRefunded.Text = "..";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(5, 292);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 27;
            label7.Text = "Is Refunded :";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentMethod.ForeColor = Color.DarkGray;
            lblPaymentMethod.Location = new Point(160, 202);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(16, 21);
            lblPaymentMethod.TabIndex = 25;
            lblPaymentMethod.Text = "..";
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaymentDate.ForeColor = Color.DarkGray;
            lblPaymentDate.Location = new Point(160, 113);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(16, 21);
            lblPaymentDate.TabIndex = 24;
            lblPaymentDate.Text = "..";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(5, 202);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 22;
            label5.Text = "Payment Method :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(5, 113);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 21;
            label4.Text = "Payment Date :";
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
            label3.Size = new Size(169, 32);
            label3.TabIndex = 1;
            label3.Text = "Payments Info";
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
            panel1.TabIndex = 13;
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
            cbFilterBy.Items.AddRange(new object[] { "Date", "Amount", "BookingID", "Refund" });
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
            label1.Size = new Size(199, 32);
            label1.TabIndex = 2;
            label1.Text = "Payments Search";
            // 
            // frmPayments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 50);
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlUserListAndInfo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPayments";
            Text = "frmPayments";
            Load += frmPayments_Load;
            pnlUserListAndInfo.ResumeLayout(false);
            pnlUserLIst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPaymentsList).EndInit();
            pnlUserListTitle.ResumeLayout(false);
            pnlUserListTitle.PerformLayout();
            pnlUserInfo.ResumeLayout(false);
            pnlUserInfo.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUserListAndInfo;
        private Panel pnlUserLIst;
        private DataGridView dgvPaymentsList;
        private Panel pnlUserListTitle;
        private Label label2;
        private Panel pnlUserInfo;
        private Label lblAmount;
        private Label label10;
        private Label lblIsRefunded;
        private Label label7;
        private Label lblPaymentMethod;
        private Label lblPaymentDate;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private Custom_Controls.CustomButton btnSearch;
        public Custom_Controls.CustomTextBox txtSearchFor;
        private Custom_Controls.CustomComboBox cbFilterBy;
        private Label label1;
        private Label lblBookingID;
        private Label label8;
    }
}