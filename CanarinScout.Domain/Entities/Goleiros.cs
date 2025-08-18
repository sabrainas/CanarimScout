namespace CanarinScout.Domain.Entities
{
    public class Goleiros
    {
        public int Id { get; private set; }
        public int Defesas { get; private set; }
        public int PartidaSemGol { get; private set; }
        public int ChutesNoGol { get; private set; }
        public int GolSofridos { get; private set; }
        public float PerDefesas { get; private set; }
        public int PenaltiDefendidos { get; private set; }
        public int PenaltiSofrido { get; private set; }
        public int PenaltiCausados { get; private set; }
        public int PenaltiMarcado { get; private set; }
        public int Lancamento { get; private set; }
        public Penalti Penalti {  get; private set; }
        public Lancamentos Lancamentos { get; private set; }
        public PassesGoleiro PassesGoleiro { get; private set; }
        public TiroDeMeta TiroDeMeta { get; private set; }
        public Cruzamento Cruzamento { get; private set; }
        public ForaDaArea ForaDaArea { get; private set; }

        public Goleiros() { }

        public Goleiros(int defesas, int partidaSemGol, int chutesNoGol, int golSofridos, float perDefesas, int penaltiDefendidos, int penaltiSofrido, int penaltiCausados, int penaltiMarcado, int lancamento, Penalti penalti, Lancamentos lancamentos, PassesGoleiro passesGoleiro, TiroDeMeta tiroDeMeta, Cruzamento cruzamento, ForaDaArea foraDaArea)
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
