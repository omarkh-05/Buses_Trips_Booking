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

namespace AdminBusesBooking.Forms.Trip
{
    // ======================= Delegate ======================= في حال بدي ابعت بيانات الافضل استخدم ديليجيت 
    // لكن لو بدون بيانات الافضل استخدم event action او event func اسهل في التعامل مع ال  اذا بدي ارجع قيمة برضو async
    // بس انا مستخدم الديليجت هون بدون قيمة عشان التجربة 
    public delegate void EventToChangeBusStatus();

    public partial class frmTrips : Form
    {

        private event EventToChangeBusStatus ChangeBusStatus;

        private enum enMode { AddMode = 1, UpdateMode = 2 }
        private enMode _mode = enMode.AddMode;

        private TripBLL _tripBLL;
        private Trips _trip;

        private DataTable _dtAllTrips;
        private DataTable _dtTrips;


        public frmTrips()
        {
            InitializeComponent();
        }

        private async Task LoadTripsAsync()
        {
            _dtAllTrips = await TripBLL.GetAllTrips();
            _dtTrips = _dtAllTrips.DefaultView.ToTable(false,
                "TripID",
                "IsInternational",
                "TripDate",
                "DepartureTime",
                "ArrivalTime",
                "Price",
                "Status",
                "TripName"
            );
        }

        // ======================= Setup DataGrid =======================
        private async Task SetupDataGridAsync()
        {
            await LoadData();
            await LoadTripsAsync();

            dgvTripsList.AutoGenerateColumns = false;
            dgvTripsList.AllowUserToAddRows = false;
            dgvTripsList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTripsList.MultiSelect = false;
            dgvTripsList.RowHeadersVisible = false;
            dgvTripsList.EnableHeadersVisualStyles = false;
            dgvTripsList.AllowUserToResizeColumns = false;
            dgvTripsList.AllowUserToResizeRows = false;

            dgvTripsList.Columns.Clear();

            foreach (DataColumn col in _dtTrips.Columns)
            {
                dgvTripsList.Columns.Add(new DataGridViewTextBoxColumn
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

            dgvTripsList.RowTemplate.Height = 40;
            dgvTripsList.ColumnHeadersHeight = 35;


            dgvTripsList.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvTripsList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            dgvTripsList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvTripsList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvTripsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            dgvTripsList.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTripsList.ForeColor = Color.Silver;

            dgvTripsList.DataSource = _dtTrips;

            dgvTripsList.CellClick -= dgvTrips_CellClick;
            dgvTripsList.CellClick += dgvTrips_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvTripsList.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 150
            });
        }
        private async void dgvTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int tripId = Convert.ToInt32(dgvTripsList.Rows[e.RowIndex].Cells["TripID"].Value);
            string header = dgvTripsList.Columns[e.ColumnIndex].HeaderText;

            _trip = await TripBLL.GetTripByID(tripId);

            if (_trip == null)
            {
                MessageBox.Show("تعذر العثور على الرحلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (header == "Update")
            {
                _tripBLL = new TripBLL(_trip);
                _mode = enMode.UpdateMode;

                rbInternational.Checked = _trip.IsInternational;
                rbNational.Checked = !_trip.IsInternational;

                if (_trip.TripDate < dtpTripDate.MinDate)
                    dtpTripDate.Value = dtpTripDate.MinDate;
                else if (_trip.TripDate > dtpTripDate.MaxDate)
                    dtpTripDate.Value = dtpTripDate.MaxDate;
                else
                    dtpTripDate.Value = _trip.TripDate;

                DepartureTime.Text = _trip.DepartureTime.ToString("HH:mm");
                ArrivalTime.Text = _trip.ArrivalTime.ToString("HH:mm");


                cbRoutes.Texts = _trip.Route.RouteName;
                cbBuses.Texts = _trip.Bus.BusNumber;

                cbStatus.Texts = _trip.Status;

                cbClass.Texts = _trip.Class;

                txtPrice.Texts = _trip.Price.ToString();
            }
            else if (header == "Info")
            {
                pnlUserInfo.Visible = true;
                lblTripType.Text = _trip.IsInternational ? "International" : "National";
                lblStatus.Text = _trip.Status;
                lblRoute.Text = _trip.TripName;
                lblBus.Text = _trip.Bus?.BusNumber;
                lblTripDate.Text = _trip.TripDate.ToShortDateString();
                lblDepartureTime.Text = _trip.DepartureTime.ToString();
                lblArrivalTime.Text = _trip.ArrivalTime.ToString();
                lblPrice.Text = _trip.Price.ToString();
                lblAvailableSeat.Text = _trip.AvailableSeats.ToString();
                lblClass.Text = _trip.Class;
                lblUserID.Text = _trip.CreatedByUserID.ToString();
            }
            else if (header == "Delete")
            {
                if (MessageBox2.Show("هل أنت متأكد من حذف هذه الرحلة؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _tripBLL = new TripBLL(_trip);
                    _tripBLL.Delete(tripId);
                    await SetupDataGridAsync();
                }
            }
        }
        private void dgvTripsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTripsList.ClearSelection();
            dgvTripsList.CurrentCell = null;
        }



        // ======================= Load =======================
        async Task LoadBuses()
        {
            List<string>? Buses = await BusesBLL.GetBusName();

            cbBuses.Items.Clear();

            foreach (string c in Buses)
                cbBuses.Items.Add(c);
        }
        async Task LoadToRoutes()
        {
            List<string>? Routes = await RouteBLL.GetRoutesNames();

            cbRoutes.Items.Clear();

            foreach (string c in Routes)
                cbRoutes.Items.Add(c);
        }
        private async Task LoadData()
        {
            if (_mode == enMode.AddMode)
            {
                _trip = new Trips();
                _tripBLL = new TripBLL();
            }

            await LoadBuses();
            await LoadToRoutes();

            dtpTripDate.MinDate = DateTime.Now.AddDays(1);
        }
        private async void frmTrips_Load(object sender, EventArgs e)
        {
            await SetupDataGridAsync();
        }


        // ======================= Move Data to DB =======================
        private async Task MoveDataToDB()
        {
            if (_trip == null)
                _trip = new Trips();

            _trip.IsInternational = rbInternational.Checked;

            if (_mode == enMode.AddMode)
                _trip.TripDate = dtpTripDate.Value;
            else
                _trip.TripDate = _trip.TripDate;

                _trip.DepartureTime = TimeOnly.ParseExact(DepartureTime.Text, "HH:mm");
            _trip.ArrivalTime = TimeOnly.ParseExact(ArrivalTime.Text, "HH:mm");

            _trip.Status = cbStatus.Texts;

            _trip.RouteID = _tripBLL.GetRouteIdByName(cbRoutes.Texts);

            _trip.BusID = _tripBLL.GetBusIdByName(cbBuses.Texts).BusID;

            _trip.Price = (await _tripBLL.GetRoutePriceByRoutID(_trip.RouteID)) + Decimal.Parse(txtPrice.Texts) ;

            _trip.Class = cbClass.Texts;

            _trip.TripName = cbRoutes.Texts +" "+ cbClass.Texts;

            _trip.CreatedByUserID = UserSession.UserID;

            OnSaveTrip();
        }
        protected virtual void OnSaveTrip()
        {
            ChangeBusStatus?.Invoke();
        }

        private async void ChangeBusStatusEvent()
        {
            if (_trip?.Bus == null) return;

            if (cbStatus.Texts == "On Going")
                _trip.Bus.Status = "On Work";
            else if (_mode == enMode.UpdateMode && (cbStatus.Texts == "Done"))
                _trip.Bus.Status = "Ready";

            using var db = new AppDbContext();
            db.Buses.Update(_trip.Bus);
            await db.SaveChangesAsync();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == enMode.AddMode && !Validation())
                return;

            if (!IsValidClassAndTime())
                return;

            ChangeBusStatus -= ChangeBusStatusEvent;
            ChangeBusStatus += ChangeBusStatusEvent;

            await MoveDataToDB();

            if (_mode == enMode.AddMode)
            {
                if (MessageBox2.Show("هل أنت متأكد من إضافة هذه الرحلة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _tripBLL = new TripBLL();
                    _tripBLL.CurrentTrip = _trip;

                    if (_tripBLL.Save())
                    {
                        MessageBox2.Show("تم إضافة الرحلة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        _mode = enMode.UpdateMode;
                        await SetupDataGridAsync();
                    }
                    else
                    {
                        MessageBox2.Show("تعذر إضافة الرحلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }
            else
            {
                if (MessageBox2.Show("هل أنت متأكد من تعديل هذه الرحلة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _tripBLL = new TripBLL(_trip);
                    _tripBLL.CurrentTrip = _trip;

                    if (_tripBLL.Save())
                    {
                        MessageBox2.Show("تم تعديل الرحلة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await SetupDataGridAsync();
                    }
                    else
                    {
                        MessageBox2.Show("تعذر تعديل الرحلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }
        }
        bool Validation()
        {
            if (cbStatus.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار حالة الرحلة");
                return false;
            }

            if (cbRoutes.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار رقم الطريق");
                return false;
            }

            if (cbBuses.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار الباص");
                return false;
            }

            if (!TimeSpan.TryParse(DepartureTime.Text, out TimeSpan departure))
            {
                errorProvider1.SetError(btnSave, "يرجى إدخال وقت مغادرة صحيح");
                return false;
            }

            if (!TimeSpan.TryParse(ArrivalTime.Text, out TimeSpan arrival))
            {
                errorProvider1.SetError(btnSave, "يرجى إدخال وقت وصول صحيح");
                return false;
            }

            if (arrival == departure)
            {
                errorProvider1.SetError(btnSave, "يجب أن يكون وقت الوصول بعد وقت المغادرة");
                return false;
            }



            errorProvider1.SetError(btnSave, "");
            return true;
        }
        
        bool IsValidClassAndTime()
        {
            Buses? buses = BusesBLL.GetBusByNumber(cbBuses.Texts);
            if (buses.Class != cbClass.Texts)
            {
                errorProvider1.SetError(btnSave, "فئة الباص المختار غير متطابقة مع الفئة المحددة");
                return false;
            }
            var DepartureTimevar = TimeOnly.ParseExact(DepartureTime.Text, "HH:mm");
            var ArrivalTimevar = TimeOnly.ParseExact(ArrivalTime.Text, "HH:mm");

            if (DepartureTimevar == ArrivalTimevar)
            {
                errorProvider1.SetError(btnSave, "يجب أن يكون وقت الوصول غير مساوي لوقت المغادرة");
                return false;
            }


            return true;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            MainMenu.activeForm = null;
            this.Close();
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
