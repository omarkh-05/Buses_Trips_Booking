namespace ClientBusesBooking.Forms.Booking
{
    partial class frmChairs
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
            pnlChairsMain = new Panel();
            btnContinue = new AdminBusesBooking.Custom_Controls.CustomButton();
            bigBusSeatsuc1 = new BigBusSeatsUC();
            pnlChairsMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChairsMain
            // 
            pnlChairsMain.Controls.Add(btnContinue);
            pnlChairsMain.Controls.Add(bigBusSeatsuc1);
            pnlChairsMain.Dock = DockStyle.Fill;
            pnlChairsMain.Location = new Point(0, 0);
            pnlChairsMain.Name = "pnlChairsMain";
            pnlChairsMain.Size = new Size(411, 817);
            pnlChairsMain.TabIndex = 0;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.CornflowerBlue;
            btnContinue.BackgroundColor = Color.CornflowerBlue;
            btnContinue.BorderColor = Color.PaleVioletRed;
            btnContinue.BorderRadius = 20;
            btnContinue.BorderSize = 0;
            btnContinue.FlatAppearance.BorderSize = 0;
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.Font = new Font("Segoe UI", 15F);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(111, 725);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(161, 55);
            btnContinue.TabIndex = 1;
            btnContinue.Text = "Continue";
            btnContinue.TextColor = Color.White;
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // bigBusSeatsuc1
            // 
            bigBusSeatsuc1.AutoScroll = true;
            bigBusSeatsuc1.BackColor = Color.FromArgb(35, 45, 55);
            bigBusSeatsuc1.Location = new Point(0, 0);
            bigBusSeatsuc1.Name = "bigBusSeatsuc1";
            bigBusSeatsuc1.Size = new Size(408, 706);
            bigBusSeatsuc1.TabIndex = 0;
            // 
            // frmChairs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 45, 55);
            ClientSize = new Size(411, 817);
            Controls.Add(pnlChairsMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChairs";
            Text = "Chairs";
            pnlChairsMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChairsMain;
        private BigBusSeatsUC bigBusSeatsuc1;
        private AdminBusesBooking.Custom_Controls.CustomButton btnContinue;
    }
}