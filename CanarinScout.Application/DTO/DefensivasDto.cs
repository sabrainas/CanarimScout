namespace CanarinScout.Application.DTO
{
    public class DefensivasDto
    {
        public int Id { get; set; }
        public string? Competicao { get; set; }        // Comp
        public string? DesarmesConcluidos { get; set; } // Tkl1
        public string? PassesBloqueados { get; set; }  // Blocks
        public string? Interceptacoes { get; set; }    // Int
        public string? TentativaDesarmes { get; set; } // Att
        public string? DesDriblador { get; set; }      // Lost
        public string? Bloqueios { get; set; }         // Blocks
        public string? ChutesBloqueados { get; set; }  // Sh
        public string? Defesas { get; set; }           // Pass
        public string? Erros { get; set; }             // Err
        public string? PerDesDriblador { get; set; }
        public string? DesarmesDefensivos { get; set; }
        public string? DesarmesAtaque { get; set; }
        public string? DesarmesCentrais { get; set; }
    }
}
