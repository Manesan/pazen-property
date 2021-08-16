using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PazenAPI.DTO;
using PazenAPI.Models;

namespace PazenAPI.Mapper
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<MarketType, MarketTypeDto>().ReverseMap();
            CreateMap<Photo, PhotoDto>().ReverseMap();
            CreateMap<Property, PropertyDto>().ReverseMap();
            CreateMap<PropertyType, PropertyTypeDto>().ReverseMap();
            CreateMap<Room, RoomDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Mandate, MandateDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<PropertyOwner, PropertyOwnerDto>().ReverseMap();
        }
    }
}
