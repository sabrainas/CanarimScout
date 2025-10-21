namespace CanarinScout.Domain.Entities.Sum
{
    public class OfensivasSum
    {
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;

        public decimal? AcaoCriacaoChute { get; private set; }
        public decimal? PassesTentChutes { get; private set; }
        public decimal? PassesTentChutesBolaParada { get; private set; }
        public decimal? DriblesTentChutes { get; private set; }
        public decimal? ChutesTentChutes { get; private set; }
        public decimal? FaltaTentChutes { get; private set; }
        public decimal? AcaoDefensivaTentChutes { get; private set; }
        public decimal? AcaoGol { get; private set; }
        public decimal? PasseGol { get; private set; }
        public decimal? GolBolaParada { get; private set; }
        public decimal? DribleGol { get; private set; }
        public decimal? ChuteGol { get; private set; }
        public decimal? FaltaGol { get; private set; }
        public decimal? AcaoDefensivaGol { get; private set; }

        public OfensivasSum() { }

        public OfensivasSum(string playerId, Jogador jogador, decimal? acaoCriacaoChute, decimal? passesTentChutes,
            decimal? passesTentChutesBolaParada, decimal? driblesTentChutes, decimal? chutesTentChutes, decimal? faltaTentChutes,
            decimal? acaoDefensivaTentChutes, decimal? acaoGol, decimal? passeGol, decimal? golBolaParada,
            decimal? dribleGol, decimal? chuteGol, decimal? faltaGol, decimal? acaoDefensivaGol)
        {
            PlayerId = playerId;
            Jogador = jogador;
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
            FaltaGol = faltaGol;
            AcaoDefensivaGol = acaoDefensivaGol;
        }
    }
}
