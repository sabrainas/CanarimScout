namespace CanarinScout.Domain.Entities
{
    public class Ofensivas
    {
        public int Id { get; private set; }
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;
        public string? AcaoCriacaoChute {  get; private set; }
        public string? PassesTentChutes { get; private set; }
        public string? PassesTentChutesBolaParada { get; private set; }
        public string? DriblesTentChutes { get; private set; }
        public string? ChutesTentChutes { get; private set; }
        public string? FaltaTentChutes { get; private set; }
        public string? AcaoDefensivaTentChutes { get; private set; }
        public string? AcaoGol {  get; private set; }
        public string? PasseGol { get; private set;}
        public string? GolBolaParada { get; private set;}
        public string? DribleGol { get; private set;}
        public string? ChuteGol { get; private set;}
        public string? AcaoDefensivaGol { get; private set; }
        public string? FaltaGol { get; private set;}

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
