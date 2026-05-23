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
    public partial class frmNote : DevExpress.XtraEditors.XtraForm
    {
        public frmNote()
        {
            InitializeComponent();
        }

        private void frmNote_Load(object sender, EventArgs e)
        {

        }
        public string NoteText
        {
            get { return tbNote.Text; }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}