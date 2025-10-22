using CanarinScout.Domain.Entities;
using CanarinScout.Domain.Entities.Sum;

namespace CanarinScout.Infrastructure.Interface
{
    public interface IStatsRepository
    {
        Task<Estatisticas?> GetStatsByIdAsync(int id);
        Task<Goleiros?> GetGoleiroStatsByPlayerIdAsync(string playerId);
       
        Task<EstatisticasSum?> GetStatsSumByPlayerIdAsync(string playerId);
        Task<GoleirosSum?> GetGoleiroStatsSumByPlayerIdAsync(string playerId);
        Task<List<Estatisticas>> GetAllStatsAsync(string playerId);
    }
}
