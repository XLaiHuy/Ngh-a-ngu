using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRooms : DevExpress.XtraEditors.XtraForm
    {
        public frmRooms()
        {
            InitializeComponent();
        }
        RoomBUS _room;
        FloorBUS _floor;
        RoomTypeBUS _roomType;
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        bool _them = false;
        bool _sua = false;
        int _currentId = -1;
        private void frmRooms_Load(object sender, EventArgs e)
        {
            _room = new RoomBUS();
            _floor = new FloorBUS();
            _roomType = new RoomTypeBUS();
            loadData();
            enableText(false);
            showHideControl(true);
            // handle selection changes
            gvDanhSach.FocusedRowChanged += gvDanhSach_FocusedRowChanged;
        }
        public void loadFloor()
        {
            var lsTang = _floor.GetAll();
            cboTang.DataSource = lsTang;
            cboTang.DisplayMember = "FloorName";
            cboTang.ValueMember = "FloorID";
        }
        public void loadRoomType()
        {
            var lsLoaiPhong = _roomType.getAll();
            cboLoaiPhong.DataSource = lsLoaiPhong;
            cboLoaiPhong.DisplayMember = "TypeName";
            cboLoaiPhong.ValueMember = "RoomTypeID";
        }
        public void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnRfresh.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;
        }
        private void refreshText()
        {
            txtTenPhong.Text = "";
        }

        private void enableText(bool t)
        {
            txtTenPhong.Enabled = t;
            cboTang.Enabled = t;
            cboLoaiPhong.Enabled = t;
            grbStatus.Enabled = t;
            
        }
        public void loadData()
        {
            // load rooms ordered by FloorID then RoomCode so the list is grouped/sorted by floor
            var list = _room.getAllWithDetails()
                        .OrderBy(r => r.FloorID ?? int.MaxValue)
                        .ThenBy(r => r.RoomCode)
                        .ToList();
            gcDanhSach.DataSource = list;
            loadFloor();
            loadRoomType();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            _sua = false;
            _currentId = -1;
            txtTenPhong.Text = string.Empty;
            enableText(true);
            SetStatusRadios("Trống");
            showHideControl(false);
            txtTenPhong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var idObj = gvDanhSach.GetFocusedRowCellValue("RoomID");
            if (idObj == null)
            {
                MessageBox.Show("Vui lòng chọn 1 phòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _currentId = Convert.ToInt32(idObj);
            // populate inputs
            txtTenPhong.Text = gvDanhSach.GetFocusedRowCellValue("RoomCode")?.ToString();
            var floorVal = gvDanhSach.GetFocusedRowCellValue("FloorID");
            if (floorVal != null) cboTang.SelectedValue = floorVal;
            var typeVal = gvDanhSach.GetFocusedRowCellValue("RoomTypeID");
            if (typeVal != null) cboLoaiPhong.SelectedValue = typeVal;

            _sua = true;
            _them = false;
            enableText(true);
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var codeObj = gvDanhSach.GetFocusedRowCellValue("RoomCode");
            if (codeObj == null)
            {
                MessageBox.Show("Vui lòng chọn phòng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string code = codeObj.ToString();
            if (MessageBox.Show($"Bạn có chắc chắn xoá phòng {code}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _room.remove(code);
                    loadData();
                    MessageBox.Show("Xoá thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenPhong.Text))
            {
                MessageBox.Show("Tên phòng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var room = new DAL.Room();
                room.RoomCode = txtTenPhong.Text.Trim();
                room.FloorID = cboTang.SelectedValue != null ? (int?)Convert.ToInt32(cboTang.SelectedValue) : null;
                room.RoomTypeID = cboLoaiPhong.SelectedValue != null ? (int?)Convert.ToInt32(cboLoaiPhong.SelectedValue) : null;
                room.Status = GetSelectedStatus();
                room.AllowExtraPeople = false;

                if (_them)
                {
                    _room.add(room);
                    MessageBox.Show("Thêm phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_sua)
                {
                    room.RoomID = _currentId;
                    _room.update(room);
                    MessageBox.Show("Cập nhật phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // reset UI
                _them = _sua = false;
                enableText(false);
                showHideControl(true);
                loadData();
                objMain.gControl.Gallery.Groups.Clear();
                objMain.showRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            _them = _sua = false;
            enableText(false);
            showHideControl(true);
            loadData();
        }

        private void btnRfresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var idObj = gvDanhSach.GetFocusedRowCellValue("RoomID");
            if (idObj == null) return;
            _currentId = Convert.ToInt32(idObj);
            txtTenPhong.Text = gvDanhSach.GetFocusedRowCellValue("RoomCode")?.ToString();
            var floorVal = gvDanhSach.GetFocusedRowCellValue("FloorID");
            if (floorVal != null) cboTang.SelectedValue = floorVal;
            var typeVal = gvDanhSach.GetFocusedRowCellValue("RoomTypeID");
            if (typeVal != null) cboLoaiPhong.SelectedValue = typeVal;
            // set status radio according to selection
            var statusVal = gvDanhSach.GetFocusedRowCellValue("Status");
            if (statusVal != null)
                SetStatusRadios(statusVal.ToString());
        }

        private string GetSelectedStatus()
        {
            if (rdThue.Checked) return "Cho thuê";
            if (rdDon.Checked) return "Dọn";
            return "Trống";
        }

        private void SetStatusRadios(string status)
        {
            rdTrong.Checked = status == "Trống";
            rdThue.Checked = status == "Cho thuê";
            rdDon.Checked = status == "Dọn";
        }
    }
}