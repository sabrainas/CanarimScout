using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Domain.Entities;
using CanarinScout.WebApi;

namespace CanarinScout.Application.Mapping
{
    public class JogadorProfile : Profile
    {
        public JogadorProfile() 
        {
            CreateMap<Jogador, JogadorDto>();

            CreateMap<Defensivas, DefensivasDto>();

            CreateMap<Passes, PassesDto>();

            CreateMap<Posses, PossesDto>();

            CreateMap<Estatisticas, EstatisticasDto>();
        }
    }
}
