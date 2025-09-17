using CanarinScout.Application.DTO;

namespace CanarinScout.Application.Interfaces
{
    public interface IPlayerService
    {
        Task<List<JogadorDto>> SearchPlayersAsync(int skip, int take);
        Task<JogadorDetailDto> GetPlayerByIdAsync(int id);
    }
}
