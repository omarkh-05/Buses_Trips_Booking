namespace ClientBusesBooking.Forms.Main_Page
{
    partial class MainPageUC
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
            pnlMainPage = new Panel();
            pnlButtons = new Panel();
            TlpButtons = new TableLayoutPanel();
            btnOfficesLocations = new FontAwesome.Sharp.IconButton();
            btnContactUs = new FontAwesome.Sharp.IconButton();
            btnTripsSchedule = new FontAwesome.Sharp.IconButton();
            btnBook = new FontAwesome.Sharp.IconButton();
            pnlImage = new Panel();
            pnlNavBar = new Panel();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnAboutUs = new FontAwesome.Sharp.IconButton();
            btnMrBusCredit = new FontAwesome.Sharp.IconButton();
            btnMyAccount = new FontAwesome.Sharp.IconButton();
            pnlMainPicLabel = new Panel();
            label2 = new Label();
            pbMainPic = new PictureBox();
            pnlMainPage.SuspendLayout();
            pnlButtons.SuspendLayout();
            TlpButtons.SuspendLayout();
            pnlImage.SuspendLayout();
            pnlNavBar.SuspendLayout();
            pnlMainPicLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainPic).BeginInit();
            SuspendLayout();
            // 
            // pnlMainPage
            // 
            pnlMainPage.Controls.Add(pnlButtons);
            pnlMainPage.Controls.Add(pnlImage);
            pnlMainPage.Dock = DockStyle.Fill;
            pnlMainPage.Location = new Point(0, 0);
            pnlMainPage.Name = "pnlMainPage";
            pnlMainPage.Size = new Size(394, 817);
            pnlMainPage.TabIndex = 2;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(TlpButtons);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(0, 385);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(394, 432);
            pnlButtons.TabIndex = 1;
            // 
            // TlpButtons
            // 
            TlpButtons.BackColor = Color.FromArgb(35, 40, 45);
            TlpButtons.ColumnCount = 2;
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TlpButtons.Controls.Add(btnOfficesLocations, 1, 1);
            TlpButtons.Controls.Add(btnContactUs, 0, 1);
            TlpButtons.Controls.Add(btnTripsSchedule, 1, 0);
            TlpButtons.Controls.Add(btnBook, 0, 0);
            TlpButtons.Dock = DockStyle.Fill;
            TlpButtons.Location = new Point(0, 0);
            TlpButtons.Name = "TlpButtons";
            TlpButtons.RowCount = 2;
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TlpButtons.Size = new Size(394, 432);
            TlpButtons.TabIndex = 0;
            // 
            // btnOfficesLocations
            // 
            btnOfficesLocations.BackColor = Color.Transparent;
            btnOfficesLocations.Cursor = Cursors.Hand;
            btnOfficesLocations.Dock = DockStyle.Fill;
            btnOfficesLocations.FlatAppearance.BorderColor = Color.Gray;
            btnOfficesLocations.FlatAppearance.BorderSize = 0;
            btnOfficesLocations.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnOfficesLocations.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnOfficesLocations.FlatStyle = FlatStyle.Flat;
            btnOfficesLocations.Font = new Font("Segoe UI Emoji", 15.75F);
            btnOfficesLocations.ForeColor = Color.LightGray;
            btnOfficesLocations.IconChar = FontAwesome.Sharp.IconChar.Building;
            btnOfficesLocations.IconColor = Color.DarkGray;
            btnOfficesLocations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOfficesLocations.IconSize = 128;
            btnOfficesLocations.Location = new Point(200, 219);
            btnOfficesLocations.Name = "btnOfficesLocations";
            btnOfficesLocations.Size = new Size(191, 210);
            btnOfficesLocations.TabIndex = 3;
            btnOfficesLocations.Text = "Offices Locations";
            btnOfficesLocations.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOfficesLocations.UseVisualStyleBackColor = false;
            btnOfficesLocations.Click += btnOfficesLocations_Click;
            // 
            // btnContactUs
            // 
            btnContactUs.BackColor = Color.Transparent;
            btnContactUs.Cursor = Cursors.Hand;
            btnContactUs.Dock = DockStyle.Fill;
            btnContactUs.FlatAppearance.BorderColor = Color.Gray;
            btnContactUs.FlatAppearance.BorderSize = 0;
            btnContactUs.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnContactUs.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnContactUs.FlatStyle = FlatStyle.Flat;
            btnContactUs.Font = new Font("Segoe UI Emoji", 15.75F);
            btnContactUs.ForeColor = Color.LightGray;
            btnContactUs.IconChar = FontAwesome.Sharp.IconChar.Phone;
            btnContactUs.IconColor = Color.DarkGray;
            btnContactUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnContactUs.IconSize = 128;
            btnContactUs.Location = new Point(3, 219);
            btnContactUs.Name = "btnContactUs";
            btnContactUs.Size = new Size(191, 210);
            btnContactUs.TabIndex = 2;
            btnContactUs.Text = "Contact Us";
            btnContactUs.TextImageRelation = TextImageRelation.ImageAboveText;
            btnContactUs.UseVisualStyleBackColor = false;
            btnContactUs.Click += btnContactUs_Click;
            // 
            // btnTripsSchedule
            // 
            btnTripsSchedule.BackColor = Color.Transparent;
            btnTripsSchedule.Cursor = Cursors.Hand;
            btnTripsSchedule.Dock = DockStyle.Fill;
            btnTripsSchedule.FlatAppearance.BorderColor = Color.Gray;
            btnTripsSchedule.FlatAppearance.BorderSize = 0;
            btnTripsSchedule.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnTripsSchedule.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnTripsSchedule.FlatStyle = FlatStyle.Flat;
            btnTripsSchedule.Font = new Font("Segoe UI Emoji", 15.75F);
            btnTripsSchedule.ForeColor = Color.LightGray;
            btnTripsSchedule.IconChar = FontAwesome.Sharp.IconChar.Route;
            btnTripsSchedule.IconColor = Color.DarkGray;
            btnTripsSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTripsSchedule.IconSize = 128;
            btnTripsSchedule.Location = new Point(200, 3);
            btnTripsSchedule.Name = "btnTripsSchedule";
            btnTripsSchedule.Size = new Size(191, 210);
            btnTripsSchedule.TabIndex = 1;
            btnTripsSchedule.Text = "Trips Schedule";
            btnTripsSchedule.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTripsSchedule.UseVisualStyleBackColor = false;
            btnTripsSchedule.Click += btnTripsSchedule_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Transparent;
            btnBook.Cursor = Cursors.Hand;
            btnBook.Dock = DockStyle.Fill;
            btnBook.FlatAppearance.BorderColor = Color.Gray;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnBook.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.LightGray;
            btnBook.IconChar = FontAwesome.Sharp.IconChar.BusSimple;
            btnBook.IconColor = Color.DarkGray;
            btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBook.IconSize = 128;
            btnBook.Location = new Point(3, 3);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(191, 210);
            btnBook.TabIndex = 0;
            btnBook.Text = "Book A Trip";
            btnBook.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBook.UseVisualStyleBackColor = false;
            // 
            // pnlImage
            // 
            pnlImage.Controls.Add(pnlNavBar);
            pnlImage.Controls.Add(pnlMainPicLabel);
            pnlImage.Controls.Add(pbMainPic);
            pnlImage.Dock = DockStyle.Top;
            pnlImage.Location = new Point(0, 0);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(394, 385);
            pnlImage.TabIndex = 0;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(35, 45, 55);
            pnlNavBar.Controls.Add(btnLogout);
            pnlNavBar.Controls.Add(btnAboutUs);
            pnlNavBar.Controls.Add(btnMrBusCredit);
            pnlNavBar.Controls.Add(btnMyAccount);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(394, 226);
            pnlNavBar.TabIndex = 3;
            pnlNavBar.Visible = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Silver;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnLogout.IconColor = Color.DarkGray;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.IconSize = 32;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 162);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(394, 54);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAboutUs
            // 
            btnAboutUs.BackColor = Color.Transparent;
            btnAboutUs.Dock = DockStyle.Top;
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnAboutUs.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAboutUs.ForeColor = Color.Silver;
            btnAboutUs.IconChar = FontAwesome.Sharp.IconChar.Info;
            btnAboutUs.IconColor = Color.DarkGray;
            btnAboutUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAboutUs.IconSize = 32;
            btnAboutUs.ImageAlign = ContentAlignment.MiddleLeft;
            btnAboutUs.Location = new Point(0, 108);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(394, 54);
            btnAboutUs.TabIndex = 2;
            btnAboutUs.Text = "About Us";
            btnAboutUs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAboutUs.UseVisualStyleBackColor = false;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // btnMrBusCredit
            // 
            btnMrBusCredit.BackColor = Color.Transparent;
            btnMrBusCredit.Dock = DockStyle.Top;
            btnMrBusCredit.FlatAppearance.BorderSize = 0;
            btnMrBusCredit.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnMrBusCredit.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnMrBusCredit.FlatStyle = FlatStyle.Flat;
            btnMrBusCredit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMrBusCredit.ForeColor = Color.Silver;
            btnMrBusCredit.IconChar = FontAwesome.Sharp.IconChar.CcDiscover;
            btnMrBusCredit.IconColor = Color.DarkGray;
            btnMrBusCredit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMrBusCredit.IconSize = 32;
            btnMrBusCredit.ImageAlign = ContentAlignment.MiddleLeft;
            btnMrBusCredit.Location = new Point(0, 54);
            btnMrBusCredit.Name = "btnMrBusCredit";
            btnMrBusCredit.Size = new Size(394, 54);
            btnMrBusCredit.TabIndex = 1;
            btnMrBusCredit.Text = "MrBus Credit";
            btnMrBusCredit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMrBusCredit.UseVisualStyleBackColor = false;
            btnMrBusCredit.Click += btnMrBusCredit_Click;
            // 
            // btnMyAccount
            // 
            btnMyAccount.BackColor = Color.Transparent;
            btnMyAccount.Dock = DockStyle.Top;
            btnMyAccount.FlatAppearance.BorderSize = 0;
            btnMyAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 40, 55);
            btnMyAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 40, 55);
            btnMyAccount.FlatStyle = FlatStyle.Flat;
            btnMyAccount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyAccount.ForeColor = Color.Silver;
            btnMyAccount.IconChar = FontAwesome.Sharp.IconChar.User;
            btnMyAccount.IconColor = Color.DarkGray;
            btnMyAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMyAccount.IconSize = 32;
            btnMyAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnMyAccount.Location = new Point(0, 0);
            btnMyAccount.Name = "btnMyAccount";
            btnMyAccount.Size = new Size(394, 54);
            btnMyAccount.TabIndex = 0;
            btnMyAccount.Text = "My Account";
            btnMyAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMyAccount.UseVisualStyleBackColor = false;
            btnMyAccount.Click += btnMyAccount_Click;
            // 
            // pnlMainPicLabel
            // 
            pnlMainPicLabel.BackColor = Color.White;
            pnlMainPicLabel.Controls.Add(label2);
            pnlMainPicLabel.Dock = DockStyle.Bottom;
            pnlMainPicLabel.Location = new Point(0, 320);
            pnlMainPicLabel.Name = "pnlMainPicLabel";
            pnlMainPicLabel.Size = new Size(394, 65);
            pnlMainPicLabel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 58.2F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(39, -13);
            label2.Name = "label2";
            label2.Size = new Size(331, 93);
            label2.TabIndex = 1;
            label2.Text = "MrBus ";
            // 
            // pbMainPic
            // 
            pbMainPic.BackColor = Color.White;
            pbMainPic.BackgroundImageLayout = ImageLayout.None;
            pbMainPic.Dock = DockStyle.Fill;
            pbMainPic.Image = Properties.Resources.busLogo;
            pbMainPic.Location = new Point(0, 0);
            pbMainPic.Name = "pbMainPic";
            pbMainPic.Size = new Size(394, 385);
            pbMainPic.SizeMode = PictureBoxSizeMode.CenterImage;
            pbMainPic.TabIndex = 0;
            pbMainPic.TabStop = false;
            // 
            // MainPageUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlMainPage);
            Name = "MainPageUC";
            Size = new Size(394, 817);
            pnlMainPage.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            TlpButtons.ResumeLayout(false);
            pnlImage.ResumeLayout(false);
            pnlNavBar.ResumeLayout(false);
            pnlMainPicLabel.ResumeLayout(false);
            pnlMainPicLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainPage;
        private Panel pnlButtons;
        private TableLayoutPanel TlpButtons;
        private FontAwesome.Sharp.IconButton btnOfficesLocations;
        private FontAwesome.Sharp.IconButton btnContactUs;
        private FontAwesome.Sharp.IconButton btnTripsSchedule;
        private FontAwesome.Sharp.IconButton btnBook;
        private Panel pnlImage;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnAboutUs;
        private FontAwesome.Sharp.IconButton btnMrBusCredit;
        private FontAwesome.Sharp.IconButton btnMyAccount;
        private Panel pnlMainPicLabel;
        private Label label2;
        private PictureBox pbMainPic;
        public Panel pnlNavBar;
    }
}
