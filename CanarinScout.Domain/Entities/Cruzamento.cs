namespace CanarinScout.Domain.Entities
{
    public class Cruzamento
    {
        public int Id { get; private set; }
        public int CruzamentosEnfrentados { get; private set; }
        public int CruzamentoBloqueado { get; private set; }
        public float PerCruzamentoBloqueado { get; private set; }

        public Cruzamento() { }

        public Cruzamento(int cruzamentosEnfrentados, int cruzamentoBloqueado, float perCruzamentoBloqueado)
        {
            CruzamentosEnfrentados = cruzamentosEnfrentados;
            CruzamentoBloqueado = cruzamentoBloqueado;
            PerCruzamentoBloqueado = perCruzamentoBloqueado;
        }
    }
}
