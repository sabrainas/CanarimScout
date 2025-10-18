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
        private readonly ILogger<JogadoresController> _logger;

        public JogadoresController(IPlayerService playerService, AppDbContext context, ILogger<JogadoresController> logger)
        {
            _playerService = playerService;
            _context = context;
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
                if (skip < 0 || take <= 0 || take > 100)
                {
                    return BadRequest(new { Message = "Parâmetros de paginação inválidos. Skip deve ser >= 0 e Take entre 1 e 100" });
                }

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

        /// <summary>
        /// Obtém o total de jogadores cadastrados
        /// </summary>
        [HttpGet("total")]
        [ProducesResponseType(typeof(int), 200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<int>> GetTotalPlayers()
        {
            try
            {
                var total = await _context.Jogador.CountAsync();
                return Ok(total);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao contar total de jogadores");
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }
    }
}
