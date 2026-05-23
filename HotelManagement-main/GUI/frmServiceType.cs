using BUS;
using DAL;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
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
    public partial class frmServiceType : DevExpress.XtraEditors.XtraForm
    {
        public frmServiceType()
        {
            InitializeComponent();
        }

        ServiceTypeBUS _svType;
        bool _them,_sua;
        string _maLDV;
        
        private void frmServiceType_Load(object sender, EventArgs e)
        {
            _svType = new ServiceTypeBUS();
            loadData();
            showHideControl(true);
            enableText(false);
        }
        public void loadData()
        {
            gcDanhSach.DataSource = _svType.getAll();
            gvDanhSach.OptionsBehavior.Editable = false;
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
            txtTen.Enabled = t;
            txtMaLDV.Enabled = t;
        }
        private void refreshText()
        {
            txtTen.Text = "";
            txtMaLDV.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            enableText(true);
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaLDV.Enabled = false;
            txtTen.Enabled = true;
            _sua = true;
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                 _maLDV = gvDanhSach.GetFocusedRowCellValue("MaServiceType").ToString();
                _svType.remove(_maLDV);
                loadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                ServiceType type = new ServiceType();
                type.MaServiceType = txtMaLDV.Text;
                type.Type = txtTen.Text;
                _svType.add(type);
            }
            else
            {
                ServiceType type =_svType.getItem(_maLDV);
                type.Type = txtTen.Text;
                _svType.update(type);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (_sua)
            {
                _maLDV = gvDanhSach.GetFocusedRowCellValue("MaServiceType").ToString();
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("Type").ToString();
                txtMaLDV.Text = _maLDV;
            }
        }
    }
}