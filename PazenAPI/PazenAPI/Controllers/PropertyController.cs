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
    /// <summary>
    /// CRUD Property
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IGenCRUDRepository<Property> propertyGenRepo;
        private readonly IMapper mapper;

        public PropertyController(
            IGenCRUDRepository<Property> _propertyGenRepo,
            IMapper _mapper
            )
        {
            propertyGenRepo = _propertyGenRepo;
            mapper = _mapper;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAllProperties()
        {
            var result =  propertyGenRepo.GetAll();
            return Ok(mapper.Map(result, new List<PropertyDto>()));
        }

        [HttpGet]
        [Route("getproperty/{propertyId}")]
        public async Task<IActionResult> GetProperty(int propertyId)
        {
            var result = await propertyGenRepo.GetByPrimaryKeyAsync(propertyId);
            return Ok(mapper.Map(result, new PropertyDto()));
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateProperty([FromBody] PropertyDto dto)
        {
            try
            {
                var result = await propertyGenRepo.AddAsync(mapper.Map(dto, new Property()));
                return Ok(result);
            }
            catch
            {
                return BadRequest("Unable to add property. Please contact IT support");
            }
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateProperty([FromBody] PropertyDto dto)
        {
            try
            {
                var result = await propertyGenRepo.UpdateAsync(mapper.Map(dto, new Property()));
                return Ok(mapper.Map(result, new PropertyDto()));
            }
            catch
            {
                return BadRequest("Unable to update property. Please contact IT support");
            }
        }

        [HttpDelete]
        [Route("delete/{propertyId}")]
        public async Task<IActionResult> DeleteProperty (int propertyId)
        {
            try
            {
                await propertyGenRepo.RemoveAsync(propertyId);
                return Ok();
            }
            catch
            {
                return BadRequest("Unable to delete property. Please contact IT support");
            }
        }

    }
}
