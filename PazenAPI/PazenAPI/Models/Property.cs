using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace PazenAPI.Models
{
    public class Property : BaseEntity
    {
        private ILazyLoader lazyLoader;
        private ICollection<Photo> photos;
        private ICollection<Room> rooms;

        public Property()
        {

        }
        public Property(ILazyLoader _lLoader)
        {
            lazyLoader = _lLoader;
        }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

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

        [ForeignKey("MarketType")] //rent/sale
        public int MarketTypeId { get; set; }
        public MarketType MarketType { get; set; }

        [ForeignKey("PropertyType")]  //house/commercial/apartment
        public int PropertyTypeId { get; set; }
        public PropertyType PropertyType { get; set; }

        [ForeignKey("Mandate")]
        public int MandateId { get; set; }
        public Mandate Mandate { get; set; }

        public ICollection<Photo> Photos
        {
            get => lazyLoader.Load(this, ref photos);
            set => photos = value;
        }

        public ICollection<Room> Rooms
        {
            get => lazyLoader.Load(this, ref rooms);
            set => rooms = value;
        }
    }
}
