namespace CanarinScout.WebApi
{
    public class Passes
    {
        public int Id { get; private set; }
         
        // Passes gerais
        public string? PassesConcluidos { get; set; }   // cmp
        public string? TentativasPasses { get; set; }   // att
        public string? PerPassesConcluidos { get; set; } // comp %

        // Passes curtos
        public string? PassesCurtosConcluidos { get; set; } // cmp_
        public string? PassesCurtosTentados { get; set; }   // att_1
        public string? PerPassesCurtosConcluidos { get; set; } // cmp_1 %

        // Passes médios
        public string? PassesMediosConcluidos { get; set; } // cmp__1
        public string? PassesMediosTentados { get; set; }   // att_2
        public string? PerPassesMediosTentados { get; set; } // cmp_2 %

        // Passes longos
        public string? PassesLongosConcluidos { get; set; } // cmp__2
        public string? PassesLongosTentados { get; set; }   // att_3
        public string? PerPassesLongosTentados { get; set; } // cmp_3 %

        // Distâncias e métricas de passe
        public string? DistanciaTotal { get; set; }       // totdist
        public string? DistPassesProgressivo { get; set; } // prgdist
        public string? QtdPassesProgressivos { get; set; } // prgp

        // Métricas avançadas
        public string? XAG { get; set; }  // xag
        public string? XA { get; set; }   // xa
        public string? PassesImportantes { get; set; } // kp
        public string? PassesAreaAdv { get; set; }     // ppa
        public string? PassesPeqAreaAdv { get; set; }  // 1_3
        public string? CruzamentoPeqArea { get; set; } // crspa
        public string? Assistencia { get; set; }
        public string? PassesBloqueados { get; set; }
        public string? LancamentoEscanteio { get; set; }
        public string? PassesBolasParadas { get; set; }
        public string? PassesAPartirDeFaltas { get; set; }
        public string? EscanteiosDentroArea { get; set; }
        public string? PassesEmjogo { get; set; }
        public string? PassesImpedidos { get; set; }
        public string? EscanteioReto { get; set; }
        public string? PassesDeReversao { get; set; }
        public string? PassesEntreLinhaDefesa { get; set; }
        public string? LancamentoLateral { get; set; }
        public string? Cruzamentos { get; set; }
        public string? PassesEmJogo { get; set; }
        public string? EscanteioForaArea { get; set; }
        public Passes(string? passesConcluidos, string? tentativasPasses, string? perPassesConcluidos, string? passesCurtosConcluidos, string? passesCurtosTentados, string? perPassesCurtosConcluidos, string? passesMediosConcluidos, string? passesMediosTentados, string? perPassesMediosTentados, string? passesLongosConcluidos, string? passesLongosTentados, string? perPassesLongosTentados, string? distanciaTotal, string? distPassesProgressivo, string? qtdPassesProgressivos, string? xAG, string? xA, string? passesImportantes, string? passesAreaAdv, string? passesPeqAreaAdv, string? cruzamentoPeqArea, string? assistencia, string? passesBloqueados, string? lancamentoEscanteio, string? passesBolasParadas, string? passesAPartirDeFaltas, string? escanteiosDentroArea, string? passesEmjogo, string? passesImpedidos, string? escanteioReto, string? passesDeReversao, string? passesEntreLinhaDefesa, string? lancamentoLateral, string? cruzamentos, string? passesEmJogo, string? escanteioForaArea)
        {
            PassesConcluidos = passesConcluidos;
            TentativasPasses = tentativasPasses;
            PerPassesConcluidos = perPassesConcluidos;
            PassesCurtosConcluidos = passesCurtosConcluidos;
            PassesCurtosTentados = passesCurtosTentados;
            PerPassesCurtosConcluidos = perPassesCurtosConcluidos;
            PassesMediosConcluidos = passesMediosConcluidos;
            PassesMediosTentados = passesMediosTentados;
            PerPassesMediosTentados = perPassesMediosTentados;
            PassesLongosConcluidos = passesLongosConcluidos;
            PassesLongosTentados = passesLongosTentados;
            PerPassesLongosTentados = perPassesLongosTentados;
            DistanciaTotal = distanciaTotal;
            DistPassesProgressivo = distPassesProgressivo;
            QtdPassesProgressivos = qtdPassesProgressivos;
            XAG = xAG;
            XA = xA;
            PassesImportantes = passesImportantes;
            PassesAreaAdv = passesAreaAdv;
            PassesPeqAreaAdv = passesPeqAreaAdv;
            CruzamentoPeqArea = cruzamentoPeqArea;
            Assistencia = assistencia;
            PassesBloqueados = passesBloqueados;
            LancamentoEscanteio = lancamentoEscanteio;
            PassesBolasParadas = passesBolasParadas;
            PassesAPartirDeFaltas = passesAPartirDeFaltas;
            EscanteiosDentroArea = escanteiosDentroArea;
            PassesEmjogo = passesEmjogo;
            PassesImpedidos = passesImpedidos;
            EscanteioReto = escanteioReto;
            PassesDeReversao = passesDeReversao;
            PassesEntreLinhaDefesa = passesEntreLinhaDefesa;
            LancamentoLateral = lancamentoLateral;
            Cruzamentos = cruzamentos;
            PassesEmJogo = passesEmJogo;
            EscanteioForaArea = escanteioForaArea;
        }
    }
}
