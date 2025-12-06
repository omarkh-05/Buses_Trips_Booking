namespace AdminBusesBooking.Forms.Users
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            pnlLogin = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new AdminBusesBooking.Custom_Controls.CustomButton();
            cbRememberMe = new AdminBusesBooking.Custom_Controls.CustomCheackBox();
            txtPassword = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            txtUserName = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(4, 23, 35);
            iconPictureBox1.BackgroundImage = Properties.Resources.LoginBack2;
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 775;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(1449, 775);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlLogin.BackColor = Color.FromArgb(35, 40, 50);
            pnlLogin.Controls.Add(iconPictureBox2);
            pnlLogin.Controls.Add(iconPictureBox3);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(cbRememberMe);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUserName);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Location = new Point(354, 129);
            pnlLogin.Margin = new Padding(3, 2, 3, 2);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(724, 520);
            pnlLogin.TabIndex = 2;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox2.BackColor = Color.FromArgb(35, 40, 50);
            iconPictureBox2.ForeColor = Color.DarkGray;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.DarkGray;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(500, 308);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(37, 30);
            iconPictureBox2.TabIndex = 9;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.MouseEnter += iconPictureBox2_MouseEnter;
            iconPictureBox2.MouseLeave += iconPictureBox2_MouseLeave;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox3.BackColor = Color.FromArgb(35, 40, 50);
            iconPictureBox3.ForeColor = Color.Silver;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox3.IconColor = Color.Silver;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(500, 188);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(37, 30);
            iconPictureBox3.TabIndex = 8;
            iconPictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(194, 273);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(194, 151);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 6;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(240, 371);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "RememberMe";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.BackgroundColor = Color.RoyalBlue;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(240, 446);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbRememberMe
            // 
            cbRememberMe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbRememberMe.AutoSize = true;
            cbRememberMe.ForeColor = Color.FromArgb(224, 224, 224);
            cbRememberMe.Location = new Point(194, 371);
            cbRememberMe.Margin = new Padding(3, 2, 3, 2);
            cbRememberMe.MinimumSize = new Size(39, 16);
            cbRememberMe.Name = "cbRememberMe";
            cbRememberMe.OffBackColor = Color.DarkGray;
            cbRememberMe.OffToggleColor = Color.GhostWhite;
            cbRememberMe.OnBackColor = Color.FromArgb(255, 128, 0);
            cbRememberMe.OnToggleColor = Color.WhiteSmoke;
            cbRememberMe.Size = new Size(39, 16);
            cbRememberMe.TabIndex = 3;
            cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = Color.FromArgb(35, 40, 50);
            txtPassword.BorderColor = Color.FromArgb(255, 128, 0);
            txtPassword.BorderFocusColor = Color.Red;
            txtPassword.BorderSize = 2;
            txtPassword.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Silver;
            txtPassword.Location = new Point(194, 298);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(6, 5, 6, 5);
            txtPassword.PasswordChar = true;
            txtPassword.Size = new Size(353, 49);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password";
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = true;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BackColor = Color.FromArgb(35, 40, 50);
            txtUserName.BorderColor = Color.FromArgb(255, 128, 0);
            txtUserName.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtUserName.BorderSize = 2;
            txtUserName.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Silver;
            txtUserName.Location = new Point(194, 176);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Multiline = false;
            txtUserName.Name = "txtUserName";
            txtUserName.Padding = new Padding(13, 5, 6, 5);
            txtUserName.PasswordChar = false;
            txtUserName.Size = new Size(353, 49);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "User Name";
            txtUserName.Texts = "";
            txtUserName.UnderlinedStyle = true;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI", 50F);
            lblLogin.ForeColor = Color.Chocolate;
            lblLogin.Location = new Point(248, 16);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(233, 89);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // frmLoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 23, 35);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1449, 775);
            Controls.Add(pnlLogin);
            Controls.Add(iconPictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLoginPage";
            Text = "frmLoginPage";
            WindowState = FormWindowState.Maximized;
            Load += frmLoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel pnlLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Custom_Controls.CustomButton btnLogin;
        private Custom_Controls.CustomCheackBox cbRememberMe;
        private Custom_Controls.CustomTextBox txtPassword;
        private Custom_Controls.CustomTextBox txtUserName;
        private Label lblLogin;
    }
}