using AdminBusesBooking.Custom_Controls;
using BusesBooking;
using BussinessLayer;
using Castle.Core.Resource;
using DataLayer;
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

namespace AdminBusesBooking.Forms.Customers
{
    public partial class frmCustomersManage : Form
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private ModelsLayer.Customers _customer;
        private CustomersBLL _customerBLL;

        private DataTable _dtAllCustomers;
        private DataTable _dtCustomers;


        public frmCustomersManage()
        {
            InitializeComponent();
        }


        private async Task LoadCustomersAsync()
        {
            _dtAllCustomers = await CustomersBLL.GetAllCustomers();
            _dtCustomers = _dtAllCustomers.DefaultView.ToTable(false, "CustomerID", "FullName", "PhoneNumber", "Email", "IsActive", "DateOfBirth");
        }

        private async Task SetupDataGridAsync()
        {
            await LoadCustomersAsync();

            dgvCustomerInfo.AutoGenerateColumns = false;
            dgvCustomerInfo.AllowUserToAddRows = false;
            dgvCustomerInfo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCustomerInfo.MultiSelect = false;
            dgvCustomerInfo.RowHeadersVisible = false;
            dgvCustomerInfo.EnableHeadersVisualStyles = false;
            dgvCustomerInfo.AllowUserToResizeColumns = false;
            dgvCustomerInfo.AllowUserToResizeRows = false;

            dgvCustomerInfo.Columns.Clear();

            foreach (DataColumn col in _dtCustomers.Columns)
            {
                dgvCustomerInfo.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = col.ColumnName,
                    HeaderText = col.ColumnName,
                    DataPropertyName = col.ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            // أزرار Update / Customer / Disable
            AddButtonColumn("Update", "✏️");
            AddButtonColumn("Customer", "👤");
            AddButtonColumn("Disable", "🗙");

            dgvCustomerInfo.RowTemplate.Height = 45;
            dgvCustomerInfo.ColumnHeadersHeight = 40;
            dgvCustomerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvCustomerInfo.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvCustomerInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            dgvCustomerInfo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvCustomerInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvCustomerInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            dgvCustomerInfo.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCustomerInfo.ForeColor = Color.Silver;

            dgvCustomerInfo.DataSource = _dtCustomers;
            dgvCustomerInfo.CellClick -= dgvCustomerInfo_CellClick;
            dgvCustomerInfo.CellClick += dgvCustomerInfo_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvCustomerInfo.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 140
            });
        }

        private async void dgvCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var customerId = Convert.ToInt32(dgvCustomerInfo.Rows[e.RowIndex].Cells["CustomerID"].Value);
            var header = dgvCustomerInfo.Columns[e.ColumnIndex].HeaderText;

            _customer = await new CustomersBLL().GetCustomerByID(customerId);
            if (_customer == null)
            {
                MessageBox2.Show("خطأ في العثور على العميل", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (header == "Update")
            {
                _customerBLL = new CustomersBLL(_customer);
                _mode = enMode.UpdateMode;

                txtFullName.Texts = _customer.FullName;
                txtPhoneNumber.Text = _customer.PhoneNumber;
                txtEmail.Texts = _customer.Email??"No Email";
                cbNationality.SelectedValue = _customer.CountryId;
                dtpDateOfBirth.Value = _customer.DateOfBirth;
                rbActive.Checked = _customer.IsActive;

            }
            else if (header == "Customer")
            {
                pnlUserInfo.Visible = true;
                lblFullName.Text = _customer.FullName;
                lblEmail.Text = _customer.Email;
                lblPhoneNumber.Text = _customer.PhoneNumber;
                lblNationality.Text = _customer.CustomerCountry?.CountryName;
                lblDateOfBirth.Text = _customer.DateOfBirth.ToShortDateString();
                lblStatus.Text = _customer.IsActive ? "Active" : "Not Active";
            }
            else if (header == "Disable")
            {
                if (_customer.IsActive == false)
                {
                    MessageBox2.Show("هذا العميل معطل بالفعل");
                    return;
                }
                if (MessageBox.Show("هل أنت متأكد من تعطيل هذا العميل؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    new CustomersBLL(_customer).Delete(customerId);
                    await SetupDataGridAsync();
                }
            }
        }

        private void dgvCustomerInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCustomerInfo.ClearSelection();
            dgvCustomerInfo.CurrentCell = null;
        }



        // ======================= Load =======================

        private async Task LoadCountries()
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

        private async void frmCustomersManage_Load(object sender, EventArgs e)
        {
           await LoadCountries();
            await SetupDataGridAsync();
            LoadData();
        }


        // ====================== Data ======================
        void LoadData()
        {
            if (_mode == enMode.AddMode)
            {
                _customer = new ModelsLayer.Customers();
                _customerBLL = new CustomersBLL();
                return;
            }
        }
        private void MoveDataToDB()
        {
            if (_customer == null) _customer = new ModelsLayer.Customers();

            _customer.FullName = txtFullName.Texts;
            _customer.PhoneNumber = txtPhoneNumber.Text;
            _customer.Email = txtEmail.Texts;
            _customer.CountryId = Convert.ToInt16(cbNationality.SelectedValue);
            _customer.DateOfBirth = dtpDateOfBirth.Value;
            _customer.Password = PassHash.ComputeHash(txtPassword.Texts);
            _customer.IsActive = rbActive.Checked;
        }

        // ======================= Save =======================
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == enMode.AddMode && !Validation()) return;

            MoveDataToDB();

            if (_mode == enMode.AddMode)
            {
                if (MessageBox2.Show("هل أنت متأكد من إضافة هذا العميل؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _customerBLL = new CustomersBLL();
                    _customerBLL.CurrentCustomer = _customer;
                    if (_customerBLL.Save())
                    {
                        MessageBox2.Show(("تم إضافة") + $" العميل {_customer.FullName}");
                        _mode = enMode.UpdateMode;

                        await SetupDataGridAsync();
                    }
                    else
                        MessageBox2.Show(("تعذر إضافة") + $" {_customer.FullName}");
                }
                else return;
            }
            else // Update
            {
                // تحقق من كلمة المرور الأصلية
                if (PassHash.ComputeHash(txtPassword.Texts) != _customer.Password || txtPassword.Texts == "Password" || string.IsNullOrWhiteSpace(txtPassword.Texts) )
                {
                    errorProvider1.SetError(btnSave, "كلمة السر الحالية غير مطابقة مع كلمة السر الأصلية");
                    return;
                }
                if (MessageBox2.Show("هل أنت متأكد من تعديل هذا العميل؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MoveDataToDB();
                    _customerBLL = new CustomersBLL(_customer);
                    _customerBLL.CurrentCustomer = _customer;
                    if (_customerBLL.Save())
                    {
                        MessageBox2.Show(("تم تعديل") + $" العميل {_customer.FullName}");
                        await SetupDataGridAsync();
                    }
                    else
                        MessageBox2.Show(("تعذر تعديل") + $" {_customer.FullName}");
                }
                else return;
            }
        }

        // ======================= Validation =======================
        bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Texts))
            {
                errorProvider1.SetError(btnSave, "الاسم فارغ");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(btnSave, "الرجاء إدخال رقم الهاتف");
                return false;
            }

            if (cbNationality.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "الرجاء اختيار الدولة");
                return false;
            }

            // شرط الإضافة فقط
            if (_mode == enMode.AddMode)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Texts))
                {
                    errorProvider1.SetError(btnSave, "الرجاء إدخال كلمة المرور");
                    return false;
                }

                if (txtPassword.Texts.Length < 10)
                {
                    errorProvider1.SetError(btnSave, "كلمة المرور أقل من 10 أحرف");
                    return false;
                }
            }

            errorProvider1.SetError(btnSave, "");
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu.activeForm = null;
            this.Close();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
        }
    }
}
