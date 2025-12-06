using AdminBusesBooking.Custom_Controls;
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

namespace AdminBusesBooking.Forms.Customers
{
    public partial class frmTickets : Form
    {
        private Tickets? _ticket;

        private DataTable _dtAllTickets;
        private DataTable _dtTickets;

        public frmTickets()
        {
            InitializeComponent();
        }


        private async Task LoadTicketsAsync()
        {
            _dtAllTickets = await TicketsBLL.GetAllTickets();

            _dtTickets = _dtAllTickets.DefaultView.ToTable(false,
                "TicketID",
                "PassengerName",
                "PassengerGender",
                "NationalID",
                "IssueDate",
                "SeatNumber",
                "QRCode",
                "PersonType",
                "BookingID"
            );
        }

        private async Task SetupDataGridAsync()
        {
            await LoadTicketsAsync();

            dgvTicketsList.AutoGenerateColumns = false;
            dgvTicketsList.AllowUserToAddRows = false;
            dgvTicketsList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTicketsList.MultiSelect = false;
            dgvTicketsList.RowHeadersVisible = false;
            dgvTicketsList.EnableHeadersVisualStyles = false;
            dgvTicketsList.AllowUserToResizeColumns = false;
            dgvTicketsList.AllowUserToResizeRows = false;

            dgvTicketsList.Columns.Clear();

            // إضافة أعمدة الداتا تيبل
            foreach (DataColumn col in _dtTickets.Columns)
            {
                dgvTicketsList.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = col.ColumnName,
                    HeaderText = col.ColumnName,
                    DataPropertyName = col.ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            AddButtonColumn("Print", "🖨");
            AddButtonColumn("Info", "i");

            dgvTicketsList.RowTemplate.Height = 45;
            dgvTicketsList.ColumnHeadersHeight = 40;
            dgvTicketsList.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvTicketsList.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvTicketsList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            dgvTicketsList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvTicketsList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvTicketsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            dgvTicketsList.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTicketsList.ForeColor = Color.Silver;

            dgvTicketsList.DataSource = _dtTickets;

            dgvTicketsList.CellClick -= dgvTickets_CellClick;
            dgvTicketsList.CellClick += dgvTickets_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvTicketsList.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 140
            });
        }

        private async void dgvTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var ticketId = Convert.ToInt32(dgvTicketsList.Rows[e.RowIndex].Cells["TicketID"].Value);
            var header = dgvTicketsList.Columns[e.ColumnIndex].HeaderText;

            _ticket = await new TicketsBLL().GetTicketByID(ticketId);

            if (_ticket == null)
            {
                MessageBox2.Show("لم يتم العثور على التذكرة.", "خطأ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // عرض معلومات التذكرة
            if (header == "Info")
            {
                pnlUserInfo.Visible = true;
                lblPassengerName.Text = _ticket.PassengerName;
                lblGender.Text = _ticket.PassengerGender;
                lblNationalID.Text = _ticket.NationalID;
                lblIssueDate.Text = _ticket.IssueDate.ToShortDateString();
                lblSeatNumber.Text = _ticket.SeatNumber.ToString();
                lblPersonType.Text = _ticket.PersonType;
                lblBookingID.Text = _ticket.BookingID.ToString();
                lblQrCode.Text = _ticket.QRCode;
            }

            // طباعة التذكرة
            else if (header == "Print")
            {
                MessageBox2.Show("سيتم تنفيذ أمر الطباعة هنا...", "Print Ticket",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // مكان الكود الحقيقي للطباعة
                // PrintTicket(_ticket);
            }
        }

        private void dgvTickets_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTicketsList.ClearSelection();
            dgvTicketsList.CurrentCell = null;
        }

        private async void frmTickets_Load(object sender, EventArgs e)
        {
            await SetupDataGridAsync();
        }

        private void txtSearchFor_Click(object sender, EventArgs e)
        {
            string FilterColumn = "";

            // اختيار العمود حسب الفلتر
            switch (cbFilterBy.Texts)
            {
                case "Date":
                    FilterColumn = "IssueDate";   // أو TransactionDate حسب جدولك
                    break;

                case "BookingID":
                    FilterColumn = "BookingID";
                    break;

                case "Name":
                    FilterColumn = "PassengerName";
                    break;

                case "NationalID":
                    FilterColumn = "NationalID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            // إذا ما في بحث → إزالة الفلترة
            if (txtSearchFor.Texts.Trim() == "" || FilterColumn == "None")
            {
                _dtTickets.DefaultView.RowFilter = "";
                return;
            }

            string searchText = txtSearchFor.Texts.Trim();

            // ------------------------
            //  فلترة حسب النوع
            // ------------------------

            // 🔍 1) بحث التاريخ Date
            if (FilterColumn == "IssueDate")
            {
                // البحث كنص لتسهيل كتابة التاريخ
                _dtTickets.DefaultView.RowFilter =
                    $"CONVERT([{FilterColumn}], 'System.String') LIKE '%{searchText}%'";
            }

            // 🔍 2) بحث BookingID = رقم
            else if (FilterColumn == "BookingID")
            {
                try
                {
                    int.Parse(searchText);  // يجب أن يكون رقم

                    _dtTickets.DefaultView.RowFilter =
                        $"[{FilterColumn}] = {searchText}";
                }
                catch
                {
                    MessageBox.Show("يجب إدخال رقم فقط لـ BookingID");
                }
            }

            // 🔍 3) بحث نصي Name أو NationalID
            else if (FilterColumn == "PassengerName" || FilterColumn == "NationalID")
            {
                _dtTickets.DefaultView.RowFilter =
                    $"[{FilterColumn}] LIKE '{searchText}%'";
            }
        }
    }
}
