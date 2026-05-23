using BUS;
using DTO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frmRevenueReport : XtraForm
    {
        private readonly RevenueBUS _revenueBus;

        public frmRevenueReport()
        {
            _revenueBus = new RevenueBUS();
            InitializeComponent();
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
