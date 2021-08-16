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
    public class PhotoController : ControllerBase
    {
        private readonly IGenCRUDRepository<Photo> photoGenRepo;
        private readonly IMapper mapper;

        public PhotoController(
            IGenCRUDRepository<Photo> _photoGenRepo,
            IMapper _mapper
            )
        {
            photoGenRepo = _photoGenRepo;
            mapper = _mapper;
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdatePhoto([FromBody] PhotoDto dto)
        {
            try
            {
                var result = await photoGenRepo.UpdateAsync(mapper.Map(dto, new Photo()));
                return Ok(mapper.Map(result, new PhotoDto()));
            }
            catch
            {
                return BadRequest("Unable to update photo. Please contact IT support");
            }
        }

        [HttpDelete]
        [Route("delete/{photoId}")]
        public async Task<IActionResult> DeletePhoto(int photoId)
        {
            try
            {
                await photoGenRepo.RemoveAsync(photoId);
                return Ok();
            }
            catch
            {
                return BadRequest("Unable to delete photo. Please contact IT support");
            }
        }
    }
}
