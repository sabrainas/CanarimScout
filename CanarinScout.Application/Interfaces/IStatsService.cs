using CanarinScout.Application.DTO;

namespace CanarinScout.Application.Interfaces
{
    public interface IStatsService
    {
        Task<EstatisticasDto> GetStatsByIdAsync(int id);
        Task<GoleiroStatsDto> GetGoleiroStatsByPlayerIdAsync(int playerId);
    }
}
