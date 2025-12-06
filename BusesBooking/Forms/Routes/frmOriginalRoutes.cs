using AdminBusesBooking.Custom_Controls;
using AdminBusesBooking.Forms.Users;
using BusesBooking;
using BussinessLayer;
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

namespace AdminBusesBooking.Forms.Routes
{
    public partial class frmOriginalRoutes : Form
    {
        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private RouteBLL _routeBLL;
        private ModelsLayer.Routes _route;

        private DataTable _dtAllRoutes;
        private DataTable _dtRoutes;

        public frmOriginalRoutes()
        {
            InitializeComponent();
        }

        private async Task LoadRoutesAsync()
        {
            _dtAllRoutes = await RouteBLL.GetAllRoutes();
            _dtRoutes = _dtAllRoutes.DefaultView.ToTable(false, "RouteID", "DistanceKM", "Price", "IsInternational", "RouteName");
        }

        private async Task SetupDataGridAsync()
        {
            await LoadCountries();
            LoadData();
            await LoadRoutesAsync();

            dgvRoutesList.AutoGenerateColumns = false;
           dgvRoutesList.AllowUserToAddRows = false;
           dgvRoutesList.SelectionMode = DataGridViewSelectionMode.CellSelect;
           dgvRoutesList.MultiSelect = false;
           dgvRoutesList.RowHeadersVisible = false;
           dgvRoutesList.EnableHeadersVisualStyles = false;
           dgvRoutesList.AllowUserToResizeColumns = false;
            dgvRoutesList.AllowUserToResizeRows = false;

            dgvRoutesList.Columns.Clear();

            foreach (DataColumn col in _dtRoutes.Columns)
            {
                dgvRoutesList.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = col.ColumnName,
                    HeaderText = col.ColumnName,
                    DataPropertyName = col.ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            // Adding buttons for Update/Delete
            AddButtonColumn("Update", "✏️");
            AddButtonColumn("Delete", "🗑️");
            AddButtonColumn("Info", "i");


            dgvRoutesList.RowTemplate.Height = 40;
            dgvRoutesList.ColumnHeadersHeight = 35;
            dgvRoutesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvRoutesList.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvRoutesList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            dgvRoutesList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvRoutesList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvRoutesList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            dgvRoutesList.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRoutesList.ForeColor = Color.Silver;

            dgvRoutesList.DataSource = _dtRoutes;
            dgvRoutesList.CellClick -= dgvRoutes_CellClick;
            dgvRoutesList.CellClick += dgvRoutes_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvRoutesList.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 150
            });
        }

        private async void dgvRoutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // التأكد من أن الصف ليس فارغًا

            var routeId = Convert.ToInt16(dgvRoutesList.Rows[e.RowIndex].Cells["RouteID"].Value);
            var header = dgvRoutesList.Columns[e.ColumnIndex].HeaderText;

            // الحصول على الطريق من قاعدة البيانات
            _route = await new RouteBLL().GetRouteByID(routeId);

            if (_route == null)
            {
                MessageBox2.Show("خطأ في العثور على الطريق", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // إذا لم يتم العثور على الطريق، لا تستمر في العملية
            }

            if (header == "Update")
            {
                _routeBLL = new RouteBLL(_route);
                _mode = enMode.UpdateMode;

                //// جلب أسماء الدول والمدن من قاعدة البيانات باستخدام الـ BLL
                //string CountryFromName = await RouteBLL.GetCountryNameByID(_route.FromCountryID);
                //string CountryToName = await RouteBLL.GetCountryNameByID(_route.ToCountryID);
                //string CityFromName = await RouteBLL.GetCityNameByID(_route.FromCityID);
                //string CityToName = await RouteBLL.GetCityNameByID(_route.ToCityID);

                // تعيين القيم في الـ ComboBox و TextBox باستخدام الكائن _route navigation propertyمن خلال ال
                cbCityFrom.Texts = _route.FromCity.CityName;
                cbCityTo.Texts = _route.ToCity.CityName;
                cbCountryFrom.Texts = _route.FromCountry.CountryName;

                if (_route.IsInternational == true)
                {
                    rbInternational.Checked = true;
                    cbCountryTo.Texts = _route.ToCountry.CountryName;
                }
                else
                {
                    cbCountryTo.SelectedIndex = -1;
                    rbNational.Checked = true;
                }

                // تعيين مسافة السعر في الـ TextBox
                txtDistanceKm.Texts = _route.DistanceKM.ToString();
                txtPrice.Texts = _route.Price.ToString("F2"); // تنسيق السعر لتكون قيمته دوماً رقمين عشريين
               

            }
            else if (header == "Info")
            {
                pnlUserInfo.Visible = true;


                if(_route.IsInternational)
                {
                    lblRouteType.Text = "International";
                }else
                    lblRouteType.Text = "National";

                lblCountryFrom.Text = _route.FromCountryID.ToString();
                lblCityFrom.Text = _route.FromCityID.ToString();

                lblCountryTo.Text = _route.ToCountryID.ToString();
                lblCityTo.Text = _route.ToCityID.ToString();

                lblDistanceKm.Text = _route.DistanceKM.ToString();
                lblPrice.Text = _route.Price.ToString();
                lblRouteName.Text = _route.RouteName;
            }

            else if (header == "Delete")
            {
                // حذف الطريق بعد تأكيد المستخدم
                if (MessageBox2.Show("هل أنت متأكد من حذف هذا الطريق؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _routeBLL = new RouteBLL(_route);
                    _routeBLL.Delete(routeId);
                    await SetupDataGridAsync(); // إعادة تحميل البيانات في الجدول
                }
            }
        }


        private void dgvRoutesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRoutesList.ClearSelection();
            dgvRoutesList.CurrentCell = null;
        }

        // ======================= Load =======================
        async Task LoadCountries()
        {
            List<string>? Countries = await CountriesBLL.GetAllCountryName();

            if (Countries == null || Countries.Count == 0)
                return;

            cbCountryFrom.Items.Clear();
            cbCountryTo.Items.Clear();

            foreach (string c in Countries)
            {
                cbCountryFrom.Items.Add(c);
                cbCountryTo.Items.Add(c);
            }

            cbCountryFrom.SelectedIndex = 0;

        }
        async Task LoadFromCities()
        {
            cbCityFrom.Enabled = true;

            // استخدم SelectedItem وليس Texts
            string selectedCountry = cbCountryFrom.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCountry)) return;

            short? CountryFromID = await CountriesBLL.GetCountryIDByName(selectedCountry);

            if (CountryFromID == null) return;

            List<string>? CitiesFrom = await CitiesBLL.GetAllCitiesByCountryName(CountryFromID);

            cbCityFrom.Items.Clear();

            foreach (string c in CitiesFrom)
                cbCityFrom.Items.Add(c);
        }

        async Task LoadToCities()
        {

            string selectedCountry = cbCountryTo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCountry)) return;

            short? CountryToID = await CountriesBLL.GetCountryIDByName(selectedCountry);

            List<string>? CitiesTo = await CitiesBLL.GetAllCitiesByCountryName(CountryToID);

            cbCityTo.Items.Clear();

            if (CitiesTo == null) return;

            foreach (string c in CitiesTo)
                cbCityTo.Items.Add(c);
        }
        private async void frmOriginalRoutes_Load(object sender, EventArgs e)
        {
            cbCityFrom.Enabled = false;
            cbCityTo.Enabled = false;
            if (rbNational.Checked)
            {
                cbCountryTo.Enabled = false;
                cbCityTo.Enabled = true;
            }
            await SetupDataGridAsync();
        }




        // ======================= Data =======================
        void LoadData()
        {
            if (_mode == enMode.AddMode)
            {
                _route = new ModelsLayer.Routes();
                _routeBLL = new RouteBLL();
                return;
            }
        }

        private async void MoveDataToDB()
        {
            if (_route == null) _route = new ModelsLayer.Routes();

            short CountryFromID = await CountriesBLL.GetCountryIDByName(cbCountryFrom.Texts);
            short CountryToID = await CountriesBLL.GetCountryIDByName(cbCountryTo.Texts);

            short CityFromID = await CitiesBLL.GetCityIDByCityNameAsync(cbCityFrom.Texts);
            short CityToID = await CitiesBLL.GetCityIDByCityNameAsync(cbCityTo.Texts);


            _route.FromCountryID = CountryFromID;
            _route.FromCityID = CityFromID;

            if (rbNational.Checked)
            {
                _route.ToCountryID = null;
            }
            else
            {
                _route.ToCountryID = CountryToID;
            }
            _route.ToCityID = CityToID;

            double distance;
            if (!double.TryParse(txtDistanceKm.Texts, out distance))
            {
                MessageBox2.Show("يرجى إدخال مسافة صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Exit the method if the distance is not valid
            }
            _route.DistanceKM = distance;
            decimal price;
            if (!decimal.TryParse(txtPrice.Texts, out price))
            {
                MessageBox2.Show("يرجى إدخال سعر صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  // Exit the method if the price is not valid
            }
            _route.Price = price;
            _route.IsInternational = rbInternational.Checked;
            _route.CreatedByUserID = UserSession.UserID;  // Assuming the current user ID is 1

            _route.RouteName = $"{cbCityFrom.Texts}-{cbCityTo.Texts}";
        }

        // ======================= Save =======================
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if(_mode == enMode.AddMode && !Validation())
                return;

            MoveDataToDB();
            if (_mode == enMode.AddMode)
            {
                if (MessageBox2.Show("هل انت متأكد من إضافة هذا الطريق؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _routeBLL = new RouteBLL();
                    _routeBLL.CurrentRoute = _route;
                    if (_routeBLL.Save())
                    {
                        MessageBox2.Show($"تم إضافة الطريق من {cbCityFrom.Texts} إلى {cbCityTo.Texts}", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _mode = enMode.UpdateMode;
                        await SetupDataGridAsync();
                    }
                    else
                    {
                        MessageBox2.Show("تعذر إضافة الطريق", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }
            else
            {
                if (MessageBox2.Show("هل انت متأكد من تعديل هذا الطريق؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MoveDataToDB();
                    _routeBLL = new RouteBLL(_route);
                    _routeBLL.CurrentRoute = _route;

                    if (_routeBLL.Save())
                    {
                        MessageBox2.Show($"تم تعديل الطريق من {cbCityFrom.Texts} إلى {cbCityTo.Texts}", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await SetupDataGridAsync();
                    }
                    else
                    {
                        MessageBox2.Show("تعذر تعديل الطريق", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }
        }

        // ======================= Validation =======================
        bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtDistanceKm.Texts))
            {
                errorProvider1.SetError(btnSave, "يرجى إدخال المسافة");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Texts))
            {
                errorProvider1.SetError(btnSave, "يرجى إدخال السعر");
                return false;
            }

            if (cbCityFrom.SelectedItem == null || cbCityTo.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار المدن");
                return false;
            }

            if (cbCountryFrom.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار دولة الانطلاق");
                return false;
            }

            if (!rbNational.Checked)
            {
                if (cbCountryTo.SelectedItem == null)
                {
                    errorProvider1.SetError(btnSave, "يرجى اختيار دولة الوجهة");
                    return false;
                }
            }

            errorProvider1.SetError(btnSave, "");
            return true;
        }


      

        

        async Task LoadCityWhenNational()
        {
            string selectedCountry = cbCountryFrom.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCountry)) return;

            short? CountryFromID = await CountriesBLL.GetCountryIDByName(selectedCountry);

            if (CountryFromID == null) return;

            List<string>? CitiesFrom = await CitiesBLL.GetAllCitiesByCountryName(CountryFromID);

            cbCityTo.Items.Clear();

            foreach (string c in CitiesFrom)
                cbCityTo.Items.Add(c);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu.activeForm = null;
            this.Close();
        }

        
        private void rbNational_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNational.Checked)
            {
                cbCountryTo.Enabled = false;
            }
            else
            {
                cbCountryTo.Enabled = true;
            }
        }

        private async void cbCountryFrom_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbCityFrom.SelectedIndex = -1;
            cbCityFrom.Items.Clear();
            await LoadFromCities();
            if (rbNational.Checked)
            {
                cbCityTo.SelectedIndex = -1;
                cbCityTo.Items.Clear();
                await LoadCityWhenNational();
            }
        }

        private async void cbCountryTo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbCityTo.SelectedIndex = -1;
            cbCityTo.Items.Clear();

            await LoadToCities();
        }
    }
}
