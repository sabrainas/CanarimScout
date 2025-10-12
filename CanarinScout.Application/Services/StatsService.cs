using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using CanarinScout.Infrastructure.Interface;

namespace CanarinScout.Application.Services
{
    public class StatsService : IStatsService
    {
        private readonly IStatsRepository _statsRepository;
        public StatsService(IStatsRepository statsRepository)
        {
            _statsRepository = statsRepository;
        }

        public async Task<EstatisticasDto> GetStatsAsync(int idJogador)
        {
            var estatisticas = await _statsRepository.GetStatsByPlayerIdAsync(idJogador);
            if (estatisticas == null) return null;

            return new EstatisticasDto
            {
                Id = estatisticas.Id,
                Gols = estatisticas.Gols,
                Assistencias = estatisticas.Assistencias,
                CartaoAmarelo = estatisticas.CartaoAmarelo,
                CartaoVermelho = estatisticas.CartaoVermelho,
                MinutosJogados = estatisticas.MinutosJogados,
                Ofensivas = estatisticas.Ofensivas,
                Passes = estatisticas.Passes,
                Posses = estatisticas.Posses
            };
        }
    }
}
