using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PazenAPI.Models
{
    public class Photo : BaseEntity
    {
        public string Image { get; set; } //bytes or base64?
        public string Name { get; set; }
        public string Size { get; set; }

        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }
}
