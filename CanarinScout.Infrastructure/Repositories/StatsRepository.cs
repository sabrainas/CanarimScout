using CanarinScout.Domain.Entities;
using CanarinScout.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.Infrastructure.Repositories
{
    public class StatsRepository : IStatsRepository
    {
        private readonly AppDbContext _context;
        public StatsRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Estatisticas?> GetStatsByIdAsync(int id)
        {
            return await _context.Estatisticas
                .AsNoTracking()
                .Include(e => e.Jogador)
                .Include(e => e.Ofensivas)
                .Include(e => e.Passes)
                .Include(e => e.Passes).ThenInclude(p => p.Tipo)
                .Include(e => e.Posses)
                .Include(e => e.Defensivas)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Estatisticas?> GetStatsByPlayerIdAsync(string playerId)
        {
            return await _context.Estatisticas
                .AsNoTracking()
                .Include(e => e.Jogador)
                .Include(e => e.Ofensivas)
                .Include(e => e.Passes)
                .Include(e => e.Passes).ThenInclude(p => p.Tipo)
                .Include(e => e.Posses)
                .Include(e => e.Defensivas)
                .FirstOrDefaultAsync(e => e.PlayerId == playerId);
        }
    }
}