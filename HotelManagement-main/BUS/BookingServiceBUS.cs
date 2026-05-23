using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BookingServiceBUS
    {
        public List<BookingService> getAll()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.BookingServices.Include("Service").Include("Booking").ToList();
            }
        }

        public List<OBJ_DPSP> getByBooking(int bookingId)
        {
            using (var db = Entities.CreateEntities())
            {
                var lst = db.BookingServices.Where(b => b.BookingID == bookingId).ToList();
                List<OBJ_DPSP> lstDPSP = new List<OBJ_DPSP>();
                OBJ_DPSP sp;
                foreach (var item in lst)
                {
                    sp = new OBJ_DPSP();
                    sp.BookingServicedID = item.BookingServiceID;
                    sp.ServiceID = item.ServiceID;
                    sp.BookingID = item.BookingID;
                    sp.RoomID = item.RoomID;
                    var p = db.Rooms.FirstOrDefault(x => x.RoomID == item.RoomID);
                    sp.RoomCode = p != null ? p.RoomCode : string.Empty;
                    var _sp = db.Services.FirstOrDefault(x => x.ServiceID == item.ServiceID);
                    sp.NameService = _sp != null ? _sp.NameService : string.Empty;
                    sp.Quantity = item.Quantity;
                    sp.Price = item.DONGIA;
                    sp.ThanhTien = item.THANHTIEN;

                    lstDPSP.Add(sp);
                }
                return lstDPSP;
            }
        }


        public void add(BookingService bs)
        {
            using (var db = Entities.CreateEntities())
            {
                try
                {
                    db.BookingServices.Add(bs);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }

        public void update(BookingService bs)
        {
            using (var db = Entities.CreateEntities())
            {
                var item = db.BookingServices.FirstOrDefault(x => x.BookingServiceID == bs.BookingServiceID);
                if (item == null)
                    throw new Exception("Khong tim thay dich vu dat phong.");

                item.BookingID = bs.BookingID;
                item.ServiceID = bs.ServiceID;
                item.BookingDetailID = bs.BookingDetailID;
                item.RoomID = bs.RoomID;
                item.Quantity = bs.Quantity;
                item.UsedDate = bs.UsedDate;
                item.DONGIA = bs.DONGIA;
                item.THANHTIEN = bs.THANHTIEN;
                item.Note = bs.Note;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }

        public void removeByRoom(int bookingID, int roomID)
        {
            using (var db = Entities.CreateEntities())
            {
                var item = db.BookingServices.FirstOrDefault(x => x.BookingID == bookingID && x.RoomID == roomID);
                if (item != null)
                {
                    try
                    {
                        db.BookingServices.Remove(item);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        public void deleteAll(int idDP)
        {
            using (var db = Entities.CreateEntities())
            {
                List<BookingService> items = db.BookingServices.Where(x => x.BookingID == idDP).ToList();
                if (items.Count > 0)
                {
                    try
                    {
                        db.BookingServices.RemoveRange(items);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Lỗi: " + ex.Message);
                    }
                }
            }
        }
    }
}