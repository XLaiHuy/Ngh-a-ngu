using BUS;
using DAL;
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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        CustomerBUS _cus;
        frmBooking objDP = (frmBooking)Application.OpenForms["frmBooking"];
        bool _them = false;
        string _cccd;
        bool suaClick = false;
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            _cus = new CustomerBUS();
            loadData();
            enableText(false);
            showHideControl(true);
        }
        public void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnChan.Visible = t;
            btnRfresh.Visible = t;
            btnTim.Visible = t;
            btnLuu.Visible = !t;
            btnBoqua.Visible = !t;
        }
        private void refreshText()
        {
            tbHoTen.Text = "";
            tbCCCD.Text = "";
            tbSDT.Text = "";
            tbEmail.Text = "";
        }

        private void enableText(bool t)
        {
            tbHoTen.Enabled = t;
            tbCCCD.Enabled = t;
            tbSDT.Enabled = t;
            tbEmail.Enabled = t;
            grGender.Enabled = t;
        }
        public void loadData()
        {
            gcDanhSach.DataSource = _cus.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
            enableText(false);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
           showHideControl(false);
           enableText(true);
           refreshText();
           tbCCCD.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var cccdObj = gvDanhSach.GetFocusedRowCellValue("CCCD");
            if (cccdObj == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _cccd = cccdObj.ToString();
            // populate fields immediately
            tbHoTen.Text = gvDanhSach.GetFocusedRowCellValue("FullName")?.ToString();
            tbCCCD.Text = _cccd;
            tbSDT.Text = gvDanhSach.GetFocusedRowCellValue("Phone")?.ToString();
            tbEmail.Text = gvDanhSach.GetFocusedRowCellValue("Email")?.ToString();
            enableText(true);
            tbCCCD.Enabled = false;
            showHideControl(false);
            grGender.Enabled = true; // allow changing gender if needed
            // set gender radio
            var g = gvDanhSach.GetFocusedRowCellValue("Gender");
            if (g != null && g.ToString() == "Nam") rdNam.Checked = true; else rdNu.Checked = true;
            suaClick = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xoá không ?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var sel = gvDanhSach.GetFocusedRowCellValue("CCCD");
                if (sel == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _cccd = sel.ToString();
                try
                {
                    _cus.delete(_cccd);
                    loadData();
                    MessageBox.Show("Xoá khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // basic validation
            if (string.IsNullOrWhiteSpace(tbHoTen.Text))
            {
                MessageBox.Show("Tên khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbCCCD.Text))
            {
                MessageBox.Show("CCCD không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_them)
                {
                    // check duplicate CCCD
                    var exists = _cus.getItem(tbCCCD.Text);
                    if (exists != null)
                    {
                        MessageBox.Show("CCCD đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    Customer cus = new Customer();
                    cus.FullName = tbHoTen.Text.Trim();
                    cus.CCCD = tbCCCD.Text.Trim();
                    cus.Phone = tbSDT.Text.Trim();
                    cus.Email = tbEmail.Text.Trim();
                    cus.Gender = rdNam.Checked ? "Nam" : "Nữ";
                    _cus.add(cus);
                    MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // update
                    Customer cus = _cus.getItem(_cccd);
                    if (cus == null)
                    {
                        MessageBox.Show("Khách hàng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    cus.FullName = tbHoTen.Text.Trim();
                    cus.Phone = tbSDT.Text.Trim();
                    cus.Email = tbEmail.Text.Trim();
                    cus.Gender = rdNam.Checked ? "Nam" : "Nữ";
                    _cus.update(cus);
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                _them = false;
                suaClick = false;
                loadData();
                enableText(false);
                showHideControl(true);
                refreshText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn chặn khách hàng này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmNote fNote = new frmNote();
                if(fNote.ShowDialog() == DialogResult.OK)
                {
                    string reason = fNote.NoteText;
                    _cccd = gvDanhSach.GetFocusedRowCellValue("CCCD").ToString();
                    try
                    {
                        _cus.blockCustomer(_cccd, reason);
                        MessageBox.Show("Đã chặn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi chặn khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            _them = false;
            suaClick = false;
            showHideControl(true);
            enableText(false);
            refreshText();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (suaClick)
            {
                _cccd = gvDanhSach.GetFocusedRowCellValue("CCCD").ToString();
                tbHoTen.Text = gvDanhSach.GetFocusedRowCellValue("FullName").ToString();
                tbCCCD.Text = _cccd;
                tbSDT.Text = gvDanhSach.GetFocusedRowCellValue("Phone").ToString();
                tbEmail.Text = gvDanhSach.GetFocusedRowCellValue("Email").ToString();

            }
        }

       
        private void btnTim_Click(object sender, EventArgs e)
        {
            frmSearch nameSCus = new frmSearch();
            if(nameSCus.ShowDialog() == DialogResult.OK)
            {
                string nameCus = nameSCus.SearchText;
                if(_cus.checkNameExits(nameCus))
                    gcDanhSach.DataSource = _cus.getByName(nameCus);
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng nào có tên " + nameCus, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
                
        }

        private void btnRfresh_Click(object sender, EventArgs e)
        {
            enableText(false);
            refreshText();
            showHideControl(true);
            loadData();
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        private void gvDanhSach_DoubleClick(object sender, EventArgs e)
        {
            if(gvDanhSach.GetFocusedRowCellValue("CustomerID") != null)
            {
                objDP.loadKhachHang();
                objDP.setCustomer(int.Parse(gvDanhSach.GetFocusedRowCellValue("CustomerID").ToString()));
                this.Close();
            }
        }
    }
}

