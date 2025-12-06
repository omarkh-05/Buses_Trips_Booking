namespace ClientBusesBooking.Forms.Trip
{
    partial class AlLTrips
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTripsList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTripsList).BeginInit();
            SuspendLayout();
            // 
            // dgvTripsList
            // 
            dgvTripsList.AllowUserToAddRows = false;
            dgvTripsList.AllowUserToDeleteRows = false;
            dgvTripsList.AllowUserToOrderColumns = true;
            dgvTripsList.BackgroundColor = Color.FromArgb(35, 45, 55);
            dgvTripsList.BorderStyle = BorderStyle.None;
            dgvTripsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTripsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvTripsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTripsList.Dock = DockStyle.Fill;
            dgvTripsList.Location = new Point(0, 0);
            dgvTripsList.Name = "dgvTripsList";
            dgvTripsList.ReadOnly = true;
            dgvTripsList.Size = new Size(394, 817);
            dgvTripsList.TabIndex = 0;
            // 
            // AlLTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 45, 55);
            Controls.Add(dgvTripsList);
            Name = "AlLTrips";
            Size = new Size(394, 817);
            ((System.ComponentModel.ISupportInitialize)dgvTripsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTripsList;
    }
}
