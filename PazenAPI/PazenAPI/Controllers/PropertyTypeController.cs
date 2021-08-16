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
    public class PropertyTypeController : ControllerBase
    {
        private readonly IGenCRUDRepository<PropertyType> propertyTypeGenRepo;
        private readonly IMapper mapper;

        public PropertyTypeController(
            IGenCRUDRepository<PropertyType> _propertyTypeGenRepo,
            IMapper _mapper
            )
        {
            propertyTypeGenRepo = _propertyTypeGenRepo;
            mapper = _mapper;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAllPropertyTypes()
        {
            var result = propertyTypeGenRepo.GetAll();
            return Ok(mapper.Map(result, new List<PropertyTypeDto>()));
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreatePropertyType([FromBody] PropertyTypeDto dto)
        {
            try
            {
                var result = await propertyTypeGenRepo.AddAsync(mapper.Map(dto, new PropertyType()));
                return Ok(result);
            }
            catch
            {
                return BadRequest("Unable to add property type. Please contact IT support");
            }
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdatePropertyType([FromBody] PropertyTypeDto dto)
        {
            try
            {
                var result = await propertyTypeGenRepo.UpdateAsync(mapper.Map(dto, new PropertyType()));
                return Ok(mapper.Map(result, new PropertyType()));
            }
            catch
            {
                return BadRequest("Unable to update property type. Please contact IT support");
            }
        }

        [HttpDelete]
        [Route("delete/{propertyTypeId}")]
        public async Task<IActionResult> DeletePropertyType(int propertyTypeId)
        {
            try
            {
                await propertyTypeGenRepo.RemoveAsync(propertyTypeId);
                return Ok();
            }
            catch
            {
                return BadRequest("Unable to delete property type. Please contact IT support");
            }
        }
    }
}
