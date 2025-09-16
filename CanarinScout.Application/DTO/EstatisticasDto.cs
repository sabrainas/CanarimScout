using CanarinScout.Domain.Entities;
using CanarinScout.WebApi;

namespace CanarinScout.Application.DTO
{
    public class EstatisticasDto
    {
        public int Id { get; private set; }
        //public string? Jogos { get; set; }
        public string? Gols { get; set; }
        public string? Assistencias { get; set; }
        public string? CartaoAmarelo { get; set; }
        public string? CartaoVermelho { get; set; }
        public string? MinutosJogados { get; set; }
        public Ofensivas? Ofensivas { get; set; }
        public Passes? Passes { get; set; }
        public Posses? Posses { get; set; }
        public Defensivas? Defensivas { get; set; }
    }
}
