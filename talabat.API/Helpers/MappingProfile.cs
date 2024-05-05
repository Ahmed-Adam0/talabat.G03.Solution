using AutoMapper;
using talabat.API.DTOs;
using talabat.DAL.Entities;

namespace talabat.API.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<product, ProductToRetarnDTo>()
                .ForMember(d => d.producttype, o => o.MapFrom(s => s.producttype.name))
                .ForMember(d => d.productBrand, o => o.MapFrom(s => s.productBrand.name));

        }
    }
}
