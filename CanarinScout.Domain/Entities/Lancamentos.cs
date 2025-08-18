namespace CanarinScout.Domain.Entities
{
    public class Lancamentos
    {
        public int Id { get; private set; }
        public int LancamentosCompletos { get; private set; }
        public int TentativasLancamentos { get; private set; }
        public float PerLancamentosCompletos { get; private set; }

        public Lancamentos() { }
        public Lancamentos(int lancamentosCompletos, int tentativasLancamentos, float perLancamentosCompletos)
        {
            LancamentosCompletos = lancamentosCompletos;
            TentativasLancamentos = tentativasLancamentos;
            PerLancamentosCompletos = perLancamentosCompletos;
        }
    }
}
