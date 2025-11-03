using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Sum;
using CanarinScout.Application.Interfaces;
using CanarinScout.Domain.Common;
using CanarinScout.Infrastructure.Interface;

namespace CanarinScout.Application.Services
{
    public class StatsService : IStatsService
    {
        private readonly IStatsRepository _statsRepository;
        private readonly IMapper _mapper;
        private readonly IPlayerRepository _playerRepository;

        public StatsService(
            IStatsRepository statsRepository,
            IMapper mapper,
            IPlayerRepository playerRepository)
        {
            _statsRepository = statsRepository;
            _mapper = mapper;
            _playerRepository = playerRepository;
        }

        public async Task<EstatisticasSumDto?> GetStatsByIdAsync(string playerId)
        {
            var estatisticas = await _statsRepository.GetStatsSumByPlayerIdAsync(playerId);

            if (estatisticas == null)
                return null;

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

            return _mapper.Map<GoleirosSumDto>(goleiroStats);
        }

        public async Task<PaginatedResult<EstatisticasDto>> GetStatsRoundByPlayerIdAsync(
            string playerId,
            int skip,
            int take)
        {
            if (skip < 0)
                throw new ArgumentException("Skip não pode ser negativo");

            var estatisticas = await _statsRepository.GetAllStatsAsync(playerId);

            if (estatisticas == null || !estatisticas.Any())
            {
                return new PaginatedResult<EstatisticasDto>
                {
                    Items = new List<EstatisticasDto>(),
                    TotalCount = 0,
                    Page = 1,
                    PageSize = take
                };
            }

            var totalCount = estatisticas.Count;
            var items = estatisticas
                .Skip(skip)
                .Take(take)
                .ToList();

            var dtos = _mapper.Map<List<EstatisticasDto>>(items);

            return new PaginatedResult<EstatisticasDto>
            {
                Items = dtos,
                TotalCount = totalCount,
                Page = (skip / take) + 1,
                PageSize = take
            };
        }

        public async Task<List<EstatisticasSumDto>> ComparePlayersStatsAsync(List<string> playerIds)
        {
            if (playerIds == null || playerIds.Count < 2 || playerIds.Count > 5)
                throw new ArgumentException("Forneça entre 2 e 5 IDs de jogadores");

            var comparisons = new List<EstatisticasSumDto>();

            foreach (var playerId in playerIds)
            {
                var stats = await GetStatsByIdAsync(playerId);

                if (stats != null)
                {
                    comparisons.Add(stats);
                }
            }

            return comparisons;
        }
    }
}