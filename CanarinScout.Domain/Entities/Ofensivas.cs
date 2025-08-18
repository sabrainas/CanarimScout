namespace CanarinScout.Domain.Entities
{
    public class Ofensivas
    {
        public int Id { get; private set; }
        public int AcaoCriacaoChute {  get; set; }
        public int PassesTentChutes { get; set; }
        public int PassesTentChutesBolaParada { get; set; }
        public int DriblesTentChutes { get; set; }
        public int ChutesTentChutes { get; set; }
        public int FaltaTentChutes { get; set; }
        public int AcaoDefensivaTentChutes { get; set; }
        public int AcaoGol {  get; set; }
        public int PasseGol { get; set;}
        public int GolBolaParada { get; set;}
        public int DribleGol { get; set;}
        public int ChuteGol { get; set;}
        public int AcaoDefensivaGol { get; set; }

        public Ofensivas() { }

        public Ofensivas(int acaoCriacaoChute, int passesTentChutes, int passesTentChutesBolaParada, int driblesTentChutes, int chutesTentChutes, int faltaTentChutes, int acaoDefensivaTentChutes, int acaoGol, int passeGol, int golBolaParada, int dribleGol, int chuteGol, int acaoDefensivaGol)
        {
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
        }
    }
}
