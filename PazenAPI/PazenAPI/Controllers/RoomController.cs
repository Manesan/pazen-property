using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PazenAPI.DTO;
using PazenAPI.Models;
using PazenAPI.Repository.IRepository;

namespace PazenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IGenCRUDRepository<Room> roomGenRepo;
        private readonly IMapper mapper;

        public RoomController(
            IGenCRUDRepository<Room> _roomGenRepo,
            IMapper _mapper
            )
        {
            roomGenRepo = _roomGenRepo;
            mapper = _mapper;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateRoom([FromBody] RoomDto dto)
        {
            try
            {
                var result = await roomGenRepo.AddAsync(mapper.Map(dto, new Room()));
                return Ok(result);
            }
            catch
            {
                return BadRequest("Unable to add room. Please contact IT support");
            }
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateRoom([FromBody] RoomDto dto)
        {
            try
            {
                var result = await roomGenRepo.UpdateAsync(mapper.Map(dto, new Room()));
                return Ok(mapper.Map(result, new RoomDto()));
            }
            catch
            {
                return BadRequest("Unable to update room. Please contact IT support");
            }
        }

        [HttpDelete]
        [Route("delete/{roomId}")]
        public async Task<IActionResult> DeleteRoom(int roomId)
        {
            try
            {
                await roomGenRepo.RemoveAsync(roomId);
                return Ok();
            }
            catch
            {
                return BadRequest("Unable to delete room. Please contact IT support");
            }
        }
    }
}
