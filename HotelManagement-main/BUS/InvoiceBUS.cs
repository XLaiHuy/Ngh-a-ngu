using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BUS
{
    public class InvoiceBUS
    {
        public List<BookingLookupDTO> getBookingLookups()
        {
            using (var db = Entities.CreateEntities())
            {
                var query = from b in db.Bookings
                            join c in db.Customers on b.CustomerID equals c.CustomerID into bc
                            from c in bc.DefaultIfEmpty()
                            orderby b.BookingID descending
                            select new BookingLookupDTO
                            {
                                BookingID = b.BookingID,
                                Display = "#" + b.BookingID + " - " + (c != null ? c.FullName : "")
                            };
                return query.ToList();
            }
        }

        public InvoiceInfoDTO getInvoiceInfo(int bookingId)
        {
            using (var db = Entities.CreateEntities())
            {
                return BuildInvoiceInfo(db, bookingId);
            }
        }

        public Invoice createOrUpdateInvoice(int bookingId)
        {
            using (var db = Entities.CreateEntities())
            {
                var info = BuildInvoiceInfo(db, bookingId);

                var invoice = db.Invoices.Include("InvoiceDetails").FirstOrDefault(i => i.BookingID == bookingId);
                if (invoice == null)
                {
                    invoice = new Invoice();
                    invoice.BookingID = bookingId;
                    invoice.IssueDate = DateTime.Now;
                    db.Invoices.Add(invoice);
                }
                else
                {
                    invoice.IssueDate = DateTime.Now;
                }

                decimal roundedTotal = Math.Round(info.TotalAmount, 0, MidpointRounding.AwayFromZero);
                invoice.TotalAmount = roundedTotal;
                invoice.FinalAmount = roundedTotal;

                if (invoice.InvoiceDetails != null && invoice.InvoiceDetails.Count > 0)
                {
                    db.InvoiceDetails.RemoveRange(invoice.InvoiceDetails.ToList());
                }

                foreach (var item in info.Services)
                {
                    var detail = new InvoiceDetail();
                    detail.ServiceID = item.ServiceID;
                    detail.Quantity = item.Quantity;
                    detail.UnitPrice = item.UnitPrice;
                    detail.Invoice = invoice;
                    db.InvoiceDetails.Add(detail);
                }

                db.SaveChanges();
                return invoice;
            }
        }

        private static InvoiceInfoDTO BuildInvoiceInfo(Entities db, int bookingId)
        {
            var booking = db.Bookings.Include("Customer").FirstOrDefault(b => b.BookingID == bookingId);
            if (booking == null)
                throw new Exception("Khong tim thay booking.");

            if (booking.CheckInDate == null)
                throw new Exception("Booking khong co ngay check-in.");

            DateTime checkOut = booking.CheckOutDate ?? booking.PlannedCheckOutDate ?? booking.CheckInDate.Value;
            DateTime checkIn = booking.CheckInDate.Value;
            int days = Math.Max(1, (int)(checkOut.Date - checkIn.Date).TotalDays);

            var details = db.BookingDetails.Where(d => d.BookingID == bookingId).ToList();
            decimal roomPricePerDay = details.Sum(d => d.RoomPrice);
            decimal roomTotal = roomPricePerDay * days;

            var roomCodes = (from d in details
                             join r in db.Rooms on d.RoomID equals r.RoomID
                             select r.RoomCode).Distinct().ToList();

            var serviceItems = db.BookingServices.Where(s => s.BookingID == bookingId && s.ServiceID != null).ToList();
            var services = new List<InvoiceServiceItemDTO>();
            foreach (var grp in serviceItems.GroupBy(s => s.ServiceID.Value))
            {
                var service = db.Services.FirstOrDefault(x => x.ServiceID == grp.Key);
                int qty = grp.Sum(x => x.Quantity ?? 0);
                decimal unit = grp.Select(x => x.DONGIA ?? 0).FirstOrDefault();
                decimal sub = grp.Sum(x => x.THANHTIEN ?? ((x.Quantity ?? 0) * (x.DONGIA ?? 0)));
                services.Add(new InvoiceServiceItemDTO
                {
                    ServiceID = grp.Key,
                    ServiceName = service != null ? service.NameService : string.Empty,
                    Quantity = qty,
                    UnitPrice = unit,
                    SubTotal = sub
                });
            }

            decimal serviceTotal = services.Sum(s => s.SubTotal);
            decimal total = roomTotal + serviceTotal;
            decimal roundedTotal = Math.Round(total, 0, MidpointRounding.AwayFromZero);

            int invoiceId = db.Invoices.Where(i => i.BookingID == bookingId).Select(i => i.InvoiceID).FirstOrDefault();

            return new InvoiceInfoDTO
            {
                BookingID = booking.BookingID,
                InvoiceID = invoiceId,
                CustomerName = booking.Customer != null ? booking.Customer.FullName : string.Empty,
                CustomerCCCD = booking.Customer != null ? booking.Customer.CCCD : string.Empty,
                CustomerPhone = booking.Customer != null ? booking.Customer.Phone : string.Empty,
                RoomCodes = string.Join(", ", roomCodes),
                CheckInDate = checkIn,
                CheckOutDate = checkOut,
                StayDays = days,
                RoomPricePerDayTotal = roomPricePerDay,
                RoomTotal = roomTotal,
                ServiceTotal = serviceTotal,
                TotalAmount = roundedTotal,
                Services = services
            };
        }
    }
}
