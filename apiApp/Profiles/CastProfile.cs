using api.Models;
using apiApp.Entities;
using AutoMapper;

namespace apiApp.Profiles
{
    public class CastProfile : Profile
    {
        public CastProfile()
        {
            CreateMap<Cast, CastDto>();
            CreateMap<CastForCreationDto, Cast>().ReverseMap();
            CreateMap<CastForupdateDto, Cast>().ReverseMap();
        }
    }
}