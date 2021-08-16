using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazenAPI.Models
{
    public class Address : BaseEntity
    {
        public string UnitNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public bool InOfficePark { get; set; }
        public bool InEstate { get; set; }
    }

}