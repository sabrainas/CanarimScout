namespace CanarinScout.Domain.Entities
{
    public class Penalti
    {
        public int Id { get; private set; }
        public int CobrancaPenalti { get; private set; }
        public int NaoDefendido { get; private set; }
        public int PenaltiMarcado { get; private set; }
        public int ErroAdversario { get; private set; }

        private Penalti() { }

        public Penalti(int cobrancaPenalti, int naoDefendido, int penaltiMarcado, int erroAdversario)
        {
            CobrancaPenalti = cobrancaPenalti;
            NaoDefendido = naoDefendido;
            PenaltiMarcado = penaltiMarcado;
            ErroAdversario = erroAdversario;
        }
    }
}
