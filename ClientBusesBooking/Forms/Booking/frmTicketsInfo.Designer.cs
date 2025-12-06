namespace ClientBusesBooking.Forms.Booking
{
    partial class frmTicketsInfo
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
            pnlTicketsMain = new Panel();
            ticketInfouc1 = new TicketInfoUC();
            btnConfirmTheBook = new AdminBusesBooking.Custom_Controls.CustomButton();
            pnlTicketsMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTicketsMain
            // 
            pnlTicketsMain.AutoScroll = true;
            pnlTicketsMain.Controls.Add(ticketInfouc1);
            pnlTicketsMain.Dock = DockStyle.Top;
            pnlTicketsMain.Location = new Point(0, 0);
            pnlTicketsMain.Name = "pnlTicketsMain";
            pnlTicketsMain.Size = new Size(394, 666);
            pnlTicketsMain.TabIndex = 1;
            // 
            // ticketInfouc1
            // 
            ticketInfouc1.BackColor = Color.FromArgb(35, 45, 55);
            ticketInfouc1.Location = new Point(5, 3);
            ticketInfouc1.Name = "ticketInfouc1";
            ticketInfouc1.Size = new Size(386, 354);
            ticketInfouc1.TabIndex = 0;
            // 
            // btnConfirmTheBook
            // 
            btnConfirmTheBook.BackColor = Color.CornflowerBlue;
            btnConfirmTheBook.BackgroundColor = Color.CornflowerBlue;
            btnConfirmTheBook.BorderColor = Color.PaleVioletRed;
            btnConfirmTheBook.BorderRadius = 20;
            btnConfirmTheBook.BorderSize = 0;
            btnConfirmTheBook.FlatAppearance.BorderSize = 0;
            btnConfirmTheBook.FlatStyle = FlatStyle.Flat;
            btnConfirmTheBook.Font = new Font("Segoe UI", 15F);
            btnConfirmTheBook.ForeColor = Color.White;
            btnConfirmTheBook.Location = new Point(117, 705);
            btnConfirmTheBook.Name = "btnConfirmTheBook";
            btnConfirmTheBook.Size = new Size(161, 55);
            btnConfirmTheBook.TabIndex = 2;
            btnConfirmTheBook.Text = "Confirm Book";
            btnConfirmTheBook.TextColor = Color.White;
            btnConfirmTheBook.UseVisualStyleBackColor = false;
            btnConfirmTheBook.Click += btnConfirmTheBook_Click;
            // 
            // frmTicketsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 45, 55);
            ClientSize = new Size(394, 817);
            Controls.Add(btnConfirmTheBook);
            Controls.Add(pnlTicketsMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTicketsInfo";
            Text = "frmTicketsInfo";
            Load += frmTicketsInfo_Load;
            pnlTicketsMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTicketsMain;
        private TicketInfoUC ticketInfouc1;
        private AdminBusesBooking.Custom_Controls.CustomButton btnConfirmTheBook;
    }
}