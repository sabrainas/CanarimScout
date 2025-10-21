namespace CanarinScout.Application.DTO.Sum
{
    public class DefensivasSumDto
    {
        public string PlayerId { get; set; } = null!;
        public decimal? DesarmesConcluidos { get; set; }
        public decimal? DesarmesDefensivos { get; set; }
        public decimal? DesarmesCentrais { get; set; }
        public decimal? DesarmesAtaque { get; set; }
        public decimal? TentativaDesarmes { get; set; }
        public decimal? PerDesDriblador { get; set; }
        public decimal? DesDriblador { get; set; }
        public decimal? Bloqueios { get; set; }
        public decimal? ChutesBloqueados { get; set; }
        public decimal? PassesBloqueados { get; set; }
        public decimal? Interceptacoes { get; set; }
        public decimal? DesarmesInterceptacoes { get; set; }
        public decimal? Defesas { get; set; }
        public decimal? Erros { get; set; }
    }
}
