using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazenAPI.DTO
{
    public class MarketTypeDto : BaseDto
    {
        /// <summary>
        /// for sale/to rent
        /// </summary>
        public string Description { get; set; }
    }
}
