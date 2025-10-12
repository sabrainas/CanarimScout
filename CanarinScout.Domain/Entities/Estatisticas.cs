using CanarinScout.WebApi;

namespace CanarinScout.Domain.Entities
{
    public class Estatisticas
    {
        public int Id { get; private set; }
        public string PlayerId { get; set; }
        public Jogador Jogador { get; set; }
        public string? Gols { get; set; }
        public string? Assistencias { get; set; }
        public string? CartaoAmarelo { get; set; }
        public string? CartaoVermelho { get; set; }
        public string? MinutosJogados { get; set; }
        public Ofensivas Ofensivas { get; set; }
        public Passes Passes { get; set; }
        public Posses Posses { get; set; }
        public Defensivas Defensivas { get; set; }

        public Estatisticas() { }

    }
}
