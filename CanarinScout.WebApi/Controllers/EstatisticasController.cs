using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
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
        /// Obtém estatísticas por ID
        /// </summary>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(EstatisticasDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<EstatisticasDto>> GetEstatisticasById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { Message = "ID deve ser maior que zero" });
                }

                var estatisticas = await _statsService.GetStatsByIdAsync(id);

                if (estatisticas == null)
                {
                    _logger.LogWarning("Estatísticas não encontradas para ID: {Id}", id);
                    return NotFound(new { Message = $"Estatísticas com ID {id} não encontradas" });
                }

                return Ok(estatisticas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar estatísticas por ID: {Id}", id);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }

        /// <summary>
        /// Obtem as estatisticas de goleiros
        /// </summary>
        [HttpGet("goleiro/{id}")]
        [ProducesResponseType(typeof(GoleiroStatsDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<GoleiroStatsDto>> GetGoleiroStatsByPlayerId(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { Message = "ID deve ser maior que zero" });
                }
                var stats = await _statsService.GetGoleiroStatsByPlayerIdAsync(id);
                if (stats == null)
                {
                    _logger.LogWarning("Estatísticas de goleiro não encontradas para ID: {Id}", id);
                    return NotFound(new { Message = $"Estatísticas de goleiro para ID {id} não encontradas" });
                }
                return Ok(stats);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar estatísticas de goleiro por ID: {Id}", id);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }
    }
}
