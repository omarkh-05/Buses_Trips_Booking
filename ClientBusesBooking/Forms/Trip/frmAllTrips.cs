using AdminBusesBooking.Custom_Controls;
using BussinessLayer;
using Castle.Components.DictionaryAdapter.Xml;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBusesBooking.Forms.Trip
{
    public partial class frmAllTrips : Form
    {
        private DataTable _dtTrips;

        public frmAllTrips()
        {
            InitializeComponent();
        }

        //====================== ConvertToDataTable =======================
        private DataTable ConvertToDataTable<T>(List<T> items)
        {
            DataTable table = new DataTable();

            var props = typeof(T).GetProperties();

            foreach (var prop in props)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in items)
            {
                var row = table.NewRow();
                foreach (var prop in props)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }

        // ======================= Load Trips from API =======================
        private async Task LoadTripsAsync()
        {
            var response = await HttpClientHelper.HttpClient.GetAsync("api/BusBookingRest/GetAllTrips");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var trips = Newtonsoft.Json.JsonConvert.DeserializeObject<List<TripDTO>>(json);

                if (trips != null && trips.Count > 0)
                {
                    _dtTrips = ConvertToDataTable(trips);   // <<< هنا الحل
                }
                else
                {
                    _dtTrips = new DataTable(); // فاضي
                }
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox2.Show("No trips found.");
                _dtTrips = new DataTable();
            }
            else
            {
                MessageBox2.Show("API error: " + response.StatusCode);
                _dtTrips = new DataTable();
            }
        }
        
        // ======================= Setup DataGrid =======================
        private async Task SetupDataGridAsync()
        {
            await LoadTripsAsync();

            if (_dtTrips != null && _dtTrips.Rows.Count > 0)
            {
                dgvTripsList.AutoGenerateColumns = false;
                dgvTripsList.AllowUserToAddRows = false;
                dgvTripsList.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvTripsList.MultiSelect = false;
                dgvTripsList.RowHeadersVisible = false;
                dgvTripsList.EnableHeadersVisualStyles = false;
                dgvTripsList.AllowUserToResizeColumns = false;
                dgvTripsList.AllowUserToResizeRows = false;

                dgvTripsList.Columns.Clear();

                string[] visibleColumns = { "TripId", "TripName", "TripDate", "DepartureTime", "Price" };

                // إضافة الأعمدة إلى DataGridView بناءً على الأعمدة في DataTable
                foreach (string col in visibleColumns)
                {
                    dgvTripsList.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = col,
                        HeaderText = col,
                        DataPropertyName = col,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });
                }

                // تخصيص بعض إعدادات DataGridView
                dgvTripsList.RowTemplate.Height = 40;
                dgvTripsList.ColumnHeadersHeight = 35;

                dgvTripsList.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
                dgvTripsList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

                dgvTripsList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                dgvTripsList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
                dgvTripsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

                dgvTripsList.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvTripsList.ForeColor = Color.Silver;

                // ربط البيانات مع DataGridView
                dgvTripsList.DataSource = _dtTrips;
            }
        }
        private void dgvTripsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTripsList.ClearSelection();
            dgvTripsList.CurrentCell = null;
        }

        private async void frmAllTrips_Load(object sender, EventArgs e)
        {
           await SetupDataGridAsync();
        }
    }
}
