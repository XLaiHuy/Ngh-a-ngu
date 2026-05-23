using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BUS
{
    public enum RevenuePeriod
    {
        Day,
        Week,
        Month,
        Year
    }

    public class RevenueBUS
    {
        public List<RevenueRowDTO> getRevenueReport(DateTime fromDate, DateTime toDate, RevenuePeriod period)
        {
            using (var db = Entities.CreateEntities())
            {
                DateTime from = fromDate.Date;
                DateTime to = toDate.Date.AddDays(1).AddTicks(-1);
                var invoices = db.Invoices.Where(i => i.IssueDate != null && i.IssueDate >= from && i.IssueDate <= to).ToList();

                var rows = new List<RevenueRowDTO>();
                switch (period)
                {
                    case RevenuePeriod.Day:
                        rows = invoices
                            .GroupBy(i => i.IssueDate.Value.Date)
                            .Select(g => new RevenueRowDTO
                            {
                                Period = g.Key.ToString("yyyy-MM-dd"),
                                Revenue = g.Sum(x => (x.FinalAmount ?? x.TotalAmount) ?? 0)
                            })
                            .OrderBy(r => r.Period)
                            .ToList();
                        break;

                    case RevenuePeriod.Month:
                        rows = invoices
                            .GroupBy(i => new { i.IssueDate.Value.Year, i.IssueDate.Value.Month })
                            .Select(g => new RevenueRowDTO
                            {
                                Period = g.Key.Year + "-" + g.Key.Month.ToString("D2"),
                                Revenue = g.Sum(x => (x.FinalAmount ?? x.TotalAmount) ?? 0)
                            })
                            .OrderBy(r => r.Period)
                            .ToList();
                        break;

                    case RevenuePeriod.Year:
                        rows = invoices
                            .GroupBy(i => i.IssueDate.Value.Year)
                            .Select(g => new RevenueRowDTO
                            {
                                Period = g.Key.ToString(),
                                Revenue = g.Sum(x => (x.FinalAmount ?? x.TotalAmount) ?? 0)
                            })
                            .OrderBy(r => r.Period)
                            .ToList();
                        break;

                    case RevenuePeriod.Week:
                        rows = invoices
                            .GroupBy(i => GetWeekKey(i.IssueDate.Value))
                            .Select(g => new RevenueRowDTO
                            {
                                Period = g.Key,
                                Revenue = g.Sum(x => (x.FinalAmount ?? x.TotalAmount) ?? 0)
                            })
                            .OrderBy(r => r.Period)
                            .ToList();
                        break;
                }

                decimal totalRevenue = rows.Sum(r => r.Revenue);
                decimal totalInvoices = invoices.Sum(x => (x.FinalAmount ?? x.TotalAmount) ?? 0);
                if (Math.Abs(totalRevenue - totalInvoices) > 0.01m)
                    throw new Exception("Doanh thu khong khop tong hoa don.");

                return rows;
            }
        }

        private static string GetWeekKey(DateTime date)
        {
            Calendar cal = CultureInfo.InvariantCulture.Calendar;
            int week = cal.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            int year = date.Year;
            return year + "-W" + week.ToString("D2");
        }
    }
}
