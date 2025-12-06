using BussinessLayer;
using DataLayer;
using Microsoft.VisualBasic.ApplicationServices;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using BusesBooking;
using AdminBusesBooking.Custom_Controls;

namespace AdminBusesBooking.Forms.Users
{
    public partial class frmLoginPage : Form
    {
        private UsersBLL _usersBussinessObject;
        private ModelsLayer.Users _user;
        IConfiguration? _configuration;
        private MainMenu main;

        public frmLoginPage(MainMenu mainMenu)
        {
            InitializeComponent();
            this.main = mainMenu;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {
            string savedUsername = "", savedPassword = "";
            UserSession.GetStoredCredential(ref savedUsername, ref savedPassword);
            if (!string.IsNullOrEmpty(savedUsername))
            {
                txtUserName.Texts = savedUsername;
                txtPassword.Texts = savedPassword;
                cbRememberMe.Checked = true;
            }
        }

        private void iconPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = false;
        }

        private void iconPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
                Cursor = Cursors.WaitCursor;

                if (cbRememberMe.Checked)
                    UserSession.RememberUsernameAndPassword(txtUserName.Texts.Trim(), txtPassword.Texts.Trim());
                else
                    UserSession.RememberUsernameAndPassword("", "");

                if (await _CheackLoginInfo())
                {
                    FileLogger.Log($"LOGIN SUCCESS → User: {txtUserName.Texts.Trim()}");

                    // حفظ جلسة المستخدم
                    UserSession.SetUser(_user);
                    LoadMainMenuForm();

                }
                else
                {
                    FileLogger.Log($"LOGIN FAILED → User: {txtUserName.Texts.Trim()}");

                    MessageBox2.Show("خطأ في اسم المستخدم / كلمة المرور أو المستخدم غير فعال");
                    Cursor = Cursors.Default;
                    return;
                }
        }

        void LoadMainMenuForm()
        {
            main.lblUserName.Text = UserSession.UserName;
            main.PbUserImg.ImageLocation = UserSession.Image;
            main.SettingsBeforeLogin(true);
            main.btnExit2.Text = "Logout";
            this.Hide();
        }

        private async Task<bool> _CheackLoginInfo()
        {
            string hashedPassword = PassHash.ComputeHash(txtPassword.Texts.Trim());
            _user = await UsersBLL.GetUserForLogin(txtUserName.Texts.Trim(), hashedPassword);

            if (_user == null)
            {
                return false;
            }
            return true;

        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
