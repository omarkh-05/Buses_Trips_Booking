using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelsLayer;

namespace AdminBusesBooking.Custom_Controls
{
    public partial class TicketInfo : UserControl
    {
        Guid newGuid = Guid.NewGuid();

        public TicketInfo()
        {
            InitializeComponent();
        }

        public Tickets GetTicketObject(int bookingId)
        {
            return new Tickets
            {
                BookingID = bookingId,
                PassengerName = txtPassengerName.Texts,
                PassengerGender = rbMale.Checked ? "Male" : "Female",
                IssueDate = DateTime.Now,
                SeatNumber = byte.Parse(txtSeatNumber.Texts),
                NationalID = txtNationalID.Texts,
                PersonType = cbPersonType.Texts,
                QRCode = newGuid.ToString()
            };
        }

    }
}
