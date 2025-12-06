namespace ClientBusesBooking.Forms.Customer
{
    partial class frmLoginPage
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
            pnlTopNav = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnNav = new FontAwesome.Sharp.IconButton();
            pnlMainPage = new Panel();
            pnlTopNav.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopNav
            // 
            pnlTopNav.BackColor = Color.FromArgb(24, 34, 54);
            pnlTopNav.Controls.Add(btnClose);
            pnlTopNav.Controls.Add(label1);
            pnlTopNav.Controls.Add(btnNav);
            pnlTopNav.Dock = DockStyle.Top;
            pnlTopNav.Location = new Point(0, 0);
            pnlTopNav.Name = "pnlTopNav";
            pnlTopNav.Size = new Size(394, 53);
            pnlTopNav.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnClose.IconColor = Color.DarkGray;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 32;
            btnClose.Location = new Point(345, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 32);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // btnNav
            // 
            btnNav.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNav.BackColor = Color.Transparent;
            btnNav.Cursor = Cursors.Hand;
            btnNav.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btnNav.FlatAppearance.BorderSize = 0;
            btnNav.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnNav.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnNav.FlatStyle = FlatStyle.Flat;
            btnNav.ForeColor = Color.White;
            btnNav.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnNav.IconColor = Color.FromArgb(224, 224, 224);
            btnNav.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNav.IconSize = 32;
            btnNav.Location = new Point(536, 10);
            btnNav.Name = "btnNav";
            btnNav.Size = new Size(49, 33);
            btnNav.TabIndex = 0;
            btnNav.UseVisualStyleBackColor = false;
            // 
            // pnlMainPage
            // 
            pnlMainPage.BackColor = Color.FromArgb(35, 40, 45);
            pnlMainPage.Dock = DockStyle.Fill;
            pnlMainPage.Location = new Point(0, 53);
            pnlMainPage.Name = "pnlMainPage";
            pnlMainPage.Size = new Size(394, 817);
            pnlMainPage.TabIndex = 2;
            // 
            // frmLoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 870);
            Controls.Add(pnlMainPage);
            Controls.Add(pnlTopNav);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoginPage";
            Load += frmLoginPage_Load;
            pnlTopNav.ResumeLayout(false);
            pnlTopNav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTopNav;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnNav;
        private FontAwesome.Sharp.IconButton btnClose;
        public Panel pnlMainPage;
    }
}