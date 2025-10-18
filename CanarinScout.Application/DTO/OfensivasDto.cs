namespace CanarinScout.Application.DTO
{
    public class OfensivasDto
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public string? AcaoCriacaoChute { get; set; }
        public string? PassesTentChutes { get; set; }
        public string? PassesTentChutesBolaParada { get; set; }
        public string? DriblesTentChutes { get; set; }
        public string? ChutesTentChutes { get; set; }
        public string? FaltaTentChutes { get; set; }
        public string? AcaoDefensivaTentChutes { get; set; }
        public string? AcaoGol { get; set; }
        public string? PasseGol { get; set; }
        public string? GolBolaParada { get; set; }
        public string? DribleGol { get; set; }
        public string? ChuteGol { get; set; }
        public string? AcaoDefensivaGol { get; set; }
        public string? FaltaGol { get; set; }
    }
}
