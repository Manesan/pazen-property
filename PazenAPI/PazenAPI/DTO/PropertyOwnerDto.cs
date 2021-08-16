using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazenAPI.DTO
{
    public class PropertyOwnerDto : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string AlternativeContactNumber { get; set; }
        public string IDNumber { get; set; }
        public string PassportNumber { get; set; }
        public int AddressId { get; set; }
        public AddressDto Address { get; set; }
    }
}
