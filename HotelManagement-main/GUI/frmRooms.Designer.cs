namespace GUI
{
    partial class frmRooms
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
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.btnRfresh = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ROOMCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDFLOOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ROOMTYPEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ROOMTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AllowExtraPeople = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbTen = new DevExpress.XtraEditors.LabelControl();
            this.txtTenPhong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboTang = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rdDon = new System.Windows.Forms.RadioButton();
            this.rdThue = new System.Windows.Forms.RadioButton();
            this.rdTrong = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhong.Properties)).BeginInit();
            this.grbStatus.SuspendLayout();
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
            this.btnBoqua,
            this.btnRfresh,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 68);
            this.toolStrip1.TabIndex = 1;
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
            this.gcDanhSach.Location = new System.Drawing.Point(0, 295);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(979, 600);
            this.gcDanhSach.TabIndex = 2;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.ROOMCODE,
            this.IDFLOOR,
            this.TANG,
            this.ROOMTYPEID,
            this.ROOMTYPE,
            this.STATUS,
            this.AllowExtraPeople});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            // 
            // IDPHONG
            // 
            this.IDPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.IDPHONG.AppearanceHeader.Options.UseFont = true;
            this.IDPHONG.Caption = "ID";
            this.IDPHONG.FieldName = "RoomID";
            this.IDPHONG.MaxWidth = 40;
            this.IDPHONG.MinWidth = 25;
            this.IDPHONG.Name = "IDPHONG";
            this.IDPHONG.Width = 35;
            // 
            // ROOMCODE
            // 
            this.ROOMCODE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.ROOMCODE.AppearanceHeader.Options.UseFont = true;
            this.ROOMCODE.Caption = "Phòng";
            this.ROOMCODE.FieldName = "RoomCode";
            this.ROOMCODE.MaxWidth = 100;
            this.ROOMCODE.MinWidth = 35;
            this.ROOMCODE.Name = "ROOMCODE";
            this.ROOMCODE.Visible = true;
            this.ROOMCODE.VisibleIndex = 0;
            this.ROOMCODE.Width = 100;
            // 
            // IDFLOOR
            // 
            this.IDFLOOR.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.IDFLOOR.AppearanceHeader.Options.UseFont = true;
            this.IDFLOOR.Caption = "IdTang";
            this.IDFLOOR.FieldName = "FloorID";
            this.IDFLOOR.MaxWidth = 50;
            this.IDFLOOR.MinWidth = 35;
            this.IDFLOOR.Name = "IDFLOOR";
            this.IDFLOOR.Width = 50;
            // 
            // TANG
            // 
            this.TANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.TANG.AppearanceHeader.Options.UseFont = true;
            this.TANG.Caption = "Tầng";
            this.TANG.FieldName = "FloorName";
            this.TANG.MaxWidth = 100;
            this.TANG.MinWidth = 35;
            this.TANG.Name = "TANG";
            this.TANG.Visible = true;
            this.TANG.VisibleIndex = 1;
            this.TANG.Width = 100;
            // 
            // ROOMTYPEID
            // 
            this.ROOMTYPEID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.ROOMTYPEID.AppearanceHeader.Options.UseFont = true;
            this.ROOMTYPEID.Caption = "IDRoomType";
            this.ROOMTYPEID.FieldName = "RoomTypeID";
            this.ROOMTYPEID.MaxWidth = 50;
            this.ROOMTYPEID.MinWidth = 35;
            this.ROOMTYPEID.Name = "ROOMTYPEID";
            this.ROOMTYPEID.Width = 50;
            // 
            // ROOMTYPE
            // 
            this.ROOMTYPE.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.ROOMTYPE.AppearanceHeader.Options.UseFont = true;
            this.ROOMTYPE.Caption = "Loại Phòng";
            this.ROOMTYPE.FieldName = "TypeName";
            this.ROOMTYPE.MaxWidth = 200;
            this.ROOMTYPE.MinWidth = 35;
            this.ROOMTYPE.Name = "ROOMTYPE";
            this.ROOMTYPE.Visible = true;
            this.ROOMTYPE.VisibleIndex = 2;
            this.ROOMTYPE.Width = 100;
            // 
            // STATUS
            // 
            this.STATUS.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.STATUS.AppearanceHeader.Options.UseFont = true;
            this.STATUS.Caption = "Trạng Thái";
            this.STATUS.FieldName = "Status";
            this.STATUS.MaxWidth = 150;
            this.STATUS.MinWidth = 35;
            this.STATUS.Name = "STATUS";
            this.STATUS.Visible = true;
            this.STATUS.VisibleIndex = 3;
            this.STATUS.Width = 131;
            // 
            // AllowExtraPeople
            // 
            this.AllowExtraPeople.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.AllowExtraPeople.AppearanceHeader.Options.UseFont = true;
            this.AllowExtraPeople.Caption = "Cho phép vượt số lượng";
            this.AllowExtraPeople.FieldName = "AllowExtraPeople";
            this.AllowExtraPeople.MaxWidth = 200;
            this.AllowExtraPeople.MinWidth = 35;
            this.AllowExtraPeople.Name = "AllowExtraPeople";
            this.AllowExtraPeople.Visible = true;
            this.AllowExtraPeople.VisibleIndex = 4;
            this.AllowExtraPeople.Width = 50;
            // 
            // lbTen
            // 
            this.lbTen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTen.Appearance.Options.UseFont = true;
            this.lbTen.Location = new System.Drawing.Point(24, 106);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(109, 28);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "Tên Phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(159, 100);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(277, 38);
            this.txtTenPhong.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(80, 186);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 29);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tầng";
            // 
            // cboTang
            // 
            this.cboTang.FormattingEnabled = true;
            this.cboTang.Location = new System.Drawing.Point(159, 184);
            this.cboTang.Name = "cboTang";
            this.cboTang.Size = new System.Drawing.Size(277, 31);
            this.cboTang.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(503, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(116, 29);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Loại phòng";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(625, 104);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(277, 31);
            this.cboLoaiPhong.TabIndex = 5;
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rdDon);
            this.grbStatus.Controls.Add(this.rdThue);
            this.grbStatus.Controls.Add(this.rdTrong);
            this.grbStatus.Location = new System.Drawing.Point(528, 167);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(374, 100);
            this.grbStatus.TabIndex = 6;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Trạng thái:";
            // 
            // rdDon
            // 
            this.rdDon.AutoSize = true;
            this.rdDon.Location = new System.Drawing.Point(250, 45);
            this.rdDon.Name = "rdDon";
            this.rdDon.Size = new System.Drawing.Size(71, 28);
            this.rdDon.TabIndex = 0;
            this.rdDon.Text = "Dọn";
            this.rdDon.UseVisualStyleBackColor = true;
            // 
            // rdThue
            // 
            this.rdThue.AutoSize = true;
            this.rdThue.Location = new System.Drawing.Point(129, 45);
            this.rdThue.Name = "rdThue";
            this.rdThue.Size = new System.Drawing.Size(115, 28);
            this.rdThue.TabIndex = 0;
            this.rdThue.Text = "Cho thuê";
            this.rdThue.UseVisualStyleBackColor = true;
            // 
            // rdTrong
            // 
            this.rdTrong.AutoSize = true;
            this.rdTrong.Checked = true;
            this.rdTrong.Location = new System.Drawing.Point(23, 45);
            this.rdTrong.Name = "rdTrong";
            this.rdTrong.Size = new System.Drawing.Size(87, 28);
            this.rdTrong.TabIndex = 0;
            this.rdTrong.Text = "Trống";
            this.rdTrong.UseVisualStyleBackColor = true;
            // 
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 907);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.cboTang);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRooms";
            this.Load += new System.EventHandler(this.frmRooms_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPhong.Properties)).EndInit();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.ToolStripButton btnRfresh;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn ROOMCODE;
        private DevExpress.XtraGrid.Columns.GridColumn IDFLOOR;
        private DevExpress.XtraGrid.Columns.GridColumn TANG;
        private DevExpress.XtraGrid.Columns.GridColumn ROOMTYPEID;
        private DevExpress.XtraGrid.Columns.GridColumn ROOMTYPE;
        private DevExpress.XtraGrid.Columns.GridColumn STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn AllowExtraPeople;
        private DevExpress.XtraEditors.LabelControl lbTen;
        private DevExpress.XtraEditors.TextEdit txtTenPhong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cboTang;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.RadioButton rdDon;
        private System.Windows.Forms.RadioButton rdThue;
        private System.Windows.Forms.RadioButton rdTrong;
    }
}