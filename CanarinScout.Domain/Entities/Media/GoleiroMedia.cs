namespace CanarinScout.Domain.Entities.Media
{
    public class GoleiroMedia
    {
        public string PlayerId { get; set; } = null!;
        public Jogador Jogador { get; set; }

        public double? MinutosJogados { get; set; }
        public double? ChutesNoGol { get; set; }
        public double? GolSofridos { get; set; }
        public double? Defesas { get; set; }
        public double? PerDefesas { get; set; }
        public double? PartidaSemGol { get; set; }
        public double? GolsEsperados { get; set; }
        public double? PenaltiSofrido { get; set; }
        public double? PenaltiCausados { get; set; }
        public double? PenaltiDefendidos { get; set; }
        public double? PenaltiErrado { get; set; }
        public double? PassesConcluidos { get; set; }
        public double? TentativasPasses { get; set; }
        public double? PerPassesConcluidos { get; set; }
        public double? QtdTirosDeMeta { get; set; }
        public double? LancamentoTotal { get; set; }
        public double? DistMediaLancamentos { get; set; }
        public double? TentativasLancamentos { get; set; }
        public double? PerLancamentosCompletos { get; set; }
        public double? PerTiroDeMetas { get; set; }
        public double? DistMediaTiroDeMeta { get; set; }
        public double? CruzamentosEnfrentados { get; set; }
        public double? CruzamentoBloqueado { get; set; }
        public double? PerCruzamentoBloqueado { get; set; }
        public double? AcoesForaDaPequenaArea { get; set; }
        public double? DistMedia { get; set; }

        public GoleiroMedia() { }

        public GoleiroMedia(string playerId, Jogador jogador, double? chutesNoGol, double? golSofridos,
            double? defesas, double? perDefesas, double? partidaSemGol, double? golsEsperados,
            double? penaltiSofrido, double? penaltiCausados, double? penaltiDefendidos, double? penaltiErrado,
            double? passesConcluidos, double? tentativasPasses, double? perPassesConcluidos, double? qtdTirosDeMeta,
            double? lancamentoTotal, double? distMediaLancamentos, double? tentativasLancamentos,
            double? perLancamentosCompletos, double? distMediaTiroDeMeta, double? cruzamentosEnfrentados, double? cruzamentoBloqueado,
            double? perCruzamentoBloqueado, double? acoesForaDaPequenaArea, double? distMedia, double? perTiroDeMetas)
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
            PerTiroDeMetas = perTiroDeMetas;
        }
    }
}
