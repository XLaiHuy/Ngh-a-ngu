namespace GUI
{
    partial class frmBooking
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
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnBoqua = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnCheckOut = new System.Windows.Forms.ToolStripButton();
            this.btnRE = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.pageChiTiet = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcSanPham = new DevExpress.XtraGrid.GridControl();
            this.gvSanPham = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnAddKH = new DevExpress.XtraEditors.SimpleButton();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ckTheoDoan = new System.Windows.Forms.CheckBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.lbTongTien = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gcSPDV = new DevExpress.XtraGrid.GridControl();
            this.gvSPDV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.spServiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spIDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spTHANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcPhongdat = new DevExpress.XtraGrid.GridControl();
            this.gvPhongDat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dpIDPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dpTENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dpDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dpTANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageDanhSach = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BOOKINGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckInDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CheckOutDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlannedCheckOutDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Channel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TheoDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CHECKOUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageDanhDanh = new DevExpress.XtraTab.XtraTabControl();
            this.toolStrip1.SuspendLayout();
            this.pageChiTiet.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhongdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pageDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageDanhDanh)).BeginInit();
            this.pageDanhDanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnLuu,
            this.btnBoqua,
            this.btnPrint,
            this.btnCheckOut,
            this.btnRE,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1871, 68);
            this.toolStrip1.TabIndex = 2;
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
            // btnPrint
            // 
            this.btnPrint.Image = global::GUI.Properties.Resources.printer;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(40, 62);
            this.btnPrint.Text = "In";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Image = global::GUI.Properties.Resources.check;
            this.btnCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(108, 62);
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnRE
            // 
            this.btnRE.Image = global::GUI.Properties.Resources.refresh_1_;
            this.btnRE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRE.Name = "btnRE";
            this.btnRE.Size = new System.Drawing.Size(86, 62);
            this.btnRE.Text = "Refresh";
            this.btnRE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRE.Click += new System.EventHandler(this.btnRE_Click);
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
            // pageChiTiet
            // 
            this.pageChiTiet.Controls.Add(this.tableLayoutPanel1);
            this.pageChiTiet.Name = "pageChiTiet";
            this.pageChiTiet.Size = new System.Drawing.Size(1867, 1227);
            this.pageChiTiet.Text = "Chi tiết";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.81329F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.20318F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainerControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1867, 1227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.gcPhong);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(554, 1221);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách phòng trống";
            // 
            // gcPhong
            // 
            this.gcPhong.AllowDrop = true;
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhong.Location = new System.Drawing.Point(3, 39);
            this.gcPhong.MainView = this.gvPhong;
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(548, 1179);
            this.gcPhong.TabIndex = 0;
            this.gcPhong.UseDisabledStatePainter = false;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhong,
            this.gridView4});
            this.gcPhong.DragDrop += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragDrop);
            this.gcPhong.DragOver += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragOver);
            // 
            // gvPhong
            // 
            this.gvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDPHONG,
            this.TENPHONG,
            this.IDTANG,
            this.TENTANG,
            this.pDONGIA});
            this.gvPhong.GridControl = this.gcPhong;
            this.gvPhong.GroupCount = 1;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.OptionsBehavior.Editable = false;
            this.gvPhong.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.TENTANG, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvPhong.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gvPhong_CustomDrawGroupRow);
            this.gvPhong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvPhong_MouseDown);
            this.gvPhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gvPhong_MouseMove);
            // 
            // IDPHONG
            // 
            this.IDPHONG.Caption = "ID";
            this.IDPHONG.FieldName = "RoomID";
            this.IDPHONG.MaxWidth = 120;
            this.IDPHONG.MinWidth = 100;
            this.IDPHONG.Name = "IDPHONG";
            this.IDPHONG.Width = 120;
            // 
            // TENPHONG
            // 
            this.TENPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.TENPHONG.AppearanceHeader.Options.UseFont = true;
            this.TENPHONG.Caption = "Tên Phòng";
            this.TENPHONG.FieldName = "RoomCode";
            this.TENPHONG.MaxWidth = 120;
            this.TENPHONG.MinWidth = 100;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 0;
            this.TENPHONG.Width = 120;
            // 
            // IDTANG
            // 
            this.IDTANG.Caption = "IDTang";
            this.IDTANG.FieldName = "FloorID";
            this.IDTANG.MinWidth = 35;
            this.IDTANG.Name = "IDTANG";
            this.IDTANG.Width = 131;
            // 
            // TENTANG
            // 
            this.TENTANG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.TENTANG.AppearanceHeader.Options.UseFont = true;
            this.TENTANG.Caption = "Tầng";
            this.TENTANG.FieldName = "FloorName";
            this.TENTANG.MaxWidth = 100;
            this.TENTANG.MinWidth = 80;
            this.TENTANG.Name = "TENTANG";
            this.TENTANG.Visible = true;
            this.TENTANG.VisibleIndex = 1;
            this.TENTANG.Width = 100;
            // 
            // pDONGIA
            // 
            this.pDONGIA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.pDONGIA.AppearanceHeader.Options.UseFont = true;
            this.pDONGIA.Caption = "Đơn giá";
            this.pDONGIA.FieldName = "Price";
            this.pDONGIA.MaxWidth = 100;
            this.pDONGIA.MinWidth = 90;
            this.pDONGIA.Name = "pDONGIA";
            this.pDONGIA.Visible = true;
            this.pDONGIA.VisibleIndex = 1;
            this.pDONGIA.Width = 100;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gcPhong;
            this.gridView4.Name = "gridView4";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.gcSanPham);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(1306, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(558, 1221);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Sản Phẩm - Dịch Vụ";
            // 
            // gcSanPham
            // 
            this.gcSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSanPham.Location = new System.Drawing.Point(3, 39);
            this.gcSanPham.MainView = this.gvSanPham;
            this.gcSanPham.Name = "gcSanPham";
            this.gcSanPham.Size = new System.Drawing.Size(552, 1179);
            this.gcSanPham.TabIndex = 0;
            this.gcSanPham.UseDisabledStatePainter = false;
            this.gcSanPham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSanPham,
            this.gridView3});
            this.gcSanPham.DoubleClick += new System.EventHandler(this.gcSanPham_DoubleClick);
            // 
            // gvSanPham
            // 
            this.gvSanPham.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDSP,
            this.TENSP,
            this.DONGIA});
            this.gvSanPham.GridControl = this.gcSanPham;
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.OptionsView.ShowGroupPanel = false;
            // 
            // IDSP
            // 
            this.IDSP.Caption = "id Sản phẩm";
            this.IDSP.FieldName = "ServiceID";
            this.IDSP.MinWidth = 35;
            this.IDSP.Name = "IDSP";
            this.IDSP.Width = 131;
            // 
            // TENSP
            // 
            this.TENSP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.TENSP.AppearanceHeader.Options.UseFont = true;
            this.TENSP.Caption = "Tên sản phẩm";
            this.TENSP.FieldName = "NameService";
            this.TENSP.MaxWidth = 150;
            this.TENSP.MinWidth = 120;
            this.TENSP.Name = "TENSP";
            this.TENSP.Visible = true;
            this.TENSP.VisibleIndex = 0;
            this.TENSP.Width = 131;
            // 
            // DONGIA
            // 
            this.DONGIA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.DONGIA.AppearanceHeader.Options.UseFont = true;
            this.DONGIA.Caption = "Đơn giá";
            this.DONGIA.FieldName = "Price";
            this.DONGIA.MaxWidth = 120;
            this.DONGIA.MinWidth = 100;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 1;
            this.DONGIA.Width = 100;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gcSanPham;
            this.gridView3.Name = "gridView3";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(563, 3);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.btnAddKH);
            this.splitContainerControl2.Panel1.Controls.Add(this.txtGhiChu);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl7);
            this.splitContainerControl2.Panel1.Controls.Add(this.ckTheoDoan);
            this.splitContainerControl2.Panel1.Controls.Add(this.cboTrangThai);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl2.Panel1.Controls.Add(this.dtNgayTra);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl2.Panel1.Controls.Add(this.dtNgayDat);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl2.Panel1.Controls.Add(this.cboKhachHang);
            this.splitContainerControl2.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl5);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl4);
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(737, 1221);
            this.splitContainerControl2.SplitterPosition = 214;
            this.splitContainerControl2.TabIndex = 3;
            // 
            // btnAddKH
            // 
            this.btnAddKH.ImageOptions.Image = global::GUI.Properties.Resources.add;
            this.btnAddKH.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddKH.Location = new System.Drawing.Point(563, 39);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(37, 34);
            this.btnAddKH.TabIndex = 11;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(199, 163);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(378, 38);
            this.txtGhiChu.TabIndex = 10;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(127, 163);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 23);
            this.labelControl7.TabIndex = 9;
            this.labelControl7.Text = "Ghi chú";
            // 
            // ckTheoDoan
            // 
            this.ckTheoDoan.AutoSize = true;
            this.ckTheoDoan.Location = new System.Drawing.Point(446, 125);
            this.ckTheoDoan.Name = "ckTheoDoan";
            this.ckTheoDoan.Size = new System.Drawing.Size(131, 28);
            this.ckTheoDoan.TabIndex = 8;
            this.ckTheoDoan.Text = "Theo đoàn";
            this.ckTheoDoan.UseVisualStyleBackColor = true;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(198, 124);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(175, 31);
            this.cboTrangThai.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(100, 125);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(92, 24);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Trạng thái";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTra.Location = new System.Drawing.Point(474, 82);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(175, 30);
            this.dtNgayTra.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(388, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 24);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Ngày trả";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayDat.Location = new System.Drawing.Point(198, 82);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(175, 30);
            this.dtNgayDat.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(112, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 24);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Ngày đặt";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(198, 39);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(359, 31);
            this.cboKhachHang.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(91, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Khách hàng";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupControl5.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl5.Controls.Add(this.txtTongTien);
            this.groupControl5.Controls.Add(this.lbTongTien);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(0, 765);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(737, 225);
            this.groupControl5.TabIndex = 2;
            this.groupControl5.Text = "TỔNG THANH TOÁN";
            // 
            // txtTongTien
            // 
            this.txtTongTien.EditValue = "0";
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(169, 89);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.Appearance.Options.UseForeColor = true;
            this.txtTongTien.Properties.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(278, 42);
            this.txtTongTien.TabIndex = 1;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTongTien.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.Appearance.Options.UseFont = true;
            this.lbTongTien.Appearance.Options.UseForeColor = true;
            this.lbTongTien.Location = new System.Drawing.Point(49, 89);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(113, 29);
            this.lbTongTien.TabIndex = 0;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl4.Controls.Add(this.gcSPDV);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(0, 373);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(737, 392);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Danh sách sản phẩm - dịch vụ";
            // 
            // gcSPDV
            // 
            this.gcSPDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSPDV.Location = new System.Drawing.Point(3, 39);
            this.gcSPDV.MainView = this.gvSPDV;
            this.gcSPDV.Name = "gcSPDV";
            this.gcSPDV.Size = new System.Drawing.Size(731, 350);
            this.gcSPDV.TabIndex = 0;
            this.gcSPDV.UseDisabledStatePainter = false;
            this.gcSPDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSPDV,
            this.gridView2});
            // 
            // gvSPDV
            // 
            this.gvSPDV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.spServiceID,
            this.spTENSP,
            this.spTENPHONG,
            this.spIDPHONG,
            this.spSOLUONG,
            this.spPrice,
            this.spTHANHTIEN});
            this.gvSPDV.GridControl = this.gcSPDV;
            this.gvSPDV.Name = "gvSPDV";
            this.gvSPDV.OptionsView.ShowFooter = true;
            this.gvSPDV.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvSPDV_CellValueChanged);
            // 
            // spServiceID
            // 
            this.spServiceID.Caption = "IDSP";
            this.spServiceID.FieldName = "ServiceID";
            this.spServiceID.MinWidth = 35;
            this.spServiceID.Name = "spServiceID";
            this.spServiceID.Width = 131;
            // 
            // spTENSP
            // 
            this.spTENSP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.spTENSP.AppearanceHeader.Options.UseFont = true;
            this.spTENSP.Caption = "Tên Sản Phẩm";
            this.spTENSP.FieldName = "NameService";
            this.spTENSP.MaxWidth = 150;
            this.spTENSP.MinWidth = 120;
            this.spTENSP.Name = "spTENSP";
            this.spTENSP.OptionsColumn.AllowEdit = false;
            this.spTENSP.Visible = true;
            this.spTENSP.VisibleIndex = 0;
            this.spTENSP.Width = 120;
            // 
            // spTENPHONG
            // 
            this.spTENPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.spTENPHONG.AppearanceHeader.Options.UseFont = true;
            this.spTENPHONG.Caption = "Tên Phòng";
            this.spTENPHONG.FieldName = "RoomCode";
            this.spTENPHONG.MaxWidth = 120;
            this.spTENPHONG.MinWidth = 100;
            this.spTENPHONG.Name = "spTENPHONG";
            this.spTENPHONG.OptionsColumn.AllowEdit = false;
            this.spTENPHONG.Visible = true;
            this.spTENPHONG.VisibleIndex = 1;
            this.spTENPHONG.Width = 120;
            // 
            // spIDPHONG
            // 
            this.spIDPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.spIDPHONG.AppearanceHeader.Options.UseFont = true;
            this.spIDPHONG.Caption = "ID Phòng";
            this.spIDPHONG.FieldName = "RoomID";
            this.spIDPHONG.MinWidth = 35;
            this.spIDPHONG.Name = "spIDPHONG";
            this.spIDPHONG.Width = 131;
            // 
            // spSOLUONG
            // 
            this.spSOLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.spSOLUONG.AppearanceHeader.Options.UseFont = true;
            this.spSOLUONG.Caption = "SL";
            this.spSOLUONG.FieldName = "Quantity";
            this.spSOLUONG.MaxWidth = 80;
            this.spSOLUONG.MinWidth = 70;
            this.spSOLUONG.Name = "spSOLUONG";
            this.spSOLUONG.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:n0}")});
            this.spSOLUONG.Visible = true;
            this.spSOLUONG.VisibleIndex = 2;
            this.spSOLUONG.Width = 80;
            // 
            // spPrice
            // 
            this.spPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.spPrice.AppearanceHeader.Options.UseFont = true;
            this.spPrice.Caption = "Đơn Giá";
            this.spPrice.FieldName = "Price";
            this.spPrice.MaxWidth = 100;
            this.spPrice.MinWidth = 80;
            this.spPrice.Name = "spPrice";
            this.spPrice.Visible = true;
            this.spPrice.VisibleIndex = 3;
            this.spPrice.Width = 100;
            // 
            // spTHANHTIEN
            // 
            this.spTHANHTIEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.spTHANHTIEN.AppearanceHeader.Options.UseFont = true;
            this.spTHANHTIEN.Caption = "Thành Tiền";
            this.spTHANHTIEN.FieldName = "ThanhTien";
            this.spTHANHTIEN.MaxWidth = 150;
            this.spTHANHTIEN.MinWidth = 120;
            this.spTHANHTIEN.Name = "spTHANHTIEN";
            this.spTHANHTIEN.OptionsColumn.AllowEdit = false;
            this.spTHANHTIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", "{0:n0}")});
            this.spTHANHTIEN.Visible = true;
            this.spTHANHTIEN.VisibleIndex = 4;
            this.spTHANHTIEN.Width = 120;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcSPDV;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.gcPhongdat);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(737, 373);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Danh Sách phòng đặt";
            // 
            // gcPhongdat
            // 
            this.gcPhongdat.AllowDrop = true;
            this.gcPhongdat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhongdat.Location = new System.Drawing.Point(3, 39);
            this.gcPhongdat.MainView = this.gvPhongDat;
            this.gcPhongdat.Name = "gcPhongdat";
            this.gcPhongdat.Size = new System.Drawing.Size(731, 331);
            this.gcPhongdat.TabIndex = 0;
            this.gcPhongdat.UseDisabledStatePainter = false;
            this.gcPhongdat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhongDat,
            this.gridView1});
            this.gcPhongdat.DragDrop += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragDrop);
            this.gcPhongdat.DragOver += new System.Windows.Forms.DragEventHandler(this.gcPhong_DragOver);
            // 
            // gvPhongDat
            // 
            this.gvPhongDat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dpIDPHONG,
            this.dpTENPHONG,
            this.dpDONGIA,
            this.dpTANG});
            this.gvPhongDat.GridControl = this.gcPhongdat;
            this.gvPhongDat.Name = "gvPhongDat";
            this.gvPhongDat.OptionsBehavior.Editable = false;
            this.gvPhongDat.OptionsView.ShowFooter = true;
            this.gvPhongDat.OptionsView.ShowGroupPanel = false;
            this.gvPhongDat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gvPhongDat_MouseDown);
            this.gvPhongDat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gvPhongDat_MouseMove);
            this.gvPhongDat.Click += new System.EventHandler(this.gvPhongDat_Click);
            this.gvPhongDat.RowCountChanged += new System.EventHandler(this.gvPhongDat_RowCountChanged);
            // 
            // dpIDPHONG
            // 
            this.dpIDPHONG.Caption = "ID";
            this.dpIDPHONG.FieldName = "RoomID";
            this.dpIDPHONG.MinWidth = 35;
            this.dpIDPHONG.Name = "dpIDPHONG";
            this.dpIDPHONG.Width = 131;
            // 
            // dpTENPHONG
            // 
            this.dpTENPHONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.dpTENPHONG.AppearanceHeader.Options.UseFont = true;
            this.dpTENPHONG.Caption = "Tên Phòng";
            this.dpTENPHONG.FieldName = "RoomCode";
            this.dpTENPHONG.MaxWidth = 150;
            this.dpTENPHONG.MinWidth = 100;
            this.dpTENPHONG.Name = "dpTENPHONG";
            this.dpTENPHONG.Visible = true;
            this.dpTENPHONG.VisibleIndex = 0;
            this.dpTENPHONG.Width = 120;
            // 
            // dpDONGIA
            // 
            this.dpDONGIA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.dpDONGIA.AppearanceHeader.Options.UseFont = true;
            this.dpDONGIA.Caption = "Đơn Giá";
            this.dpDONGIA.FieldName = "Price";
            this.dpDONGIA.MaxWidth = 120;
            this.dpDONGIA.MinWidth = 100;
            this.dpDONGIA.Name = "dpDONGIA";
            this.dpDONGIA.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "{0:n0}")});
            this.dpDONGIA.Visible = true;
            this.dpDONGIA.VisibleIndex = 1;
            this.dpDONGIA.Width = 120;
            // 
            // dpTANG
            // 
            this.dpTANG.Caption = "Tên Tầng";
            this.dpTANG.FieldName = "FloorName";
            this.dpTANG.MinWidth = 35;
            this.dpTANG.Name = "dpTANG";
            this.dpTANG.Width = 131;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcPhongdat;
            this.gridView1.Name = "gridView1";
            // 
            // pageDanhSach
            // 
            this.pageDanhSach.Controls.Add(this.splitContainerControl1);
            this.pageDanhSach.Name = "pageDanhSach";
            this.pageDanhSach.Size = new System.Drawing.Size(1867, 1227);
            this.pageDanhSach.Text = "Danh sách";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.dtDenNgay);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtTuNgay);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1867, 1227);
            this.splitContainerControl1.SplitterPosition = 137;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(881, 59);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(321, 30);
            this.dtDenNgay.TabIndex = 1;
            this.dtDenNgay.ValueChanged += new System.EventHandler(this.dtDenNgay_ValueChanged);
            this.dtDenNgay.Leave += new System.EventHandler(this.dtDenNgay_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(758, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 24);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Đến ngày";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(383, 59);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(321, 30);
            this.dtTuNgay.TabIndex = 1;
            this.dtTuNgay.ValueChanged += new System.EventHandler(this.dtTuNgay_ValueChanged);
            this.dtTuNgay.Leave += new System.EventHandler(this.dtTuNgay_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(260, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Từ ngày";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1867, 1073);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach,
            this.gridView5});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BOOKINGID,
            this.CheckInDate,
            this.CheckOutDate,
            this.PlannedCheckOutDate,
            this.TotalPrice,
            this.Channel,
            this.CustomerID,
            this.FullName,
            this.TheoDoan,
            this.Note,
            this.CHECKOUT});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSach_CustomDrawCell);
            this.gvDanhSach.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvDanhSach_CustomColumnDisplayText);
            this.gvDanhSach.Click += new System.EventHandler(this.gvDanhSach_Click);
            this.gvDanhSach.DoubleClick += new System.EventHandler(this.gvDanhSach_DoubleClick);
            // 
            // BOOKINGID
            // 
            this.BOOKINGID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.BOOKINGID.AppearanceHeader.Options.UseFont = true;
            this.BOOKINGID.Caption = "SỐ HĐ";
            this.BOOKINGID.FieldName = "BookingID";
            this.BOOKINGID.MaxWidth = 60;
            this.BOOKINGID.MinWidth = 50;
            this.BOOKINGID.Name = "BOOKINGID";
            this.BOOKINGID.Visible = true;
            this.BOOKINGID.VisibleIndex = 0;
            this.BOOKINGID.Width = 60;
            // 
            // CheckInDate
            // 
            this.CheckInDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.CheckInDate.AppearanceHeader.Options.UseFont = true;
            this.CheckInDate.Caption = "Ngày đặt";
            this.CheckInDate.FieldName = "CheckInDate";
            this.CheckInDate.MaxWidth = 120;
            this.CheckInDate.MinWidth = 80;
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Visible = true;
            this.CheckInDate.VisibleIndex = 1;
            this.CheckInDate.Width = 90;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.CheckOutDate.AppearanceHeader.Options.UseFont = true;
            this.CheckOutDate.Caption = "Ngày trả";
            this.CheckOutDate.FieldName = "CheckOutDate";
            this.CheckOutDate.MaxWidth = 120;
            this.CheckOutDate.MinWidth = 70;
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Visible = true;
            this.CheckOutDate.VisibleIndex = 2;
            this.CheckOutDate.Width = 90;
            // 
            // PlannedCheckOutDate
            // 
            this.PlannedCheckOutDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.PlannedCheckOutDate.AppearanceHeader.Options.UseFont = true;
            this.PlannedCheckOutDate.Caption = "Ngày trả dự kiến";
            this.PlannedCheckOutDate.FieldName = "PlannedCheckOutDate";
            this.PlannedCheckOutDate.MaxWidth = 200;
            this.PlannedCheckOutDate.MinWidth = 120;
            this.PlannedCheckOutDate.Name = "PlannedCheckOutDate";
            this.PlannedCheckOutDate.Visible = true;
            this.PlannedCheckOutDate.VisibleIndex = 3;
            this.PlannedCheckOutDate.Width = 120;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.TotalPrice.AppearanceHeader.Options.UseFont = true;
            this.TotalPrice.Caption = "Số tiền";
            this.TotalPrice.DisplayFormat.FormatString = "{0:n0}";
            this.TotalPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.MaxWidth = 100;
            this.TotalPrice.MinWidth = 35;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 4;
            this.TotalPrice.Width = 80;
            // 
            // Channel
            // 
            this.Channel.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.Channel.AppearanceHeader.Options.UseFont = true;
            this.Channel.Caption = "Trạng thái";
            this.Channel.FieldName = "Channel";
            this.Channel.MaxWidth = 130;
            this.Channel.MinWidth = 100;
            this.Channel.Name = "Channel";
            this.Channel.Visible = true;
            this.Channel.VisibleIndex = 5;
            this.Channel.Width = 100;
            // 
            // CustomerID
            // 
            this.CustomerID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.CustomerID.AppearanceHeader.Options.UseFont = true;
            this.CustomerID.Caption = "IDKHACHHANG";
            this.CustomerID.FieldName = "CustomerID";
            this.CustomerID.MaxWidth = 60;
            this.CustomerID.MinWidth = 50;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = true;
            this.CustomerID.VisibleIndex = 6;
            this.CustomerID.Width = 60;
            // 
            // FullName
            // 
            this.FullName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.FullName.AppearanceHeader.Options.UseFont = true;
            this.FullName.Caption = "Họ tên";
            this.FullName.FieldName = "FullName";
            this.FullName.MaxWidth = 150;
            this.FullName.MinWidth = 120;
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 7;
            this.FullName.Width = 131;
            // 
            // TheoDoan
            // 
            this.TheoDoan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.TheoDoan.AppearanceHeader.Options.UseFont = true;
            this.TheoDoan.Caption = "Đoàn";
            this.TheoDoan.FieldName = "TheoDoan";
            this.TheoDoan.MaxWidth = 90;
            this.TheoDoan.MinWidth = 80;
            this.TheoDoan.Name = "TheoDoan";
            this.TheoDoan.Visible = true;
            this.TheoDoan.VisibleIndex = 8;
            this.TheoDoan.Width = 90;
            // 
            // Note
            // 
            this.Note.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.Note.AppearanceHeader.Options.UseFont = true;
            this.Note.Caption = "GhiChu";
            this.Note.FieldName = "Note";
            this.Note.MaxWidth = 200;
            this.Note.MinWidth = 100;
            this.Note.Name = "Note";
            this.Note.Visible = true;
            this.Note.VisibleIndex = 9;
            this.Note.Width = 131;
            // 
            // CHECKOUT
            // 
            this.CHECKOUT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.142858F, System.Drawing.FontStyle.Bold);
            this.CHECKOUT.AppearanceHeader.Options.UseFont = true;
            this.CHECKOUT.Caption = "CheckOut";
            this.CHECKOUT.FieldName = "CheckOut";
            this.CHECKOUT.MaxWidth = 60;
            this.CHECKOUT.MinWidth = 35;
            this.CHECKOUT.Name = "CHECKOUT";
            this.CHECKOUT.Visible = true;
            this.CHECKOUT.VisibleIndex = 10;
            this.CHECKOUT.Width = 60;
            // 
            // gridView5
            // 
            this.gridView5.GridControl = this.gcDanhSach;
            this.gridView5.Name = "gridView5";
            // 
            // pageDanhDanh
            // 
            this.pageDanhDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageDanhDanh.Location = new System.Drawing.Point(0, 68);
            this.pageDanhDanh.Name = "pageDanhDanh";
            this.pageDanhDanh.SelectedTabPage = this.pageDanhSach;
            this.pageDanhDanh.Size = new System.Drawing.Size(1871, 1273);
            this.pageDanhDanh.TabIndex = 3;
            this.pageDanhDanh.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageDanhSach,
            this.pageChiTiet});
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1871, 1341);
            this.Controls.Add(this.pageDanhDanh);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBooking";
            this.Text = "Quán lý đặt phòng theo đoàn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pageChiTiet.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            this.splitContainerControl2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPhongdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pageDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageDanhDanh)).EndInit();
            this.pageDanhDanh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnBoqua;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraTab.XtraTabPage pageChiTiet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private DevExpress.XtraGrid.Columns.GridColumn IDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn IDTANG;
        private DevExpress.XtraGrid.Columns.GridColumn TENTANG;
        private DevExpress.XtraGrid.Columns.GridColumn pDONGIA;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcSanPham;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn IDSP;
        private DevExpress.XtraGrid.Columns.GridColumn TENSP;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddKH;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.CheckBox ckTheoDoan;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl lbTongTien;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gcSPDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSPDV;
        private DevExpress.XtraGrid.Columns.GridColumn spServiceID;
        private DevExpress.XtraGrid.Columns.GridColumn spTENSP;
        private DevExpress.XtraGrid.Columns.GridColumn spTENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn spIDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn spSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn spPrice;
        private DevExpress.XtraGrid.Columns.GridColumn spTHANHTIEN;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gcPhongdat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhongDat;
        private DevExpress.XtraGrid.Columns.GridColumn dpIDPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn dpTENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn dpDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn dpTANG;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraTab.XtraTabPage pageDanhSach;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn BOOKINGID;
        private DevExpress.XtraGrid.Columns.GridColumn CheckInDate;
        private DevExpress.XtraGrid.Columns.GridColumn CheckOutDate;
        private DevExpress.XtraGrid.Columns.GridColumn PlannedCheckOutDate;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Channel;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn TheoDoan;
        private DevExpress.XtraGrid.Columns.GridColumn Note;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraTab.XtraTabControl pageDanhDanh;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private System.Windows.Forms.ToolStripButton btnCheckOut;
        private DevExpress.XtraGrid.Columns.GridColumn CHECKOUT;
        private System.Windows.Forms.ToolStripButton btnRE;
    }
}