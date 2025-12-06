using AdminBusesBooking.Custom_Controls;
using ClientBusesBooking.Forms.Booking;
using ClientBusesBooking.Forms.Customer;
using ClientBusesBooking.Forms.Customer.Classes;
using ClientBusesBooking.Forms.Trip;

namespace ClientBusesBooking
{
    public partial class MainPage : Form
    {
        bool IsMainPageFilled = false;

        public MainPage()
        {
            InitializeComponent();
        }
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
            pnlImage.Dock = DockStyle.None;
            pnlMainPage.Controls.Add(childForm);
            pnlMainPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnNav.IconChar = FontAwesome.Sharp.IconChar.Home; // تغيير الأيق
            IsMainPageFilled = true;
        }
        private void btnNav_Click(object sender, EventArgs e)
        {
            if (IsMainPageFilled)
            {
                activeForm.Close(); // إغلاق النموذج الفرعي الحالي
                activeForm.Dispose();
                activeForm = null;
                btnNav.IconChar = FontAwesome.Sharp.IconChar.Bars; // إعادة الأيقونة القديمة
                IsMainPageFilled = false; // التأكيد على أننا في الصفحة الرئيسية
                pnlImage.Dock = DockStyle.Top;
            }
            else
            {
                if (pnlNavBar.Visible)
                    pnlNavBar.Visible = false;
                else
                    pnlNavBar.Visible = true;
            }
        }
        private void btnContactUs_Click(object sender, EventArgs e)
        {
            MessageBox2.Show("For any inquiries, please contact us , Email : MrBusComp@gmail.com", "Contact Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOfficesLocations_Click(object sender, EventArgs e)
        {
            MessageBox2.Show("Visit our offices , Locations : 1- Aqaba 2- Amman", "Offices Locations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMrBusCredit_Click(object sender, EventArgs e)
        {
            MessageBox2.Show("Coming Soon", "MrBus Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            MessageBox2.Show("We are MrBus Company", "About us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CustomerSession.Clear();
            frmLoginPage loginPage = new frmLoginPage();
            loginPage.Show();
            this.Close();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
           frmCustomerInfo frmCustomerInfo = new frmCustomerInfo();
            openChildForm(frmCustomerInfo);
        }

        private void btnTripsSchedule_Click(object sender, EventArgs e)
        {
            frmAllTrips allTrips = new frmAllTrips();
            openChildForm(allTrips);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBookATrip bookATrip = new frmBookATrip();
            openChildForm(bookATrip);
        }
    }
}
