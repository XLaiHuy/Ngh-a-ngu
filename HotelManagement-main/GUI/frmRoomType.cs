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
    public partial class frmRoomType : DevExpress.XtraEditors.XtraForm
    {
        public frmRoomType()
        {
            InitializeComponent();
        }
        BUS.RoomTypeBUS _rtBUS;
        bool _them = false;
        bool _sua = false;
        int _currentId = -1;

        private void frmRoomType_Load(object sender, EventArgs e)
        {
            _rtBUS = new BUS.RoomTypeBUS();
            loadData();
            showHideControl(true);
            enableText(false);
        }

        void loadData()
        {
            gcDanhSach.DataSource = _rtBUS.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
        }

        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnLuu.Visible = !t;
            btnRfresh.Visible = t;
            btnBoqua.Visible = !t;
            btnThoat.Visible = t;
        }

        void enableText(bool t)
        {
            txtTypeName.Enabled = t;
            txtPrice.Enabled = t;
            txtBedNumbers.Enabled = t;
            txtHumanCapacity.Enabled = t;
        }

        void clearInputs()
        {
            txtTypeName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtBedNumbers.Text = string.Empty;
            txtHumanCapacity.Text = string.Empty;
            _currentId = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            _sua = false;
            clearInputs();
            enableText(true);
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_currentId < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _sua = true;
            _them = false;
            enableText(true);
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_currentId < 0)
            {
                MessageBox.Show("Vui lòng chọn loại phòng để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn xoá không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var rt = _rtBUS.getItem(_currentId);
                if (rt != null)
                {
                    _rtBUS.remove(rt);
                    loadData();
                    clearInputs();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show("Tên loại phòng không được rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = 0;
            int bedNumbers = 0;
            int humanCap = 0;
            decimal.TryParse(txtPrice.Text.Replace(",", ""), out price);
            int.TryParse(txtBedNumbers.Text, out bedNumbers);
            int.TryParse(txtHumanCapacity.Text, out humanCap);

            if (_them)
            {
                var rt = new DAL.RoomType
                {
                    TypeName = txtTypeName.Text,
                    Price = price,
                    BedNumbers = bedNumbers,
                    HumanCapacity = humanCap
                };
                _rtBUS.add(rt);
            }
            else if (_sua)
            {
                var rt = _rtBUS.getItem(_currentId);
                if (rt != null)
                {
                    rt.TypeName = txtTypeName.Text;
                    rt.Price = price;
                    rt.BedNumbers = bedNumbers;
                    rt.HumanCapacity = humanCap;
                    _rtBUS.update(rt);
                }
            }

            _them = _sua = false;
            enableText(false);
            showHideControl(true);
            loadData();
            clearInputs();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            _them = _sua = false;
            enableText(false);
            showHideControl(true);
            clearInputs();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _currentId = (int)gvDanhSach.GetFocusedRowCellValue("RoomTypeID");

            txtTypeName.Text = gvDanhSach.GetFocusedRowCellValue("TypeName").ToString();
            txtPrice.Text = gvDanhSach.GetFocusedRowCellValue("Price").ToString();
            txtBedNumbers.Text = gvDanhSach.GetFocusedRowCellValue("BedNumbers").ToString();
            txtHumanCapacity.Text = gvDanhSach.GetFocusedRowCellValue("HumanCapacity").ToString();
        }

        private void btnRfresh_Click(object sender, EventArgs e)
        {

        }
    }
}