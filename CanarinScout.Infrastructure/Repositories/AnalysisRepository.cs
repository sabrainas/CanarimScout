using CanarinScout.Domain.Common;
using CanarinScout.Domain.Entities.Analysis;
using CanarinScout.Domain.Entities.Media;
using CanarinScout.Domain.Extensions;
using CanarinScout.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.Infrastructure.Repositories
{
    public class AnalysisRepository : IAnalysisRepository
    {
        private readonly AppDbContext _context;

        public AnalysisRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PlayerFeatures?> GetPlayerFeaturesByPlayerIdAsync(string playerId)
        {
            return await _context.PlayerFeatures
                .AsNoTracking()
                .Include(pf => pf.Jogador)
                .FirstOrDefaultAsync(pf => pf.PlayerId == playerId);
        }

        public async Task<PaginatedResult<PlayerFeatures>> GetPlayersWithFeaturesAsync(
            string? posicao,
            int skip,
            int take)
        {
            var query = _context.PlayerFeatures
                .Include(p => p.Jogador)
                .AsNoTracking()
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(posicao))
            {
                var siglaPosicao = PosicaoExtensions.ToSigla(posicao);

                if (!string.IsNullOrEmpty(siglaPosicao))
                {
                    query = query.Where(p => p.Posicao == siglaPosicao);
                }
            }

            var totalCount = await query.CountAsync();

            var items = await query
                .Skip(skip)
                .Take(take)
                .ToListAsync();

            return new PaginatedResult<PlayerFeatures>
            {
                Items = items,
                TotalCount = totalCount,
                Page = (skip / take) + 1,
                PageSize = take
            };
        }

        public async Task<List<PlayerFeatures>> SearchPlayersByNameAsync(string query, int limit)
        {
            return await _context.PlayerFeatures
                .Include(p => p.Jogador)
                .AsNoTracking()
                .Where(p => EF.Functions.Like(p.Nome!, $"%{query}%"))
                .OrderBy(p => p.Nome)
                .Take(limit)
                .ToListAsync();
        }

        public async Task<GoleiroMedia?> GetGoleiroMediaByPlayerIdAsync(string playerId)
        {
            return await _context.GoleiroMedia
                .AsNoTracking()
                .Include(g => g.Jogador)
                .FirstOrDefaultAsync(g => g.PlayerId == playerId);
        }

        public async Task<AttackerAnalysis?> GetAttackerAnalysisAsync(string playerId)
        {
            return await _context.AttackerAnalysis
                .Include(a => a.Jogador)
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.PlayerId == playerId);
        }

        public async Task<MidfielderAnalysis?> GetMidfielderAnalysisAsync(string playerId)
        {
            return await _context.MidfielderAnalysis
                .Include(m => m.Jogador)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.PlayerId == playerId);
        }

        public async Task<DefenseAnalysis?> GetDefenseAnalysisAsync(string playerId)
        {
            return await _context.DefenseAnalysis
                .Include(d => d.Jogador)
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.PlayerId == playerId);
        }

        public async Task<GoalkeeperAnalysis?> GetGoalkeeperAnalysisAsync(string playerId)
        {
            return await _context.GoalkeeperAnalysis
                .Include(g => g.Jogador)
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.PlayerId == playerId);
        }
    }
}