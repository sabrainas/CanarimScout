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

        public async Task<Estatisticas?> GetStatsByPlayerIdAsync(int idJogador)
        {
            return await _context.Estatisticas
                .FirstOrDefaultAsync(e => e.Id == idJogador);
        }
    }
}
