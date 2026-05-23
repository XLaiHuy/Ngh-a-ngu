using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class BookingDetailBUS
    {
        public List<BookingDetail> getAll()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.BookingDetails.ToList();
            }
        }

        public List<BookingDetail> getByBooking(int bookingId)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.BookingDetails.Where(d => d.BookingID == bookingId).ToList();
            }
        }

        public BookingDetail getItem(int id)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.BookingDetails.FirstOrDefault(d => d.BookingDetailID == id);
            }
        }

        public BookingDetail add(BookingDetail detail)
        {
            if (detail == null)
                throw new Exception("Chi tiet dat phong khong hop le.");

            ValidateDates(detail);

            using (var db = Entities.CreateEntities())
            {
                EnsureRoomAvailable(db, detail);
                try
                {
                    db.BookingDetails.Add(detail);
                    db.SaveChanges();
                    return detail;
                }
                catch (Exception ex)
                {
                    throw new Exception("Loi: " + ex.Message);
                }
            }
        }

        public void update(BookingDetail detail)
        {
            if (detail == null)
                throw new Exception("Chi tiet dat phong khong hop le.");

            ValidateDates(detail);

            using (var db = Entities.CreateEntities())
            {
                BookingDetail d = db.BookingDetails.FirstOrDefault(x => x.BookingDetailID == detail.BookingDetailID);
                if (d == null)
                    throw new Exception("Khong tim thay chi tiet dat phong.");

                EnsureRoomAvailable(db, detail);
                d.BookingID = detail.BookingID;
                d.RoomID = detail.RoomID;
                d.SONGAYO = detail.SONGAYO;
                d.RoomPrice = detail.RoomPrice;
                d.NGAY = detail.NGAY;
                d.CheckInDate = detail.CheckInDate;
                d.CheckOutDate = detail.CheckOutDate;
                d.THANHTIEN = detail.THANHTIEN;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Loi: " + ex.Message);
                }
            }
        }

        public void remove(int bookingID, int roomID)
        {
            using (var db = Entities.CreateEntities())
            {
                BookingDetail d = db.BookingDetails.FirstOrDefault(x => x.BookingID == bookingID && x.RoomID == roomID);
                if (d != null)
                {
                    try
                    {
                        db.BookingDetails.Remove(d);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Loi: " + ex.Message);
                    }
                }
            }
        }

        public void deleteAll(int idDP)
        {
            using (var db = Entities.CreateEntities())
            {
                List<BookingDetail> items = db.BookingDetails.Where(x => x.BookingID == idDP).ToList();
                if (items.Count > 0)
                {
                    try
                    {
                        db.BookingDetails.RemoveRange(items);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Loi: " + ex.Message);
                    }
                }
            }
        }

        private static void ValidateDates(BookingDetail detail)
        {
            if (detail.CheckInDate == default(DateTime))
                throw new Exception("Ngay check-in khong hop le.");
            if (detail.CheckOutDate == null)
                throw new Exception("Vui long chon ngay check-out.");
            if (detail.CheckOutDate.Value.Date < detail.CheckInDate.Date)
                throw new Exception("Ngay check-out phai bang hoac sau ngay check-in.");
        }

        private static void EnsureRoomAvailable(Entities db, BookingDetail detail)
        {
            Room room = db.Rooms.FirstOrDefault(r => r.RoomID == detail.RoomID);
            if (room == null)
                throw new Exception("Phong khong ton tai.");

            DateTime start = detail.CheckInDate.Date;
            DateTime end = detail.CheckOutDate.Value.Date;

            bool overlap = db.BookingDetails.Any(d => d.RoomID == detail.RoomID
                && d.BookingID != detail.BookingID
                && d.CheckInDate < end
                && (d.CheckOutDate ?? d.Booking.PlannedCheckOutDate ?? DateTime.MaxValue) > start);

            if (overlap)
                throw new Exception("Phong da duoc dat trong khoang thoi gian nay.");

            if (!string.IsNullOrWhiteSpace(room.Status) && room.Status != "Trống")
                throw new Exception("Phong khong san sang de dat.");
        }
    }
}
