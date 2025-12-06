namespace ClientBusesBooking.Forms.Customer
{
    partial class LoginUC
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
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new AdminBusesBooking.Custom_Controls.CustomButton();
            cbRememberMe = new AdminBusesBooking.Custom_Controls.CustomCheackBox();
            txtPassword = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            txtPhoneNumber = new AdminBusesBooking.Custom_Controls.CustomTextBox();
            label4 = new Label();
            llSignIn = new LinkLabel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
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
            iconPictureBox2.Location = new Point(336, 383);
            iconPictureBox2.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(37, 30);
            iconPictureBox2.TabIndex = 18;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.MouseEnter += iconPictureBox2_MouseEnter;
            iconPictureBox2.MouseLeave += iconPictureBox2_MouseLeave;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox3.BackColor = Color.FromArgb(35, 40, 50);
            iconPictureBox3.ForeColor = Color.Silver;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PhoneFlip;
            iconPictureBox3.IconColor = Color.Silver;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 30;
            iconPictureBox3.Location = new Point(336, 252);
            iconPictureBox3.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(37, 30);
            iconPictureBox3.TabIndex = 17;
            iconPictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(20, 349);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(20, 218);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 15;
            label2.Text = "Phone Number";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(66, 447);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 14;
            label1.Text = "RememberMe";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Bottom;
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.BackgroundColor = Color.RoyalBlue;
            btnLogin.BorderColor = Color.RoyalBlue;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(76, 538);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 48);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbRememberMe
            // 
            cbRememberMe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbRememberMe.AutoSize = true;
            cbRememberMe.BackColor = Color.Black;
            cbRememberMe.ForeColor = Color.FromArgb(224, 224, 224);
            cbRememberMe.Location = new Point(20, 447);
            cbRememberMe.Margin = new Padding(3, 2, 3, 2);
            cbRememberMe.MinimumSize = new Size(39, 16);
            cbRememberMe.Name = "cbRememberMe";
            cbRememberMe.OffBackColor = Color.DarkGray;
            cbRememberMe.OffToggleColor = Color.GhostWhite;
            cbRememberMe.OnBackColor = Color.FromArgb(255, 128, 0);
            cbRememberMe.OnToggleColor = Color.WhiteSmoke;
            cbRememberMe.Size = new Size(39, 16);
            cbRememberMe.TabIndex = 12;
            cbRememberMe.UseVisualStyleBackColor = false;
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
            txtPassword.Location = new Point(20, 374);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(6, 5, 6, 5);
            txtPassword.PasswordChar = true;
            txtPassword.Size = new Size(353, 49);
            txtPassword.TabIndex = 11;
            txtPassword.Text = "Password";
            txtPassword.Texts = "";
            txtPassword.UnderlinedStyle = true;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhoneNumber.BackColor = Color.FromArgb(35, 40, 50);
            txtPhoneNumber.BorderColor = Color.FromArgb(255, 128, 0);
            txtPhoneNumber.BorderFocusColor = Color.FromArgb(255, 128, 0);
            txtPhoneNumber.BorderSize = 2;
            txtPhoneNumber.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = Color.Silver;
            txtPhoneNumber.Location = new Point(20, 243);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Multiline = false;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Padding = new Padding(13, 5, 6, 5);
            txtPhoneNumber.PasswordChar = false;
            txtPhoneNumber.Size = new Size(353, 49);
            txtPhoneNumber.TabIndex = 10;
            txtPhoneNumber.Text = "User Name";
            txtPhoneNumber.Texts = "";
            txtPhoneNumber.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(109, 622);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 19;
            label4.Text = "New To MrBus? ";
            // 
            // llSignIn
            // 
            llSignIn.AutoSize = true;
            llSignIn.BackColor = Color.Transparent;
            llSignIn.Font = new Font("Segoe UI", 10.8F);
            llSignIn.LinkColor = Color.FromArgb(255, 128, 0);
            llSignIn.Location = new Point(218, 622);
            llSignIn.Name = "llSignIn";
            llSignIn.Size = new Size(57, 20);
            llSignIn.TabIndex = 20;
            llSignIn.TabStop = true;
            llSignIn.Text = "SignUp";
            llSignIn.VisitedLinkColor = Color.FromArgb(128, 64, 0);
            llSignIn.LinkClicked += llSignIn_LinkClicked;
            // 
            // label5
            // 
            label5.AllowDrop = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 40F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(15, 18);
            label5.Name = "label5";
            label5.Size = new Size(372, 140);
            label5.TabIndex = 21;
            label5.Text = "Welcom Back \r\n   Customer !";
            // 
            // LoginUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoginBack2;
            Controls.Add(label5);
            Controls.Add(llSignIn);
            Controls.Add(label4);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(cbRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneNumber);
            Name = "LoginUC";
            Size = new Size(394, 817);
            Load += LoginUC_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private AdminBusesBooking.Custom_Controls.CustomButton btnLogin;
        private AdminBusesBooking.Custom_Controls.CustomCheackBox cbRememberMe;
        private AdminBusesBooking.Custom_Controls.CustomTextBox txtPassword;
        private AdminBusesBooking.Custom_Controls.CustomTextBox txtPhoneNumber;
        private Label label4;
        private LinkLabel llSignIn;
        private Label label5;
    }
}
