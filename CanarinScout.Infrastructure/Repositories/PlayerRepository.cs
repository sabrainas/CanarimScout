using CanarinScout.Domain.Entities;
using CanarinScout.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly AppDbContext _context;
        public PlayerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Jogador>> GetAllPlayersAsync(int skip, int take)
        {
            return await _context.Jogador
                .AsNoTracking()
                .OrderBy(d => d.Id)
                .Skip(skip)
                .Take(take)
                .ToListAsync();
        }

        public async Task<Jogador?> GetPlayerByIdAsync(string playerId)
        {
            return await _context.Jogador
                .AsNoTracking()
                .FirstOrDefaultAsync(j => j.PlayerId.Equals(playerId));
        }
    }
}
