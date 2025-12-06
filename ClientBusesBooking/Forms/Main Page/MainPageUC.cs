using AdminBusesBooking.Custom_Controls;
using ClientBusesBooking.Forms.Customer;
using ClientBusesBooking.Forms.Customer.Classes;
using ClientBusesBooking.Forms.Trip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBusesBooking.Forms.Main_Page
{
    public partial class MainPageUC : UserControl
    {
        public MainPageUC()
        {
            InitializeComponent();
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
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            MessageBox2.Show($"All Info Will Appear", "My Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTripsSchedule_Click(object sender, EventArgs e)
        {
        }

    }
}
