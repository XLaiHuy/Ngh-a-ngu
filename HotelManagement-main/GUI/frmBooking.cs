using BUS;
using DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout.Customization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBooking : DevExpress.XtraEditors.XtraForm
    {
        public frmBooking()
        {
            InitializeComponent();
        }
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        bool _them, _sua;
        int _idPhong =0;
        string _tenPhong;
        int _idDP = 0;
        int _rowDatPhong =0;
        RoomBUS _room;
        BookingDetailBUS _bookingDetail;
        BookingBUS _booking;
        BookingServiceBUS _bookingService;
        CustomerBUS _cus;
        ServiceBUS _sv;
        GridHitInfo downHitInfor = null;
        List<OBJ_DPSP> lstDPSP;
        private void frmBooking_Load(object sender, EventArgs e)
        {
            _bookingService = new BookingServiceBUS();
            _room = new RoomBUS();
            _bookingDetail = new BookingDetailBUS();
            _booking = new BookingBUS();
            _cus = new CustomerBUS();
            _sv = new ServiceBUS();
            lstDPSP = new List<OBJ_DPSP>();
            dtTuNgay.Value = myFunctions.GetFirstDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            dtDenNgay.Value = DateTime.Now.AddDays(1);
            loadDanhSach();
            loadKhachHang();
            loadSanPham();
            LoadAvailableRooms();
            LoadAvailableRooms();
            
            cboTrangThai.DataSource = dpTRANGTHAIBUS.getListTrangThai();
            cboTrangThai.DisplayMember = "_display";
            cboTrangThai.ValueMember = "_value";
            gvPhong.ExpandAllGroups();

            

            showHideControl(true);
            enableText(false);
            pageDanhDanh.SelectedTabPage = pageDanhSach;

            dtNgayDat.ValueChanged += (s, ev) => UpdateTotal();
            dtNgayTra.ValueChanged += (s, ev) => UpdateTotal();
        }

        public void loadDanhSach()
        {
            _booking = new BookingBUS();
            gcDanhSach.DataSource = _booking.getAll(dtTuNgay.Value,dtDenNgay.Value);
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        public void loadKhachHang()
        {
            cboKhachHang.DataSource = _cus.getAll();
            cboKhachHang.DisplayMember = "FullName";
            cboKhachHang.ValueMember = "CustomerID";
        }
        public void loadSanPham()
        {
            gcSanPham.DataSource = _sv.getAll();
            gvSanPham.OptionsBehavior.Editable = false;

        }

        private void LoadAvailableRooms()
        {
            DataTable dt = _booking.getAvailableRoomsTable();
            gcPhong.DataSource = dt;
            gcPhongdat.DataSource = dt.Clone();
        }

        private int GetStayDays()
        {
            return Math.Max(1, (int)(dtNgayTra.Value.Date - dtNgayDat.Value.Date).TotalDays);
        }

        private decimal GetRoomTotalPerDay()
        {
            decimal total = 0;
            for (int i = 0; i < gvPhongDat.RowCount; i++)
            {
                total += ParseDecimal(gvPhongDat.GetRowCellValue(i, "Price"));
            }
            return total;
        }

        private decimal GetServiceTotal()
        {
            decimal total = 0;
            for (int i = 0; i < gvSPDV.RowCount; i++)
            {
                total += ParseDecimal(gvSPDV.GetRowCellValue(i, "ThanhTien"));
            }
            return total;
        }

        private decimal CalculateTotal()
        {
            int days = GetStayDays();
            return (days * GetRoomTotalPerDay()) + GetServiceTotal();
        }

        private void UpdateTotal()
        {
            txtTongTien.Text = CalculateTotal().ToString("N0");
        }

        private static decimal ParseDecimal(object value)
        {
            if (value == null || value == DBNull.Value) return 0m;
            if (value is decimal dec) return dec;
            decimal result;
            if (decimal.TryParse(value.ToString(), NumberStyles.AllowThousands | NumberStyles.Number, CultureInfo.CurrentCulture, out result))
                return result;
            return 0m;
        }
        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnCheckOut.Visible = t;
            btnRE.Visible = t;
            btnLuu.Visible = !t;
            btnPrint.Visible = t;
            btnBoqua.Visible = !t;
            btnThoat.Visible = t;
        }

        void enableText(bool t)
        {
            btnAddKH.Enabled = t;
            cboKhachHang.Enabled = t;
            cboTrangThai.Enabled = t;
            txtGhiChu.Enabled = t;
            dtNgayDat.Enabled = t;
            dtNgayTra.Enabled = t;
            gcPhong.Enabled = t;
            gcPhongdat.Enabled = t;
            gcSanPham.Enabled = t;
            gcSPDV.Enabled = t; 
        }

        void refreshText()
        {
            dtNgayDat.Value = DateTime.Now;
            dtNgayTra.Value = DateTime.Now.AddDays(1);
            //cboKhachHang.Text = string.Empty;
            //cboTrangThai.Text = string.Empty;
            //txtGhiChu.Text = string.Empty;
            //ckTheoDoan.Checked = true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            _sua = false;
            refreshText();
            enableText(true);
            showHideControl(false);
            pageDanhDanh.SelectedTabPage = pageChiTiet;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _sua = true;
            _them = false;
            enableText(true);
            showHideControl(false);
            pageDanhDanh.SelectedTabPage = pageChiTiet;
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!SaveData())
                return;
            loadDanhSach();
            objMain.gControl.Gallery.Groups.Clear();
            objMain.showRoom();
            _them = false;
            _sua = false;
            enableText(false);
            showHideControl(true);
            refreshText();
            
        }
        bool SaveData()
        {
            if (dtNgayTra.Value.Date < dtNgayDat.Value.Date)
            {
                MessageBox.Show("Ngay check-out khong hop le.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (gvPhongDat.RowCount == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int soNgay = GetStayDays();
            decimal total = CalculateTotal();
            txtTongTien.Text = total.ToString("N0");

            if (_them)
            {
                Booking booking = new Booking();
                BookingDetail bookingDetail;
                BookingService bookingService;

                booking.CheckInDate = dtNgayDat.Value;
                booking.PlannedCheckOutDate = dtNgayTra.Value;
                booking.Channel = cboTrangThai.SelectedValue.ToString();
                booking.TheoDoan = ckTheoDoan.Checked;
                booking.CustomerID = (int)cboKhachHang.SelectedValue;
                booking.Note = txtGhiChu.Text;
                booking.CheckOut = false;
                booking.TotalPrice = total;
                try
                {
                    var _dp = _booking.add(booking);
                    _idDP = _dp.BookingID;
                    for (int i = 0; i < gvPhongDat.RowCount; i++)
                    {
                        bookingDetail = new BookingDetail();
                        bookingDetail.BookingID = _dp.BookingID;
                        bookingDetail.RoomID = (int)gvPhongDat.GetRowCellValue(i, "RoomID");
                        bookingDetail.SONGAYO = soNgay;
                        bookingDetail.CheckInDate = dtNgayDat.Value;
                        bookingDetail.CheckOutDate = dtNgayTra.Value;
                        bookingDetail.NGAY = DateTime.Now;
                        bookingDetail.RoomPrice = ParseDecimal(gvPhongDat.GetRowCellValue(i, "Price"));
                        bookingDetail.THANHTIEN = bookingDetail.SONGAYO * bookingDetail.RoomPrice;
                        var _dpct = _bookingDetail.add(bookingDetail);
                        _room.updateStatus((int)bookingDetail.RoomID, "Cho thuê");
                        if (gvSPDV.RowCount > 0)
                        {
                            for (int j = 0; j < gvSPDV.RowCount; j++)
                            {
                                if (bookingDetail.RoomID == (int)gvSPDV.GetRowCellValue(j, "RoomID"))
                                {
                                    bookingService = new BookingService();
                                    bookingService.BookingID = _dp.BookingID;
                                    bookingService.BookingDetailID = _dpct.BookingDetailID;
                                    bookingService.RoomID = (int)gvSPDV.GetRowCellValue(j, "RoomID");
                                    bookingService.ServiceID = (int)gvSPDV.GetRowCellValue(j, "ServiceID");
                                    bookingService.Quantity = (int)gvSPDV.GetRowCellValue(j, "Quantity");
                                    bookingService.DONGIA = ParseDecimal(gvSPDV.GetRowCellValue(j, "Price"));
                                    bookingService.THANHTIEN = ParseDecimal(gvSPDV.GetRowCellValue(j, "ThanhTien"));
                                    _bookingService.add(bookingService);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (_idDP > 0)
                        _booking.delete(_idDP);
                    MessageBox.Show("Lỗi khi đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                //update

                Booking booking = _booking.getItem(_idDP);
                BookingDetail bookingDetail;
                BookingService bookingService;

                booking.CheckInDate = dtNgayDat.Value;
                booking.PlannedCheckOutDate = dtNgayTra.Value;
                booking.Channel = cboTrangThai.SelectedValue.ToString();
                booking.CustomerID = (int)cboKhachHang.SelectedValue;
                booking.Note = txtGhiChu.Text;
                booking.TotalPrice = total;
                try
                {
                    var _dp = _booking.update(booking);
                    _idDP = _dp.BookingID;

                    var oldDetails = _bookingDetail.getByBooking(_dp.BookingID);
                    foreach (var d in oldDetails)
                        _room.updateStatus(d.RoomID, "Trống");

                    _bookingService.deleteAll(_dp.BookingID);
                    _bookingDetail.deleteAll(_dp.BookingID);

                    for (int i = 0; i < gvPhongDat.RowCount; i++)
                    {
                        bookingDetail = new BookingDetail();
                        bookingDetail.BookingID = _dp.BookingID;
                        bookingDetail.RoomID = (int)gvPhongDat.GetRowCellValue(i, "RoomID");
                        bookingDetail.SONGAYO = soNgay;
                        bookingDetail.RoomPrice = ParseDecimal(gvPhongDat.GetRowCellValue(i, "Price"));
                        bookingDetail.CheckInDate = dtNgayDat.Value;
                        bookingDetail.CheckOutDate = dtNgayTra.Value;
                        bookingDetail.NGAY = DateTime.Now;
                        bookingDetail.THANHTIEN = bookingDetail.SONGAYO * bookingDetail.RoomPrice;
                        var _dpct = _bookingDetail.add(bookingDetail);
                        _room.updateStatus((int)bookingDetail.RoomID, "Cho thuê");
                        if (gvSPDV.RowCount > 0)
                        {
                            for (int j = 0; j < gvSPDV.RowCount; j++)
                            {
                                if (bookingDetail.RoomID == (int)gvSPDV.GetRowCellValue(j, "RoomID"))
                                {
                                    bookingService = new BookingService();
                                    bookingService.BookingID = _dp.BookingID;
                                    bookingService.BookingDetailID = _dpct.BookingDetailID;
                                    bookingService.RoomID = (int)gvSPDV.GetRowCellValue(j, "RoomID");
                                    bookingService.ServiceID = (int)gvSPDV.GetRowCellValue(j, "ServiceID");
                                    bookingService.Quantity = (int)gvSPDV.GetRowCellValue(j, "Quantity");
                                    bookingService.DONGIA = ParseDecimal(gvSPDV.GetRowCellValue(j, "Price"));
                                    bookingService.THANHTIEN = ParseDecimal(gvSPDV.GetRowCellValue(j, "ThanhTien"));
                                    _bookingService.add(bookingService);
                                }

                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật booking: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            _them = false;
            _sua = false;
            showHideControl(true);
            enableText(false);
            refreshText();
            pageDanhDanh.SelectedTabPage = pageDanhSach;


        }

        private void gvPhongDat_MouseDown(object sender, MouseEventArgs e)
        {
            if(gvPhongDat.GetFocusedRowCellValue("RoomID") != null)
            {
                _idPhong = (int)gvPhongDat.GetFocusedRowCellValue("RoomID");
                _tenPhong = (string)gvPhongDat.GetFocusedRowCellValue("RoomCode");
            }
            GridView view = sender as GridView;
            downHitInfor = null;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if (Control.ModifierKeys != Keys.None) return;
            if(e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfor = hitInfo;
            }
        }

        private void gvPhongDat_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfor != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfor.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfor = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void gvPhong_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfor != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfor.HitPoint.X - dragSize.Width / 2, downHitInfor.HitPoint.Y - dragSize.Height / 2), dragSize);
                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfor.RowHandle);
                    view.GridControl.DoDragDrop(row, DragDropEffects.Move);
                    downHitInfor = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void gvPhong_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfor = null;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0)
            {
                downHitInfor = hitInfo;
            }
        }

        private void gcPhong_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = sender as GridControl;
            DataTable table = grid.DataSource as DataTable;
            DataRow row = e.Data.GetData(typeof(DataRow)) as DataRow;   
            if (row != null && table != null && row.Table != table)
            {
                table.ImportRow(row);
                row.Delete();
            }
        }

        private void gcPhong_DragOver(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(DataRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void gvPhong_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if(info.Column.Caption == string.Empty)
            {
                caption = info.Column.ToString();
            }
            info.GroupText = string.Format("{0}: {1} ({2} phòng trống)", caption, info.GroupValueText, view.GetChildRowCount(e.RowHandle));
        }

        private void gcSanPham_DoubleClick(object sender, EventArgs e)
        {
            if(_idPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(gvSanPham.GetFocusedRowCellValue("ServiceID") != null)
            {
                OBJ_DPSP sp = new OBJ_DPSP();
                sp.ServiceID = (int)gvSanPham.GetFocusedRowCellValue("ServiceID");
                sp.NameService = gvSanPham.GetFocusedRowCellValue("NameService").ToString();
                sp.Price = (decimal)gvSanPham.GetFocusedRowCellValue("Price");
                sp.RoomID = _idPhong;
                sp.RoomCode = _tenPhong;
                sp.Quantity = 1;
                sp.ThanhTien = (decimal)(sp.Price * sp.Quantity);

                foreach(var item in lstDPSP)
                {
                    if(item.ServiceID == sp.ServiceID && item.RoomID == sp.RoomID)
                     {
                         item.Quantity += 1;
                         item.ThanhTien = (decimal)(item.Price * item.Quantity);
                        loadDPSP();
                        UpdateTotal();
                        return;
                    }
                }
                lstDPSP.Add(sp);
            }
            loadDPSP();
            UpdateTotal();

        }
        public void loadDPSP()
        {
            //List<OBJ_DPSP> lst = new List<OBJ_DPSP>();
            //    foreach(var item in lstDPSP)
            //    {
            //            lst.Add(item);
            //    }
            //gcSPDV.DataSource = lst;

            gcSPDV.DataSource = null; // Reset lại kết nối cũ
            gcSPDV.DataSource = lstDPSP;
        }

        private void gvSPDV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName =="Quantity")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    decimal price = decimal.Parse(gvSPDV.GetRowCellValue(gvSPDV.FocusedRowHandle,"Price").ToString());
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "ThanhTien", sl * price);
                }
                else
                {
                    gvSPDV.SetRowCellValue(gvSPDV.FocusedRowHandle, "ThanhTien", 0);

                }
                gvSPDV.UpdateTotalSummary();
                UpdateTotal();

            }
        }


        private void gvPhongDat_RowCountChanged(object sender, EventArgs e)
        {
             //decimal t = 0;
            //if (gvSPDV.Columns["ThanhTien"].SummaryItem.SummaryValue != null)
            //{
            //    t += decimal.Parse(gvSPDV.Columns["ThanhTien"].SummaryItem.SummaryValue.ToString());
            //}
            //else
            //{
            //    t = decimal.Parse(gvPhongDat.Columns["Price"].SummaryItem.SummaryValue.ToString());
            //}
            //txtTongTien.Text = t.ToString("N0");
            if(gvPhongDat.RowCount < _rowDatPhong && _them == false)
            {
                _room.updateStatus(_idPhong, "Trống");
                _bookingService.removeByRoom(_idDP, _idPhong);
                _bookingDetail.remove(_idDP,_idPhong);
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
            }
            UpdateTotal();
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
        }

        public void setCustomer(int id)
        {
            var _kh = _cus.getItem(id);
            cboKhachHang.SelectedValue = _kh.CustomerID;
            cboKhachHang.Text = _kh.FullName;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idDP = int.Parse(gvDanhSach.GetFocusedRowCellValue("BookingID").ToString());
                var dp = _booking.getItem(_idDP);
                cboKhachHang.SelectedValue = dp.CustomerID;
                dtNgayDat.Value = dp.CheckInDate.Value;
                dtNgayTra.Value = dp.PlannedCheckOutDate.Value;
                cboTrangThai.Text = dp.Channel;
                txtGhiChu.Text = dp.Note;
                txtTongTien.Text = dp.TotalPrice.Value.ToString("N0");
                ckTheoDoan.Checked = dp.TheoDoan.Value;
                loadDP();
                loadDPSP_Click();
                UpdateTotal();
            }
        }
        public void loadDP()
        {
            gcPhongdat.DataSource = _booking.getBookedRoomsTable(_idDP);
            _rowDatPhong = gvPhongDat.RowCount;
        }
        public void loadDPSP_Click()
        {
            gcSPDV.DataSource = _bookingService.getByBooking(_idDP);
        }

        private void gvPhongDat_Click(object sender, EventArgs e)
        {
        }

        private void gvDanhSach_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Channel")
            {
                if (e.Value == null) return;
                bool val = false;
                if (e.Value is bool b)
                    val = b;
                else
                    bool.TryParse(e.Value.ToString(), out val);
                e.DisplayText = val ? "Đã thanh toán" : "Chưa thanh toán";
            }
        }

        private void dtTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if(dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtTuNgay.Value = dtDenNgay.Value.AddDays(-1);
            }
            else
            {
                loadDanhSach();
            }
        }

        private void dtTuNgay_Leave(object sender, EventArgs e)
        {
            if (dtTuNgay.Value > dtDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtTuNgay.Value = dtDenNgay.Value.AddDays(-1);
            }
            else
            {
                loadDanhSach();
            }
        }

        private void dtDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtDenNgay.Value < dtTuNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 dtDenNgay.Value = dtTuNgay.Value.AddDays(1);
            }
            else
            {
                loadDanhSach();
            }
        }

        private void dtDenNgay_Leave(object sender, EventArgs e)
        {
            if (dtDenNgay.Value < dtTuNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtDenNgay.Value = dtTuNgay.Value.AddDays(1);
            }
            else
            {
                loadDanhSach();
            }
        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _idDP = int.Parse(gvDanhSach.GetFocusedRowCellValue("BookingID").ToString());
                var dp = _booking.getItem(_idDP);
                cboKhachHang.SelectedValue = dp.CustomerID;
                dtNgayDat.Value = dp.CheckInDate.Value;
                dtNgayTra.Value = dp.PlannedCheckOutDate.Value;
                cboTrangThai.Text = dp.Channel;
                txtGhiChu.Text = dp.Note;
                txtTongTien.Text = dp.TotalPrice.Value.ToString("N0");
                ckTheoDoan.Checked = dp.TheoDoan.Value;
                loadDP();
                loadDPSP_Click();
                UpdateTotal();
            }
            pageDanhDanh.SelectedTabPage = pageChiTiet;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Lấy booking id hiện tại nếu chưa có
            if (_idDP == 0 && gvDanhSach.RowCount > 0)
            {
                var val = gvDanhSach.GetFocusedRowCellValue("BookingID");
                if (val != null) _idDP = Convert.ToInt32(val);
            }

            if (_idDP == 0)
            {
                MessageBox.Show("Vui lòng chọn booking để checkout.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Xác nhận checkout cho booking này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                // Ghi ngày checkout và tính tiền trên DB
                _booking.checkOut(_idDP);

                MessageBox.Show("Checkout thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDanhSach();
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi checkout: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            // Hiển thị icon khi cột CheckOutDate có giá trị (đã checkout)
            if (e.Column.FieldName == "CheckOut")
            {
                if (e.CellValue != null && e.CellValue != DBNull.Value)
                {
                    try
                    {
                        Image img = Properties.Resources.check;
                        // Vẽ ảnh ở giữa ô
                        int imgW = img.Width;
                        int imgH = img.Height;
                        int x = e.Bounds.X + (e.Bounds.Width - imgW) / 2;
                        int y = e.Bounds.Y + (e.Bounds.Height - imgH) / 2;
                        e.Graphics.DrawImage(img, x, y, imgW, imgH);
                        e.Handled = true;
                    }
                    catch
                    {
                        // Nếu lỗi vẽ ảnh, fallback không block render
                    }
                }
            }
        }

        private void btnRE_Click(object sender, EventArgs e)
        {
            loadDanhSach();
            loadKhachHang();
            loadSanPham();



            _idDP = 0;
            _idPhong = 0;
            _tenPhong = "";
            lstDPSP = new List<OBJ_DPSP>();
            loadDPSP();

            // Reset UI
            gcPhongdat.DataSource = null;
            gcSPDV.DataSource = null;
            txtTongTien.Text = "0";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}