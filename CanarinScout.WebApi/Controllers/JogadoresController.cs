using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Analysis;
using CanarinScout.Application.Interfaces;
using CanarinScout.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace CanarinScout.WebApi.Controllers
{
    [ApiController]
    [Route("api/jogadores")]
    public class JogadoresController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly IAnalysisService _analysisService;
        private readonly ILogger<JogadoresController> _logger;

        public JogadoresController(
            IPlayerService playerService,
            IAnalysisService analysisService,
            ILogger<JogadoresController> logger)
        {
            _playerService = playerService;
            _analysisService = analysisService;
            _logger = logger;
        }

        /// <summary>
        /// Obtém jogadores com features de análise, paginação e filtros
        /// </summary>
        /// <param name="posicao">Filtro por posição (GK, DF, MF, FW)</param>
        /// <param name="skip">Quantidade de registros a pular</param>
        /// <param name="take">Quantidade de registros a retornar</param>
        [HttpGet]
        [ProducesResponseType(typeof(PaginatedResult<JogadorDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<PaginatedResult<JogadorDto>>> GetPlayers(
            [FromQuery] string? posicao = null,
            [FromQuery] int skip = 0,
            [FromQuery] int take = 50)
        {
            try
            {
                var result = await _analysisService.GetPlayersWithFeaturesAsync(
                    posicao, skip, take);

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, "Parâmetros inválidos na busca de jogadores");
                return BadRequest(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar jogadores");
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }

        /// <summary>
        /// Obtém detalhes completos de um jogador incluindo features de análise
        /// </summary>
        [HttpGet("{playerId}")]
        [ProducesResponseType(typeof(PlayerFeaturesDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<PlayerFeaturesDto>> GetPlayerById(string playerId)
        {
            try
            {
                var player = await _analysisService.GetPlayerCompleteByIdAsync(playerId);

                if (player == null)
                {
                    _logger.LogWarning("Jogador não encontrado para ID: {Id}", playerId);
                    return NotFound(new { Message = $"Jogador com ID {playerId} não encontrado" });
                }

                return Ok(player);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar jogador por ID: {Id}", playerId);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }

        /// <summary>
        /// Busca jogadores por nome
        /// </summary>
        [HttpGet("search")]
        [ProducesResponseType(typeof(List<PlayerFeaturesDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<List<PlayerFeaturesDto>>> SearchPlayers(
            [FromQuery] string query,
            [FromQuery] int limit = 20)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(query) || query.Length < 3)
                {
                    return BadRequest(new { Message = "Query deve ter no mínimo 3 caracteres" });
                }

                var players = await _analysisService.SearchPlayersByNameAsync(query, limit);

                return Ok(players);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar jogadores por nome: {Query}", query);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }
    }
}