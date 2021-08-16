using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazenAPI.Models
{
    public class Mandate : BaseEntity
    {
        public string Document { get; set; }
        public string MandateType { get; set; } //hardcoded in frontend
    }
}
