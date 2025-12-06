using AdminBusesBooking.Custom_Controls;
using AdminBusesBooking.Forms.Users;
using BusesBooking;
using BussinessLayer;
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

namespace AdminBusesBooking.Forms.Buses_And_Drivers
{
    public partial class frmDrivers : Form
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private DriversBLL _driverBLL;
        private Drivers _driver;

        private DataTable _dtAllDrivers;
        private DataTable _dtDrivers;

        public frmDrivers()
        {
            InitializeComponent();
        }

        // ======================= DataGridView =======================
        private async Task LoadDriversAsync()
        {
            _dtAllDrivers = await DriversBLL.GetAllDrivers();
            _dtDrivers = _dtAllDrivers.DefaultView.ToTable(false, "DriverID", "DriverName", "DriverRank");
        }

        private async Task SetupDataGridAsync()
        {
            await LoadDriversAsync();

            dgvDriversLIst.AutoGenerateColumns = false;
            dgvDriversLIst.AllowUserToAddRows = false;
            dgvDriversLIst.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvDriversLIst.MultiSelect = false;
            dgvDriversLIst.RowHeadersVisible = false;
            dgvDriversLIst.EnableHeadersVisualStyles = false;
            dgvDriversLIst.AllowUserToResizeColumns = false;
            dgvDriversLIst.AllowUserToResizeRows = false;

            dgvDriversLIst.Columns.Clear();

            foreach (DataColumn col in _dtDrivers.Columns)
            {
                dgvDriversLIst.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = col.ColumnName,
                    HeaderText = col.ColumnName,
                    DataPropertyName = col.ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            // أزرار Update / Delete
            AddButtonColumn("Update", "✏️");
            AddButtonColumn("Delete", "🗑️");
            AddButtonColumn("Info", "i");

            if (dgvDriversLIst.Columns.Contains("DriverID")) dgvDriversLIst.Columns["DriverID"].Width = 250;
            if (dgvDriversLIst.Columns.Contains("DriverName")) dgvDriversLIst.Columns["DriverName"].Width = 250;
            if (dgvDriversLIst.Columns.Contains("DriverRank")) dgvDriversLIst.Columns["DriverRank"].Width = 250;

            dgvDriversLIst.RowTemplate.Height = 40;
            dgvDriversLIst.ColumnHeadersHeight = 35;
            dgvDriversLIst.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvDriversLIst.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvDriversLIst.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            dgvDriversLIst.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvDriversLIst.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvDriversLIst.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            dgvDriversLIst.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDriversLIst.ForeColor = Color.Silver;

            dgvDriversLIst.DataSource = _dtDrivers;
            dgvDriversLIst.CellClick -= dgvDrivers_CellClick;
            dgvDriversLIst.CellClick += dgvDrivers_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvDriversLIst.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 200
            });
        }

        private async void dgvDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var driverId = Convert.ToInt16(dgvDriversLIst.Rows[e.RowIndex].Cells["DriverID"].Value);
            var header = dgvDriversLIst.Columns[e.ColumnIndex].HeaderText;

            _driver = await new DriversBLL().GetDriverByID(driverId);
            if (_driver == null) { MessageBox.Show("خطأ في العثور على السائق", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (header == "Update")
            {
                _driverBLL = new DriversBLL(_driver);
                _mode = enMode.UpdateMode;
                txtDriverName.Texts = _driver.DriverName;
                cbRank.Texts = _driver.DriverRank;
            }
            if (header == "Info")
            {
                pnlUserInfo.Visible = true;
                lblDriverName.Text = _driver.DriverName;
                lblRank.Text = _driver.DriverRank;
                lblStatus.Text = _driver.CreatedByUserID.ToString();
            }
            else if (header == "Delete")
            {
                if (MessageBox2.Show("هل أنت متأكد من حذف هذا السائق؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _driverBLL = new DriversBLL(_driver);
                    _driverBLL.Delete(driverId);
                    await SetupDataGridAsync();
                    pnlUserInfo.Visible = false;
                }
            }
        }
        private void dgvDriversLIst_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDriversLIst.ClearSelection();
            dgvDriversLIst.CurrentCell = null;
        }



        // ======================= Load =======================
        private async void frmDrivers_Load(object sender, EventArgs e)
        {
            await SetupDataGridAsync();
            LoadData();
        }


        // ======================= Data =======================
        void LoadData()
        {
            if (_mode == enMode.AddMode)
            {
                _driver = new Drivers();
                _driverBLL = new DriversBLL();
                return;
            }
        }
        private void MoveDataToDB()
        {
            if (_driver == null) _driver = new ModelsLayer.Drivers();

            _driver.DriverName = txtDriverName.Texts;
            _driver.DriverRank = cbRank.Texts;
            _driver.CreatedByUserID = UserSession.UserID;
        }


        // ======================= Save =======================
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == enMode.AddMode && !Validation())
            { return; }

            MoveDataToDB();
            if (_mode == enMode.AddMode)
            {
                if (MessageBox2.Show("هل انت متأكد من اضافة هذا السائق؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _driverBLL = new DriversBLL();
                    _driverBLL.CurrentDriver = _driver;
                    if (_driverBLL.Save())
                    {
                        MessageBox2.Show($"تم إضافة السائق {_driver.DriverName}", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _mode = enMode.UpdateMode;

                        await SetupDataGridAsync();
                    }
                    else
                    {
                        MessageBox2.Show($"تعذر إضافة السائق {_driver.DriverName}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }
            else
            {
                if (MessageBox2.Show("هل انت متأكد من تعديل هذا السائق؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MoveDataToDB();
                    _driverBLL = new DriversBLL(_driver);
                    _driverBLL.CurrentDriver = _driver;

                    if (_driverBLL.Save())
                    {
                        MessageBox2.Show($"تم تعديل السائق {_driver.DriverName}", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await SetupDataGridAsync();
                    }
                    else
                    {
                        MessageBox2.Show($"تعذر تعديل السائق {_driver.DriverName}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }
        }

        // ======================= Validation =======================
        bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtDriverName.Text))
            {
                errorProvider1.SetError(btnSave, "اسم السائق فارغ");
                return false;
            }

            if (cbRank.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "الرجاء اختيار تصنيف السائق");
                return false;
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
                pbDriverImg.Load(selectedFilePath);
                // pbPhoto.BackgroundImage = Image.FromFile(selectedFilePath);
                llRemoveImg.Visible = true;

            }
        }

        private void llRemoveImg_Click(object sender, EventArgs e)
        {
            pbDriverImg.ImageLocation = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu.activeForm = null;
            this.Close();
        }

    }
}
