using CanarinScout.Domain.Entities;
using CanarinScout.Domain.Entities.Sum;
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

        public async Task<Goleiros?> GetGoleiroStatsByPlayerIdAsync(string playerId)
        {
            return await _context.Goleiros
                .AsNoTracking()
                .Include(g => g.Jogador)
                .FirstOrDefaultAsync(g => g.PlayerId == playerId);
        }

        public async Task<EstatisticasSum?> GetStatsSumByPlayerIdAsync(string playerId)
        {
            var estatisticasSum = await _context.EstatisticasSum
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.PlayerId == playerId);

            if (estatisticasSum == null)
                return null;

            var ofensivas = await _context.OfensivasSum
                .AsNoTracking()
                .FirstOrDefaultAsync(o => o.PlayerId == playerId);

            var passes = await _context.PassesSum
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.PlayerId == playerId);

            var tipoPasses = await _context.TipoPassesSum
                .AsNoTracking()
                .FirstOrDefaultAsync(tp => tp.PlayerId == playerId);

            var posses = await _context.PossesSum
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.PlayerId == playerId);

            var defensivas = await _context.DefensivasSum
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.PlayerId == playerId);

            var estatisticasType = typeof(EstatisticasSum);
            
            if (ofensivas != null)
            {
                var ofensivasProperty = estatisticasType.GetProperty("Ofensivas");
                ofensivasProperty?.SetValue(estatisticasSum, ofensivas);
            }

            if (passes != null)
            {
                var passesProperty = estatisticasType.GetProperty("Passes");
                passesProperty?.SetValue(estatisticasSum, passes);

                if (tipoPasses != null)
                {
                    var passesType = typeof(PassesSum);
                    var tipoProperty = passesType.GetProperty("Tipo");
                    tipoProperty?.SetValue(passes, tipoPasses);
                }
            }

            if (posses != null)
            {
                var possesProperty = estatisticasType.GetProperty("Posses");
                possesProperty?.SetValue(estatisticasSum, posses);
            }

            if (defensivas != null)
            {
                var defensivasProperty = estatisticasType.GetProperty("Defensivas");
                defensivasProperty?.SetValue(estatisticasSum, defensivas);
            }

            return estatisticasSum;
        }

        public async Task<GoleirosSum?> GetGoleiroStatsSumByPlayerIdAsync(string playerId)
        {
            return await _context.GoleirosSum
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.PlayerId == playerId);
        }

        public async Task<List<Estatisticas>> GetAllStatsAsync(string playerId)
        {
            return await _context.Estatisticas
                .AsNoTracking()
                .Where(e => e.PlayerId == playerId)
                .Include(e => e.Jogador)
                .Include(e => e.Ofensivas)
                .Include(e => e.Passes)
                .Include(e => e.Passes).ThenInclude(p => p.Tipo)
                .Include(e => e.Posses)
                .Include(e => e.Defensivas)
                .ToListAsync();
        }
    }
}