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
    public partial class frmChairs : Form
    {
       public static List<byte>? _Seats {  get; set; }
       public static byte _SeatNumbersForPassenger {  get; set; }
        
       // حطينا التريب ايدي هون وبعدين ربطناه في  اليوزر كونترول تبع الباص هاي احسن من اني اربطه مرة وحدة من البوكينج لليوزر كونترول ليش لانه في حال بدي اضيف اكثر من يوزر كونترول فقط بمرر التريب ايدي للفورم هاض وهو المسؤول في التوزيع لباقي اليوزرز كونترول
       public static int _TripId { get; set; }
        
        public frmChairs(byte SeatNumber)
        {
            InitializeComponent();
            _SeatNumbersForPassenger = SeatNumber;
            BigBusSeatsUC.SeatNumbersForPassenger = _SeatNumbersForPassenger;
            BigBusSeatsUC._TripId = _TripId;
            _Seats = BigBusSeatsUC.MoveSeatsToTicketsInfo();
        }

        public static Form? activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChairsMain.Controls.Add(childForm);
            pnlChairsMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (_Seats == null || _Seats.Count != _SeatNumbersForPassenger)
            {
                MessageBox2.Show("Please select all seats");
                return;
            }
            frmTicketsInfo TicketsInfo = new frmTicketsInfo();
            frmTicketsInfo.Seats = _Seats;
            openChildForm(TicketsInfo);
        }


    }
}
