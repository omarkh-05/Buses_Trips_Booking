using AdminBusesBooking.Custom_Controls;
using AdminBusesBooking.Forms.Users;
using BusesBooking;
using BussinessLayer;
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
    public partial class frmBuses : Form
    {

        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private BusesBLL _busBLL;
        private Buses _bus;

        private DataTable _dtAllBuses;
        private DataTable _dtBuses;

        public frmBuses()
        {
            InitializeComponent();
        }

        // ======================= Load Buses To DataGridView =======================
        private async Task LoadBusesAsync()
        {
            _dtAllBuses = await BusesBLL.GetAllBuses();

            _dtBuses = _dtAllBuses.DefaultView.ToTable(false,
                "BusID", "BusNumber", "BusModel", "Capacity", "PlateNumber", "Status");
        }

        private async Task SetupDataGridAsync()
        {
            await LoadBusesAsync();

            dgvBusesList.AutoGenerateColumns = false;
            dgvBusesList.AllowUserToAddRows = false;
            dgvBusesList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBusesList.MultiSelect = false;
            dgvBusesList.RowHeadersVisible = false;
            dgvBusesList.EnableHeadersVisualStyles = false;
            dgvBusesList.AllowUserToResizeColumns = false;
            dgvBusesList.AllowUserToResizeRows = false;


            dgvBusesList.Columns.Clear();

            foreach (DataColumn col in _dtBuses.Columns)
            {
                dgvBusesList.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = col.ColumnName,
                    HeaderText = col.ColumnName,
                    DataPropertyName = col.ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            AddButtonColumn("Update", "✏️");
            AddButtonColumn("Delete", "🗑️");
            AddButtonColumn("Info", "i");

            dgvBusesList.RowTemplate.Height = 40;
            dgvBusesList.ColumnHeadersHeight = 35;
            dgvBusesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvBusesList.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvBusesList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            dgvBusesList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvBusesList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvBusesList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            dgvBusesList.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvBusesList.ForeColor = Color.Silver;

            dgvBusesList.DataSource = _dtBuses;

            dgvBusesList.CellClick -= dgvBuses_CellClick;
            dgvBusesList.CellClick += dgvBuses_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvBusesList.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 100
            });
        }

        // ======================= Cell Click (Update/Delete/Info) =======================
        private async void dgvBuses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            short busId = Convert.ToInt16(dgvBusesList.Rows[e.RowIndex].Cells["BusID"].Value);
            string header = dgvBusesList.Columns[e.ColumnIndex].HeaderText;

            _bus = await new BusesBLL().GetBusByID(busId);

            if (_bus == null)
            {
                MessageBox2.Show("تعذر العثور على الباص", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (header == "Update")
            {
                _busBLL = new BusesBLL(_bus);
                _mode = enMode.UpdateMode;
                txtBusNumber.Texts = _bus.BusNumber;
                txtBusModel.Texts = _bus.BusModel;
                txtPlateNumber.Texts = _bus.PlateNumber;
                cbDriverID.Texts = _bus.DriverID.ToString();
                cbCategory.Texts = _bus.Category;
                cbClass.Texts = _bus.Class;
                cbCapacity.Texts = _bus.Capacity.ToString();
                cbStatus.Texts = _bus.Status;
                dtpYearofmanufacture.Value = _bus.YearOfMananufacture;
            }
            else if (header == "Info")
            {
                pnlUserInfo.Visible = true;
                lblBusNumber.Text = _bus.BusNumber;
                lblBusModel.Text = _bus.BusModel;
                lblPlateNumber.Text = _bus.PlateNumber;
                lblDriverID.Text = _bus.DriverID.ToString();
                lblCategory.Text = _bus.Category;
                lblCapacity.Text = _bus.Capacity.ToString();
                lblClass.Text = _bus.Class;
                lblStatus.Text = _bus.Status;
                lblYearOfManufacture.Text = _bus.YearOfMananufacture.ToShortDateString();
            }
            else if (header == "Delete")
            {
                if (MessageBox2.Show("هل أنت متأكد من حذف هذا الباص؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _busBLL = new BusesBLL(_bus);
                    _busBLL.Delete(busId);

                    await SetupDataGridAsync();
                    pnlUserInfo.Visible = false;
                }
            }
        }


        // ======================= Form Load =======================
        async Task LoadDriversID()
        {
            List<short>? driverIDs = await DriversBLL.GetDriverAllID();

            if (driverIDs == null || driverIDs.Count == 0)
                return;

            cbDriverID.Items.Clear(); // مهم جداً

            foreach (short id in driverIDs)
            {
                cbDriverID.Items.Add(id);
            }
        }
        private async void frmBuses_Load(object sender, EventArgs e)
        {
            await SetupDataGridAsync();
            await LoadDriversID();
            LoadData();
        }

        private void LoadData()
        {
            if (_mode == enMode.AddMode)
            {
                _bus = new Buses();
                _busBLL = new BusesBLL();
                return;
            }
        }

        // ======================= MoveDataToDB =======================
        private void MoveDataToDB()
        {
            if (_bus == null) _bus = new Buses();

            _bus.BusNumber = txtBusNumber.Texts;
            _bus.BusModel = txtBusModel.Texts;
            _bus.PlateNumber = txtPlateNumber.Texts;

            _bus.Capacity = byte.Parse(cbCapacity.Texts);
            _bus.Status = cbStatus.Texts;
            _bus.Category = cbCategory.Texts;
            _bus.Class = cbClass.Texts;
            _bus.YearOfMananufacture = dtpYearofmanufacture.Value;

            _bus.CreatedByUserID = UserSession.UserID; // من يسجل
            _bus.DriverID = short.Parse(cbDriverID.Texts);
        }

        // ======================= Save (Add / Update) =======================
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == enMode.AddMode && !Validation())
            return;

            MoveDataToDB();

            if (_mode == enMode.AddMode)
            {
                if (MessageBox2.Show("هل انت متأكد من إضافة الباص؟", "تأكيد",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _busBLL = new BusesBLL();
                    _busBLL.CurrentBus = _bus;

                    if (_busBLL.Save())
                    {
                        MessageBox2.Show("تم إضافة الباص", "نجاح");
                        _mode = enMode.UpdateMode;
                        await SetupDataGridAsync();
                    }
                    else
                        MessageBox2.Show("فشل إضافة الباص", "خطأ");
                }
            }
            else
            {
                if (MessageBox2.Show("هل انت متأكد من تعديل الباص؟", "تأكيد",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _busBLL = new BusesBLL(_bus);
                    _busBLL.CurrentBus = _bus;

                    if (_busBLL.Save())
                    {
                        MessageBox2.Show("تم تعديل الباص", "نجاح");
                        await SetupDataGridAsync();
                    }
                    else
                        MessageBox2.Show("فشل تعديل الباص", "خطأ");
                }
            }
        }

        // ======================= Validation =======================
        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtBusNumber.Texts))
            {
                errorProvider1.SetError(btnSave, "رقم الباص مطلوب");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBusModel.Texts))
            {
                errorProvider1.SetError(btnSave, "رقم مودل الباص مطلوب");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPlateNumber.Texts))
            {
                errorProvider1.SetError(btnSave, "رقم لوحة الباص مطلوب");
                return false;
            }
            if (cbDriverID.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "رقم السائق مطلوب");
                return false;
            }

            if (cbCapacity.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "السعة مطلوبة");
                return false;
            }
            if (cbClass.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "الفئة مطلوبة");
                return false;
            }
            if (cbCategory.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "الصنف مطلوب");
                return false;
            }

            if (cbStatus.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "اختر حالة الباص");
                return false;
            }

            errorProvider1.SetError(btnSave, "");
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu.activeForm = null;
            this.Close();
        }
    }
}
