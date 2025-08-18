namespace CanarinScout.Domain.Entities
{
    public class TiroDeMeta
    {
        public int Id { get; private set; }
        public int QtdTirosDeMeta { get; private set; }
        public float PerTiroDeMetas { get; private set; }
        public float DistMediaTiroDeMeta { get; private set; }
        public int DistanciaMedia { get; private set; }

        public TiroDeMeta() { }

        public TiroDeMeta(int qtdTirosDeMeta, float perTiroDeMetas, float distMediaTiroDeMeta, int distanciaMedia)
        {
            QtdTirosDeMeta = qtdTirosDeMeta;
            PerTiroDeMetas = perTiroDeMetas;
            DistMediaTiroDeMeta = distMediaTiroDeMeta;
            DistanciaMedia = distanciaMedia;
        }
    }
}
