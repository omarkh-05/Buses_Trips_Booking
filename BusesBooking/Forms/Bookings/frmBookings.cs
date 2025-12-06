using AdminBusesBooking.Custom_Controls;
using AdminBusesBooking.Forms.Users;
using BusesBooking;
using BussinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore.Diagnostics;
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

namespace AdminBusesBooking.Forms.Booking
{
    public partial class frmBookings : Form
    {
        enum enMode { AddMode = 1, UpdateMode = 2 }
        enMode _mode = enMode.AddMode;

        int _bookingId = -1;
        ModelsLayer.Bookings _booking = new ModelsLayer.Bookings();
        BookingsBLL _bookingBll = new BookingsBLL();

        public frmBookings(int bookingId)
        {
            InitializeComponent();

            _bookingId = bookingId;

            if (_bookingId <= 0)
            {
                _mode = enMode.AddMode;
            }
            else
            {
                _mode = enMode.UpdateMode;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu.activeForm = null;
            this.Close();
        }



        //===================== Load Trips Comboboxes =====================

        async Task GetInternationalTripsName()
        {
            var trips = await BookingsBLL.GetInterNationalTripsName();

            cbTrip.Items.Clear();

            foreach (var trip in trips)
            {
                cbTrip.Items.Add(trip);
            }
        }

        async Task GetNationalTripsName()
        {
            var trips = await BookingsBLL.GetNationalTripsName();

            cbTrip.Items.Clear();

            foreach (var trip in trips)
            {
                cbTrip.Items.Add(trip);
            }

        }
        async Task _LoadDate()
        {
            dtpTravelDate.MinDate = DateTime.Now.AddDays(1);
            dtpTravelDate.MaxDate = DateTime.Now.AddDays(10);

            if (rbInternational.Checked)
            {
                await GetInternationalTripsName();
            }
            else if (rbNational.Checked)
            {
                await GetNationalTripsName();
            }


            if (_mode == enMode.AddMode)
            {
                _booking = new ModelsLayer.Bookings();
                _bookingBll = new BookingsBLL();
            }else
            { 

                _booking = await BookingsBLL.GetBookingByID(_bookingId); // <-- تأكد أن _UserID صحيح

            if (_booking == null)
            {
                MessageBox.Show($"المستخدم {_bookingId} غير موجود");
                return;
            }

            _bookingBll = new BookingsBLL(_booking);

            _bookingBll.CurrentBooking = _booking;

            txtAdult.Text = _booking.AdultCount.ToString();
            txtChild.Text = _booking.ChildCount.ToString();
            txtDisabledPerson.Text = _booking.DisabledCount.ToString();
            txtPhoneNumber.Texts = _booking.PhoneNumber;

            cbClass.Texts = _booking.Class;
            cbStatus.Texts = _booking.Status;
            cbTrip.Texts = _booking.Trip.TripName;
            }
        }
        private async void frmBookings_Load(object sender, EventArgs e)
        {
            await _LoadDate();
        }

        private void rbInternational_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInternational.Checked)
            {
                _ = GetInternationalTripsName();
            }
            else
            {

                _ = GetNationalTripsName();
            }
        }



        async Task MoveDataToDB()
        {
            if (_booking == null)
                _booking = new ModelsLayer.Bookings();

            _booking.TravelDate = dtpTravelDate.Value;
            _booking.Class = cbClass.Texts;
            _booking.AdultCount = (byte)txtAdult.Value;
            _booking.ChildCount = (byte)txtChild.Value;
            _booking.DisabledCount = (byte)txtDisabledPerson.Value;

            _booking.PassengerCount = (byte)(txtAdult.Value + txtChild.Value + txtDisabledPerson.Value);

            _booking.PhoneNumber = txtPhoneNumber.Texts;
            _booking.Status = cbStatus.Texts;
            _booking.TravelType = rbInternational.Checked ? "International" : "National";


            _booking.TotalAmount = await BookingsBLL.CalculateTotalAmount(cbTrip.Texts, txtAdult.Value, txtChild.Value, txtDisabledPerson.Value);
            _booking.CustomerID = null;
            _booking.TripID = await BookingsBLL.GetTripIDByName(cbTrip.Texts);

            _booking.CreatedAt = DateTime.Now;
            _booking.PaymentStatus = true;
            _booking.CreatedBy = UserSession.UserID;
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == enMode.AddMode && !Validation())
                return;


            if (await CheackTripClassAndBookCLass())
            {
                errorProvider1.SetError(btnSave, "فئة الرحلة غير متوافقة مع فئة الحجز");
                return;
            }

            await MoveDataToDB();

            GeneratePassengerControls(_booking.PassengerCount);

            if(_mode == enMode.UpdateMode)
            {
                if (MessageBox2.Show("هل أنت متأكد من تعديل هذه الحجز؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _bookingBll = new BookingsBLL(_booking);
                    _bookingBll.CurrentBooking = _booking;

                    if (_bookingBll.Save())
                    {
                        MessageBox2.Show("تم تعديل الحجز بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox2.Show("تعذر تعديل الحجز", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    return;
            }

                return;

            //if (_mode == enMode.AddMode)
            //{
            //    if (MessageBox2.Show("هل أنت متأكد من إضافة هذه الحجز؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        _bookingBll = new BookingsBLL();
            //        _bookingBll.CurrentBooking = _booking;


            //        if (_bookingBll.Save())
            //        {
            //            _bookingId = _bookingBll._bookingID;

            //            MessageBox2.Show("تم إضافة الحجز بنجاح اضف معلومات الاشخاص", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        }
            //        else
            //        {
            //            MessageBox2.Show("تعذر إضافة الحجز", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //        return;
            //}
            //else
            //{
                
            //}
        }



        bool Validation()
        {
            if (cbStatus.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار حالة الرحلة");
                return false;
            }

            if (cbClass.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار رقم الطريق");
                return false;
            }

            if (cbTrip.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار الباص");
                return false;
            }

            if (txtAdult.Value < 1 || txtChild.Value < 0 || txtDisabledPerson.Value < 0)
            {
                errorProvider1.SetError(btnSave, "يجب أن يكون هناك راكب واحد على الأقل");
                return false;
            }
            return true;
        }

        async Task<bool> CheackTripClassAndBookCLass()
        {
            return !await (BookingsBLL.CheackTripClassAndBookCLass(cbTrip.Texts, cbClass.Texts));
        }

        bool TicketsValidation()
        {
            if (cbPaymentMethod.SelectedItem == null)
            {
                errorProvider1.SetError(btnSave, "يرجى اختيار طريقة الدفع");
                return false;
            }
            if (txtAdult.Value < 1 || txtChild.Value < 0 || txtDisabledPerson.Value < 0)
            {
                errorProvider1.SetError(btnSave, "يجب أن يكون هناك راكب واحد على الأقل");
                return false;
            }

            return true;
        }




        private async void btnCompleteBooking_Click(object sender, EventArgs e)
        {
           if( !TicketsValidation() )
                return;

            // افترض _booking (ModelsLayer.Bookings) مملوء مسبقًا من MoveDataToDB
            // _bookingId قد يكون 0 لأن Save سيكتب ويمدّنا بالـ BookingID
            // اجمع التذاكر من الــ controls
            var tickets = CollectTickets(0); // ستملأ BookingID داخل DAL
            var payment = BuildPaymentObject(); // يمكن أن يكون null إذا لم يتم الدفع الآن

            // ضع CurrentBooking داخل BLL
            var bookingBll = new BookingsBLL(_booking);

            // تعطيل الواجهة وإظهار مؤشر انتظار
            Cursor = Cursors.WaitCursor;
            btnTicketsInfoSave.Enabled = false;

            bool ok = await bookingBll.SaveCompleteAsync(tickets, payment);

            Cursor = Cursors.Default;
            btnTicketsInfoSave.Enabled = true;
            if (MessageBox2.Show( "هل تريد إتمام عملية الحجز والتذاكر والدفع؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ok)
                {
                    MessageBox2.Show("تم حفظ الحجز والتذاكر والدفع بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // _booking.BookingID موجود الآن داخل _booking أو CurrentBooking
                    _bookingId = bookingBll.CurrentBooking.BookingID;
                    // تقدر تنتقل لشاشة الطباعة أو إعادة ضبط الفورم
                }
                else
                {
                    MessageBox2.Show("حدث خطأ أثناء حفظ العملية. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;
          
        }

        private void GeneratePassengerControls(byte passengerCount)
        {
            pnlPassengers.Controls.Clear();

            for (int i = 1; i <= passengerCount; i++)
            {
                var passengerControl = new TicketInfo();
                passengerControl.groupBox1.Text = "Ticket " + i;
                passengerControl.Dock = DockStyle.Left;
                pnlPassengers.Controls.Add(passengerControl);
            }
        }

        private List<Tickets> CollectTickets(int bookingId)
        {
            var tickets = new List<Tickets>();

            foreach (TicketInfo control in pnlPassengers.Controls) // أو أي Panel يحوي الـ TicketInfo
            {
                var ticket = control.GetTicketObject(bookingId);
                tickets.Add(ticket);
            }

            return tickets;
        }

        private Payments BuildPaymentObject()
        {
            return new Payments
            {
                BookingID = _bookingId,
                Amount = _booking.TotalAmount,
                PaymentMethod = cbPaymentMethod.Texts,
                TransactionDate = DateTime.Now,
                IsRefunded = true

            };
        }






        //private async void btnTickertsSaveInfo_Click(object sender, EventArgs e)
        //{
        //    if (!TicketsValidation()) return;

        //    if (_mode == enMode.AddMode)
        //    {
        //        if (MessageBox2.Show($"هل أنت متأكد من إضافة هذه التذاكر / اجمالي الحساب : {_booking.TotalAmount} ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            _bookingBll = new BookingsBLL();
        //            _bookingBll.CurrentBooking = _booking;

        //            if (await _bookingBll.SaveTicketsAsync(_bookingId, _booking.TripID, CollectTickets(_bookingId)))
        //            {
        //                MessageBox2.Show("تم إضافة معلومات التذاكر بنجاح ", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                SavePayment();
        //            }
        //            else
        //            {
        //                MessageBox2.Show("تعذر إضافة معلومات التذاكر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }


        //            _mode = enMode.UpdateMode;
        //        }
        //        else
        //            return;
        //    }
        //    else
        //    {
        //        if (MessageBox2.Show("هل أنت متأكد من تعديل هذه التذاكر؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            _bookingBll = new BookingsBLL(_booking);
        //            _bookingBll.CurrentBooking = _booking;

        //            if (await _bookingBll.SaveTicketsAsync(_bookingId, _booking.TripID, CollectTickets(_bookingId)))
        //            {
        //                MessageBox2.Show("تم تعديل معلومات التذاكر بنجاح ", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                SavePayment();
        //            }
        //            else
        //            {
        //                MessageBox2.Show("تعذر تعديل معلومات التذاكر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //            return;
        //    }
        //}


        //private void SavePayment()
        //{
        //    var payment = BuildPaymentObject();

        //    var paymentBll = new PaymentsBLL(payment);

        //    if (paymentBll.Save())
        //    {
        //        MessageBox2.Show("تم تسجيل عملية الدفع بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox2.Show("تعذرت عملية الدفع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void pnlSaveAndClose_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}