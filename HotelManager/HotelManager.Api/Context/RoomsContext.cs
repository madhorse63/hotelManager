using Microsoft.EntityFrameworkCore;
using HotelManager.Core.DTO;

namespace HotelManager.Api.Context
{
    public class RoomsContext : DbContext
    {
        public RoomsContext(DbContextOptions<RoomsContext> options) : base(options)
        {
        
        }

        public DbSet<RoomDTO> Rooms { get; set; }
    }
}
