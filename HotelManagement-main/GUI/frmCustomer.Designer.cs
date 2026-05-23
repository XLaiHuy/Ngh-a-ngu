namespace GUI
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnTim = new System.Windows.Forms.ToolStripButton();
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.btnRfresh = new System.Windows.Forms.ToolStripButton();
            this.btnChan = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CUSTOMERID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CCCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GENDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISBLOCKED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BLOCKREASON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grGender = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCCCD = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSDT = new DevExpress.XtraEditors.TextEdit();
            this.lbSDT = new System.Windows.Forms.Label();
            this.tbHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.grGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCCCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
            this.btnTim,
            this.btnBoqua,
            this.btnRfresh,
            this.btnChan,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1108, 68);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI.Properties.Resources.add;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 62);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI.Properties.Resources.refresh;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(51, 62);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI.Properties.Resources.bin;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(52, 62);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::GUI.Properties.Resources.diskette;
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(51, 62);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = global::GUI.Properties.Resources.search;
            this.btnTim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(51, 62);
            this.btnTim.Text = "Tìm";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::GUI.Properties.Resources.back;
            this.btnBoqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(86, 62);
            this.btnBoqua.Text = "Bỏ Qua";
            this.btnBoqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnRfresh
            // 
            this.btnRfresh.Image = global::GUI.Properties.Resources.refresh_1_;
            this.btnRfresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRfresh.Name = "btnRfresh";
            this.btnRfresh.Size = new System.Drawing.Size(86, 62);
            this.btnRfresh.Text = "Refresh";
            this.btnRfresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRfresh.Click += new System.EventHandler(this.btnRfresh_Click);
            // 
            // btnChan
            // 
            this.btnChan.Image = global::GUI.Properties.Resources.block;
            this.btnChan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(65, 62);
            this.btnChan.Text = "Chặn";
            this.btnChan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI.Properties.Resources.shutdown;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 62);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 68);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1108, 488);
            this.gcDanhSach.TabIndex = 1;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CUSTOMERID,
            this.HOTEN,
            this.CCCD,
            this.PHONE,
            this.EMAIL,
            this.GENDER,
            this.ISBLOCKED,
            this.BLOCKREASON});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            this.gvDanhSach.DoubleClick += new System.EventHandler(this.gvDanhSach_DoubleClick);
            // 
            // CUSTOMERID
            // 
            this.CUSTOMERID.Caption = "ID";
            this.CUSTOMERID.FieldName = "CustomerID";
            this.CUSTOMERID.MaxWidth = 40;
            this.CUSTOMERID.MinWidth = 25;
            this.CUSTOMERID.Name = "CUSTOMERID";
            this.CUSTOMERID.Width = 25;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Họ Tên";
            this.HOTEN.FieldName = "FullName";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 100;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 0;
            this.HOTEN.Width = 100;
            // 
            // CCCD
            // 
            this.CCCD.Caption = "CCCD";
            this.CCCD.FieldName = "CCCD";
            this.CCCD.MaxWidth = 150;
            this.CCCD.MinWidth = 80;
            this.CCCD.Name = "CCCD";
            this.CCCD.Visible = true;
            this.CCCD.VisibleIndex = 1;
            this.CCCD.Width = 100;
            // 
            // PHONE
            // 
            this.PHONE.Caption = "Số Điện Thoại";
            this.PHONE.FieldName = "Phone";
            this.PHONE.MaxWidth = 150;
            this.PHONE.MinWidth = 80;
            this.PHONE.Name = "PHONE";
            this.PHONE.Visible = true;
            this.PHONE.VisibleIndex = 2;
            this.PHONE.Width = 100;
            // 
            // EMAIL
            // 
            this.EMAIL.Caption = "Email";
            this.EMAIL.FieldName = "Email";
            this.EMAIL.MaxWidth = 180;
            this.EMAIL.MinWidth = 100;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 3;
            this.EMAIL.Width = 120;
            // 
            // GENDER
            // 
            this.GENDER.Caption = "Giới tính";
            this.GENDER.FieldName = "Gender";
            this.GENDER.MaxWidth = 80;
            this.GENDER.MinWidth = 35;
            this.GENDER.Name = "GENDER";
            this.GENDER.Visible = true;
            this.GENDER.VisibleIndex = 4;
            this.GENDER.Width = 50;
            // 
            // ISBLOCKED
            // 
            this.ISBLOCKED.Caption = "isBlocked";
            this.ISBLOCKED.FieldName = "IsBlocked";
            this.ISBLOCKED.MaxWidth = 100;
            this.ISBLOCKED.MinWidth = 35;
            this.ISBLOCKED.Name = "ISBLOCKED";
            this.ISBLOCKED.Width = 50;
            // 
            // BLOCKREASON
            // 
            this.BLOCKREASON.Caption = "BlockReason";
            this.BLOCKREASON.FieldName = "BlockReason";
            this.BLOCKREASON.MaxWidth = 150;
            this.BLOCKREASON.MinWidth = 35;
            this.BLOCKREASON.Name = "BLOCKREASON";
            this.BLOCKREASON.Width = 100;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grGender);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.tbEmail);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.tbCCCD);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.tbSDT);
            this.groupControl1.Controls.Add(this.lbSDT);
            this.groupControl1.Controls.Add(this.tbHoTen);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 556);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1108, 399);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin";
            // 
            // grGender
            // 
            this.grGender.Controls.Add(this.rdNu);
            this.grGender.Controls.Add(this.rdNam);
            this.grGender.Location = new System.Drawing.Point(689, 131);
            this.grGender.Name = "grGender";
            this.grGender.Size = new System.Drawing.Size(231, 71);
            this.grGender.TabIndex = 4;
            this.grGender.TabStop = false;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(152, 29);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(60, 28);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(16, 29);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(76, 28);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(554, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(668, 72);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbEmail.Properties.Appearance.Options.UseFont = true;
            this.tbEmail.Size = new System.Drawing.Size(332, 42);
            this.tbEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(554, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // tbCCCD
            // 
            this.tbCCCD.Location = new System.Drawing.Point(204, 233);
            this.tbCCCD.Name = "tbCCCD";
            this.tbCCCD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbCCCD.Properties.Appearance.Options.UseFont = true;
            this.tbCCCD.Size = new System.Drawing.Size(324, 42);
            this.tbCCCD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(33, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "CCCD";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(204, 150);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSDT.Properties.Appearance.Options.UseFont = true;
            this.tbSDT.Size = new System.Drawing.Size(324, 42);
            this.tbSDT.TabIndex = 1;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSDT.Location = new System.Drawing.Point(33, 163);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(152, 29);
            this.lbSDT.TabIndex = 0;
            this.lbSDT.Text = "Số điện thoại";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(204, 72);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbHoTen.Properties.Appearance.Options.UseFont = true;
            this.tbHoTen.Size = new System.Drawing.Size(324, 42);
            this.tbHoTen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 955);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Khách hàng";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.grGender.ResumeLayout(false);
            this.grGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCCCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHoTen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnChan;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tbEmail;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit tbCCCD;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit tbSDT;
        private System.Windows.Forms.Label lbSDT;
        private DevExpress.XtraEditors.TextEdit tbHoTen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn CUSTOMERID;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn CCCD;
        private DevExpress.XtraGrid.Columns.GridColumn PHONE;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn GENDER;
        private DevExpress.XtraGrid.Columns.GridColumn ISBLOCKED;
        private DevExpress.XtraGrid.Columns.GridColumn BLOCKREASON;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.GroupBox grGender;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.ToolStripButton btnTim;
        private System.Windows.Forms.ToolStripButton btnRfresh;
    }
}