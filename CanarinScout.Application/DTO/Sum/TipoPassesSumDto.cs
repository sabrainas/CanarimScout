namespace CanarinScout.Application.DTO.Sum
{
    public class TipoPassesSumDto
    {
        public string PlayerId { get; set; } = null!;
        public decimal? TentativasPasses { get; set; }
        public decimal? PassesEmJogo { get; set; }
        public decimal? PassesBolasParadas { get; set; }
        public decimal? PassesAPartirDeFaltas { get; set; }
        public decimal? PassesEntreLinhaDefesa { get; set; }
        public decimal? PassesDeReversao { get; set; }
        public decimal? Cruzamentos { get; set; }
        public decimal? LancamentoLateral { get; set; }
        public decimal? LancamentoEscanteio { get; set; }
        public decimal? EscanteiosDentroArea { get; set; }
        public decimal? EscanteioForaArea { get; set; }
        public decimal? EscanteioReto { get; set; }
        public decimal? PassesConcluidos { get; set; }
        public decimal? PassesImpedidos { get; set; }
        public decimal? PassesBloqueados { get; set; }
    }
}
