using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using CanarinScout.Domain.Enums;
using CanarinScout.Domain.Extensions;
using CanarinScout.Infrastructure.Interface;
using CanarinScout.Infrastructure.Repositories;

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

        public async Task<EstatisticasDto> GetStatsByIdAsync(int id)
        {
            var estatisticas = await _statsRepository.GetStatsByIdAsync(id);
            return _mapper.Map<EstatisticasDto>(estatisticas);
        }

        public async Task<GoleiroStatsDto?> GetGoleiroStatsByPlayerIdAsync(int id)
        {
            var jogador = await _playerRepository.GetPlayerByIdAsync(id);
            if (jogador == null || string.IsNullOrEmpty(jogador.PlayerId))
                return null;

            var goleiroStats = await _statsRepository.GetGoleiroStatsByPlayerIdAsync(jogador.PlayerId);
            if (goleiroStats == null)
                return null;

            var goleiroDto = _mapper.Map<GoleiroStatsDto>(goleiroStats);

            return goleiroDto;
        }
    }
}