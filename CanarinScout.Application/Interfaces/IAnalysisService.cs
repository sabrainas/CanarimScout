using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Analysis;
using CanarinScout.Domain.Common;

namespace CanarinScout.Application.Interfaces
{
    public interface IAnalysisService
    {
        Task<PaginatedResult<JogadorDto>> GetPlayersWithFeaturesAsync(
            string? posicao,
            int skip,
            int take);

        Task<PlayerFeaturesDto?> GetPlayerCompleteByIdAsync(string playerId);

        Task<List<PlayerFeaturesDto>> SearchPlayersByNameAsync(string query, int limit);

        Task<object?> GetPlayerAnalysisByPosition(string playerId);
    }
}