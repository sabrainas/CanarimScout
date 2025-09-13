namespace CanarinScout.Domain.Entities
{
    public class PassesGoleiro
    {
        public int Id { get; private set; }
        public string? Passes { get; private set; }
        public string? TentativasPasses { get; private set; }
        public string? DistanciaMedia { get; private set; }

        public PassesGoleiro() { }

        public PassesGoleiro(string passes, string tentativasPasses, string distanciaMedia)
        {
            Passes = passes;
            TentativasPasses = tentativasPasses;
            DistanciaMedia = distanciaMedia;
        }
    }
}
