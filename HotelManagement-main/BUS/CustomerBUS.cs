using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        public List<Customer> getAll()
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Customers.ToList();
            }
        }
        public Customer getItem(string cccdCustomer)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Customers.FirstOrDefault(x => x.CCCD == cccdCustomer);
            }
        }
        public Customer getItem(int idCustomer)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Customers.FirstOrDefault(x => x.CustomerID == idCustomer);
            }
        }
        public void add(Customer cus)
        {
            using (var db = Entities.CreateEntities())
            {
                try
                {
                    db.Customers.Add(cus);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi: " + ex.Message);
                }
            }
        }

        public void update(Customer cus)
        {
            using (var db = Entities.CreateEntities())
            {
                Customer _cus = db.Customers.FirstOrDefault(x => x.CCCD == cus.CCCD);
                if (_cus == null)
                    throw new Exception("Khach hang khong ton tai.");

                _cus.FullName = cus.FullName;
                _cus.Phone = cus.Phone;
                _cus.Email = cus.Email;
                _cus.Gender = cus.Gender;

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

        public void delete(string cusCCCD)
        {
            using (var db = Entities.CreateEntities())
            {
                Customer cus = db.Customers.FirstOrDefault(x => x.CCCD == cusCCCD);
                if (cus == null)
                    throw new Exception("Khach hang khong ton tai.");

                db.Customers.Remove(cus);
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
        public List<Customer> getByName(string name)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Customers.Where(x => x.FullName.Contains(name)).ToList();
            }
        }
        public void blockCustomer(string CCCD, string reason)
        {
            using (var db = Entities.CreateEntities())
            {
                Customer _cus = db.Customers.FirstOrDefault(x => x.CCCD == CCCD);
                if (_cus == null)
                    throw new Exception("Khach hang khong ton tai.");

                _cus.IsBlocked = true;
                _cus.BlockReason = reason;
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
        public bool checkNameExits(string name)
        {
            using (var db = Entities.CreateEntities())
            {
                return db.Customers.Any(x => x.FullName == name);
            }
        }
    }
}