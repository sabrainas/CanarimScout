namespace CanarinScout.Application.DTO.Sum
{
    public class PassesSumDto
    {
        public string PlayerId { get; set; } = null!;
        public decimal? PassesConcluidos { get; set; }
        public decimal? TentativasPasses { get; set; }
        public decimal? PerPassesConcluidos { get; set; }
        public decimal? DistanciaTotal { get; set; }
        public decimal? DistPassesProgressivo { get; set; }
        public decimal? PassesCurtosConcluidos { get; set; }
        public decimal? PassesCurtosTentados { get; set; }
        public decimal? PerPassesCurtosConcluidos { get; set; }
        public decimal? PassesMediosConcluidos { get; set; }
        public decimal? PassesMediosTentados { get; set; }
        public decimal? PerPassesMediosTentados { get; set; }
        public decimal? PassesLongosConcluidos { get; set; }
        public decimal? PassesLongosTentados { get; set; }
        public decimal? PerPassesLongosTentados { get; set; }
        public decimal? Assistencia { get; set; }
        public decimal? XAG { get; set; }
        public decimal? XA { get; set; }
        public decimal? PassesImportantes { get; set; }
        public decimal? PassesAreaAdv { get; set; }
        public decimal? PassesPeqAreaAdv { get; set; }
        public decimal? CruzamentoPeqArea { get; set; }
        public decimal? QtdPassesProgressivos { get; set; }

        public TipoPassesSumDto? Tipo { get; set; }
    }
}
