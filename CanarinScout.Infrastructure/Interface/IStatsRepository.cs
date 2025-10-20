using CanarinScout.Domain.Entities;

namespace CanarinScout.Infrastructure.Interface
{
    public interface IStatsRepository
    {
        Task<Estatisticas?> GetStatsByIdAsync(int id);
        Task<Goleiros?> GetGoleiroStatsByPlayerIdAsync(string playerId);
    }
}
