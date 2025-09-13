namespace CanarinScout.Application.DTO
{
    public class PassesDto
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
    }
}
