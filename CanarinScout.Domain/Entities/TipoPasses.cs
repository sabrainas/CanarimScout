using CanarinScout.WebApi;

namespace CanarinScout.Domain.Entities
{
    public class TipoPasses
    {
        public int Id { get; set; }
        public string? PassesBloqueados { get; set; }
        public string? LancamentoEscanteio { get; set; }
        public string? Cruzamentos { get; set; }
        public string? PassesBolasParadas { get; set; }
        public string? PassesAPartirDeFaltas { get; set; }
        public string? EscanteiosDentroArea { get; set; }
        public string? PassesEmJogo { get; set; }
        public string? PassesImpedidos { get; set; }
        public string? EscanteioForaArea { get; set; }
        public string? EscanteioReto { get; set; }
        public string? PassesDeReversao { get; set; }
        public string? PassesEntreLinhaDefesa { get; set; }
        public string? LancamentoLateral { get; set; }

        public int PassesId { get; set; }
        public Passes Passes { get; set; } = null!;
    }
}
