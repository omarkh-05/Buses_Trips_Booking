using AdminBusesBooking.Custom_Controls;
using AdminBusesBooking.Forms.Booking;
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

namespace AdminBusesBooking.Forms.Bookings
{
    public partial class frmmanageBookings : Form
    {

        private ModelsLayer.Bookings? _booking;
        private BookingsBLL _bookingBLL;

        private DataTable _dtAllBookings;
        private DataTable _dtBookings;

        public frmmanageBookings()
        {
            InitializeComponent();
        }
        private async Task LoadBookingsAsync()
        {
            _dtAllBookings = await BookingsBLL.GetAllBookings();
            _dtBookings = _dtAllBookings.DefaultView.ToTable(false,
                "BookingID", "TripID", "CustomerID", "TravelDate", "Class",
                "AdultCount", "ChildCount", "DisabledCount", "PaymentStatus",
                "TotalAmount", "TravelType", "CreatedAt", "CreatedBy");
        }

        private async Task SetupDataGridAsync()
        {
            await LoadBookingsAsync();

            dgvBookingsList.AutoGenerateColumns = false;
            dgvBookingsList.AllowUserToAddRows = false;
            dgvBookingsList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvBookingsList.MultiSelect = false;
            dgvBookingsList.RowHeadersVisible = false;
            dgvBookingsList.EnableHeadersVisualStyles = false;
            dgvBookingsList.AllowUserToResizeColumns = false;
            dgvBookingsList.AllowUserToResizeRows = false;

            dgvBookingsList.Columns.Clear();

            foreach (DataColumn col in _dtBookings.Columns)
            {
                dgvBookingsList.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = col.ColumnName,
                    HeaderText = col.ColumnName,
                    DataPropertyName = col.ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            AddButtonColumn("Info", "i");
            AddButtonColumn("Update", "✏️");

            dgvBookingsList.RowTemplate.Height = 45;
            dgvBookingsList.ColumnHeadersHeight = 40;
            dgvBookingsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvBookingsList.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvBookingsList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            dgvBookingsList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvBookingsList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvBookingsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            dgvBookingsList.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvBookingsList.ForeColor = Color.Silver;

            dgvBookingsList.DataSource = _dtBookings;

            dgvBookingsList.CellClick -= dgvBookingsList_CellClick;
            dgvBookingsList.CellClick += dgvBookingsList_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvBookingsList.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 140
            });
        }

        private async void dgvBookingsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int BookingId = Convert.ToInt32(dgvBookingsList.Rows[e.RowIndex].Cells["BookingID"].Value);
            string header = dgvBookingsList.Columns[e.ColumnIndex].HeaderText;

            _booking = await BookingsBLL.GetBookingByID(BookingId);
            if (_booking == null)
            {
                MessageBox2.Show("خطأ في العثور على الحجز", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (header == "Info")
            {
                pnlUserInfo.Visible = true;
                lblTripType.Text = _booking.TravelType;
                lblClass.Text = _booking.Class;
                lblTotalAmount.Text = _booking.TotalAmount.ToString();
                lblTripID.Text = _booking.TripID.ToString();
                lblCustomerID.Text = _booking.CustomerID.ToString();
                lblTravelDate.Text = _booking.TravelDate.ToShortDateString();
                lblPassengerCount.Text = (_booking.AdultCount + _booking.ChildCount + _booking.DisabledCount).ToString();
                lblAdultCount.Text = _booking.AdultCount.ToString();
                lblChildCount.Text = _booking.ChildCount.ToString();
                lblDisabledCount.Text = _booking.DisabledCount.ToString();
                lblPaymentStatus.Text = _booking.PaymentStatus.ToString();
                lblCreatedAt.Text = _booking.CreatedAt.ToShortDateString();
                lblUserID.Text = _booking.CreatedBy.ToString();
            }
            else if (header == "Update")
            {
                frmBookings bookings = new frmBookings(BookingId);

                // استخدم MainMenu الحقيقي، وليس New Instance
                MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];
                mainMenu.openChildForm(bookings);

                await SetupDataGridAsync();
            }
        }

        private void dgvBookingsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBookingsList.ClearSelection();
            dgvBookingsList.CurrentCell = null;
        }
        private void txtSearchFor_Click(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Texts)
            {
                case "Date":
                    FilterColumn = "TravelDate";
                    break;
                case "Amount":
                    FilterColumn = "TotalAmount";
                    break;
                case "BookingID":
                    FilterColumn = "BookingID";
                    break;
                case "CustomerID":
                    FilterColumn = "CustomerID";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtSearchFor.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtBookings.DefaultView.RowFilter = "";
                return;
            }

            if (FilterColumn == "TravelDate")
            {
                try
                {
                    DateTime dateValue = DateTime.Parse(txtSearchFor.Texts);
                    _dtBookings.DefaultView.RowFilter =
                        string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", FilterColumn, txtSearchFor.Texts.Trim());
                }
                catch { }
            }
            else if (FilterColumn == "TotalAmount")
            {
                string amountText = txtSearchFor.Texts.Trim().Replace(",", ".");
                _dtBookings.DefaultView.RowFilter =
                    string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", FilterColumn, amountText);
            }
            else if (FilterColumn == "BookingID" || FilterColumn == "CustomerID")
            {
                try
                {
                    int.Parse(txtSearchFor.Texts);
                    _dtBookings.DefaultView.RowFilter =
                        string.Format("[{0}] = {1}", FilterColumn, txtSearchFor.Texts.Trim());
                }
                catch
                {
                    MessageBox.Show("يجب إدخال أرقام فقط");
                }
            }
        }

        private async void frmmanageBookings_Load(object sender, EventArgs e)
        {
           await SetupDataGridAsync();
        }
    }
}
