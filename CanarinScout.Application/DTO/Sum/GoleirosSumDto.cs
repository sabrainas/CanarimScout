namespace CanarinScout.Application.DTO.Sum
{
    public class GoleirosSumDto
    {
        public string PlayerId { get; set; } = null!;
        public decimal? ChutesNoGol { get; set; }
        public decimal? GolSofridos { get; set; }
        public decimal? Defesas { get; set; }
        public decimal? PerDefesas { get; set; }
        public decimal? PartidaSemGol { get; set; }
        public decimal? GolsEsperados { get; set; }
        public decimal? PenaltiSofrido { get; set; }
        public decimal? PenaltiCausados { get; set; }
        public decimal? PenaltiDefendidos { get; set; }
        public decimal? PenaltiErrado { get; set; }
        public decimal? PassesConcluidos { get; set; }
        public decimal? TentativasPasses { get; set; }
        public decimal? PerPassesConcluidos { get; set; }
        public decimal? QtdTirosDeMeta { get; set; }
        public decimal? LancamentoTotal { get; set; }
        public decimal? LancamentosCompletos { get; set; }
        public decimal? DistMediaLancamentos { get; set; }
        public decimal? TentativasLancamentos { get; set; }
        public decimal? PerLancamentosCompletos { get; set; }
        public decimal? DistMediaTiroDeMeta { get; set; }
        public decimal? CruzamentosEnfrentados { get; set; }
        public decimal? CruzamentoBloqueado { get; set; }
        public decimal? PerCruzamentoBloqueado { get; set; }
        public decimal? AcoesForaDaPequenaArea { get; set; }
        public decimal? DistMedia { get; set; }
    }
}
