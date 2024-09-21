using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using HotelManager.Api.Context;
using HotelManager.Core.DTO;

namespace HotelManager.Api.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private BookingContext _bookingContext;
        
        public BookingController(BookingController bookingContext)
        {
            _bookingContext = bookingContext;
        }

        [HttpGet]
        public IActionResult<IEnumerable<BookingDTO>> GetAllBookings()
        {
            var bookings = _bookingContext.Bookings.ToList();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult<BookingDTO> GetBooking(int id)
        {
            var booking = _bookingContext.Bookings.Find(id);

            if(booking = null)
            {
                return NotFound();
            }

            return Ok(booking);
        }

        [HttpPost]
        public IActionResult CreateBooking([FromBody] BookingDTO booking)
        {
            if(booking == null)
            {
                return BadRequest("Booking is can not be null.");
            }

            _bookingContext.Bookings.Add();

            int result = _bookingContext.SaveChanges();

            if(result > 0)
            {
                return CreatedAtAction(nameof(GetBooking), { id = booking.Id}, booking);
            }

            return StatusCode(500, "An error while creating booking.");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id, [FromBody] BookingDTO booking)
        {
            if(id !== booking.Id)
            {
                return BadRequest();
            }

            var existingBooking = _bookingContext.Bookings.Find(id);
            if(existingBooking == null)
            {
                return NotFound();
            }

            existingBooking.RoomId = booking.RoomId;
            existingBooking.CustomerName = booking.CustomerName;
            existingBooking.CheckInDate = booking.CheckInDate;
            existingBooking.CheckOutDate = booking.CheckOutDate;

            _bookingContext.Bookings.Update();
            _bookingContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var booking = _bookingContext.Bookings.Find(id);

            if(booking == null)
            {
                return BadRequest();
            }

            _bookingContext.Bookings.Remove(booking);
            _bookingContext.SaveChanges();

            return NoContent();
        }
    }
}
