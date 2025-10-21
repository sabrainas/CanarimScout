using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Sum;

namespace CanarinScout.Application.Interfaces
{
    public interface IStatsService
    {
        Task<EstatisticasSumDto> GetStatsByIdAsync(string playerId);
        Task<GoleirosSumDto> GetGoleiroStatsByPlayerIdAsync(string playerId);
    }
}
