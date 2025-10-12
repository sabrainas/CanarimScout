using CanarinScout.Domain.Entities;

namespace CanarinScout.Infrastructure.Interface
{
    public interface IStatsRepository
    {
        Task<Estatisticas?> GetStatsByPlayerIdAsync(int idJogador);
    }
}
