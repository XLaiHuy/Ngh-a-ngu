using System;
using System.Collections.Generic;

namespace DTO
{
    public class InvoiceInfoDTO
    {
        public int BookingID { get; set; }
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCCCD { get; set; }
        public string CustomerPhone { get; set; }
        public string RoomCodes { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int StayDays { get; set; }
        public decimal RoomPricePerDayTotal { get; set; }
        public decimal RoomTotal { get; set; }
        public decimal ServiceTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public List<InvoiceServiceItemDTO> Services { get; set; }
    }

    public class InvoiceServiceItemDTO
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }
    }

    public class BookingLookupDTO
    {
        public int BookingID { get; set; }
        public string Display { get; set; }
    }

    public class RevenueRowDTO
    {
        public string Period { get; set; }
        public decimal Revenue { get; set; }
    }
}
