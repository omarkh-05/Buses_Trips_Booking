using AdminBusesBooking.Custom_Controls;
using ClientBusesBooking.Forms.Customer.Classes;
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

namespace ClientBusesBooking.Forms.Customer
{
    public partial class frmCustomerInfo : Form
    {
        private DataTable _dtCustomerBooks; 

        public frmCustomerInfo()
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
        private async Task LoadBooksAsync()
        {
            var response = await HttpClientHelper.HttpClient.GetAsync($"api/BusBookingRest/GetAllBooks/{CustomerSession.CustomerID}");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var Books = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BooksDTO>>(json);

                if (Books != null && Books.Count > 0)
                {
                    _dtCustomerBooks = ConvertToDataTable(Books);   // <<< هنا الحل
                }
                else
                {
                    _dtCustomerBooks = new DataTable(); // فاضي
                }
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox2.Show("No Books found.");
                _dtCustomerBooks = new DataTable();
            }
            else
            {
                MessageBox2.Show("API error: " + response.StatusCode);
                _dtCustomerBooks = new DataTable();
            }
        }

        // ======================= Setup DataGrid =======================
        private async Task SetupDataGridAsync()
        {
            await LoadBooksAsync();

            if (_dtCustomerBooks != null && _dtCustomerBooks.Rows.Count > 0)
            {
                dgvCustomerBooks.AutoGenerateColumns = false;
                dgvCustomerBooks.AllowUserToAddRows = false;
                dgvCustomerBooks.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvCustomerBooks.MultiSelect = false;
                dgvCustomerBooks.RowHeadersVisible = false;
                dgvCustomerBooks.EnableHeadersVisualStyles = false;
                dgvCustomerBooks.AllowUserToResizeColumns = false;
                dgvCustomerBooks.AllowUserToResizeRows = false;

                dgvCustomerBooks.Columns.Clear();

                string[] visibleColumns = { "BookingID", "TripID", "TravelDate", "AdultCount", "ChildCount", "TotalAmount", "DisabledCount" };

                // إضافة الأعمدة إلى DataGridView بناءً على الأعمدة في DataTable
                foreach (string col in visibleColumns)
                {
                    dgvCustomerBooks.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = col,
                        HeaderText = col,
                        DataPropertyName = col,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    });
                }

                // تخصيص بعض إعدادات DataGridView
                dgvCustomerBooks.RowTemplate.Height = 40;
                dgvCustomerBooks.ColumnHeadersHeight = 35;

                dgvCustomerBooks.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
                dgvCustomerBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

               dgvCustomerBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
               dgvCustomerBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
                dgvCustomerBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

                dgvCustomerBooks.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dgvCustomerBooks.ForeColor = Color.Silver;

                // ربط البيانات مع DataGridView
                dgvCustomerBooks.DataSource = _dtCustomerBooks;
            }

        }
        private void dgvTripsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCustomerBooks.ClearSelection();
            dgvCustomerBooks.CurrentCell = null;
        }
        private async void frmCustomerInfo_Load(object sender, EventArgs e)
        {
            await SetupDataGridAsync();
        }
    }
}
