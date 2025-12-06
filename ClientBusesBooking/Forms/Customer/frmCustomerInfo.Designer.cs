namespace ClientBusesBooking.Forms.Customer
{
    partial class frmCustomerInfo
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
            dgvCustomerBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerBooks
            // 
            dgvCustomerBooks.AllowUserToAddRows = false;
            dgvCustomerBooks.AllowUserToDeleteRows = false;
            dgvCustomerBooks.AllowUserToOrderColumns = true;
            dgvCustomerBooks.BackgroundColor = Color.FromArgb(35, 45, 55);
            dgvCustomerBooks.BorderStyle = BorderStyle.None;
            dgvCustomerBooks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCustomerBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCustomerBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerBooks.Dock = DockStyle.Fill;
            dgvCustomerBooks.Location = new Point(0, 0);
            dgvCustomerBooks.Name = "dgvCustomerBooks";
            dgvCustomerBooks.ReadOnly = true;
            dgvCustomerBooks.Size = new Size(394, 817);
            dgvCustomerBooks.TabIndex = 2;
            dgvCustomerBooks.DataBindingComplete += dgvTripsList_DataBindingComplete;
            // 
            // frmCustomerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 45, 55);
            ClientSize = new Size(394, 817);
            Controls.Add(dgvCustomerBooks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomerInfo";
            Text = "CustomerInfo";
            Load += frmCustomerInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomerBooks;
    }
}