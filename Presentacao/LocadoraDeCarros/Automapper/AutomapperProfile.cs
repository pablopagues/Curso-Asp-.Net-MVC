using AutoMapper;
using Dados.Models;
using LocadoraDeCarros.Models;
using Negocio.Models;

namespace LocadoraDeCarros.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();

            CreateMap<Cliente, ClienteDataModel>().ReverseMap();
        }
    }
}
