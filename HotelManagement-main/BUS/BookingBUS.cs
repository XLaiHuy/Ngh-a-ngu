using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.Entity;

namespace BUS
{
    public class BookingBUS
    {
        /// <summary>
        /// Xac nhan checkout: ghi ngay thuc te, tinh lai tien tren tat ca booking detail va tra phong ve Trong.
        /// </summary>
        public decimal checkOut(int bookingID)
        {
            using (var db = Entities.CreateEntities())
            {
                Booking booking = db.Bookings.FirstOrDefault(b => b.BookingID == bookingID);
                if (booking == null)
                    throw new Exception("Khong tim thay booking.");
                if (booking.CheckOut == true || booking.CheckOutDate != null)
                    throw new Exception("Booking nay da duoc checkout roi.");
                if (booking.CheckInDate == null)
                    throw new Exception("Booking khong co ngay check-in.");

                booking.CheckOut = true;
                booking.CheckOutDate = DateTime.Now;

                decimal total = 0;
                var details = db.BookingDetails.Where(d => d.BookingID == bookingID).ToList();
                decimal soNgay = CalculateStayDays(booking.CheckInDate.Value, booking.CheckOutDate.Value);

                foreach (var d in details)
                {
                    decimal line = soNgay * d.RoomPrice;
                    d.THANHTIEN = line;
                    total += line;

                    var room = db.Rooms.FirstOrDefault(r => r.RoomID == d.RoomID);
                    if (room != null) room.Status = "Trống";
                }


                booking.TotalPrice = total;

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Loi checkout: " + ex.Message);
                }

                return booking.TotalPrice ?? 0;
            }
        }

        public List<Booking> getAllByDateTime(DateTime tungay, DateTime denngay)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Bookings.Where(x => x.CheckInDate >= tungay && x.PlannedCheckOutDate <= denngay).ToList();
            }
        }

        public List<OBJ_DATPHONG> getAll(DateTime tungay, DateTime denngay)
        {
            using (var db = Entities.CreateEntities())
            {
                var query = from b in db.Bookings
                            join c in db.Customers on b.CustomerID equals c.CustomerID into bc
                            from c in bc.DefaultIfEmpty()
                            where b.CheckInDate <= denngay && b.PlannedCheckOutDate >= tungay
                            select new OBJ_DATPHONG
                            {
                                BookingID = b.BookingID,
                                CustomerID = b.CustomerID ?? 0,
                                FullName = c != null ? c.FullName : string.Empty,
                                Channel = b.Channel,
                                TotalPrice = b.TotalPrice,
                                CheckInDate = b.CheckInDate,
                                PlannedCheckOutDate = b.PlannedCheckOutDate,
                                CheckOutDate = b.CheckOutDate,
                                TheoDoan = b.TheoDoan,
                                Note = b.Note,
                                CheckOut = b.CheckOut
                            };
                return query.ToList();
            }
        }

        public Booking getItem(int bookingID)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Bookings.FirstOrDefault(x => x.BookingID == bookingID);
            }
        }

        public Booking add(Booking booking)
        {
            if (booking == null)
                throw new Exception("Booking khong hop le.");
            ValidateBookingDates(booking.CheckInDate, booking.PlannedCheckOutDate);

            using (var db = Entities.CreateEntities())
            {
                if (booking.CustomerID == null)
                    throw new Exception("Vui long chon khach hang.");

                Customer cus = db.Customers.FirstOrDefault(c => c.CustomerID == booking.CustomerID);
                if (cus == null)
                    throw new Exception("Khach hang khong ton tai.");
                if (cus.IsBlocked == true)
                    throw new Exception("Khach hang nay da bi chan. Ly do: " + cus.BlockReason);

                try
                {
                    db.Bookings.Add(booking);
                    db.SaveChanges();
                    return booking;
                }
                catch (Exception ex)
                {
                    throw new Exception("Loi khi dat phong: " + ex.Message);
                }
            }
        }

        public Booking update(Booking booking)
        {
            if (booking == null)
                throw new Exception("Booking khong hop le.");
            ValidateBookingDates(booking.CheckInDate, booking.PlannedCheckOutDate);

            using (var db = Entities.CreateEntities())
            {
                Booking existing = db.Bookings.FirstOrDefault(b => b.BookingID == booking.BookingID);
                if (existing == null)
                    throw new Exception("Khong tim thay booking.");

                existing.Channel = booking.Channel;
                existing.PlannedCheckOutDate = booking.PlannedCheckOutDate;
                existing.Note = booking.Note;
                existing.CustomerID = booking.CustomerID;
                existing.CheckInDate = booking.CheckInDate;
                existing.CheckOutDate = booking.CheckOutDate;
                existing.TheoDoan = booking.TheoDoan;
                existing.TotalPrice = booking.TotalPrice;

                try
                {
                    db.SaveChanges();
                    return existing;
                }
                catch (Exception ex)
                {
                    throw new Exception("Loi cap nhat: " + ex.Message);
                }
            }
        }

        public void delete(int bookingID)
        {
            using (var db = Entities.CreateEntities())
            {
                Booking booking = db.Bookings.FirstOrDefault(b => b.BookingID == bookingID);
                if (booking == null)
                    throw new Exception("Khong tim thay booking.");

                var details = db.BookingDetails.Where(d => d.BookingID == bookingID).ToList();
                foreach (var d in details)
                {
                    var room = db.Rooms.FirstOrDefault(r => r.RoomID == d.RoomID);
                    if (room != null) room.Status = "Trống";
                }

                var services = db.BookingServices.Where(s => s.BookingID == bookingID).ToList();
                if (services.Count > 0) db.BookingServices.RemoveRange(services);
                if (details.Count > 0) db.BookingDetails.RemoveRange(details);

                try
                {
                    db.Bookings.Remove(booking);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Loi xoa booking: " + ex.Message);
                }
            }
        }

        public (int soNgay, decimal tongTien) tinhTien(int roomID, DateTime checkIn, DateTime checkOut)
        {
            using (var db = Entities.CreateEntities())
            {
                Room room = db.Rooms.Include("RoomType").FirstOrDefault(r => r.RoomID == roomID);
                int soNgay = CalculateStayDays(checkIn, checkOut);
                decimal tongTien = soNgay * (room?.RoomType?.Price ?? 0);
                return (soNgay, tongTien);
            }
        }

        public DataTable getAvailableRoomsTable()
        {
            using (var db = Entities.CreateEntities())
            {
                var rows = from r in db.Rooms
                           join t in db.RoomTypes on r.RoomTypeID equals t.RoomTypeID
                           join f in db.Floors on r.FloorID equals f.FloorID
                           where r.Status == "Trống"
                           select new RoomRow
                           {
                               RoomID = r.RoomID,
                               RoomCode = r.RoomCode,
                               Price = t.Price,
                               FloorID = r.FloorID,
                               FloorName = f.FloorName
                           };
                return ToRoomTable(rows.ToList());
            }
        }

        public DataTable getBookedRoomsTable(int bookingID)
        {
            using (var db = Entities.CreateEntities())
            {
                var rows = from d in db.BookingDetails
                           join r in db.Rooms on d.RoomID equals r.RoomID
                           join t in db.RoomTypes on r.RoomTypeID equals t.RoomTypeID
                           join f in db.Floors on r.FloorID equals f.FloorID
                           where d.BookingID == bookingID
                           select new RoomRow
                           {
                               RoomID = r.RoomID,
                               RoomCode = r.RoomCode,
                               Price = t.Price,
                               FloorID = r.FloorID,
                               FloorName = f.FloorName
                           };
                return ToRoomTable(rows.ToList());
            }
        }

        private static void ValidateBookingDates(DateTime? checkIn, DateTime? checkOut)
        {
            if (checkIn == null)
                throw new Exception("Vui long chon ngay check-in.");
            if (checkOut == null)
                throw new Exception("Vui long chon ngay check-out.");
            if (checkOut.Value.Date < checkIn.Value.Date)
                throw new Exception("Ngay check-out phai bang hoac sau ngay check-in.");
        }

        private static int CalculateStayDays(DateTime checkIn, DateTime checkOut)
        {
            return Math.Max(1, (int)(checkOut.Date - checkIn.Date).TotalDays);
        }

        private static DataTable ToRoomTable(List<RoomRow> rows)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomID", typeof(int));
            dt.Columns.Add("RoomCode", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("FloorID", typeof(int));
            dt.Columns.Add("FloorName", typeof(string));

            foreach (var r in rows)
            {
                dt.Rows.Add(r.RoomID, r.RoomCode, r.Price ?? 0m, r.FloorID ?? 0, r.FloorName ?? string.Empty);
            }

            return dt;
        }

        private class RoomRow
        {
            public int RoomID { get; set; }
            public string RoomCode { get; set; }
            public decimal? Price { get; set; }
            public int? FloorID { get; set; }
            public string FloorName { get; set; }
        }
    }
}
