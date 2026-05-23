using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTang : DevExpress.XtraEditors.XtraForm
    {
        public frmTang()
        {
            InitializeComponent();
        }
        FloorBUS _flo;
        bool _them = false;
        bool _sua = false;
        int _currentId = -1;
        private void frmTang_Load(object sender, EventArgs e)
        {
            _flo = new FloorBUS();
            LoadData();
            showHideControl(true);
            enableText(false);
            gvDanhSach.FocusedRowChanged += gvDanhSach_FocusedRowChanged;
        }

        public void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;
        }
        private void enableText(bool t)
        {
            txtTenTang.Enabled = t;
        }
        public void LoadData()
        {
            gcDanhSach.DataSource =_flo.GetAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            _sua = false;
            _currentId = -1;
            txtTenTang.Text = string.Empty;
            showHideControl(false);
            enableText(true);
            txtTenTang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var idObj = gvDanhSach.GetFocusedRowCellValue("FloorID");
            if (idObj == null)
            {
                MessageBox.Show("Vui lòng chọn tầng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _currentId = Convert.ToInt32(idObj);
            txtTenTang.Text = gvDanhSach.GetFocusedRowCellValue("FloorName")?.ToString();
            _sua = true;
            _them = false;
            showHideControl(false);
            enableText(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var nameObj = gvDanhSach.GetFocusedRowCellValue("FloorName");
            if (nameObj == null)
            {
                MessageBox.Show("Vui lòng chọn tầng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = nameObj.ToString();
            if (MessageBox.Show($"Bạn có chắc chắn xoá tầng '{name}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    _flo.delete(name);
                    LoadData();
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
            if (string.IsNullOrWhiteSpace(txtTenTang.Text))
            {
                MessageBox.Show("Tên tầng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_them)
                {
                    var floor = new DAL.Floor { FloorName = txtTenTang.Text.Trim() };
                    _flo.add(floor);
                    MessageBox.Show("Thêm tầng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_sua)
                {
                    _flo.update(_currentId, txtTenTang.Text.Trim());
                    MessageBox.Show("Cập nhật tầng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // reset
                _them = _sua = false;
                enableText(false);
                showHideControl(true);
                LoadData();
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
            LoadData();
        }

        private void gvDanhSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var idObj = gvDanhSach.GetFocusedRowCellValue("FloorID");
            if (idObj == null) return;
            _currentId = Convert.ToInt32(idObj);
            txtTenTang.Text = gvDanhSach.GetFocusedRowCellValue("FloorName")?.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}