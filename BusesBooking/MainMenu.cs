using AdminBusesBooking.Custom_Controls;
using AdminBusesBooking.Forms.Booking;
using AdminBusesBooking.Forms.Bookings;
using AdminBusesBooking.Forms.Buses_And_Drivers;
using AdminBusesBooking.Forms.Customers;
using AdminBusesBooking.Forms.Reports;
using AdminBusesBooking.Forms.Routes;
using AdminBusesBooking.Forms.Trip;
using AdminBusesBooking.Forms.Users;
using AdminBusesBooking.Users;
using Microsoft.VisualBasic.Logging;
using ModelsLayer;
using System.Windows.Media;

namespace BusesBooking
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            hideSubMenu();
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
            if(activeForm != null && activeForm.Name == "frmLoginPage")
            {
               childForm.BackColor = System.Drawing.Color.FromArgb(244,244, 244);
            }
            else
                childForm.BackColor = System.Drawing.Color.FromArgb(35, 40, 50);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMainPage.Controls.Add(childForm);
            pnlMainPage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private bool CheackOpenForm(Form childForm)
        {
            if (activeForm != null && activeForm.Name == childForm.Name)
            {
                return true;
            }
            else
                return false;
        }
        private void hideSubMenu()
        {
            pnlRouteStripeMenu.Visible = false;
            pnlBusesStrip.Visible = false;
            pnlCustomersStrip.Visible = false;
            pnlBooking.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRouteStripeMenu);
        }

        private void btnBusesAndDrivers_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBusesStrip);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCustomersStrip);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBooking);
        }
        private void btnOriginRoutes_Click(object sender, EventArgs e)
        {
            if(UserSession.Role == "SecondStuff" || UserSession.Role == "ThirdStuff")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }
            frmOriginalRoutes originalRoutes = new frmOriginalRoutes();
            CheackOpenForm(originalRoutes);
            openChildForm(originalRoutes);
            hideSubMenu();
        }

        private void btnSeasonalRoutes_Click(object sender, EventArgs e)
        {
            MessageBox2.Show("Comming Soon");
            return;
            frmSeasonalRoutes seasonalRoutes = new frmSeasonalRoutes();
            openChildForm(seasonalRoutes);
            hideSubMenu();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "SecondStuff" || UserSession.Role == "ThirdStuff")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }

            frmDrivers drivers = new frmDrivers();
            CheackOpenForm(drivers);
            openChildForm(drivers);
            hideSubMenu();
        }

        private void btnBuses_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "SecondStuff" || UserSession.Role == "ThirdStuff")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }

            frmBuses buses = new frmBuses();
            CheackOpenForm(buses);
            openChildForm(buses);
            hideSubMenu();
        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "ThirdStuff")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }

            frmTrips trips = new frmTrips();
            CheackOpenForm(trips);
            openChildForm(trips);
            hideSubMenu();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox2.Show("Comming Soon");
            return;
            frmReports reports = new frmReports();
            openChildForm(reports);
            hideSubMenu();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "SecondStuff" || UserSession.Role == "FirstStuff")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }

            frmCustomersManage customersManage = new frmCustomersManage();
            CheackOpenForm(customersManage);
            openChildForm(customersManage);
            hideSubMenu();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "SecondStuff" || UserSession.Role == "FirstStuff")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }

            frmPayments payments = new frmPayments();
            CheackOpenForm(payments);
            openChildForm(payments);
            hideSubMenu();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "SecondStuff" || UserSession.Role == "FirstStuff")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }

            frmTickets tickets = new frmTickets();
            CheackOpenForm(tickets);
            openChildForm(tickets);
            hideSubMenu();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (UserSession.Role != "Admin")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }
            frmManageUsers manageUsers = new frmManageUsers();
            CheackOpenForm(manageUsers);
            openChildForm(manageUsers);
            hideSubMenu();
        }

        private void btnBookATrip_Click(object sender, EventArgs e)
        {
            frmBookings bookings = new frmBookings(-1);
            CheackOpenForm(bookings);
            openChildForm(bookings);
            hideSubMenu();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            if(UserSession.Role == "ThirdStuff")
            {
                MessageBox2.Show("ليس لديك صلاحية للوصول الى هذه الصفحة");
                return;
            }

            frmmanageBookings manageBookings = new frmmanageBookings();
            CheackOpenForm(manageBookings);
            openChildForm(manageBookings);
            hideSubMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            if (btnExit2.Text != "Logout")
            {
                Application.Exit();
            }

            else
            {
                FileLogger.Log($"LOGOUT SUCCESS → User: {UserSession.UserName}");
                UserSession.Clear();
                SettingsBeforeLogin(false);
                btnExit2.Text = "Exit";

                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm = null;
                }

                frmLoginPage loginPage = new frmLoginPage(this);
                openChildForm(loginPage);
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            else
                return;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SettingsBeforeLogin(false);
            frmLoginPage loginPage = new frmLoginPage(this);
            openChildForm(loginPage);

            //lblUserName.Text = UserSession.UserName;
            pnlLeftNavBar.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            pnlLogo.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
        }

        public void SettingsBeforeLogin(bool Status)
        {
            btnRoutes.Enabled = Status;
            btnBusesAndDrivers.Enabled = Status;
            btnCustomers.Enabled = Status;
            btnBooking.Enabled = Status;
            btnReports.Enabled = Status;
            btnManageUsers.Enabled = Status;
            btnTrips.Enabled = Status;
            pnlTopNavBar.Visible = Status;
        }
    }
}
