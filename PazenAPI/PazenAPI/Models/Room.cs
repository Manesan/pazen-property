using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PazenAPI.Models
{
    public class Room : BaseEntity
    {
        /// <summary>
        /// field dropdowns can be hard populated on frontend
        /// </summary>
        public string Description { get; set; }
        public int Amount { get; set; }

        [ForeignKey("Property")]
        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }
}
