using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoomTypeBUS
    {
        public List<RoomType> getAll()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.RoomTypes.ToList();
            }
        }

        public RoomType getItem(int id)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.RoomTypes.FirstOrDefault(x => x.RoomTypeID == id);
            }
        }

        public void add(RoomType roomType)
        {
            using (var db = Entities.CreateEntities())
            {
                try
                {
                    db.RoomTypes.Add(roomType);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }

        public void update(RoomType roomType)
        {
            using (var db = Entities.CreateEntities())
            {
                RoomType rt = db.RoomTypes.FirstOrDefault(x => x.RoomTypeID == roomType.RoomTypeID);
                if (rt == null)
                    throw new Exception("Khong tim thay loai phong.");

                rt.TypeName = roomType.TypeName;
                rt.Price = roomType.Price;
                rt.BedNumbers = roomType.BedNumbers;
                rt.HumanCapacity = roomType.HumanCapacity;
                rt.StandardCapacity = roomType.StandardCapacity;
                rt.AdultCapacity = roomType.AdultCapacity;
                rt.ChildCapacity = roomType.ChildCapacity;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("Lỗi: " + e.Message);
                }
            }
        }

        public void remove(RoomType idRt)
        {
            using (var db = Entities.CreateEntities())
            {
                RoomType rt = db.RoomTypes.FirstOrDefault(x => x.RoomTypeID == idRt.RoomTypeID);
                if (rt == null)
                    throw new Exception("Khong tim thay loai phong.");

                try
                {
                    db.RoomTypes.Remove(rt);
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
