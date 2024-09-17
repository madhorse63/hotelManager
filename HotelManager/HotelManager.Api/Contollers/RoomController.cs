using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.Api.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllRooms()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateRoom()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRoom(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            return Ok();
        }

    }
}
