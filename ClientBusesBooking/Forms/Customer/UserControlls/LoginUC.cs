using AdminBusesBooking.Custom_Controls;
using BussinessLayer;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ClientBusesBooking.Forms.Customer.Classes;

namespace ClientBusesBooking.Forms.Customer
{
    public partial class LoginUC : UserControl
    {

        CustomersBLL _customersBLL = new CustomersBLL();
        ModelsLayer.Customers _customer = new ModelsLayer.Customers();
        CustomerDTOForLogin customerDTO = new CustomerDTOForLogin();

        public LoginUC()
        {
            InitializeComponent();
           
        }

        private void iconPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = false;
        }

        private void iconPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
        }

        private void llSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginPage? parent = this.FindForm() as frmLoginPage;
            if (parent != null)
            {
                parent.LoadUC(new SignupUC());
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (cbRememberMe.Checked)
                CustomerSession.RememberFullameAndPassword(txtPhoneNumber.Texts.Trim(), txtPassword.Texts.Trim());
            else
                CustomerSession.RememberFullameAndPassword("", "");

            try
            {
                if (await _CheackLoginInfo())
                {
                    // غلق نافذة تسجيل الدخول بعد النجاح
                    frmLoginPage loginForm = this.FindForm() as frmLoginPage;
                    if (loginForm != null)
                    {
                        loginForm.Hide(); // إغلاق نافذة تسجيل الدخول
                    }

                    LoadMainMenuForm(); // فتح الصفحة الرئيسية
                }
                else
                {
                    MessageBox2.Show("خطأ في اسم المستخدم / كلمة المرور أو المستخدم غير فعال");
                }
            }
            catch (Exception ex)
            {
                MessageBox2.Show($"حدث خطأ: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadMainMenuForm()
        {
            MainPage mainMenu = new MainPage();
            mainMenu.Show(); // عرض الصفحة الرئيسية
            mainMenu.label3.Text = CustomerSession.FullName;
        }


        private async Task<bool> _CheackLoginInfo()
        {
            try
            {
                string hashpass = PassHash.ComputeHash(txtPassword.Texts.Trim());
                ModelsLayer.Api_DTO_S.LoginCustomers loginCustomers = new ModelsLayer.Api_DTO_S.LoginCustomers()
                {
                    PhoneNumber = txtPhoneNumber.Texts.Trim(),
                    Password = hashpass
                };

                var response = await HttpClientHelper.HttpClient.PostAsJsonAsync("api/BusBookingRest/Customers/Login", loginCustomers);

                if (response.IsSuccessStatusCode)
                {
                    customerDTO = await response.Content.ReadFromJsonAsync<CustomerDTOForLogin>();

                    CustomerSession.SetCustomer(customerDTO);

                    MessageBox2.Show($"Login Successfully, Welcome Back {customerDTO.FullName}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                  //  MessageBox2.Show("NotFound: Customer Not Found.", "NotFound", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox2.Show($"BadRequest: {errorMessage}", "BadRequest", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", "Get Customer For Login From Client Side Error  " + ex, EventLogEntryType.Error);
                MessageBox2.Show("Error While Login The Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }


        private void LoginUC_Load(object sender, EventArgs e)
        {
            string savedPhoneNumber = "", savedPassword = "";
            CustomerSession.GetStoredCredential(ref savedPhoneNumber, ref savedPassword);
            if (!string.IsNullOrEmpty(savedPhoneNumber))
            {
                txtPhoneNumber.Texts = savedPhoneNumber;
                txtPassword.Texts = savedPassword;
                cbRememberMe.Checked = true;
            }
        }
    }
}
