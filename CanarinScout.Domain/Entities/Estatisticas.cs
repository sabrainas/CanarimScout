namespace CanarinScout.Domain.Entities
{
    public class Estatisticas
    {
        public int Id { get; private set; }
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;

        public string? Gols { get; private set; }
        public string? Assistencias { get; private set; }
        public string? MinutosJogados { get; private set; }
        public string? CartaoAmarelo { get; private set; }
        public string? CartaoVermelho { get; private set; }

        public Ofensivas? Ofensivas { get; private set; }
        public Passes? Passes { get; private set; }
        public Posses? Posses { get; private set; }
        public Defensivas? Defensivas { get; private set; }

        public Estatisticas() { }

    }
}
