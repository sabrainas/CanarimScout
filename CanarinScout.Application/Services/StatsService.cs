using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using CanarinScout.Infrastructure.Interface;

namespace CanarinScout.Application.Services
{
    public class StatsService : IStatsService
    {
        private readonly IStatsRepository _statsRepository;
        private readonly IMapper _mapper;

        public StatsService(IStatsRepository statsRepository, IMapper mapper)
        {
            _statsRepository = statsRepository;
            _mapper = mapper;
        }

        public async Task<EstatisticasDto> GetStatsByIdAsync(int id)
        {
            var estatisticas = await _statsRepository.GetStatsByIdAsync(id);
            return _mapper.Map<EstatisticasDto>(estatisticas);
        }

        public async Task<EstatisticasDto> GetStatsByPlayerIdAsync(string playerId)
        {
            var estatisticas = await _statsRepository.GetStatsByPlayerIdAsync(playerId);
            return _mapper.Map<EstatisticasDto>(estatisticas);
        }
    }
}