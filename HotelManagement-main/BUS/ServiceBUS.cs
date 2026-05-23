using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ServiceBUS
    {
        public List<Service> getAll()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Services.ToList();
            }
        }

        public Service getItem(int id)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Services.FirstOrDefault(x => x.ServiceID == id);
            }
        }

        public List<ObjServiceBUS> getAllDetail()
        {
            using (var db = Entities.CreateEntities())
            {
                var q = from sv in db.Services
                        join svt in db.ServiceTypes on sv.TypeID equals svt.ServiceTypeID into svtJoin
                        from svt in svtJoin.DefaultIfEmpty()
                        select new ObjServiceBUS
                        {
                            ServiceID = sv.ServiceID,
                            NameService = sv.NameService,
                            Price = sv.Price,
                            Quantity = sv.Quantity,
                            TypeID = sv.TypeID,
                            Type = svt != null ? svt.Type : "Khong co loai dich vu"
                        };
                return q.ToList();
            }
        }

        public void add(Service service)
        {
            using (var db = Entities.CreateEntities())
            {
                try
                {
                    db.Services.Add(service);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }

        public void update(Service service)
        {
            using (var db = Entities.CreateEntities())
            {
                Service s = db.Services.FirstOrDefault(x => x.ServiceID == service.ServiceID);
                if (s == null)
                    throw new Exception("Khong tim thay dich vu.");

                s.NameService = service.NameService;
                s.Price = service.Price;
                s.Quantity = service.Quantity;
                s.TypeID = service.TypeID;
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

        public void delete(int id)
        {
            using (var db = Entities.CreateEntities())
            {
                Service s = db.Services.FirstOrDefault(x => x.ServiceID == id);
                if (s == null)
                    throw new Exception("Khong tim thay dich vu.");

                try
                {
                    db.Services.Remove(s);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("Lỗi: " + e.Message);
                }
            }
        }
    }
}
