using CanarinScout.Domain.Entities;
namespace CanarinScout.Infrastructure.Interface
{
    public interface IPlayerRepository
    {
        Task<List<Jogador>> GetAllPlayersAsync();
        Task<Jogador?> GetPlayerByIdAsync(int id);
    }
}
