using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Core.DTO
{
    public class RoomDTO
    {
        public int Id { get; set; };
        public int Number { get; set; };

        public enum _Type { economy, standart, luxury };
        public _Type Type { get; set };

        public decimal Price { get; set; };
    }
}
