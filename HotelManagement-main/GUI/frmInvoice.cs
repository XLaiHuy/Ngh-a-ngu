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
    public class frmInvoice : XtraForm
    {
        private readonly InvoiceBUS _invoiceBus;
        private InvoiceInfoDTO _currentInfo;
        private PrintDocument _printDoc;
        private PrintPreviewDialog _preview;

        private ComboBox cboBooking;
        private Button btnCalculate;
        private Button btnSave;
        private Button btnPrint;

        private TextBox txtCustomerName;
        private TextBox txtCustomerCCCD;
        private TextBox txtCustomerPhone;

        private TextBox txtRooms;
        private TextBox txtCheckIn;
        private TextBox txtCheckOut;
        private TextBox txtDays;
        private TextBox txtRoomPricePerDay;
        private TextBox txtRoomTotal;

        private TextBox txtServiceTotal;
        private TextBox txtTotal;

        private DataGridView dgvServices;

        public frmInvoice()
        {
            _invoiceBus = new InvoiceBUS();
            InitializeComponent();
            LoadBookings();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
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

        private void InitializeComponent()
        {
            Text = "Hóa đơn";
            Width = 1000;
            Height = 720;
            StartPosition = FormStartPosition.CenterParent;

            var root = new TableLayoutPanel();
            root.Dock = DockStyle.Fill;
            root.RowCount = 4;
            root.ColumnCount = 1;
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 180));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));
            Controls.Add(root);

            // Top panel
            var topPanel = new FlowLayoutPanel();
            topPanel.Dock = DockStyle.Fill;
            topPanel.FlowDirection = FlowDirection.LeftToRight;
            topPanel.WrapContents = false;
            topPanel.Padding = new Padding(10, 10, 10, 10);
            topPanel.Controls.Add(new Label { Text = "Booking:", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft });

            cboBooking = new ComboBox();
            cboBooking.Width = 280;
            cboBooking.DropDownStyle = ComboBoxStyle.DropDownList;
            topPanel.Controls.Add(cboBooking);

            btnCalculate = new Button();
            btnCalculate.Text = "Calculate";
            btnCalculate.Width = 120;
            btnCalculate.Click += btnCalculate_Click;
            topPanel.Controls.Add(btnCalculate);

            root.Controls.Add(topPanel, 0, 0);

            // Info panel
            var infoPanel = new TableLayoutPanel();
            infoPanel.Dock = DockStyle.Fill;
            infoPanel.ColumnCount = 2;
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            infoPanel.RowCount = 1;

            var grpCustomer = new GroupBox();
            grpCustomer.Text = "Customer";
            grpCustomer.Dock = DockStyle.Fill;
            grpCustomer.Padding = new Padding(10);
            grpCustomer.Controls.Add(BuildCustomerPanel());

            var grpRoom = new GroupBox();
            grpRoom.Text = "Room";
            grpRoom.Dock = DockStyle.Fill;
            grpRoom.Padding = new Padding(10);
            grpRoom.Controls.Add(BuildRoomPanel());

            infoPanel.Controls.Add(grpCustomer, 0, 0);
            infoPanel.Controls.Add(grpRoom, 1, 0);
            root.Controls.Add(infoPanel, 0, 1);

            // Services grid
            dgvServices = new DataGridView();
            dgvServices.Dock = DockStyle.Fill;
            dgvServices.AutoGenerateColumns = false;
            dgvServices.ReadOnly = true;
            dgvServices.AllowUserToAddRows = false;
            dgvServices.AllowUserToDeleteRows = false;

            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ServiceName", HeaderText = "Service", Width = 240 });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qty", Width = 80 });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Unit Price", Width = 120 });
            dgvServices.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SubTotal", HeaderText = "Sub Total", Width = 120 });

            root.Controls.Add(dgvServices, 0, 2);

            // Bottom panel
            var bottomPanel = new FlowLayoutPanel();
            bottomPanel.Dock = DockStyle.Fill;
            bottomPanel.FlowDirection = FlowDirection.LeftToRight;
            bottomPanel.WrapContents = false;
            bottomPanel.Padding = new Padding(10, 10, 10, 10);

            bottomPanel.Controls.Add(new Label { Text = "Service Total:", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft });
            txtServiceTotal = CreateReadOnlyBox(120);
            bottomPanel.Controls.Add(txtServiceTotal);

            bottomPanel.Controls.Add(new Label { Text = "Total:", AutoSize = true, Margin = new Padding(20, 0, 0, 0) });
            txtTotal = CreateReadOnlyBox(120);
            bottomPanel.Controls.Add(txtTotal);

            btnSave = new Button();
            btnSave.Text = "Save Invoice";
            btnSave.Width = 140;
            btnSave.Margin = new Padding(30, 0, 0, 0);
            btnSave.Click += btnSave_Click;
            bottomPanel.Controls.Add(btnSave);

            btnPrint = new Button();
            btnPrint.Text = "Print Invoice";
            btnPrint.Width = 140;
            btnPrint.Click += btnPrint_Click;
            bottomPanel.Controls.Add(btnPrint);

            root.Controls.Add(bottomPanel, 0, 3);

            _printDoc = new PrintDocument();
            _printDoc.PrintPage += PrintDoc_PrintPage;
            _preview = new PrintPreviewDialog();
            _preview.Document = _printDoc;
            _preview.Width = 1000;
            _preview.Height = 800;
        }

        private Control BuildCustomerPanel()
        {
            var panel = new TableLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.ColumnCount = 2;
            panel.RowCount = 3;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            panel.Controls.Add(new Label { Text = "Name", AutoSize = true }, 0, 0);
            txtCustomerName = CreateReadOnlyBox(220);
            panel.Controls.Add(txtCustomerName, 1, 0);

            panel.Controls.Add(new Label { Text = "CCCD", AutoSize = true }, 0, 1);
            txtCustomerCCCD = CreateReadOnlyBox(220);
            panel.Controls.Add(txtCustomerCCCD, 1, 1);

            panel.Controls.Add(new Label { Text = "Phone", AutoSize = true }, 0, 2);
            txtCustomerPhone = CreateReadOnlyBox(220);
            panel.Controls.Add(txtCustomerPhone, 1, 2);

            return panel;
        }

        private Control BuildRoomPanel()
        {
            var panel = new TableLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.ColumnCount = 2;
            panel.RowCount = 6;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            panel.Controls.Add(new Label { Text = "Rooms", AutoSize = true }, 0, 0);
            txtRooms = CreateReadOnlyBox(220);
            panel.Controls.Add(txtRooms, 1, 0);

            panel.Controls.Add(new Label { Text = "Check-in", AutoSize = true }, 0, 1);
            txtCheckIn = CreateReadOnlyBox(220);
            panel.Controls.Add(txtCheckIn, 1, 1);

            panel.Controls.Add(new Label { Text = "Check-out", AutoSize = true }, 0, 2);
            txtCheckOut = CreateReadOnlyBox(220);
            panel.Controls.Add(txtCheckOut, 1, 2);

            panel.Controls.Add(new Label { Text = "Days", AutoSize = true }, 0, 3);
            txtDays = CreateReadOnlyBox(120);
            panel.Controls.Add(txtDays, 1, 3);

            panel.Controls.Add(new Label { Text = "Room/Day", AutoSize = true }, 0, 4);
            txtRoomPricePerDay = CreateReadOnlyBox(120);
            panel.Controls.Add(txtRoomPricePerDay, 1, 4);

            panel.Controls.Add(new Label { Text = "Room Total", AutoSize = true }, 0, 5);
            txtRoomTotal = CreateReadOnlyBox(120);
            panel.Controls.Add(txtRoomTotal, 1, 5);

            return panel;
        }

        private static TextBox CreateReadOnlyBox(int width)
        {
            return new TextBox { ReadOnly = true, Width = width };
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
