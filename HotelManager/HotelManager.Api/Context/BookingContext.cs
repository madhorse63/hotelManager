using Microsoft.EntityFrameworkCore;
using HotelManager.Core.DTO;

namespace HotelManager.Api.Context
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
        
        }

        public DbSet<BookingDTO> Bookings { get; set; }
    }
}
