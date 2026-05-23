using BUS;
using DTO;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmInvoice : XtraForm
    {
        private readonly InvoiceBUS _invoiceBus;
        private InvoiceInfoDTO _currentInfo;
        private PrintDocument _printDoc;
        private PrintPreviewDialog _preview;

        public frmInvoice()
        {
            _invoiceBus = new InvoiceBUS();
            InitializeComponent();
            SetupPrinting();
            LoadBookings();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
                if (_printDoc != null)
                {
                    _printDoc.Dispose();
                    _printDoc = null;
                }
                if (_preview != null)
                {
                    _preview.Dispose();
                    _preview = null;
                }
            }
            base.Dispose(disposing);
        }

        private void SetupPrinting()
        {
            _printDoc = new PrintDocument();
            _printDoc.PrintPage += PrintDoc_PrintPage;
            _preview = new PrintPreviewDialog();
            _preview.Document = _printDoc;
            _preview.Width = 1000;
            _preview.Height = 800;
        }

        private void LoadBookings()
        {
            cboBooking.DataSource = _invoiceBus.getBookingLookups();
            cboBooking.DisplayMember = "Display";
            cboBooking.ValueMember = "BookingID";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cboBooking.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn booking.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int bookingId = Convert.ToInt32(cboBooking.SelectedValue);
            try
            {
                _currentInfo = _invoiceBus.getInvoiceInfo(bookingId);
                BindInfo(_currentInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboBooking.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn booking.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int bookingId = Convert.ToInt32(cboBooking.SelectedValue);
                _invoiceBus.createOrUpdateInvoice(bookingId);
                MessageBox.Show("Lưu hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_currentInfo == null)
            {
                MessageBox.Show("Vui lòng bấm Calculate trước khi in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _preview.ShowDialog();
        }

        private void BindInfo(InvoiceInfoDTO info)
        {
            txtCustomerName.Text = info.CustomerName;
            txtCustomerCCCD.Text = info.CustomerCCCD;
            txtCustomerPhone.Text = info.CustomerPhone;
            txtRooms.Text = info.RoomCodes;
            txtCheckIn.Text = info.CheckInDate.ToString("yyyy-MM-dd");
            txtCheckOut.Text = info.CheckOutDate.ToString("yyyy-MM-dd");
            txtDays.Text = info.StayDays.ToString();
            txtRoomPricePerDay.Text = info.RoomPricePerDayTotal.ToString("N0");
            txtRoomTotal.Text = info.RoomTotal.ToString("N0");
            txtServiceTotal.Text = info.ServiceTotal.ToString("N0");
            txtTotal.Text = info.TotalAmount.ToString("N0");

            dgvServices.DataSource = info.Services.Select(s => new
            {
                s.ServiceName,
                s.Quantity,
                UnitPrice = s.UnitPrice.ToString("N0"),
                SubTotal = s.SubTotal.ToString("N0")
            }).ToList();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (_currentInfo == null)
                return;

            float y = 20;
            float left = 40;
            var titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
            var textFont = new Font("Segoe UI", 10, FontStyle.Regular);

            e.Graphics.DrawString("HOTEL INVOICE", titleFont, Brushes.Black, left, y);
            y += 35;
            e.Graphics.DrawString("Customer: " + _currentInfo.CustomerName, textFont, Brushes.Black, left, y);
            y += 20;
            e.Graphics.DrawString("CCCD: " + _currentInfo.CustomerCCCD + "  Phone: " + _currentInfo.CustomerPhone, textFont, Brushes.Black, left, y);
            y += 20;
            e.Graphics.DrawString("Rooms: " + _currentInfo.RoomCodes, textFont, Brushes.Black, left, y);
            y += 20;
            e.Graphics.DrawString("Check-in: " + _currentInfo.CheckInDate.ToString("yyyy-MM-dd") + "  Check-out: " + _currentInfo.CheckOutDate.ToString("yyyy-MM-dd"), textFont, Brushes.Black, left, y);
            y += 20;
            e.Graphics.DrawString("Days: " + _currentInfo.StayDays + "  Room/Day: " + _currentInfo.RoomPricePerDayTotal.ToString("N0"), textFont, Brushes.Black, left, y);
            y += 30;

            e.Graphics.DrawString("Services:", textFont, Brushes.Black, left, y);
            y += 20;
            foreach (var s in _currentInfo.Services)
            {
                string line = "- " + s.ServiceName + " x" + s.Quantity + "  " + s.SubTotal.ToString("N0");
                e.Graphics.DrawString(line, textFont, Brushes.Black, left, y);
                y += 18;
            }
            y += 10;
            e.Graphics.DrawString("Room Total: " + _currentInfo.RoomTotal.ToString("N0"), textFont, Brushes.Black, left, y);
            y += 20;
            e.Graphics.DrawString("Service Total: " + _currentInfo.ServiceTotal.ToString("N0"), textFont, Brushes.Black, left, y);
            y += 20;
            e.Graphics.DrawString("Total: " + _currentInfo.TotalAmount.ToString("N0"), titleFont, Brushes.Black, left, y);
        }
    }
}
