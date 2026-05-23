using BUS;
using DAL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmService : DevExpress.XtraEditors.XtraForm
    {
        public frmService()
        {
            InitializeComponent();
        }

        ServiceBUS _sv;
        ServiceTypeBUS _svt;
        bool _them, _sua;
        int idSv;
        private void frmService_Load(object sender, EventArgs e)
        {
            _sv = new ServiceBUS();
            _svt = new ServiceTypeBUS();
            loadData();
            enableText(false);

        }
        public void loadData()
        {
            // load services and include service type name for display
            var list = _sv.getAllDetail().OrderBy(s => s.Price).ToList();
            loadServiceType();
            gcDanhSach.DataSource = list;
            gvDanhSach.OptionsBehavior.Editable = false;
            // setup sort combo box
            cboSort.Items.Clear();
            cboSort.Items.Add("Giá tăng dần");
            cboSort.Items.Add("Giá giảm dần");
            cboSort.Items.Add("Loại dịch vụ A-Z");
            cboSort.Items.Add("Loại dịch vụ Z-A");
            if (cboSort.Items.Count > 0 && cboSort.SelectedIndex < 0) cboSort.SelectedIndex = 0;

        }
        public void loadServiceType()
        {
            var list = _svt.getAll();
            cboLoaiDichVu.DataSource = list;
            cboLoaiDichVu.DisplayMember = "Type";
            cboLoaiDichVu.ValueMember = "ServiceTypeID";
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
            tbTen.Enabled = t;
            tbDonGia.Enabled = t;
        }
        private void refreshText()
        {
            tbTen.Text = "";
            tbDonGia.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            enableText(true);
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbDonGia.Enabled = true;
            tbTen.Enabled = true;
            _sua = true;
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                idSv = int.Parse(gvDanhSach.GetFocusedRowCellValue("ServiceID").ToString());
                _sv.delete(idSv);
                loadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                Service sv = new Service();
                sv.NameService = tbTen.Text;
                sv.Price = decimal.Parse(tbDonGia.Text);
                sv.TypeID = (int)cboLoaiDichVu.SelectedValue;
                _sv.add(sv);
            }
            else
            {
                Service sv = _sv.getItem(idSv);
                sv.NameService = tbTen.Text;
                sv.Price = decimal.Parse(tbDonGia.Text);
                sv.TypeID = (int)cboLoaiDichVu.SelectedValue;
                _sv.update(sv);
            }
            _sua = false;
            refreshText();
            showHideControl(true);
            loadData();
            enableText(false);
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            enableText(false);
            refreshText();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (_sua)
            {
                idSv = int.Parse(gvDanhSach.GetFocusedRowCellValue("ServiceID").ToString());
                tbTen.Text = gvDanhSach.GetFocusedRowCellValue("NameService").ToString();
                tbDonGia.Text = gvDanhSach.GetFocusedRowCellValue("Price").ToString();
                var typeId = gvDanhSach.GetFocusedRowCellValue("TypeID");
                if (typeId != null)
                {
                    try { cboLoaiDichVu.SelectedValue = Convert.ToInt32(typeId); } catch { }
                }
            }
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = _sv.getAllDetail();
            switch (cboSort.SelectedIndex)
            {
                case 0: // price asc
                    list = list.OrderBy(s => s.Price).ToList();
                    break;
                case 1: // price desc
                    list = list.OrderByDescending(s => s.Price).ToList();
                    break;
                case 2: // type A-Z
                    list = list.OrderBy(s => s.Type).ThenBy(s => s.Price).ToList();
                    break;
                case 3: // type Z-A
                    list = list.OrderByDescending(s => s.Type).ThenBy(s => s.Price).ToList();
                    break;
                default:
                    list = list.OrderBy(s => s.Price).ToList();
                    break;
            }
            gcDanhSach.DataSource = list;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}