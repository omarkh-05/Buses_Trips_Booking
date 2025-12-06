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

namespace ClientBusesBooking.Forms.Booking
{
    public partial class TicketInfoUC : UserControl
    {
        public TicketInfoUC()
        {
            InitializeComponent();
        }

        public Tickets GetTicketObject(int bookingId)
        {
            Guid newGuid = Guid.NewGuid();
            return new Tickets
            {
                BookingID = bookingId,
                PassengerName = txtPassengerName.Texts,
                PassengerGender = rbMale.Checked ? "Male" : "Female",
                IssueDate = DateTime.Now,
                SeatNumber = byte.Parse(txtSeatNumber.Texts),
                NationalID = txtNationalID.Texts,
                PersonType = txtPersonType.Texts,
                QRCode = newGuid.ToString()
            };
        }

    }
}
