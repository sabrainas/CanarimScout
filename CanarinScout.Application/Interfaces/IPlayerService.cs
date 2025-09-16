using CanarinScout.Application.DTO;

namespace CanarinScout.Application.Interfaces
{
    public interface IPlayerService
    {
        Task<List<JogadorDto>> SearchPlayersAsync();
        Task<JogadorDetailDto> GetPlayerByIdAsync(int id);
    }
}
