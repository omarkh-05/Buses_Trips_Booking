using AdminBusesBooking.Custom_Controls;
using BussinessLayer;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
    public partial class frmTicketsInfo : Form
    {
        public static Bookings _booking { get; set; }
        public static TicketInfo _ticketInfo { get; set; }
        public static Payments _payment { get; set; }



        public static List<byte>? Seats { get; set; }
        public static List<string>? PersonType { get; set; }
        static public byte NumberOfTickets { get; set; }
        static public decimal Price { get; set; }

        public frmTicketsInfo()
        {
            InitializeComponent();
        }

        private void frmTicketsInfo_Load(object sender, EventArgs e)
        {
            GenerateTickets();
        }

        void GenerateTickets()
        {
            pnlTicketsMain.Controls.Clear();

            for (int i = NumberOfTickets; i >=1; i--)
            {
                var passengerControl = new TicketInfoUC();
                passengerControl.txtSeatNumber.Texts = Seats[i - 1].ToString();
                passengerControl.txtPersonType.Texts = PersonType[i - 1];
                passengerControl.groupBox1.Text = "Ticket " + i;
                passengerControl.Dock = DockStyle.Top;
                pnlTicketsMain.Controls.Add(passengerControl);
            }
        }

        private async void btnConfirmTheBook_Click(object sender, EventArgs e)
        {
           if( MessageBox2.Show($"هل انت تريد اتمام الحجز ؟ تكلفة الحجز {Price.ToString()} ","تأكيد الحجز",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor = Cursors.WaitCursor;
                btnConfirmTheBook.Enabled = false;
                if (await ConfirmBooking())
                {
                    MessageBox2.Show("تم حفظ الحجز والتذاكر والدفع بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor = Cursors.WaitCursor;
                }
                else
                {
                    MessageBox2.Show("حدث خطأ أثناء حفظ العملية. حاول مرة أخرى.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                return;

           Cursor = Cursors.Default;
            btnConfirmTheBook.Enabled = true;
        }

        async Task<bool> ConfirmBooking()
        {
            int bookingId = 0;
            try
            {
                var tickets = CollectTickets(0); // BookingID سيتم إسناده في DAL
                var payment = _payment; // يمكن أن يكون null إذا لم يتم الدفع الآن

                Cursor = Cursors.WaitCursor;
                btnConfirmTheBook.Enabled = false;

                CompleteBookingDTO completeBookingDTO = new CompleteBookingDTO()
                {
                    Tickets = tickets,
                    Payments = payment,
                    Booking = _booking
                };

                var response = await HttpClientHelper.HttpClient.PostAsJsonAsync("api/BusBookingRest/BookFromClient", completeBookingDTO);

                if (response.IsSuccessStatusCode)
                {
                    // طريقة واحد في حال بدي ارجع فقط ترو او فولز من الايبي اي
                    // return response.IsSuccessStatusCode;


                    // ⚡ هنا نتحقق فقط من نجاح العملية طريقة 2 لارجاع الايدي 
                    var res = await response.Content.ReadFromJsonAsync<BookingResponseDTO>();

                    if (res != null)
                    {
                        bookingId = res.BookingID;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox2.Show($"BadRequest: {errorMessage}", "BadRequest", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", "Confirm Booking Error : " + ex.Message, EventLogEntryType.Error);
                return false;
            }

        }


        private List<Tickets> CollectTickets(int bookingId)
        {
            var tickets = new List<Tickets>();

            foreach (TicketInfoUC control in pnlTicketsMain.Controls) // أو أي Panel يحوي الـ TicketInfo
            {
                var ticket = control.GetTicketObject(bookingId);
                tickets.Add(ticket);
            }

            return tickets;
        }
    }

}
