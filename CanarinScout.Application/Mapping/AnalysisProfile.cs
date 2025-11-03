using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Analysis;
using CanarinScout.Domain.Entities;
using CanarinScout.Domain.Entities.Analysis;

namespace CanarinScout.Application.Mapping
{
    public class AnalysisProfile : Profile
    {
        public AnalysisProfile()
        {
            CreateMap<Jogador, JogadorDetailDto>()
                .ForMember(dest => dest.Posicao, opt => opt.Ignore())
                .ForMember(dest => dest.PeDominante, opt => opt.Ignore())
                .ForMember(dest => dest.Idade, opt => opt.Ignore())
                .ForMember(dest => dest.Altura, opt => opt.Ignore())
                .ForMember(dest => dest.Peso, opt => opt.Ignore());

            CreateMap<PlayerFeatures, PlayerFeaturesDto>()
                .ForMember(dest => dest.Jogador, opt => opt.MapFrom(src => src.Jogador))
                .ForMember(dest => dest.EstatisticasAgregadas, opt => opt.Ignore())
                .ForMember(dest => dest.AnaliseAtacante, opt => opt.Ignore())
                .ForMember(dest => dest.AnaliseMeioCampo, opt => opt.Ignore())
                .ForMember(dest => dest.AnaliseDefensor, opt => opt.Ignore())
                .ForMember(dest => dest.AnaliseGoleiro, opt => opt.Ignore());

            CreateMap<AttackerAnalysis, AttackerAnalysisDto>()
                .ForMember(dest => dest.PeDominante, opt => opt.Ignore())
                .ForMember(dest => dest.Altura, opt => opt.Ignore())
                .ForMember(dest => dest.Peso, opt => opt.Ignore());

            CreateMap<MidfielderAnalysis, MidfielderAnalysisDto>()
                .ForMember(dest => dest.PeDominante, opt => opt.Ignore())
                .ForMember(dest => dest.Altura, opt => opt.Ignore())
                .ForMember(dest => dest.Peso, opt => opt.Ignore());

            CreateMap<DefenseAnalysis, DefenseAnalysisDto>()
                .ForMember(dest => dest.PeDominante, opt => opt.Ignore())
                .ForMember(dest => dest.Altura, opt => opt.Ignore())
                .ForMember(dest => dest.Peso, opt => opt.Ignore());

            CreateMap<GoalkeeperAnalysis, GoalkeeperAnalysisDto>();
        }
    }
}