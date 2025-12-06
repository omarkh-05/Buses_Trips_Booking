using AdminBusesBooking.Custom_Controls;
using Azure;
using BussinessLayer;
using ClientBusesBooking.Forms.Customer.Classes;
using ModelsLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBusesBooking.Forms.Booking
{
    public partial class frmBookATrip : Form
    {
        public frmBookATrip()
        {
            InitializeComponent();
        }

        public List<string> _PersonTypes = new List<string>();
        decimal ChildPrice = 0 ;
        decimal PersonPrice = 0;
        decimal _toatalAmount= 0 ;
        Bookings _booking;

        public static Form? activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null && activeForm.Name == childForm.Name)
            {
                return;
            }
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMainBookPage.Controls.Add(childForm);
            pnlMainBookPage.Tag = childForm;
            childForm.BringToFront();
            lblTitle.Text = "Complete Book Info";
            btnBack.Visible = true;
            childForm.Show();
        }
        private Payments BuildPaymentObject()
        {
            return new Payments
            {
                BookingID = 0,
                Amount = frmTicketsInfo.Price,
                PaymentMethod = cbPaymentMethod.Texts,
                TransactionDate = DateTime.Now,
                IsRefunded = false
            };
        }
        async Task MoveDataToDB()
        {
            if (_booking == null)
                _booking = new Bookings();

            _booking.TravelDate = dtpTravelDate.Value;
            _booking.Class = cbClass.Texts;
            _booking.AdultCount = (byte)txtAdult.Value;
            _booking.ChildCount = (byte)txtChild.Value;
            _booking.DisabledCount = (byte)txtDisabledPerson.Value;

            _booking.PassengerCount = (byte)(txtAdult.Value + txtChild.Value + txtDisabledPerson.Value);

            _booking.PhoneNumber = txtPhoneNumber.Texts;
            _booking.Status = cbStatus.Texts;
            _booking.TravelType = rbInternational.Checked ? "International" : "National";


            _booking.TotalAmount = _toatalAmount;
            _booking.CustomerID = CustomerSession.CustomerID;
            _booking.TripID = await GetTripIdByName();

            _booking.CreatedAt = DateTime.Now;
            _booking.PaymentStatus = false;
            _booking.CreatedBy = null;
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!Validation()) { return; }

            frmTicketsInfo.NumberOfTickets = PassengerCount();
            frmTicketsInfo.PersonType = _PersonTypes;
            byte SeatNumberForPassenger = PassengerCount();
            frmChairs._TripId = await GetTripIdByName();
            CalculateTotalAmount();
            frmTicketsInfo._payment = BuildPaymentObject();
           await MoveDataToDB();
            frmTicketsInfo._booking = _booking;


            frmChairs Chairs = new frmChairs(SeatNumberForPassenger);
            openChildForm(Chairs);
        }

        byte PassengerCount()
        {
            byte TotalPassengerCount = 0;

            byte AdultCount = Convert.ToByte(txtAdult.Value);
            byte ChildCount = Convert.ToByte(txtChild.Value);
            byte DisabledCount = Convert.ToByte(txtDisabledPerson.Value);

            for (int i = 0; i < AdultCount; i++)
                _PersonTypes.Add("Adult");

            for (int i = 0; i < ChildCount; i++)
                _PersonTypes.Add("Child");

            for (int i = 0; i < DisabledCount; i++)
                _PersonTypes.Add("Disabled");

            return (TotalPassengerCount = Convert.ToByte(AdultCount + ChildCount + DisabledCount));
        }

        bool Validation()
        {
            string message = "Field cannot be empty";
            if (cbTrip.SelectedItem == null)
            {
                errorProvider1.SetError(cbTrip, message);
                return false;
            }
            else if (cbPaymentMethod.SelectedItem == null)
            {
                errorProvider1.SetError(cbPaymentMethod, message);
                return false;
            }
            else if (cbStatus.SelectedItem == null)
            {
                errorProvider1.SetError(cbStatus, message);
                return false;
            }
            errorProvider1.SetError(cbClass, "");
            errorProvider1.SetError(cbTrip, "");
            errorProvider1.SetError(cbPaymentMethod, "");
            errorProvider1.SetError(cbStatus, "");
            return true;
        }

        private async void frmBookATrip_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            dtpTravelDate.MinDate = DateTime.Now.AddDays(1);
            dtpTravelDate.MaxDate = DateTime.Now.AddDays(10);
            await LoadTripsInComboBox();
        }

        //=========================== Load Trips ===========================
        async Task LoadNationalTrips()
        {
            try
            {
                IEnumerable<string>? trips = await HttpClientHelper.HttpClient.GetFromJsonAsync<IEnumerable<string>>("api/BusBookingRest/GetNationalTrips");

                cbTrip.Items.Clear();

                foreach (var trip in trips)
                {
                    cbTrip.Items.Add(trip);
                }
            }
            catch (Exception ex)
            {
                cbTrip.Items.Clear();
                EventLog.WriteEntry("Application", "Load National Trips Error: " + ex.Message, EventLogEntryType.Error);
                MessageBox2.Show("Sorry, Not Trips Found");
            }
        }
        async Task LoadInterNationalTrips()
        {
            try
            {
                IEnumerable<string>? trips = await HttpClientHelper.HttpClient.GetFromJsonAsync<IEnumerable<string>>("api/BusBookingRest/GetInternationalTrips");

                cbTrip.Items.Clear();

                foreach (var trip in trips)
                {
                    cbTrip.Items.Add(trip);
                }
            }
            catch (Exception ex)
            {
                cbTrip.Items.Clear();
                EventLog.WriteEntry("Application", "Load InterNational Trips Error: " + ex.Message, EventLogEntryType.Error);
                MessageBox2.Show("Sorry, Not Trips Found");
            }
        }
        async Task LoadTripsInComboBox()
        {
            if (rbNational.Checked)
            {
                await LoadNationalTrips();
            }
            else
            {
                await LoadInterNationalTrips();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            activeForm = null;
            lblTitle.Text = "Add Book Info";
            btnBack.Visible = false;
        }

        private async void rbInternational_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInternational.Checked)
            {
                await LoadInterNationalTrips();
            }
            else
            {
                await LoadNationalTrips();
            }
        }
        async Task<int> GetTripIdByName()
        {
            int TripId = 0;

            try
            {
                var responseMessage = await HttpClientHelper.HttpClient.GetAsync($"api/BusBookingRest/GetTripName/{cbTrip.Texts}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    string Content = await responseMessage.Content.ReadAsStringAsync();
                    TripId = int.Parse(Content);
                }
                else
                {
                    TripId = 0;
                }
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", "Get TripId By Name Error : " + ex.Message, EventLogEntryType.Error);
                TripId = 0;
            }
            return TripId;
        }

        private async void cbTrip_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var response = await HttpClientHelper.HttpClient.GetAsync($"api/BusBookingRest/GetTripDTOByName/{cbTrip.Texts}");
                if(response.IsSuccessStatusCode)
                {
                    TripDTO trip = await response.Content.ReadFromJsonAsync<TripDTO>();
                    if (trip != null)
                    {

                        ChildPrice = trip.Price * 0.5M;
                        PersonPrice = trip.Price;

                        cbClass.Texts = trip.Class;
                    }
                }else
                {
                    MessageBox2.Show($"Error While Putting Class For Trip {cbTrip.Texts}");
                }
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", "cbTrip_OnSelectedIndexChanged Error : " + ex.Message, EventLogEntryType.Error);
            }
        }

        void CalculateTotalAmount()
        {
            decimal TotalAmount = (txtAdult.Value * PersonPrice) + (txtChild.Value * ChildPrice) + (txtDisabledPerson.Value * PersonPrice);
            _toatalAmount = TotalAmount;
            frmTicketsInfo.Price = TotalAmount;
        }
    }
}
