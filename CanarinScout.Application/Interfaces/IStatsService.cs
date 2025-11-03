using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Sum;
using CanarinScout.Domain.Common;

namespace CanarinScout.Application.Interfaces
{
    public interface IStatsService
    {
        Task<EstatisticasSumDto?> GetStatsByIdAsync(string playerId);

        Task<GoleirosSumDto?> GetGoleiroStatsByPlayerIdAsync(string playerId);

        Task<PaginatedResult<EstatisticasDto>> GetStatsRoundByPlayerIdAsync(
            string playerId,
            int skip,
            int take);

        Task<List<EstatisticasSumDto>> ComparePlayersStatsAsync(List<string> playerIds);
    }
}