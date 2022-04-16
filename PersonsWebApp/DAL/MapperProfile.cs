using AutoMapper;
using PersonsWebApp.DAL.Entities;

namespace PersonsWebApp.DAL
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<PersonEntity, PersonDto>()
                .ReverseMap();
        }
    }
}
