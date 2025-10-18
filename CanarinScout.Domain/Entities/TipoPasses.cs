namespace CanarinScout.Domain.Entities
{
    public class TipoPasses
    {
        public int Id { get; private set; }
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;
        public string? PassesBloqueados { get; private set; }
        public string? LancamentoEscanteio { get; private set; }
        public string? Cruzamentos { get; private set; }
        public string? PassesBolasParadas { get; private set; }
        public string? PassesAPartirDeFaltas { get; private set; }
        public string? EscanteiosDentroArea { get; private set; }
        public string? PassesEmJogo { get; private set; }
        public string? PassesImpedidos { get; private set; }
        public string? EscanteioForaArea { get; private set; }
        public string? EscanteioReto { get; private set; }
        public string? PassesDeReversao { get; private set; }
        public string? PassesEntreLinhaDefesa { get; private set; }
        public string? LancamentoLateral { get; private set; }

        public Passes Passes { get; set; } = null!;
    }
}
