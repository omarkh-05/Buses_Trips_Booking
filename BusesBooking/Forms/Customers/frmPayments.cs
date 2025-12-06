using AdminBusesBooking.Custom_Controls;
using BussinessLayer;
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
using System.Windows.Forms.VisualStyles;

namespace AdminBusesBooking.Forms.Customers
{
    public partial class frmPayments : Form
    {
        private ModelsLayer.Payments? _payment;
        private Payments _paymentBLL;

        private DataTable _dtAllPayments;
        private DataTable _dtPayments;

        public frmPayments()
        {
            InitializeComponent();
        }

        private async Task LoadCustomersAsync()
        {
            _dtAllPayments = await PaymentsBLL.GetAllPayments();
            _dtPayments = _dtAllPayments.DefaultView.ToTable(false, "PaymentID", "Amount", "TransactionDate", "PaymentMethod", "IsRefunded", "BookingID");
        }

        private async Task SetupDataGridAsync()
        {
            await LoadCustomersAsync();

            dgvPaymentsList.AutoGenerateColumns = false;
            dgvPaymentsList.AllowUserToAddRows = false;
            dgvPaymentsList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvPaymentsList.MultiSelect = false;
            dgvPaymentsList.RowHeadersVisible = false;
            dgvPaymentsList.EnableHeadersVisualStyles = false;
            dgvPaymentsList.AllowUserToResizeColumns = false;
            dgvPaymentsList.AllowUserToResizeRows = false;

            dgvPaymentsList.Columns.Clear();

            // أضف أعمدة DataTable إلى DataGridView
            foreach (DataColumn col in _dtPayments.Columns)
            {
                dgvPaymentsList.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = col.ColumnName,
                    HeaderText = col.ColumnName,
                    DataPropertyName = col.ColumnName,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });
            }

            AddButtonColumn("Refund", "$");
            AddButtonColumn("Info", "i");

            dgvPaymentsList.RowTemplate.Height = 45;
            dgvPaymentsList.ColumnHeadersHeight = 40;
            dgvPaymentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvPaymentsList.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 40, 50);
            dgvPaymentsList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 50);

            dgvPaymentsList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgvPaymentsList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 45, 60);
            dgvPaymentsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Silver;

            dgvPaymentsList.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvPaymentsList.ForeColor = Color.Silver;

            dgvPaymentsList.DataSource = _dtPayments;

            dgvPaymentsList.CellClick -= dgvCustomerInfo_CellClick;
            dgvPaymentsList.CellClick += dgvCustomerInfo_CellClick;
        }

        private void AddButtonColumn(string header, string text)
        {
            dgvPaymentsList.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = header,
                Text = text,
                UseColumnTextForButtonValue = true,
                Width = 140
            });
        }

        private async void dgvCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var PaymentId = Convert.ToInt32(dgvPaymentsList.Rows[e.RowIndex].Cells["PaymentID"].Value);
            var header = dgvPaymentsList.Columns[e.ColumnIndex].HeaderText;

            _payment = await new PaymentsBLL().GetPaymentByID(PaymentId);
            if (_payment == null)
            {
                MessageBox2.Show("خطأ في العثور على العملية", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (header == "Info")
            {
                pnlUserInfo.Visible= true;
                lblAmount.Text = _payment.Amount.ToString();
                lblBookingID.Text = _payment.BookingID.ToString();
                lblPaymentDate.Text = _payment.TransactionDate.ToShortDateString();
                lblPaymentMethod.Text = _payment.PaymentMethod;
                lblIsRefunded.Text = _payment.IsRefunded == true ? "Yes" : "No";
            }
            else if (header == "Refund")
            {
                if (_payment.IsRefunded == true)
                {
                    MessageBox2.Show("المبلغ مسترد بالفعل لهذه العملية");
                    return;
                }
                if (MessageBox.Show("هل أنت متأكد من استرداد المبلغ لهذه العملية؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    if (await PaymentsBLL.UpdateRefund(PaymentId))
                    {
                        MessageBox2.Show("تم استرداد المبلغ بنجاح.");
                    }
                    else
                    {
                        MessageBox2.Show("فشل في استرداد المبلغ.", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    await SetupDataGridAsync();
                }
            }
        }

        private void dgvCustomerInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPaymentsList.ClearSelection();
            dgvPaymentsList.CurrentCell = null;
        }

        private async void frmPayments_Load(object sender, EventArgs e)
        {
            await SetupDataGridAsync();
        }

        private void txtSearchFor_Click(object sender, EventArgs e)
        {
            string FilterColumn = "";

            // تعيين اسم العمود الحقيقي بناء على الاختيار
            switch (cbFilterBy.Texts)
            {
                case "Date":
                    FilterColumn = "TransactionDate";
                    break;

                case "Amount":
                    FilterColumn = "Amount";
                    break;

                case "BookingID":
                    FilterColumn = "BookingID";
                    break;

                case "Refund":
                    FilterColumn = "IsRefunded";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            // إذا صندوق البحث فاضي → إزالة الفلترة
            if (txtSearchFor.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPayments.DefaultView.RowFilter = "";
                return;
            }

            // فلترة بحسب نوع العمود
            // -------------------------

            // الفلترة تاريخ 
            if (FilterColumn == "TransactionDate")
            {
                try
                {
                    DateTime dateValue = DateTime.Parse(txtSearchFor.Texts);
                    _dtPayments.DefaultView.RowFilter =
                        string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", FilterColumn, txtSearchFor.Texts.Trim());
                }
                catch
                {
                    // تجاهل أخطاء التحويل
                }
            }

            else if (FilterColumn == "Amount")
            {
                // تحويل النص لنقطة بدل فاصلة (لتفادي مشاكل المحلية)
                string amountText = txtSearchFor.Texts.Trim().Replace(",", ".");

                // تحويل العمود لنص ثم فلترة برقم عشري
                _dtPayments.DefaultView.RowFilter =
                    string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'",
                        FilterColumn, amountText);
            }

            // فلترة BookingID (int)
            else if (FilterColumn == "BookingID")
            {
                try
                {
                    int.Parse(txtSearchFor.Texts);
                    _dtPayments.DefaultView.RowFilter =
                        string.Format("[{0}] = {1}", FilterColumn, txtSearchFor.Texts.Trim());
                }
                catch
                {
                    MessageBox.Show("يجب إدخال أرقام فقط");
                }
            }


            // فلترة Boolean
            else if (FilterColumn == "IsRefunded")
            {
                string input = txtSearchFor.Texts.Trim().ToLower();

                // المستخدم قد يكتب: (true / false / yes / no / 1 / 0)
                if (input == "true" || input == "yes" || input == "1")
                    _dtPayments.DefaultView.RowFilter = "[IsRefunded] = true";
                else if (input == "false" || input == "no" || input == "0")
                    _dtPayments.DefaultView.RowFilter = "[IsRefunded] = false";
                else
                    _dtPayments.DefaultView.RowFilter = "";
            }
        }
    }
}
