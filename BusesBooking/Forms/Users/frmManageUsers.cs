using AdminBusesBooking.Custom_Controls;
using BusesBooking;
using BussinessLayer;
using DataLayer;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
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

namespace AdminBusesBooking.Users
{
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
        }
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private byte _UserID = 0;
        private ModelsLayer.Users _user;
        private UsersBLL _userBLL;

        private DataTable _dtAllUsers;
        private DataTable _dtUsers;

        public frmManageUsers(byte UserID)
        {
            _UserID = UserID;
            InitializeComponent();
            _mode = (_UserID == 0) ? enMode.AddMode : enMode.UpdateMode;
        }

        // ======================= DataGridView =======================
        private async Task LoadUsersAsync()
        {
            _dtAllUsers = await UsersBLL.GetAllUsers();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "UserName", "Role", "IsActive");
        }

        private async Task SetupDataGridAsync()
        {
            await LoadUsersAsync();

            dgvUserInfo.AutoGenerateColumns = false;
            dgvUserInfo.AllowUserToAddRows = false;
            dgvUserInfo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvUserInfo.MultiSelect = false;
            dgvUserInfo.RowHeadersVisible = false;
            dgvUserInfo.EnableHeadersVisualStyles = false;
            dgvUserInfo.AllowUserToResizeColumns = false;
            dgvUserInfo.AllowUserToResizeRows = false;

            dgvUserInfo.Columns.Clear();

            foreach (DataColumn col in _dtUsers.Columns)
            {
                dgvUserInfo.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = col.ColumnName,
                    HeaderText = col.ColumnName,
                    DataPropertyName = col.ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            // أزرار Update / User / Delete
            AddButtonColumn("Update", "✏️");
            AddButtonColumn("User", "👤");
            AddButtonColumn("Disable", "🗙");

            if (dgvUserInfo.Columns.Contains("UserID")) dgvUserInfo.Columns["UserID"].Width = 100;
            if (dgvUserInfo.Columns.Contains("UserName")) dgvUserInfo.Columns["UserName"].Width = 100;
            if (dgvUserInfo.Columns.Contains("Role")) dgvUserInfo.Columns["Role"].Width = 100;
            if (dgvUserInfo.Columns.Contains("IsActive")) dgvUserInfo.Columns["IsActive"].Width = 100;

            // حجم الصفوف والهيدر
            dgvUserInfo.RowTemplate.Height = 45;
            dgvUserInfo.ColumnHeadersHeight = 40;
            dgvUserInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // ألوان صفوف متبادلة
            dgvUserInfo.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvUserInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            // تصميم الخطوط في الهيدر
            dgvUserInfo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvUserInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvUserInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            // تصميم الخطوط في الصفوف
            dgvUserInfo.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvUserInfo.ForeColor = Color.Silver;


            dgvUserInfo.DataSource = _dtUsers;
            dgvUserInfo.CellClick -= dgvUserInfo_CellClick;
            dgvUserInfo.CellClick += dgvUserInfo_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvUserInfo.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 140
            });
        }

        private async void dgvUserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var userId = Convert.ToByte(dgvUserInfo.Rows[e.RowIndex].Cells["UserID"].Value);
            var header = dgvUserInfo.Columns[e.ColumnIndex].HeaderText;

            _user = await new UsersBLL().GetUserByID(userId);
            if (_user == null) { MessageBox2.Show("خطاء في العثور على المستخدم", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); return; }

            if (header == "Update")
            {
                _userBLL = new UsersBLL(_user);
                _mode = enMode.UpdateMode;
                txtUserName.Texts = _user.UserName;
                cbRole.Texts = _user.Role;
                rbActive.Checked = _user.IsActive;
                pbUserImg.ImageLocation = _user.ImgPath;

                txtPassword.Texts = "Original Password";
                txtConfirmPass.Texts = "New Password";
            }
            else if (header == "User")
            {
                pnlUserInfo.Visible = true;
                lblUserName.Text = _user.UserName;
                lblRole.Text = _user.Role;
                lblStatus.Text = _user.IsActive ? "Active" : "Not Active";
                pbUserInfoImg.ImageLocation = _user.ImgPath;
            }
            else if (header == "Disable")
            {
                if (_user.IsActive == false)
                {
                    MessageBox2.Show("هذا المستخدم معطل بالفعل");
                    return;
                }
                if (MessageBox2.Show("هل انت متأكد من تعطيل هذا المستخدم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    new UsersBLL(_user).Delete(userId);
                    await SetupDataGridAsync();
                }
            }
        }
        private void dgvUserInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUserInfo.ClearSelection();
            dgvUserInfo.CurrentCell = null;
        }



        // ======================= Load =======================
        private async void frmManageUsers_Load(object sender, EventArgs e)
        {
            await SetupDataGridAsync();
            LoadData();
        }

        //  ====================== Data ======================
        void LoadData()
        {
            if (_mode == enMode.AddMode)
            {
                _user = new ModelsLayer.Users();
                _userBLL = new UsersBLL();
                return;
            }
        }
        private void MoveDataToDB()
        {
            if (_user == null) _user = new ModelsLayer.Users();

            _user.UserName = txtUserName.Texts;
            _user.Password = PassHash.ComputeHash(txtConfirmPass.Texts);
            _user.Role = cbRole.Texts;
            _user.ImgPath = pbUserImg.ImageLocation;
            _user.IsActive = rbActive.Checked;
        }


        // ======================= Save =======================
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(_mode == enMode.AddMode && !Validation())
            { return; }

            MoveDataToDB();

            if (_mode == enMode.AddMode)
            {
                if (MessageBox2.Show("هل انت متأكد من اضافة هذا المستخدم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _userBLL = new UsersBLL();
                    _userBLL.currentuser = _user;
                    if (_userBLL.Save())
                    {
                        MessageBox2.Show((" تم إضافة ") + $" كمستخدم  {_user.UserName} ");
                        _mode = enMode.UpdateMode;

                        await SetupDataGridAsync();
                    }
                    else
                        MessageBox2.Show((" تعذر إضافة ") + $" {_user.UserName} ");

                }
                else
                    return;
            }
            else // Update
            {
                if (PassHash.ComputeHash(txtPassword.Texts) != _user.Password)
                {
                    errorProvider1.SetError(btnSave, "كلمة السر الحالية غير مطابقة مع كلمة السر الاصلية");
                    return;
                }
                if (MessageBox2.Show("هل انت متأكد من تعديل هذا المستخدم؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MoveDataToDB();

                    _userBLL = new UsersBLL(_user);

                    _userBLL.currentuser = _user;


                    if (_userBLL.Save())
                    {
                        MessageBox2.Show((" تم تعديل ") + $" كمستخدم  {_user.UserName} ");

                        await SetupDataGridAsync();
                    }
                    else
                        MessageBox2.Show((" تعذر تعديل ") + $" {_user.UserName} ");

                    txtConfirmPass.Text = "Confirm Pass :";

                }
                else

                    return;
            }
        }

        // ======================= Validation =======================
        bool Validation()
        {
            // الشروط المشتركة بين الإضافة والتعديل
            if (string.IsNullOrWhiteSpace(txtUserName.Texts))
            {
                errorProvider1.SetError(btnSave, "اسم المستخدم فارغ");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbRole.Texts))
            {
                errorProvider1.SetError(btnSave, "الرجاء اختيار الدور");
                return false;
            }

            if (pbUserImg.ImageLocation == null)
            {
                errorProvider1.SetError(btnSave, "الرجاء إضافة صورة");
                return false;
            }

            // شرط الإضافة فقط
            if (_mode == enMode.AddMode)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Texts) ||
                    string.IsNullOrWhiteSpace(txtConfirmPass.Texts))
                {
                    errorProvider1.SetError(btnSave, "الرجاء إدخال كلمة المرور وتأكيدها");
                    return false;
                }

                if (txtPassword.Texts.Length < 10)
                {
                    errorProvider1.SetError(btnSave, "كلمة المرور أقل من 10 أحرف");
                    return false;
                }

                if (txtPassword.Texts != txtConfirmPass.Texts)
                {
                    errorProvider1.SetError(btnSave, "كلمة المرور غير متطابقة");
                    return false;
                }
            }

            // شرط التعديل فقط
            if (_mode == enMode.UpdateMode)
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Texts))
                {
                    errorProvider1.SetError(btnSave, "الرجاء إدخال كلمة السر الحالية");
                    return false;
                }

                // لا تتحقق من ConfirmPass في حالة التعديل
            }

            errorProvider1.SetError(btnSave, "");
            return true;
        }



        private void llSetImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbUserImg.Load(selectedFilePath);
                // pbPhoto.BackgroundImage = Image.FromFile(selectedFilePath);
                llRemoveImg.Visible = true;

            }
        }

        private void llRemoveImg_Click(object sender, EventArgs e)
        {
            pbUserImg.ImageLocation = null;
            llRemoveImg.Visible = false;
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

        private void txtConfirmPass_Click(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = true;
        }

        
    }
}
