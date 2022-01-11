using AutoMapper;
using BelajarCoreThree.Domains.Movie.Entites;
using BelajarCoreThree.Models.Request;

namespace BelajarCoreThree.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MovieRequest, MovieEntity>();
        }
    }
}
