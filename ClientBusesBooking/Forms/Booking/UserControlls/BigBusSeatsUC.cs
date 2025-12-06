using AdminBusesBooking.Custom_Controls;
using ModelsLayer;
using System;
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
    public partial class BigBusSeatsUC : UserControl
    {
        // C#
        public static List<byte> _Seats = new List<byte>();

        public static byte SeatNumbersForPassenger { get; set; }
        byte SeatNumberBooked = 0;
        public static int _TripId { get; set; }

        public BigBusSeatsUC()
        {
            InitializeComponent(); 
            _Seats = new List<byte>();
        }

        void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; 

            if (CalculateSeatsNumberForPassengers(SeatNumberBooked, SeatNumbersForPassenger) && button.Text == "0")
            { MessageBox2.Show("Seat Booked Cannot Be More Than Passengers"); return; }


            
            if (button.Text == "0")
            {
                button.Text = "1";
                SeatNumberBooked += 1;
                _Seats.Add(Convert.ToByte(button.Tag));
                button.BackgroundImage = Properties.Resources.ChairAfterBook;
            }
            else
            {
                button.Text = "0";
                SeatNumberBooked -= 1;
                _Seats.Remove(Convert.ToByte(button.Tag));
                button.BackgroundImage = Properties.Resources.ChairBeforeBook1;
            }

            button.BackgroundImageLayout = ImageLayout.Zoom;

        }

        private async void BigBusSeatsUC_Load(object sender, EventArgs e)
        {
           await GetBookedSeatsOnTrip();
        }

        bool CalculateSeatsNumberForPassengers(byte SeatNumberBooked, byte SeatNumbersForPassenger)
        {
            if(SeatNumbersForPassenger == SeatNumberBooked)
                return true;
            else
                return false;
        }

        public static List<byte>? MoveSeatsToTicketsInfo()
        {
            if (_Seats == null)
            {
                MessageBox2.Show("Error, cannot move seats to tickets info");
                return null;
            }
            else
            {
                return _Seats;
            }
        }

        async Task GetBookedSeatsOnTrip()
        {
            try
            {
                var response = await HttpClientHelper.HttpClient.GetAsync($"api/BusBookingRest/GetBookedSeats/{_TripId}");
                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<byte>? Seats = await response.Content.ReadFromJsonAsync<IEnumerable<byte>>();
                    if (Seats == null)
                    {
                        return;
                    }
                    else
                    {
                        foreach (Control control in this.Controls)
                        {
                            if (control is Button btn)
                            {
                                if (btn.Tag == null)
                                    continue;

                                if (byte.TryParse(btn.Tag.ToString(), out byte seatNumber))
                                {
                                    if (Seats.Contains(seatNumber))
                                    {
                                        btn.Enabled = false;
                                        btn.BackgroundImage = Properties.Resources.ChairAfterBook;
                                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                                    }
                                }
                            }
                        }
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox2.Show("BadRequest Trip Id = 0");
                }
                else
                {
                    Console.WriteLine("No Seats Booked found.");
                }
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", "Get Booked Seats On Trip Error : " + ex.Message, EventLogEntryType.Error);
            }
        }


    }
}