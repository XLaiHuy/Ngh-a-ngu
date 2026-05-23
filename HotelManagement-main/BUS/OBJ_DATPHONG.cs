using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OBJ_DATPHONG
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Channel { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? PlannedCheckOutDate { get; set; }
        public bool? TheoDoan { get; set; }
        public bool? CheckOut {  get; set; }
        public string Note {get; set;}
    }
}
