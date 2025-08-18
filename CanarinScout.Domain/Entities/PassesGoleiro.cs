namespace CanarinScout.Domain.Entities
{
    public class PassesGoleiro
    {
        public int Id { get; private set; }
        public int Passes { get; private set; }
        public int TentativasPasses { get; private set; }
        public int DistanciaMedia { get; private set; }

        public PassesGoleiro() { }

        public PassesGoleiro(int passes, int tentativasPasses, int distanciaMedia)
        {
            Passes = passes;
            TentativasPasses = tentativasPasses;
            DistanciaMedia = distanciaMedia;
        }
    }
}
