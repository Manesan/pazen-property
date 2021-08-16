using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazenAPI.DTO
{
    public class PhotoDto : BaseDto
    {
        public string Image { get; set; } //bytes or base64?
        public string Name { get; set; }
        public string Size { get; set; }

        public int PropertyId { get; set; }
        public PropertyDto Property { get; set; }
    }
}
