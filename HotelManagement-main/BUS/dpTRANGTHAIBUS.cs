using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class dpTRANGTHAIBUS
    {
        public bool _value { set; get; }
        public string _display { set; get; }

        public dpTRANGTHAIBUS()
        {

        }
        public dpTRANGTHAIBUS(bool value, string display)
            {
                _value = value;
                _display = display;
        }
        public static List<dpTRANGTHAIBUS> getListTrangThai()
        {
            List<dpTRANGTHAIBUS> list = new List<dpTRANGTHAIBUS>();
            dpTRANGTHAIBUS[] collect = new dpTRANGTHAIBUS[]
            {
                new dpTRANGTHAIBUS(false, "Chưa thanh toán"),
                new dpTRANGTHAIBUS(true, "Đã thanh toán")
            };
            list.AddRange(collect);
            return list;
        }

        
    }
}
