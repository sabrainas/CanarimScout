using CanarinScout.Application.DTO.Analysis;
using CanarinScout.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CanarinScout.WebApi.Controllers
{
    [ApiController]
    [Route("api/analise")]
    public class AnaliseController : ControllerBase
    {
        private readonly IAnalysisService _analysisService;
        private readonly ILogger<AnaliseController> _logger;

        public AnaliseController(IAnalysisService analysisService, ILogger<AnaliseController> logger)
        {
            _analysisService = analysisService;
            _logger = logger;
        }

        /// <summary>
        /// Obtém análise de um jogador com base na sua posição (detecta automaticamente)
        /// </summary>
        /// <param name="playerId">ID do jogador</param>
        /// <returns>Análise específica da posição do jogador</returns>
        [HttpGet("{playerId}")]
        [ProducesResponseType(typeof(object), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetPlayerAnalysisByPosition(string playerId)
        {
            try
            {
                var analysis = await _analysisService.GetPlayerAnalysisByPosition(playerId);

                if (analysis == null)
                {
                    return NotFound(new { Message = $"Análise não encontrada para o jogador {playerId}" });
                }

                return Ok(analysis);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar análise do jogador {PlayerId}", playerId);
                return StatusCode(500, new { Message = "Erro interno ao processar a solicitação" });
            }
        }
    }
}
