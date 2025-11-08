using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Media;
using CanarinScout.Domain.Entities;
using CanarinScout.Domain.Entities.Media;

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
            CreateMap<GoleiroMedia, GoleiroMediaDto>();
        }
    }
}
