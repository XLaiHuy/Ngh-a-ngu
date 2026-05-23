using BUS;
using DTO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public class frmRevenueReport : XtraForm
    {
        private readonly RevenueBUS _revenueBus;

        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private ComboBox cboPeriod;
        private Button btnView;
        private DataGridView dgvRevenue;
        private Chart chartRevenue;

        public frmRevenueReport()
        {
            _revenueBus = new RevenueBUS();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Báo cáo doanh thu";
            Width = 1000;
            Height = 720;
            StartPosition = FormStartPosition.CenterParent;

            var root = new TableLayoutPanel();
            root.Dock = DockStyle.Fill;
            root.RowCount = 3;
            root.ColumnCount = 1;
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            Controls.Add(root);

            var topPanel = new FlowLayoutPanel();
            topPanel.Dock = DockStyle.Fill;
            topPanel.FlowDirection = FlowDirection.LeftToRight;
            topPanel.WrapContents = false;
            topPanel.Padding = new Padding(10, 10, 10, 10);

            topPanel.Controls.Add(new Label { Text = "From:", AutoSize = true, TextAlign = ContentAlignment.MiddleLeft });
            dtFrom = new DateTimePicker();
            dtFrom.Width = 140;
            topPanel.Controls.Add(dtFrom);

            topPanel.Controls.Add(new Label { Text = "To:", AutoSize = true, Margin = new Padding(20, 0, 0, 0) });
            dtTo = new DateTimePicker();
            dtTo.Width = 140;
            topPanel.Controls.Add(dtTo);

            topPanel.Controls.Add(new Label { Text = "Period:", AutoSize = true, Margin = new Padding(20, 0, 0, 0) });
            cboPeriod = new ComboBox();
            cboPeriod.Width = 140;
            cboPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeriod.Items.AddRange(new object[] { "Day", "Week", "Month", "Year" });
            cboPeriod.SelectedIndex = 0;
            topPanel.Controls.Add(cboPeriod);

            btnView = new Button();
            btnView.Text = "View Report";
            btnView.Width = 120;
            btnView.Margin = new Padding(20, 0, 0, 0);
            btnView.Click += btnView_Click;
            topPanel.Controls.Add(btnView);

            root.Controls.Add(topPanel, 0, 0);

            dgvRevenue = new DataGridView();
            dgvRevenue.Dock = DockStyle.Fill;
            dgvRevenue.AutoGenerateColumns = false;
            dgvRevenue.ReadOnly = true;
            dgvRevenue.AllowUserToAddRows = false;
            dgvRevenue.AllowUserToDeleteRows = false;
            dgvRevenue.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Period", HeaderText = "Period", Width = 200 });
            dgvRevenue.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Revenue", HeaderText = "Revenue", Width = 200 });

            root.Controls.Add(dgvRevenue, 0, 1);

            chartRevenue = new Chart();
            chartRevenue.Dock = DockStyle.Fill;
            var chartArea = new ChartArea("main");
            chartRevenue.ChartAreas.Add(chartArea);
            var series = new Series("Revenue");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            chartRevenue.Series.Add(series);

            root.Controls.Add(chartRevenue, 0, 2);

            dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtTo.Value = DateTime.Now;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dtFrom.Value.Date > dtTo.Value.Date)
            {
                MessageBox.Show("Khoang thoi gian khong hop le.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var period = RevenuePeriod.Day;
            if (cboPeriod.SelectedItem != null)
            {
                switch (cboPeriod.SelectedItem.ToString())
                {
                    case "Week":
                        period = RevenuePeriod.Week;
                        break;
                    case "Month":
                        period = RevenuePeriod.Month;
                        break;
                    case "Year":
                        period = RevenuePeriod.Year;
                        break;
                    default:
                        period = RevenuePeriod.Day;
                        break;
                }
            }

            List<RevenueRowDTO> data = _revenueBus.getRevenueReport(dtFrom.Value.Date, dtTo.Value.Date, period);
            dgvRevenue.DataSource = data.Select(x => new
            {
                x.Period,
                Revenue = x.Revenue.ToString("N0")
            }).ToList();

            BindChartFromGrid();
        }

        private void BindChartFromGrid()
        {
            var series = chartRevenue.Series["Revenue"];
            if (series == null)
            {
                series = new Series("Revenue");
                series.ChartType = SeriesChartType.Column;
                series.XValueType = ChartValueType.String;
                chartRevenue.Series.Add(series);
            }
            series.Points.Clear();
            foreach (DataGridViewRow row in dgvRevenue.Rows)
            {
                if (row.IsNewRow) continue;
                string period = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                decimal revenue = 0m;
                if (row.Cells[1].Value != null)
                    decimal.TryParse(row.Cells[1].Value.ToString(), NumberStyles.AllowThousands | NumberStyles.Number, CultureInfo.CurrentCulture, out revenue);
                series.Points.AddXY(period, revenue);
            }
        }
    }
}
