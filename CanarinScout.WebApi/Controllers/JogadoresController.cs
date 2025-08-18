using AutoMapper;
using AutoMapper.QueryableExtensions;
using CanarinScout.Application.DTO;
using CanarinScout.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.WebApi.Controllers
{
    [ApiController]
    [Route("api/jogadores")]
    public class JogadoresController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public JogadoresController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<JogadorDto>), 200)]
        [ProducesResponseType(204)]
        public async Task<ActionResult<List<JogadorDto>>> ListarJogadores(CancellationToken cancellationToken)
        {
            var lista = await _context.Jogadores
                .AsNoTracking()
                .ProjectTo<JogadorDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            if (lista.Count == 0) return NoContent();
            return Ok(lista);
        }

        [HttpGet("defensivas")]
        [ProducesResponseType(typeof(List<DefensivasDto>), 200)]
        [ProducesResponseType(204)]
        public async Task<ActionResult<List<DefensivasDto>>> GetDefensivas(CancellationToken cancellationToken)
        {
            var lista = await _context.Defensivas
                .AsNoTracking()
                .ProjectTo<DefensivasDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            if (lista.Count == 0)
                return NoContent();

            return Ok(lista);
        }
    }
}
