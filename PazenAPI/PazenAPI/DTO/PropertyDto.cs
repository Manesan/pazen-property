using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;

namespace PazenAPI.DTO
{
    public class PropertyDto : BaseDto
    {
        public int AddressId { get; set; }
        public AddressDto Address { get; set; }
        public decimal Price { get; set; }
        public int Dimension { get; set; } //m*2
        public string Description { get; set; }
        public string ReferenceNumber { get; set; } //auto generated
        public decimal Levies { get; set; }
        public decimal RatesAndTaxes { get; set; }
        public bool PetsAllowed { get; set; }
        public bool Pool { get; set; }
        public bool Garden { get; set; }
        public bool Security { get; set; }
        public bool Advertisement { get; set; }
        public int MarketTypeId { get; set; }
        public MarketTypeDto MarketType { get; set; }

        public int PropertyTypeId { get; set; }
        public PropertyTypeDto PropertyType { get; set; }

        public int MandateId { get; set; }
        public MandateDto Mandate { get; set; }

        public ICollection<RoomDto> Rooms { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
    }
}
