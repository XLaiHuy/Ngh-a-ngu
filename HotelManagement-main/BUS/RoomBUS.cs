using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoomBUS
    {
        public List<Room> getAll()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Rooms.ToList();
            }
        }

        public List<ObjRooms> getAllWithDetails()
        {
            using (var db = Entities.CreateEntities())
            {
                var q = from r in db.Rooms
                        join t in db.RoomTypes on r.RoomTypeID equals t.RoomTypeID into rt
                        from t in rt.DefaultIfEmpty()
                        join f in db.Floors on r.FloorID equals f.FloorID into rf
                        from f in rf.DefaultIfEmpty()
                        select new ObjRooms
                        {
                            RoomID = r.RoomID,
                            RoomCode = r.RoomCode,
                            RoomTypeID = r.RoomTypeID,
                            TypeName = t != null ? t.TypeName : null,
                            FloorID = r.FloorID,
                            FloorName = f != null ? f.FloorName : null,
                            Status = r.Status,
                            AllowExtraPeople = r.AllowExtraPeople ?? false,
                            Price = t != null ? t.Price : null,
                            BedNumbers = t != null ? t.BedNumbers : null,
                            HumanCapacity = t != null ? t.HumanCapacity : null
                        };

                return q.ToList();
            }
        }

        public List<Room> getByFloor(int idFloor)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Rooms.Where(r => r.FloorID == idFloor).ToList();
            }
        }

        public Room getItem(string codeRoom)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Rooms.FirstOrDefault(x => x.RoomCode == codeRoom);
            }
        }

        public void add(Room room)
        {
            using (var db = Entities.CreateEntities())
            {
                try
                {
                    db.Rooms.Add(room);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }
        public void update(string codeRoom, string status)
        {
            using (var db = Entities.CreateEntities())
            {
                Room room = db.Rooms.FirstOrDefault(x => x.RoomCode == codeRoom);
                if (room == null)
                    throw new Exception("Khong tim thay phong.");

                room.Status = status;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        // Update full room entity
        public void update(Room updated)
        {
            using (var db = Entities.CreateEntities())
            {
                Room room = db.Rooms.FirstOrDefault(x => x.RoomID == updated.RoomID);
                if (room == null)
                    throw new Exception("Khong tim thay phong.");

                room.RoomCode = updated.RoomCode;
                room.RoomTypeID = updated.RoomTypeID;
                room.FloorID = updated.FloorID;
                room.Status = updated.Status;
                room.AllowExtraPeople = updated.AllowExtraPeople;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        public void remove(string codeRoom)
        {
            using (var db = Entities.CreateEntities())
            {
                Room room = db.Rooms.FirstOrDefault(x => x.RoomCode == codeRoom);
                if (room == null)
                    throw new Exception("Khong tim thay phong.");

                try
                {
                    db.Rooms.Remove(room);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        public void updateStatus(int RoomId, string newStatus)
        {
            using (var db = Entities.CreateEntities())
            {
                Room room = db.Rooms.FirstOrDefault(x => x.RoomID == RoomId);
                if (room == null)
                    throw new Exception("Khong tim thay phong.");

                room.Status = newStatus;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }
    }
}