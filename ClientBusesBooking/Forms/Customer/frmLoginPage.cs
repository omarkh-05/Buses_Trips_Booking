using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientBusesBooking.Forms.Customer
{
    public partial class frmLoginPage : Form
    {
        public static UserControl? activeUC = null;

        public frmLoginPage()
        {
            InitializeComponent();
        }

        public void LoadUC(UserControl uc)
        {
            activeUC = uc;
            pnlMainPage.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMainPage.Controls.Add(uc);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(activeUC != null && activeUC.Name ==new SignupUC().Name)
            {
                activeUC.Dispose();
                LoadUC(new LoginUC());
            }
            else
                this.Close();
        }

        private void frmLoginPage_Load(object sender, EventArgs e)
        {
         LoadUC(new LoginUC());
        }
    }
}
