namespace GUI
{
    partial class frmRevenueReport
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel rootLayout;
        private System.Windows.Forms.FlowLayoutPanel topPanel;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rootLayout = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.colPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rootLayout.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // rootLayout
            // 
            this.rootLayout.ColumnCount = 1;
            this.rootLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootLayout.RowCount = 3;
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootLayout.Controls.Add(this.topPanel, 0, 0);
            this.rootLayout.Controls.Add(this.dgvRevenue, 0, 1);
            this.rootLayout.Controls.Add(this.chartRevenue, 0, 2);
            // 
            // topPanel
            // 
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.topPanel.WrapContents = false;
            this.topPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.topPanel.Controls.Add(this.lblFrom);
            this.topPanel.Controls.Add(this.dtFrom);
            this.topPanel.Controls.Add(this.lblTo);
            this.topPanel.Controls.Add(this.dtTo);
            this.topPanel.Controls.Add(this.lblPeriod);
            this.topPanel.Controls.Add(this.cboPeriod);
            this.topPanel.Controls.Add(this.btnView);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Text = "From:";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFrom.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            // 
            // dtFrom
            // 
            this.dtFrom.Width = 140;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Text = "To:";
            this.lblTo.Margin = new System.Windows.Forms.Padding(20, 6, 3, 3);
            // 
            // dtTo
            // 
            this.dtTo.Width = 140;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Text = "Period:";
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(20, 6, 3, 3);
            // 
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.Width = 140;
            this.cboPeriod.Items.AddRange(new object[] { "Day", "Week", "Month", "Year" });
            this.cboPeriod.SelectedIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Text = "View Report";
            this.btnView.Width = 120;
            this.btnView.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.AllowUserToAddRows = false;
            this.dgvRevenue.AllowUserToDeleteRows = false;
            this.dgvRevenue.AutoGenerateColumns = false;
            this.dgvRevenue.ReadOnly = true;
            this.dgvRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colPeriod,
                this.colRevenue
            });
            // 
            // colPeriod
            // 
            this.colPeriod.DataPropertyName = "Period";
            this.colPeriod.HeaderText = "Period";
            this.colPeriod.Width = 200;
            // 
            // colRevenue
            // 
            this.colRevenue.DataPropertyName = "Revenue";
            this.colRevenue.HeaderText = "Revenue";
            this.colRevenue.Width = 200;
            // 
            // chartRevenue
            // 
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            chartArea1.Name = "main";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Name = "Revenue";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartRevenue.Series.Add(series1);
            // 
            // frmRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo doanh thu";
            this.Controls.Add(this.rootLayout);
            this.rootLayout.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
