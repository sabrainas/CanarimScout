using CanarinScout.Domain.Entities;
using CanarinScout.Domain.Entities.Sum;

namespace CanarinScout.Infrastructure.Interface
{
    public interface IStatsRepository
    {
        Task<Estatisticas?> GetStatsByIdAsync(int id);
        Task<Goleiros?> GetGoleiroStatsByPlayerIdAsync(string playerId);
        
        // Métodos para estatísticas somadas (totais)
        Task<EstatisticasSum?> GetStatsSumByPlayerIdAsync(string playerId);
        Task<GoleirosSum?> GetGoleiroStatsSumByPlayerIdAsync(string playerId);
    }
}
