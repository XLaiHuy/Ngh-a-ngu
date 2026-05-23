namespace GUI
{
    partial class frmRoomType
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
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBedNumbers = new System.Windows.Forms.TextBox();
            this.txtHumanCapacity = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblBedNumbers = new System.Windows.Forms.Label();
            this.lblHumanCapacity = new System.Windows.Forms.Label();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDROOMTYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAIPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOGIUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUCCHUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1151, 68);
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
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(231, 85);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(450, 30);
            this.txtTypeName.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(231, 125);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 30);
            this.txtPrice.TabIndex = 4;
            // 
            // txtBedNumbers
            // 
            this.txtBedNumbers.Location = new System.Drawing.Point(231, 165);
            this.txtBedNumbers.Name = "txtBedNumbers";
            this.txtBedNumbers.Size = new System.Drawing.Size(200, 30);
            this.txtBedNumbers.TabIndex = 5;
            // 
            // txtHumanCapacity
            // 
            this.txtHumanCapacity.Location = new System.Drawing.Point(633, 128);
            this.txtHumanCapacity.Name = "txtHumanCapacity";
            this.txtHumanCapacity.Size = new System.Drawing.Size(160, 30);
            this.txtHumanCapacity.TabIndex = 6;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(51, 89);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(143, 24);
            this.lblTypeName.TabIndex = 7;
            this.lblTypeName.Text = "Tên loại phòng";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(51, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 24);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Giá (VND)";
            // 
            // lblBedNumbers
            // 
            this.lblBedNumbers.AutoSize = true;
            this.lblBedNumbers.Location = new System.Drawing.Point(52, 168);
            this.lblBedNumbers.Name = "lblBedNumbers";
            this.lblBedNumbers.Size = new System.Drawing.Size(99, 24);
            this.lblBedNumbers.TabIndex = 9;
            this.lblBedNumbers.Text = "Số giường";
            // 
            // lblHumanCapacity
            // 
            this.lblHumanCapacity.AutoSize = true;
            this.lblHumanCapacity.Location = new System.Drawing.Point(464, 128);
            this.lblHumanCapacity.Name = "lblHumanCapacity";
            this.lblHumanCapacity.Size = new System.Drawing.Size(163, 24);
            this.lblHumanCapacity.TabIndex = 10;
            this.lblHumanCapacity.Text = "Sức chứa (người)";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Location = new System.Drawing.Point(34, 239);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1064, 648);
            this.gcDanhSach.TabIndex = 12;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDROOMTYPE,
            this.LOAIPHONG,
            this.GIAPHONG,
            this.SOGIUONG,
            this.SUCCHUA});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            // 
            // IDROOMTYPE
            // 
            this.IDROOMTYPE.Caption = "ID";
            this.IDROOMTYPE.FieldName = "RoomTypeID";
            this.IDROOMTYPE.MaxWidth = 50;
            this.IDROOMTYPE.MinWidth = 35;
            this.IDROOMTYPE.Name = "IDROOMTYPE";
            this.IDROOMTYPE.Width = 50;
            // 
            // LOAIPHONG
            // 
            this.LOAIPHONG.Caption = "Loại Phòng";
            this.LOAIPHONG.FieldName = "TypeName";
            this.LOAIPHONG.MaxWidth = 200;
            this.LOAIPHONG.MinWidth = 150;
            this.LOAIPHONG.Name = "LOAIPHONG";
            this.LOAIPHONG.Visible = true;
            this.LOAIPHONG.VisibleIndex = 0;
            this.LOAIPHONG.Width = 150;
            // 
            // GIAPHONG
            // 
            this.GIAPHONG.Caption = "Giá Phòng";
            this.GIAPHONG.FieldName = "Price";
            this.GIAPHONG.MaxWidth = 100;
            this.GIAPHONG.MinWidth = 50;
            this.GIAPHONG.Name = "GIAPHONG";
            this.GIAPHONG.Visible = true;
            this.GIAPHONG.VisibleIndex = 1;
            this.GIAPHONG.Width = 100;
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.Caption = "Số Giường";
            this.SOGIUONG.FieldName = "BedNumbers";
            this.SOGIUONG.MaxWidth = 100;
            this.SOGIUONG.MinWidth = 50;
            this.SOGIUONG.Name = "SOGIUONG";
            this.SOGIUONG.Visible = true;
            this.SOGIUONG.VisibleIndex = 2;
            this.SOGIUONG.Width = 100;
            // 
            // SUCCHUA
            // 
            this.SUCCHUA.Caption = "Sức Chứa";
            this.SUCCHUA.FieldName = "StandardCapacity";
            this.SUCCHUA.MaxWidth = 100;
            this.SUCCHUA.MinWidth = 50;
            this.SUCCHUA.Name = "SUCCHUA";
            this.SUCCHUA.Visible = true;
            this.SUCCHUA.VisibleIndex = 3;
            this.SUCCHUA.Width = 100;
            // 
            // frmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 928);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.lblHumanCapacity);
            this.Controls.Add(this.lblBedNumbers);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.txtHumanCapacity);
            this.Controls.Add(this.txtBedNumbers);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmRoomType";
            this.Text = "frmRoomType";
            this.Load += new System.EventHandler(this.frmRoomType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
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
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBedNumbers;
        private System.Windows.Forms.TextBox txtHumanCapacity;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblBedNumbers;
        private System.Windows.Forms.Label lblHumanCapacity;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn GIAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn SOGIUONG;
        private DevExpress.XtraGrid.Columns.GridColumn SUCCHUA;
        private DevExpress.XtraGrid.Columns.GridColumn IDROOMTYPE;
    }
}