namespace CanarinScout.Domain.Entities
{
    public class Cruzamento
    {
        public int Id { get; private set; }
        public string? CruzamentosEnfrentados { get; private set; }
        public string? CruzamentoBloqueado { get; private set; }
        public string? PerCruzamentoBloqueado { get; private set; }

        public Cruzamento() { }

        public Cruzamento(string cruzamentosEnfrentados, string cruzamentoBloqueado, string perCruzamentoBloqueado)
        {
            CruzamentosEnfrentados = cruzamentosEnfrentados;
            CruzamentoBloqueado = cruzamentoBloqueado;
            PerCruzamentoBloqueado = perCruzamentoBloqueado;
        }
    }
}
