using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class FloorBUS
    {
        public List<Floor> GetAll()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Floors.ToList();
            }
        }

        public void add(Floor floor)
        {
            using (var db = Entities.CreateEntities())
            {
                try
                {
                    db.Floors.Add(floor);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error: " + ex.Message);
                }
            }
        }

        public void update(int idFloor, string nameFloor)
        {
            using (var db = Entities.CreateEntities())
            {
                Floor floor = db.Floors.FirstOrDefault(x => x.FloorID == idFloor);
                if (floor == null)
                    throw new Exception("Khong tim thay tang.");

                floor.FloorName = nameFloor;
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
        public void delete(string nameFloor)
        {
            using (var db = Entities.CreateEntities())
            {
                Floor floor = db.Floors.FirstOrDefault(x => x.FloorName == nameFloor);
                if (floor == null)
                    throw new Exception("Khong tim thay tang.");

                db.Floors.Remove(floor);
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