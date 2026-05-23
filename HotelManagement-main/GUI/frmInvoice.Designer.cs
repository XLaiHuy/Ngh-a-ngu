namespace GUI
{
    partial class frmInvoice
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.FlowLayoutPanel topPanel;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.ComboBox cboBooking;
        private System.Windows.Forms.Button btnCalculate;

        private System.Windows.Forms.TableLayoutPanel infoLayout;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TableLayoutPanel customerLayout;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerCCCD;
        private System.Windows.Forms.TextBox txtCustomerCCCD;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerPhone;

        private System.Windows.Forms.GroupBox grpRoom;
        private System.Windows.Forms.TableLayoutPanel roomLayout;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label lblRoomPricePerDay;
        private System.Windows.Forms.TextBox txtRoomPricePerDay;
        private System.Windows.Forms.Label lblRoomTotal;
        private System.Windows.Forms.TextBox txtRoomTotal;

        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;

        private System.Windows.Forms.FlowLayoutPanel bottomPanel;
        private System.Windows.Forms.Label lblServiceTotal;
        private System.Windows.Forms.TextBox txtServiceTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBooking = new System.Windows.Forms.Label();
            this.cboBooking = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.infoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.customerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerCCCD = new System.Windows.Forms.Label();
            this.txtCustomerCCCD = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.roomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblRooms = new System.Windows.Forms.Label();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.lblRoomPricePerDay = new System.Windows.Forms.Label();
            this.txtRoomPricePerDay = new System.Windows.Forms.TextBox();
            this.lblRoomTotal = new System.Windows.Forms.Label();
            this.txtRoomTotal = new System.Windows.Forms.TextBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblServiceTotal = new System.Windows.Forms.Label();
            this.txtServiceTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.rootLayout.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.infoLayout.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.customerLayout.SuspendLayout();
            this.grpRoom.SuspendLayout();
            this.roomLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.RowCount = 4;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.rootLayout.Controls.Add(this.topPanel, 0, 0);
            this.rootLayout.Controls.Add(this.infoLayout, 0, 1);
            this.rootLayout.Controls.Add(this.dgvServices, 0, 2);
            this.rootLayout.Controls.Add(this.bottomPanel, 0, 3);
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.topPanel.WrapContents = false;
            this.topPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.topPanel.Controls.Add(this.lblBooking);
            this.topPanel.Controls.Add(this.cboBooking);
            this.topPanel.Controls.Add(this.btnCalculate);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Text = "Booking:";
            this.lblBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBooking.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // cboBooking
            // 
            this.cboBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBooking.Width = 280;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Width = 120;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            // 
            // infoLayout
            // 
            this.infoLayout.ColumnCount = 2;
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLayout.RowCount = 1;
            this.infoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoLayout.Controls.Add(this.grpCustomer, 0, 0);
            this.infoLayout.Controls.Add(this.grpRoom, 1, 0);
            // 
            // grpCustomer
            // 
            this.grpCustomer.Text = "Customer";
            this.grpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(10);
            this.grpCustomer.Controls.Add(this.customerLayout);
            // 
            // customerLayout
            // 
            this.customerLayout.ColumnCount = 2;
            this.customerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.customerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customerLayout.RowCount = 3;
            this.customerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.customerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.customerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.customerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerLayout.Controls.Add(this.lblCustomerName, 0, 0);
            this.customerLayout.Controls.Add(this.txtCustomerName, 1, 0);
            this.customerLayout.Controls.Add(this.lblCustomerCCCD, 0, 1);
            this.customerLayout.Controls.Add(this.txtCustomerCCCD, 1, 1);
            this.customerLayout.Controls.Add(this.lblCustomerPhone, 0, 2);
            this.customerLayout.Controls.Add(this.txtCustomerPhone, 1, 2);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Text = "Name";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Width = 220;
            // 
            // lblCustomerCCCD
            // 
            this.lblCustomerCCCD.AutoSize = true;
            this.lblCustomerCCCD.Text = "CCCD";
            this.lblCustomerCCCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerCCCD.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtCustomerCCCD
            // 
            this.txtCustomerCCCD.ReadOnly = true;
            this.txtCustomerCCCD.Width = 220;
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Text = "Phone";
            this.lblCustomerPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.ReadOnly = true;
            this.txtCustomerPhone.Width = 220;
            // 
            // grpRoom
            // 
            this.grpRoom.Text = "Room";
            this.grpRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRoom.Padding = new System.Windows.Forms.Padding(10);
            this.grpRoom.Controls.Add(this.roomLayout);
            // 
            // roomLayout
            // 
            this.roomLayout.ColumnCount = 2;
            this.roomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.roomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.roomLayout.RowCount = 6;
            this.roomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.roomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.roomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.roomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.roomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.roomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.roomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomLayout.Controls.Add(this.lblRooms, 0, 0);
            this.roomLayout.Controls.Add(this.txtRooms, 1, 0);
            this.roomLayout.Controls.Add(this.lblCheckIn, 0, 1);
            this.roomLayout.Controls.Add(this.txtCheckIn, 1, 1);
            this.roomLayout.Controls.Add(this.lblCheckOut, 0, 2);
            this.roomLayout.Controls.Add(this.txtCheckOut, 1, 2);
            this.roomLayout.Controls.Add(this.lblDays, 0, 3);
            this.roomLayout.Controls.Add(this.txtDays, 1, 3);
            this.roomLayout.Controls.Add(this.lblRoomPricePerDay, 0, 4);
            this.roomLayout.Controls.Add(this.txtRoomPricePerDay, 1, 4);
            this.roomLayout.Controls.Add(this.lblRoomTotal, 0, 5);
            this.roomLayout.Controls.Add(this.txtRoomTotal, 1, 5);
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Text = "Rooms";
            this.lblRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRooms.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtRooms
            // 
            this.txtRooms.ReadOnly = true;
            this.txtRooms.Width = 220;
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Text = "Check-in";
            this.lblCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.ReadOnly = true;
            this.txtCheckIn.Width = 220;
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Text = "Check-out";
            this.lblCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCheckOut.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.ReadOnly = true;
            this.txtCheckOut.Width = 220;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Text = "Days";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDays.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtDays
            // 
            this.txtDays.ReadOnly = true;
            this.txtDays.Width = 120;
            // 
            // lblRoomPricePerDay
            // 
            this.lblRoomPricePerDay.AutoSize = true;
            this.lblRoomPricePerDay.Text = "Room/Day";
            this.lblRoomPricePerDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRoomPricePerDay.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtRoomPricePerDay
            // 
            this.txtRoomPricePerDay.ReadOnly = true;
            this.txtRoomPricePerDay.Width = 120;
            // 
            // lblRoomTotal
            // 
            this.lblRoomTotal.AutoSize = true;
            this.lblRoomTotal.Text = "Room Total";
            this.lblRoomTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRoomTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtRoomTotal
            // 
            this.txtRoomTotal.ReadOnly = true;
            this.txtRoomTotal.Width = 120;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AutoGenerateColumns = false;
            this.dgvServices.ReadOnly = true;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colServiceName,
                this.colQuantity,
                this.colUnitPrice,
                this.colSubTotal
            });
            // 
            // colServiceName
            // 
            this.colServiceName.DataPropertyName = "ServiceName";
            this.colServiceName.HeaderText = "Service";
            this.colServiceName.Width = 240;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Qty";
            this.colQuantity.Width = 80;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Width = 120;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DataPropertyName = "SubTotal";
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Width = 120;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.bottomPanel.WrapContents = false;
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.bottomPanel.Controls.Add(this.lblServiceTotal);
            this.bottomPanel.Controls.Add(this.txtServiceTotal);
            this.bottomPanel.Controls.Add(this.lblTotal);
            this.bottomPanel.Controls.Add(this.txtTotal);
            this.bottomPanel.Controls.Add(this.btnSave);
            this.bottomPanel.Controls.Add(this.btnPrint);
            // 
            // lblServiceTotal
            // 
            this.lblServiceTotal.AutoSize = true;
            this.lblServiceTotal.Text = "Service Total:";
            this.lblServiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblServiceTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // txtServiceTotal
            // 
            this.txtServiceTotal.ReadOnly = true;
            this.txtServiceTotal.Width = 120;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Margin = new System.Windows.Forms.Padding(20, 6, 3, 3);
            // 
            // txtTotal
            // 
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Width = 120;
            // 
            // btnSave
            // 
            this.btnSave.Text = "Save Invoice";
            this.btnSave.Width = 140;
            this.btnSave.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.Width = 140;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn";
            this.Controls.Add(this.rootLayout);
            this.rootLayout.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.infoLayout.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            this.customerLayout.ResumeLayout(false);
            this.customerLayout.PerformLayout();
            this.grpRoom.ResumeLayout(false);
            this.roomLayout.ResumeLayout(false);
            this.roomLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
