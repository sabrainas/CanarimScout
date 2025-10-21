using AutoMapper;
using CanarinScout.Application.DTO.Sum;
using CanarinScout.Domain.Entities.Sum;

namespace CanarinScout.Application.Mapping
{
    public class StatsSumProfile : Profile
    {
        public StatsSumProfile()
        {
            CreateMap<DefensivasSum, DefensivasSumDto>();
            CreateMap<OfensivasSum, OfensivasSumDto>();
            CreateMap<PassesSum, PassesSumDto>();
            CreateMap<TipoPassesSum, TipoPassesSumDto>();
            CreateMap<PossesSum, PossesSumDto>();
            CreateMap<GoleirosSum, GoleirosSumDto>();
            CreateMap<EstatisticasSum, EstatisticasSumDto>();
        }
    }
}
