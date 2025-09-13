namespace CanarinScout.Domain.Entities
{
    public class Lancamentos
    {
        public int Id { get; private set; }
        public string? LancamentosCompletos { get; private set; }
        public string? TentativasLancamentos { get; private set; }
        public string? PerLancamentosCompletos { get; private set; }

        public Lancamentos() { }
        public Lancamentos(string lancamentosCompletos, string tentativasLancamentos, string perLancamentosCompletos)
        {
            LancamentosCompletos = lancamentosCompletos;
            TentativasLancamentos = tentativasLancamentos;
            PerLancamentosCompletos = perLancamentosCompletos;
        }
    }
}
