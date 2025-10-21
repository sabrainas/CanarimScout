namespace CanarinScout.Domain.Entities.Sum
{
    public class TipoPassesSum
    {
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;
        public decimal? TentativasPasses { get; private set; }
        public decimal? PassesEmJogo { get; private set; }
        public decimal? PassesBolasParadas { get; private set; }
        public decimal? PassesAPartirDeFaltas { get; private set; }
        public decimal? PassesEntreLinhaDefesa { get; private set; }
        public decimal? PassesDeReversao { get; private set; }
        public decimal? Cruzamentos { get; private set; }
        public decimal? LancamentoLateral { get; private set; }
        public decimal? LancamentoEscanteio { get; private set; }
        public decimal? EscanteiosDentroArea { get; private set; }
        public decimal? EscanteioForaArea { get; private set; }
        public decimal? EscanteioReto { get; private set; }
        public decimal? PassesConcluidos { get; private set; }
        public decimal? PassesImpedidos { get; private set; }
        public decimal? PassesBloqueados { get; private set; }

        public PassesSum Passes { get; private set; } = null!;

        public TipoPassesSum() { }

        public TipoPassesSum(string playerId, decimal? tentativasPasses, decimal? passesEmJogo, decimal? passesBolaParadas,
            decimal? passesAPartirDeFaltas, decimal? passesEntreLinhaDefesa, decimal? passesDeReversao, decimal? cruzamentos,
            decimal? lancamentoLateral, decimal? lancamentoEscanteio, decimal? escanteiosDentroArea, decimal? escanteioForaArea,
            decimal? escanteioReto, decimal? passesConcluidos, decimal? passesImpedidos, decimal? passesBloqueados)
        {
            PlayerId = playerId;
            TentativasPasses = tentativasPasses;
            PassesEmJogo = passesEmJogo;
            PassesBolasParadas = passesBolaParadas;
            PassesAPartirDeFaltas = passesAPartirDeFaltas;
            PassesEntreLinhaDefesa = passesEntreLinhaDefesa;
            PassesDeReversao = passesDeReversao;
            Cruzamentos = cruzamentos;
            LancamentoLateral = lancamentoLateral;
            LancamentoEscanteio = lancamentoEscanteio;
            EscanteiosDentroArea = escanteiosDentroArea;
            EscanteioForaArea = escanteioForaArea;
            EscanteioReto = escanteioReto;
            PassesConcluidos = passesConcluidos;
            PassesImpedidos = passesImpedidos;
            PassesBloqueados = passesBloqueados;
        }
    }
}
