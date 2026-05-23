using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ObjRooms
    {
        public int RoomID { get; set; }
        public string RoomCode { get; set; }
        public int? RoomTypeID { get; set; }
        public string TypeName { get; set; }
        public int? FloorID { get; set; }
        public string FloorName { get; set; }
        public string Status { get; set; }
        public bool AllowExtraPeople { get; set; }
        public decimal? Price { get; set; }
        public int? BedNumbers { get; set; }
        public int? HumanCapacity { get; set; }
    }
}
