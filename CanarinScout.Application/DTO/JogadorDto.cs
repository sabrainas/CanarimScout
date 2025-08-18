using CanarinScout.Domain.Enums;

namespace CanarinScout.Application.DTO
{
    public class JogadorDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Posicao Posicao { get; set; }
        public string? TimeAtual {  get; set; }
        public string? Selecao { get; set; }
    }
}
