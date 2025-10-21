namespace CanarinScout.Application.DTO.Sum
{
    public class OfensivasSumDto
    {
        public string PlayerId { get; set; } = null!;
        public decimal? AcaoCriacaoChute { get; set; }
        public decimal? PassesTentChutes { get; set; }
        public decimal? PassesTentChutesBolaParada { get; set; }
        public decimal? DriblesTentChutes { get; set; }
        public decimal? ChutesTentChutes { get; set; }
        public decimal? FaltaTentChutes { get; set; }
        public decimal? AcaoDefensivaTentChutes { get; set; }
        public decimal? AcaoGol { get; set; }
        public decimal? PasseGol { get; set; }
        public decimal? GolBolaParada { get; set; }
        public decimal? DribleGol { get; set; }
        public decimal? ChuteGol { get; set; }
        public decimal? FaltaGol { get; set; }
        public decimal? AcaoDefensivaGol { get; set; }
    }
}
