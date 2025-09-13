namespace CanarinScout.Domain.Entities
{
    public class TiroDeMeta
    {
        public int Id { get; private set; }
        public string? QtdTirosDeMeta { get; private set; }
        public string? PerTiroDeMetas { get; private set; }
        public string? DistMediaTiroDeMeta { get; private set; }
        public string? DistanciaMedia { get; private set; }

        public TiroDeMeta() { }

        public TiroDeMeta(string qtdTirosDeMeta, string perTiroDeMetas, string distMediaTiroDeMeta, string distanciaMedia)
        {
            QtdTirosDeMeta = qtdTirosDeMeta;
            PerTiroDeMetas = perTiroDeMetas;
            DistMediaTiroDeMeta = distMediaTiroDeMeta;
            DistanciaMedia = distanciaMedia;
        }
    }
}
