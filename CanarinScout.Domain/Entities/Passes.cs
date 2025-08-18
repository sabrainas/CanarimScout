namespace CanarinScout.Domain.Entities
{
    public class Passes
    {
        public int Id { get; private set; }
        public int PassesConcluidos { get; private set; }
        public int TentativasPasses { get; private set; }
        public float PerPassesConcluidos { get; private set; }
        public int DistanciaTotal { get; private set; }
        public int DistPassesProgressivo { get; private set; }
        public int QtdPassesProgressivos { get; private set; }
        public int PassesCurtosTentados { get; private set; }
        public int PassesCurtosConcluidos { get; private set; }
        public float PerPassesCurtosConcluidos { get; private set; }
        public int PassesMediosConcluidos { get; private set; }
        public int PassesMediosTentados { get; private set; }
        public float PerPassesMediosTentados { get; private set; }
        public int PassesLongosConcluidos { get; private set; }
        public int PassesLongosTentados { get; private set; }
        public float PerPassesLongosTentados { get; private set; }
        public float XAG { get; private set; }
        public float XA { get; private set; }
        public int PassesImportantes { get; private set; }
        public int PassesAreaAdv { get; private set; }
        public int PassesPeqAreaAdv { get; private set; }
        public int CruzamentoPeqArea { get; private set; }
        public int PassesEmJogo { get; private set; }
        public int PassesBolasParadas { get; private set; }
        public int PassesAPartirDeFaltas { get; private set; }
        public int PassesEntreLinhaDefesa { get; private set; }
        public int PassesDeReversao { get; private set; }
        public int Cruzamentos { get; private set; }
        public int LancamentosLaterais { get; private set; }
        public int EscanteiosDentroArea { get; private set; }
        public int EscanteioForaArea { get; private set; }
        public int EscanteioReto { get; private set; }
        public int PassesImpedidos { get; private set; }
        public int PassesBloqueados { get; private set; }

        private Passes() { }

        public Passes(int passesConcluidos, int tentativasPasses, float perPassesConcluidos, int distanciaTotal, int distPassesProgressivo, int qtdPassesProgressivos, int passesCurtosTentados, int passesCurtosConcluidos, float perPassesCurtosConcluidos, int passesMediosConcluidos, int passesMediosTentados, float perPassesMediosTentados, int passesLongosConcluidos, int passesLongosTentados, float perPassesLongosTentados, float xAG, float xA, int passesImportantes, int passesAreaAdv, int passesPeqAreaAdv, int cruzamentoPeqArea, int passesEmJogo, int passesBolasParadas, int passesAPartirDeFaltas, int passesEntreLinhaDefesa, int passesDeReversao, int cruzamentos, int lancamentosLaterais, int escanteiosDentroArea, int escanteioForaArea, int escanteioReto, int passesImpedidos, int passesBloqueados)
        {
            PassesConcluidos = passesConcluidos;
            TentativasPasses = tentativasPasses;
            PerPassesConcluidos = perPassesConcluidos;
            DistanciaTotal = distanciaTotal;
            DistPassesProgressivo = distPassesProgressivo;
            QtdPassesProgressivos = qtdPassesProgressivos;
            PassesCurtosTentados = passesCurtosTentados;
            PassesCurtosConcluidos = passesCurtosConcluidos;
            PerPassesCurtosConcluidos = perPassesCurtosConcluidos;
            PassesMediosConcluidos = passesMediosConcluidos;
            PassesMediosTentados = passesMediosTentados;
            PerPassesMediosTentados = perPassesMediosTentados;
            PassesLongosConcluidos = passesLongosConcluidos;
            PassesLongosTentados = passesLongosTentados;
            PerPassesLongosTentados = perPassesLongosTentados;
            XAG = xAG;
            XA = xA;
            PassesImportantes = passesImportantes;
            PassesAreaAdv = passesAreaAdv;
            PassesPeqAreaAdv = passesPeqAreaAdv;
            CruzamentoPeqArea = cruzamentoPeqArea;
            PassesEmJogo = passesEmJogo;
            PassesBolasParadas = passesBolasParadas;
            PassesAPartirDeFaltas = passesAPartirDeFaltas;
            PassesEntreLinhaDefesa = passesEntreLinhaDefesa;
            PassesDeReversao = passesDeReversao;
            Cruzamentos = cruzamentos;
            LancamentosLaterais = lancamentosLaterais;
            EscanteiosDentroArea = escanteiosDentroArea;
            EscanteioForaArea = escanteioForaArea;
            EscanteioReto = escanteioReto;
            PassesImpedidos = passesImpedidos;
            PassesBloqueados = passesBloqueados;
        }
    }
}
