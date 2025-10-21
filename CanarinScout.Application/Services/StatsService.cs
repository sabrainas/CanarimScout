using AutoMapper;
using CanarinScout.Application.DTO.Sum;
using CanarinScout.Application.Interfaces;
using CanarinScout.Infrastructure.Interface;

namespace CanarinScout.Application.Services
{
    public class StatsService : IStatsService
    {
        private readonly IStatsRepository _statsRepository;
        private readonly IMapper _mapper;
        private readonly IPlayerRepository _playerRepository;

        public StatsService(IStatsRepository statsRepository, IMapper mapper, IPlayerRepository playerRepository)
        {
            _statsRepository = statsRepository;
            _mapper = mapper;
            _playerRepository = playerRepository;
        }

        public async Task<EstatisticasSumDto?> GetStatsByIdAsync(string playerId)
        {
            var estatisticas = await _statsRepository.GetStatsSumByPlayerIdAsync(playerId);
            return _mapper.Map<EstatisticasSumDto>(estatisticas);
        }

        public async Task<GoleirosSumDto?> GetGoleiroStatsByPlayerIdAsync(string playerId)
        {
            var jogador = await _playerRepository.GetPlayerByIdAsync(playerId);
            if (jogador == null || string.IsNullOrEmpty(jogador.PlayerId))
                return null;

            var goleiroStats = await _statsRepository.GetGoleiroStatsSumByPlayerIdAsync(jogador.PlayerId);
            if (goleiroStats == null)
                return null;

            var goleiroDto = _mapper.Map<GoleirosSumDto>(goleiroStats);

            return goleiroDto;
        }
    }
}