using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ObjServiceBUS
    {
        public int ServiceID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string NameService { get; set; }
        public Nullable<decimal> Price { get; set; }

        public string Type { get; set; }
        public int ServiceTypeID { get; set; } 
    }
}
