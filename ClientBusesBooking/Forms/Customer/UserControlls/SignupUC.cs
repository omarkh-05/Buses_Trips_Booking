using AdminBusesBooking.Custom_Controls;
using BussinessLayer;
using ModelsLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBusesBooking.Forms.Customer
{
    public partial class SignupUC : UserControl
    {

        CustomersBLL _customersBLL;
        ModelsLayer.Customers _customers;

        public SignupUC()
        {
            InitializeComponent();

        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginPage? parent = this.FindForm() as frmLoginPage;
            if (parent != null)
            {
                parent.LoadUC(new LoginUC());
            }
        }


        async Task LoadCountries()
        {
            var countries = await CustomerCountriesBLL.GetCountries();

            // أضف عنصر وهمي للعرض الافتراضي
            cbNationality.Items.Clear();
            cbNationality.Items.Add(new { CountryID = 0, CountryName = "Nationality" });

            foreach (var country in countries)
            {
                cbNationality.Items.Add(country);
            }

            // تعيين DisplayMember و ValueMember
            cbNationality.DisplayMember = "CountryName";
            cbNationality.ValueMember = "CountryID";

            // اجعل العنصر الافتراضي محدد
            cbNationality.SelectedIndex = 0;
        }

        private async void SignupUC_Load(object sender, EventArgs e)
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            await LoadCountries();
        }

        private void iconPictureBox2_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = false;
        }
        private void iconPictureBox2_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
        }


        private void iconPictureBox4_MouseEnter(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = false;
        }

        private void iconPictureBox4_MouseLeave(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = true;
        }

        void LoadData()
        {
            if(_customers == null)
                _customers = new ModelsLayer.Customers();

            _customers.FullName = txtFullName.Texts;
            _customers.PhoneNumber = txtPhoneNumber.Text;
            _customers.Email = null;
            _customers.CountryId = Convert.ToInt16(cbNationality.SelectedValue);
            _customers.DateOfBirth = dtpDateOfBirth.Value;
            _customers.Password = PassHash.ComputeHash( txtConfirmPass.Texts);
            _customers.IsActive = true;

        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Validation())
                return;

            LoadData();

            try
            {
                var response = await HttpClientHelper.HttpClient.PostAsJsonAsync("api/BusBookingRest/AddCustomer", _customers);

                if (response.IsSuccessStatusCode)
                {

                    var addedCustomer = await response.Content.ReadFromJsonAsync<ModelsLayer.Customers>();
                    MessageBox2.Show("Signed Up Successfully, Back To Login Page To Login","Succeeded",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox2.Show("Bad Request: Invalid Customer data.", "Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                EventLog.WriteEntry("Application", "Add Customer From Client Side Error  " + ex, EventLogEntryType.Error);
                MessageBox2.Show("Error While Signup The Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        bool Validation()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtFullName.Texts))
            {
                errorProvider1.SetError(txtFullName, "Full Name is required.");
                return false;
            }
             if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "Phone Number is required.");
                return false;
            }
             if (cbNationality.SelectedItem == null)
            {
                errorProvider1.SetError(cbNationality, "Nationality Is Required");
                return false;
            }

             if (txtPassword.Texts.Length < 10 && PassStrength(txtPassword.Texts))
            {
                errorProvider1.SetError(txtPassword, "Password must be at least 10 characters long and include uppercase, lowercase, digit, and special character.");
                return false;
            }

             if (txtConfirmPass.Texts != txtPassword.Texts)
            {
                errorProvider1.SetError(txtConfirmPass, "Password Not Matched");
                return false;
            }

            return true;
        }

        bool PassStrength(string password)
        {
            BitArray checks = new BitArray(4, false); // Uppercase, Lowercase, Digit, Special Character


            foreach (char c in password)
            {
                if (char.IsUpper(c)) checks[0] = true;
                if (char.IsLower(c)) checks[1] = true;
                if (char.IsDigit(c)) checks[2] = true;
                if (!char.IsLetterOrDigit(c)) checks[3] = true;
            }
            return checks.Cast<bool>().All(b => b);


        }
    }
}
