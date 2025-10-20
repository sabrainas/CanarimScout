using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Domain.Entities;

namespace CanarinScout.Application.Mapping
{
    public class JogadorProfile : Profile
    {
        public JogadorProfile()
        {
            CreateMap<Estatisticas, EstatisticasDto>();
            CreateMap<Ofensivas, OfensivasDto>();
            CreateMap<Passes, PassesDto>();
            CreateMap<Posses, PossesDto>();
            CreateMap<Defensivas, DefensivasDto>();
            CreateMap<TipoPasses, TipoPassesDto>();
            CreateMap<Goleiros, GoleiroStatsDto>();
        }
    }
}
