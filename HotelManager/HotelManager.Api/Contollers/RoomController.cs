using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using HotelManager.Api.Context;
using HotelManager.Core.DTO;

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
        public IActionResult <IEnumerable<RoomDTO>> GetAllRooms()
        {
            var rooms = _roomContext.Rooms.ToLists();

            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public IActionResult<RoomDTO> GetRoom(int id)
        {
            var room = _roomContext.Rooms.Find(id);
            if(room == null)
            {
                return NotFound();
            }

            return Ok(room);
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
                return CreatedAtAction(nameof(GetRoom), new {id = room.Id}, room)
            }

            return StatusCode(500, "An error while creating room");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRoom(int id, [FromBody] RoomDTO room)
        {
            if(id != room.Id)
            {
                return BadRequest();
            }

            var existingRoom = _roomContext.Rooms.Find(id);
            if(existingRoom == null)
            {
                return NotFound();
            }

            existingRoom.Number = room.Number;
            existingRoom.Type = room.Type;
            existingRoom.Price = room.Price;

            _roomContext.Rooms.Update();
            _roomContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var room = _roomContext.Rooms.Find(id);

            if(room == null)
            {
                return BadRequest();
            }

            _roomContext.Rooms.Remove(room);
            _roomContext.SaveChanges();

            return NoContent();
        }

    }
}
