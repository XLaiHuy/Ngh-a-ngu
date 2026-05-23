using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ServiceTypeBUS
    {
        public List<ServiceType> getAll()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.ServiceTypes.ToList();
            }
        }
        public ServiceType getItem(string maLDV)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.ServiceTypes.FirstOrDefault(x => x.MaServiceType == maLDV);
            }
        }
        public void add(ServiceType nameType)
        {
            using (var db = Entities.CreateEntities())
            {
                try
                {
                    db.ServiceTypes.Add(nameType);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }

        public void remove(string maLDV) 
        {
            using (var db = Entities.CreateEntities())
            {
                ServiceType svType = db.ServiceTypes.FirstOrDefault(x => x.MaServiceType == maLDV);
                if (svType == null)
                    throw new Exception("Khong tim thay loai dich vu.");

                try
                {
                    db.ServiceTypes.Remove(svType);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }


        public void update(ServiceType nameType)
        {
            using (var db = Entities.CreateEntities())
            {
                ServiceType serviceType = db.ServiceTypes.FirstOrDefault(s => s.MaServiceType == nameType.MaServiceType);
                if (serviceType == null)
                    throw new Exception("Khong tim thay loai dich vu.");

                serviceType.Type = nameType.Type;
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
    }
}
