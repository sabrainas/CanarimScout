using AutoMapper;
using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CanarinScout.WebApi.Controllers
{
    [ApiController]
    [Route("api/jogadores")]
    public class JogadoresController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPlayerService _playerService;

        public JogadoresController(IMapper mapper, IPlayerService playerService)
        {
            _mapper = mapper;
            _playerService = playerService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<JogadorDto>), 200)]
        [ProducesResponseType(204)]
        public async Task<ActionResult<List<JogadorDto>>> GetPlayers()
        {
            var list = await _playerService.SearchPlayersAsync();

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
    }
}
