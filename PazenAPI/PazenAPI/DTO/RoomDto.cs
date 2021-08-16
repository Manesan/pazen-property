using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazenAPI.DTO
{
    public class RoomDto : BaseDto
    {
        /// <summary>
        /// field dropdowns can be hard populated on frontend
        /// </summary>
        public string Description { get; set; }
        public int Amount { get; set; }
        public int PropertyId { get; set; }
        public PropertyDto Property { get; set; }
    }
}
