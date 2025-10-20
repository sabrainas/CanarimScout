using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CanarinScout.WebApi.Controllers
{
    [ApiController]
    [Route("api/jogadores")]
    public class JogadoresController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly ILogger<JogadoresController> _logger;

        public JogadoresController(IPlayerService playerService, ILogger<JogadoresController> logger)
        {
            _playerService = playerService;
            _logger = logger;
        }

        /// <summary>
        /// Obtém jogadores de forma paginada
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(List<JogadorDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<List<JogadorDto>>> GetPlayers(int skip = 0, int take = 50)
        {
            try
            {
                var list = await _playerService.SearchPlayersAsync(skip, take);

                if (list.Count == 0)
                {
                    _logger.LogInformation("Nenhum jogador encontrado com skip={Skip} e take={Take}", skip, take);
                    return NotFound(new { Message = "Nenhum jogador encontrado" });
                }

                return Ok(list);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar jogadores com skip={Skip} e take={Take}", skip, take);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }

        /// <summary>
        /// Obtém jogador por ID
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(JogadorDetailDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<JogadorDetailDto>> GetPlayerById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { Message = "ID deve ser maior que zero" });
                }

                var player = await _playerService.GetPlayerByIdAsync(id);

                if (player == null)
                {
                    _logger.LogWarning("Jogador não encontrado para ID: {Id}", id);
                    return NotFound(new { Message = $"Jogador com ID {id} não encontrado" });
                }

                return Ok(player);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar jogador por ID: {Id}", id);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }
    }
}
