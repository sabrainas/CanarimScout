using CanarinScout.Application.DTO;
using CanarinScout.Application.DTO.Sum;
using CanarinScout.Application.Interfaces;
using CanarinScout.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace CanarinScout.WebApi.Controllers
{
    [ApiController]
    [Route("api/estatisticas")]
    public class EstatisticasController : ControllerBase
    {
        private readonly IStatsService _statsService;
        private readonly ILogger<EstatisticasController> _logger;

        public EstatisticasController(IStatsService statsService, ILogger<EstatisticasController> logger)
        {
            _statsService = statsService;
            _logger = logger;
        }

        /// <summary>
        /// Obtém estatísticas agregadas (soma total) de um jogador
        /// </summary>
        [HttpGet("{playerId}")]
        [ProducesResponseType(typeof(EstatisticasSumDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<EstatisticasSumDto>> GetAggregatedStats(string playerId)
        {
            try
            {
                var estatisticas = await _statsService.GetStatsByIdAsync(playerId);

                if (estatisticas == null)
                {
                    _logger.LogWarning("Estatísticas não encontradas para ID: {Id}", playerId);
                    return NotFound(new { Message = $"Estatísticas para jogador {playerId} não encontradas" });
                }

                return Ok(estatisticas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar estatísticas agregadas: {Id}", playerId);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }

        /// <summary>
        /// Obtém estatísticas específicas de goleiro
        /// </summary>
        [HttpGet("goleiro/{playerId}")]
        [ProducesResponseType(typeof(GoleirosSumDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<GoleirosSumDto>> GetGoalkeeperStats(string playerId)
        {
            try
            {
                var stats = await _statsService.GetGoleiroStatsByPlayerIdAsync(playerId);

                if (stats == null)
                {
                    _logger.LogWarning("Estatísticas de goleiro não encontradas para ID: {Id}", playerId);
                    return NotFound(new { Message = $"Estatísticas de goleiro para {playerId} não encontradas" });
                }

                return Ok(stats);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar estatísticas de goleiro: {Id}", playerId);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }

        /// <summary>
        /// Obtém histórico de estatísticas por partida
        /// </summary>
        [HttpGet("partida/{playerId}")]
        [ProducesResponseType(typeof(PaginatedResult<EstatisticasDto>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<PaginatedResult<EstatisticasDto>>> GetMatchStats(
            string playerId,
            [FromQuery] int skip = 0,
            [FromQuery] int take = 10)
        {
            try
            {
                var estatisticas = await _statsService.GetStatsRoundByPlayerIdAsync(
                    playerId, skip, take);

                if (estatisticas == null || estatisticas.Items.Count == 0)
                {
                    _logger.LogWarning("Estatísticas de partidas não encontradas: {PlayerId}", playerId);
                    return NotFound(new { Message = $"Nenhuma estatística de partida encontrada para {playerId}" });
                }

                return Ok(estatisticas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar estatísticas de partidas: {PlayerId}", playerId);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }

        /// <summary>
        /// Obtém comparação de estatísticas entre múltiplos jogadores
        /// </summary>
        [HttpPost("comparar")]
        [ProducesResponseType(typeof(List<EstatisticasSumDto>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<List<EstatisticasSumDto>>> ComparePlayersStats(
            [FromBody] List<string> playerIds)
        {
            try
            {
                var comparisons = await _statsService.ComparePlayersStatsAsync(playerIds);

                return Ok(comparisons);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao comparar estatísticas de jogadores");
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }
    }
}