namespace CanarinScout.Domain.Entities
{
    public class Ofensivas
    {
        public int Id { get; private set; }
        public string? AcaoCriacaoChute {  get; set; }
        public string? PassesTentChutes { get; set; }
        public string? PassesTentChutesBolaParada { get; set; }
        public string? DriblesTentChutes { get; set; }
        public string? ChutesTentChutes { get; set; }
        public string? FaltaTentChutes { get; set; }
        public string? AcaoDefensivaTentChutes { get; set; }
        public string? AcaoGol {  get; set; }
        public string? PasseGol { get; set;}
        public string? GolBolaParada { get; set;}
        public string? DribleGol { get; set;}
        public string? ChuteGol { get; set;}
        public string? AcaoDefensivaGol { get; set; }
        public string? FaltaGol { get; set;}

        public Ofensivas() { }

        public Ofensivas(int id, string? acaoCriacaoChute, string? passesTentChutes, string? passesTentChutesBolaParada, string? driblesTentChutes, string? chutesTentChutes, string? faltaTentChutes, string? acaoDefensivaTentChutes, string? acaoGol, string? passeGol, string? golBolaParada, string? dribleGol, string? chuteGol, string? acaoDefensivaGol, string? faltaGol)
        {
            Id = id;
            AcaoCriacaoChute = acaoCriacaoChute;
            PassesTentChutes = passesTentChutes;
            PassesTentChutesBolaParada = passesTentChutesBolaParada;
            DriblesTentChutes = driblesTentChutes;
            ChutesTentChutes = chutesTentChutes;
            FaltaTentChutes = faltaTentChutes;
            AcaoDefensivaTentChutes = acaoDefensivaTentChutes;
            AcaoGol = acaoGol;
            PasseGol = passeGol;
            GolBolaParada = golBolaParada;
            DribleGol = dribleGol;
            ChuteGol = chuteGol;
            AcaoDefensivaGol = acaoDefensivaGol;
            FaltaGol = faltaGol;
        }
    }
}
