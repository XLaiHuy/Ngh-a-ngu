using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OBJ_DPSP
    {
        public int BookingServicedID { get; set; }
        public int? ServiceID { get; set; }
        public string NameService { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? ThanhTien { get; set; }
        public int RoomID { get; set; }
        public string RoomCode { get; set; }
        public int BookingID { get; set; }
    }
}
