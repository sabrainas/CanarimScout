using CanarinScout.Application.DTO;
using CanarinScout.Application.Interfaces;
using CanarinScout.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CanarinScout.WebApi.Controllers
{
    [ApiController]
    [Route("api/estatisticas")]
    public class EstatisticasController : ControllerBase
    {
        private readonly IStatsService _statsService;
        private readonly AppDbContext _context;

        public EstatisticasController(IStatsService statsService, AppDbContext context)
        {
            _statsService = statsService;
            _context = context;
        }

        [HttpGet("{idJogador}")]
        [ProducesResponseType(typeof(EstatisticasDto), 200)]
        [ProducesResponseType(204)]
        public async Task<ActionResult<EstatisticasDto>> GetEstatisticas(int idJogador)
        {
            var estatisticas = await _statsService.GetStatsAsync(idJogador);

            if (estatisticas == null) return NoContent();

            return Ok(estatisticas);
        }
    }
}
