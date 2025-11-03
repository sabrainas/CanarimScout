namespace CanarinScout.Domain.Entities.Sum
{
    public class GoleirosSum
    {
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; }

        public decimal? ChutesNoGol { get; private set; }
        public decimal? GolSofridos { get; private set; }
        public decimal? Defesas { get; private set; }
        public decimal? PerDefesas { get; private set; }
        public decimal? PartidaSemGol { get; private set; }
        public decimal? GolsEsperados { get; private set; }
        public decimal? PenaltiSofrido { get; private set; }
        public decimal? PenaltiCausados { get; private set; }
        public decimal? PenaltiDefendidos { get; private set; }
        public decimal? PenaltiErrado { get; private set; }
        public decimal? PassesConcluidos { get; private set; }
        public decimal? TentativasPasses { get; private set; }
        public decimal? PerPassesConcluidos { get; private set; }
        public decimal? QtdTirosDeMeta { get; private set; }
        public decimal? LancamentoTotal { get; private set; }
        public decimal? DistMediaLancamentos { get; private set; }
        public decimal? TentativasLancamentos { get; private set; }
        public decimal? PerLancamentosCompletos { get; private set; }
        public decimal? DistMediaTiroDeMeta { get; private set; }
        public decimal? CruzamentosEnfrentados { get; private set; }
        public decimal? CruzamentoBloqueado { get; private set; }
        public decimal? PerCruzamentoBloqueado { get; private set; }
        public decimal? AcoesForaDaPequenaArea { get; private set; }
        public decimal? DistMedia { get; private set; }

        public GoleirosSum() { }

        public GoleirosSum(string playerId, Jogador jogador, decimal? chutesNoGol, decimal? golSofridos,
            decimal? defesas, decimal? perDefesas, decimal? partidaSemGol, decimal? golsEsperados,
            decimal? penaltiSofrido, decimal? penaltiCausados, decimal? penaltiDefendidos, decimal? penaltiErrado,
            decimal? passesConcluidos, decimal? tentativasPasses, decimal? perPassesConcluidos, decimal? qtdTirosDeMeta,
            decimal? lancamentoTotal, decimal? distMediaLancamentos, decimal? tentativasLancamentos,
            decimal? perLancamentosCompletos, decimal? distMediaTiroDeMeta, decimal? cruzamentosEnfrentados, decimal? cruzamentoBloqueado,
            decimal? perCruzamentoBloqueado, decimal? acoesForaDaPequenaArea, decimal? distMedia)
        {
            PlayerId = playerId;
            Jogador = jogador;
            ChutesNoGol = chutesNoGol;
            GolSofridos = golSofridos;
            Defesas = defesas;
            PerDefesas = perDefesas;
            PartidaSemGol = partidaSemGol;
            GolsEsperados = golsEsperados;
            PenaltiSofrido = penaltiSofrido;
            PenaltiCausados = penaltiCausados;
            PenaltiDefendidos = penaltiDefendidos;
            PenaltiErrado = penaltiErrado;
            PassesConcluidos = passesConcluidos;
            TentativasPasses = tentativasPasses;
            PerPassesConcluidos = perPassesConcluidos;
            QtdTirosDeMeta = qtdTirosDeMeta;
            LancamentoTotal = lancamentoTotal;
            DistMediaLancamentos = distMediaLancamentos;
            TentativasLancamentos = tentativasLancamentos;
            PerLancamentosCompletos = perLancamentosCompletos;
            DistMediaTiroDeMeta = distMediaTiroDeMeta;
            CruzamentosEnfrentados = cruzamentosEnfrentados;
            CruzamentoBloqueado = cruzamentoBloqueado;
            PerCruzamentoBloqueado = perCruzamentoBloqueado;
            AcoesForaDaPequenaArea = acoesForaDaPequenaArea;
            DistMedia = distMedia;
        }
    }
}
