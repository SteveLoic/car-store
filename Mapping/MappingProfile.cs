using AutoMapper;
using digitalcar.Controllers.Models;
using digitalcar.Controllers.Ressources;

namespace digitalcar.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeRessource>();
            CreateMap<Model, ModelRessource>();
        }
    }
}