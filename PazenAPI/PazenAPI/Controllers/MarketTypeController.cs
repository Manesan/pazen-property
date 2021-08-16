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
    public class MarketTypeController : ControllerBase
    {
        private readonly IGenCRUDRepository<MarketType> marketTypeGenRepo;
        private readonly IMapper mapper;

        public MarketTypeController(
            IGenCRUDRepository<MarketType> _marketTypeGenRepo,
            IMapper _mapper
            )
        {
            marketTypeGenRepo = _marketTypeGenRepo;
            mapper = _mapper;
        }

        [HttpGet]
        [Route("getall")]
        public IActionResult GetAllMarketTypes()
        {
            var result = marketTypeGenRepo.GetAll();
            return Ok(mapper.Map(result, new List<MarketTypeDto>()));
        }

        [HttpGet]
        [Route("getmarkettype/{marketTypeId}")]
        public async Task<IActionResult> GetMarketType(int marketTypeId)
        {
            var result = await marketTypeGenRepo.GetByPrimaryKeyAsync(marketTypeId);
            return Ok(mapper.Map(result, new MarketTypeDto()));
        }



        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateMarketType([FromBody] MarketTypeDto dto)
        {
            try
            {
                var result = await marketTypeGenRepo.AddAsync(mapper.Map(dto, new MarketType()));
                return Ok(result);
            }
            catch
            {
                return BadRequest("Unable to add market type. Please contact IT support");
            }
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateMarketType([FromBody] MarketTypeDto dto)
        {
            try
            {
                var result = await marketTypeGenRepo.UpdateAsync(mapper.Map(dto, new MarketType()));
                return Ok(mapper.Map(result, new MarketTypeDto()));
            }
            catch
            {
                return BadRequest("Unable to update market type. Please contact IT support");
            }
        }

        [HttpDelete]
        [Route("delete/{marketTypeId}")]
        public async Task<IActionResult> DeleteMarketType(int marketTypeId)
        {
            try
            {
                await marketTypeGenRepo.RemoveAsync(marketTypeId);
                return Ok();
            }
            catch
            {
                return BadRequest("Unable to delete market type. Please contact IT support");
            }
        }
    }
}
