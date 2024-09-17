using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Core.DTO
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public enum Type
        {
            economy,
            standart,
            luxury
        }
        public decimal Price { get; set; }
    }
}
