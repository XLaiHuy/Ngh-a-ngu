using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConnectDB : DevExpress.XtraEditors.XtraForm
    {
        private readonly ConnectionBUS _connBus;

        public frmConnectDB()
        {
            InitializeComponent();
            _connBus = new ConnectionBUS();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string error;
            bool ok = _connBus.TestConnection(tbServer.Text, tbUsername.Text, tbPassword.Text, cboDatabase.Text, out error);
            if (ok)
                MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Kết nối thất bại: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                _connBus.SaveConnection(tbServer.Text, tbUsername.Text, tbPassword.Text, cboDatabase.Text);
                MessageBox.Show("Lưu file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu cấu hình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            cboDatabase.Items.Clear();
            string error;
            var dbs = _connBus.GetDatabases(tbServer.Text, tbUsername.Text, tbPassword.Text, out error);
            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show("Lỗi : " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var db in dbs)
            {
                cboDatabase.Items.Add(db);
            }

        }
    }
}