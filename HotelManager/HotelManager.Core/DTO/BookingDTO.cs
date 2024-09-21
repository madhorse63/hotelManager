using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Core.DTO
{
    public class BookingDTO
    {
        public int Id { get; set; };
        public int RoomId { get; set; };
        public string CustomerName { get; set; };
        public DateTime CheckInDate { get; set; };
        public DateTime CheckOutDate { get; set; };
        public decimal TotalPrice { get; set; };
    }
}
