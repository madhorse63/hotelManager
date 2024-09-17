using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.Api.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllBookings()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            return Ok($"{id}");
        }

        [HttpPost]
        public IActionResult CreateBooking()
        {
            return Ok("booking created");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBooking(int id)
        {
            return Ok($"booking {id} updated!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            return Ok($"booking {id} deleted");
        }
    }
}
