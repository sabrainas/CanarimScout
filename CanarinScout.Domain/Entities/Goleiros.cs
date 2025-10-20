namespace CanarinScout.Domain.Entities
{
    public class Goleiros
    {
        public int Id { get; private set; }
        public string? PlayerId { get; set; }
        public Jogador Jogador { get; private set; }
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

        public Goleiros() { }

        public Goleiros(int id, string playerId, Jogador jogador, string? defesas, string? partidaSemGol, string? chutesNoGol, string? golSofridos, string? perDefesas, string? penaltiDefendidos, string? penaltiSofrido, string? penaltiCausados, string? lancamentosCompletos, string? tentativasLancamentos, string? perLancamentosCompletos, string? passes, string? tentativasPasses, string? qtdTirosDeMeta, string? perTiroDeMetas, string? distMediaTiroDeMeta, string? distanciaMedia, string? cruzamentosEnfrentados, string? cruzamentoBloqueado, string? perCruzamentoBloqueado, string? acoesForaDaPequenaArea, string? distMedia, string? golsEsperados, string? penaltiErrado)
        {
            Id = id;
            PlayerId = playerId;
            Jogador = jogador;
            Defesas = defesas;
            PartidaSemGol = partidaSemGol;
            ChutesNoGol = chutesNoGol;
            GolSofridos = golSofridos;
            PerDefesas = perDefesas;
            PenaltiDefendidos = penaltiDefendidos;
            PenaltiSofrido = penaltiSofrido;
            PenaltiCausados = penaltiCausados;
            LancamentosCompletos = lancamentosCompletos;
            TentativasLancamentos = tentativasLancamentos;
            PerLancamentosCompletos = perLancamentosCompletos;
            Passes = passes;
            TentativasPasses = tentativasPasses;
            QtdTirosDeMeta = qtdTirosDeMeta;
            PerTiroDeMetas = perTiroDeMetas;
            DistMediaTiroDeMeta = distMediaTiroDeMeta;
            DistanciaMedia = distanciaMedia;
            CruzamentosEnfrentados = cruzamentosEnfrentados;
            CruzamentoBloqueado = cruzamentoBloqueado;
            PerCruzamentoBloqueado = perCruzamentoBloqueado;
            AcoesForaDaPequenaArea = acoesForaDaPequenaArea;
            DistMedia = distMedia;
            GolsEsperados = golsEsperados;
            PenaltiErrado = penaltiErrado;
        }
    }
}
