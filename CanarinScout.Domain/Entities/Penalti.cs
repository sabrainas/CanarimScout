namespace CanarinScout.Domain.Entities
{
    public class Penalti
    {
        public int Id { get; private set; }
        public string? CobrancaPenalti { get; private set; }
        public string? NaoDefendido { get; private set; }
        public string? PenaltiMarcado { get; private set; }
        public string? ErroAdversario { get; private set; }

        private Penalti() { }

        public Penalti(string cobrancaPenalti, string naoDefendido, string penaltiMarcado, string erroAdversario)
        {
            CobrancaPenalti = cobrancaPenalti;
            NaoDefendido = naoDefendido;
            PenaltiMarcado = penaltiMarcado;
            ErroAdversario = erroAdversario;
        }
    }
}
