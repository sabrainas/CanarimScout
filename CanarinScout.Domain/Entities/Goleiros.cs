namespace CanarinScout.Domain.Entities
{
    public class Goleiros
    {
        public int Id { get; private set; }
        public string? Defesas { get; private set; }
        public string? PartidaSemGol { get; private set; }
        public string? ChutesNoGol { get; private set; }
        public string? GolSofridos { get; private set; }
        public string? PerDefesas { get; private set; }
        public string? PenaltiDefendidos { get; private set; }
        public string? PenaltiSofrido { get; private set; }
        public string? PenaltiCausados { get; private set; }
        public string? PenaltiMarcado { get; private set; }
        public string? Lancamento { get; private set; }
        public Penalti Penalti {  get; private set; }
        public Lancamentos Lancamentos { get; private set; }
        public PassesGoleiro PassesGoleiro { get; private set; }
        public TiroDeMeta TiroDeMeta { get; private set; }
        public Cruzamento Cruzamento { get; private set; }
        public ForaDaArea ForaDaArea { get; private set; }

        public Goleiros() { }

        public Goleiros(string defesas, string partidaSemGol, string chutesNoGol, string golSofridos, string perDefesas, string penaltiDefendidos, string penaltiSofrido, string penaltiCausados, string penaltiMarcado, string lancamento, Penalti penalti, Lancamentos lancamentos, PassesGoleiro passesGoleiro, TiroDeMeta tiroDeMeta, Cruzamento cruzamento, ForaDaArea foraDaArea)
        {
            Defesas = defesas;
            PartidaSemGol = partidaSemGol;
            ChutesNoGol = chutesNoGol;
            GolSofridos = golSofridos;
            PerDefesas = perDefesas;
            PenaltiDefendidos = penaltiDefendidos;
            PenaltiSofrido = penaltiSofrido;
            PenaltiCausados = penaltiCausados;
            PenaltiMarcado = penaltiMarcado;
            Lancamento = lancamento;
            Penalti = penalti;
            Lancamentos = lancamentos;
            PassesGoleiro = passesGoleiro;
            TiroDeMeta = tiroDeMeta;
            Cruzamento = cruzamento;
            ForaDaArea = foraDaArea;
        }
    }
}
