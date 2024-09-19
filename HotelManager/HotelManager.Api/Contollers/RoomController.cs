using HotelManager.Api.Context;
using HotelManager.Core.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.Api.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private RoomsContext _roomContext;

        public RoomController(RoomsContext roomContext)
        {
            _roomContext = roomContext;
        }

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
        public IActionResult CreateRoom([FromBody] RoomDTO room)
        {
            if (room == null)
            {
                return BadRequest("Room can not be null.");
            }

            _roomContext.Rooms.Add(room);

            int result = _roomContext.SaveChanges();

            if (result > 0)
            {
                
            }

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
