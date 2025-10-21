using CanarinScout.Domain.Entities;
namespace CanarinScout.Infrastructure.Interface
{
    public interface IPlayerRepository
    {
        Task<List<Jogador>> GetAllPlayersAsync(int skip, int take);
        Task<Jogador?> GetPlayerByIdAsync(string playerId);
    }
}
