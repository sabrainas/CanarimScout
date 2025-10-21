namespace CanarinScout.Domain.Entities.Sum
{
    public class PassesSum
    {
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;

        public decimal? PassesConcluidos { get; private set; }
        public decimal? TentativasPasses { get; private set; }
        public decimal? PerPassesConcluidos { get; private set; }
        public decimal? DistanciaTotal { get; private set; }
        public decimal? DistPassesProgressivo { get; private set; }
        public decimal? PassesCurtosConcluidos { get; private set; }
        public decimal? PassesCurtosTentados { get; private set; }
        public decimal? PerPassesCurtosConcluidos { get; private set; }
        public decimal? PassesMediosConcluidos { get; private set; }
        public decimal? PassesMediosTentados { get; private set; }
        public decimal? PerPassesMediosTentados { get; private set; }
        public decimal? PassesLongosConcluidos { get; private set; }
        public decimal? PassesLongosTentados { get; private set; }
        public decimal? PerPassesLongosTentados { get; private set; }
        public decimal? Assistencia { get; private set; }
        public decimal? XAG { get; private set; }
        public decimal? XA { get; private set; }
        public decimal? PassesImportantes { get; private set; }
        public decimal? PassesAreaAdv { get; private set; }
        public decimal? PassesPeqAreaAdv { get; private set; }
        public decimal? CruzamentoPeqArea { get; private set; }
        public decimal? QtdPassesProgressivos { get; private set; }

        public TipoPassesSum? Tipo { get; private set; }

        public PassesSum() { }

        public PassesSum(string playerId, Jogador jogador, decimal? passesConcluidos, decimal? tentativasPasses,
            decimal? perPassesConcluidos, decimal? distanciaTotal, decimal? distPassesProgressivo, decimal? passesCurtosConcluidos,
            decimal? passesCurtosTentados, decimal? perPassesCurtosConcluidos, decimal? passesMediosConcluidos, decimal? passesMediosTentados,
            decimal? perPassesMediosTentados, decimal? passesLongosConcluidos, decimal? passesLongosTentados, decimal? perPassesLongosTentados,
            decimal? assistencia, decimal? xAG, decimal? xA, decimal? passesImportantes,
            decimal? passesAreaAdv, decimal? passesPeqAreaAdv, decimal? cruzamentoPeqArea, decimal? qtdPassesProgressivos)
        {
            PlayerId = playerId;
            Jogador = jogador;
            PassesConcluidos = passesConcluidos;
            TentativasPasses = tentativasPasses;
            PerPassesConcluidos = perPassesConcluidos;
            DistanciaTotal = distanciaTotal;
            DistPassesProgressivo = distPassesProgressivo;
            PassesCurtosConcluidos = passesCurtosConcluidos;
            PassesCurtosTentados = passesCurtosTentados;
            PerPassesCurtosConcluidos = perPassesCurtosConcluidos;
            PassesMediosConcluidos = passesMediosConcluidos;
            PassesMediosTentados = passesMediosTentados;
            PerPassesMediosTentados = perPassesMediosTentados;
            PassesLongosConcluidos = passesLongosConcluidos;
            PassesLongosTentados = passesLongosTentados;
            PerPassesLongosTentados = perPassesLongosTentados;
            Assistencia = assistencia;
            XAG = xAG;
            XA = xA;
            PassesImportantes = passesImportantes;
            PassesAreaAdv = passesAreaAdv;
            PassesPeqAreaAdv = passesPeqAreaAdv;
            CruzamentoPeqArea = cruzamentoPeqArea;
            QtdPassesProgressivos = qtdPassesProgressivos;
        }
    }
}
