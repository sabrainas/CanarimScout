namespace CanarinScout.Application.DTO
{
    public class PassesDto
    {
        public int Id { get; private set; }
        public string? PassesConcluidos { get; set; }  
        public string? TentativasPasses { get; set; }
        public string? PassesCurtosConcluidos { get; set; } 
        public string? PassesCurtosTentados { get; set; }  
        public string? PerPassesCurtosConcluidos { get; set; }
        public string? PassesMediosConcluidos { get; set; }
        public string? PassesMediosTentados { get; set; } 
        public string? PerPassesMediosTentados { get; set; }
        public string? PassesLongosConcluidos { get; set; }
        public string? PassesLongosTentados { get; set; } 
        public string? PerPassesLongosTentados { get; set; }
        public string? DistanciaTotal { get; set; }      
        public string? DistPassesProgressivo { get; set; } 
        public string? QtdPassesProgressivos { get; set; }
        public string? XAG { get; set; }  
        public string? XA { get; set; }   
        public string? PassesImportantes { get; set; }
        public string? PassesAreaAdv { get; set; }    
        public string? PassesPeqAreaAdv { get; set; } 
        public string? CruzamentoPeqArea { get; set; } 
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
        public string? EscanteioForaArea { get; set; }
    }
}
