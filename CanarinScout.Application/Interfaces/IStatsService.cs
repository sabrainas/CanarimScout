using CanarinScout.Application.DTO;

namespace CanarinScout.Application.Interfaces
{
    public interface IStatsService
    {
        Task<EstatisticasDto> GetStatsAsync(int idJogador);
    }
}
