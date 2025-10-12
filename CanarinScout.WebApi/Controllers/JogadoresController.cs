using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using CanarinScout.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.WebApi.Controllers
{
    [ApiController]
    [Route("api/jogadores")]
    public class JogadoresController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly AppDbContext _context;

        public JogadoresController(IPlayerService playerService, AppDbContext context)
        {
            _playerService = playerService;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<JogadorDto>), 200)]
        [ProducesResponseType(204)]
        public async Task<ActionResult<List<JogadorDto>>> GetPlayers(int skip = 0, int take = 50)
        {
            var list = await _playerService.SearchPlayersAsync(skip, take);

            if (list.Count == 0) return NoContent();
            return Ok(list);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(JogadorDetailDto), 200)]
        [ProducesResponseType(204)]
        public async Task<ActionResult<JogadorDetailDto>> GetPlayerById(int id)
        {
            var player = await _playerService.GetPlayerByIdAsync(id);

            if (player == null) return NoContent();
            return Ok(player);
        }

        [HttpGet("total")]
        public async Task<ActionResult<int>> GetTotalPlayers()
        {
            var total = await _context.Jogador.CountAsync();
            return Ok(total);
        }
    }
}
