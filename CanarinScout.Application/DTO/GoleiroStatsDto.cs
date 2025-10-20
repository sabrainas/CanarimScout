namespace CanarinScout.Application.DTO
{
    public class GoleiroStatsDto
    {
        public int Id { get; private set; }
        public string? PlayerId { get; private set; }
        public string? Defesas { get; private set; }
        public string? PartidaSemGol { get; private set; }
        public string? ChutesNoGol { get; private set; }
        public string? GolSofridos { get; private set; }
        public string? PerDefesas { get; private set; }
        public string? PenaltiDefendidos { get; private set; }
        public string? PenaltiSofrido { get; private set; }
        public string? PenaltiCausados { get; private set; }
        public string? LancamentosCompletos { get; private set; }
        public string? TentativasLancamentos { get; private set; }
        public string? PerLancamentosCompletos { get; private set; }
        public string? Passes { get; private set; }
        public string? TentativasPasses { get; private set; }
        public string? QtdTirosDeMeta { get; private set; }
        public string? PerTiroDeMetas { get; private set; }
        public string? DistMediaTiroDeMeta { get; private set; }
        public string? DistanciaMedia { get; private set; }
        public string? CruzamentosEnfrentados { get; private set; }
        public string? CruzamentoBloqueado { get; private set; }
        public string? PerCruzamentoBloqueado { get; private set; }
        public string? AcoesForaDaPequenaArea { get; private set; }
        public string? DistMedia { get; private set; }
        public string? GolsEsperados { get; private set; }
        public string? PenaltiErrado { get; private set; }
    }
}
