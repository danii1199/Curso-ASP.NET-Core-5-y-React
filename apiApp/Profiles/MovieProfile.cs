using api.Models;
using apiApp.Entities;
using AutoMapper;

namespace apiApp.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDto>();
            CreateMap<Movie, MovieWithoutCastDto>();
        }
    }
}