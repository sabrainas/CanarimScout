using CanarinScout.Domain.Common;
using CanarinScout.Domain.Entities.Analysis;
using CanarinScout.Domain.Entities.Media;

namespace CanarinScout.Infrastructure.Interface
{
    public interface IAnalysisRepository
    {
        Task<PlayerFeatures?> GetPlayerFeaturesByPlayerIdAsync(string playerId);

        Task<PaginatedResult<PlayerFeatures>> GetPlayersWithFeaturesAsync(
            string? posicao,
            int skip,
            int take);

        Task<List<PlayerFeatures>> SearchPlayersByNameAsync(string query, int limit);

        Task<AttackerAnalysis?> GetAttackerAnalysisAsync(string playerId);
        Task<MidfielderAnalysis?> GetMidfielderAnalysisAsync(string playerId);
        Task<DefenseAnalysis?> GetDefenseAnalysisAsync(string playerId);
        Task<GoalkeeperAnalysis?> GetGoalkeeperAnalysisAsync(string playerId);
        Task<GoleiroMedia?> GetGoleiroMediaByPlayerIdAsync(string playerId);
    }
}