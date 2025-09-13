namespace CanarinScout.Domain.Entities
{
    public class ForaDaArea
    {
        public int Id { get; private set; }
        public string? AcoesForaDaPequenaArea { get; private set; }
        public string? DistMedia { get; private set; }

        public ForaDaArea() { }

        public ForaDaArea(string acoesForaDaPequenaArea, string distMedia)
        {
            AcoesForaDaPequenaArea = acoesForaDaPequenaArea;
            DistMedia = distMedia;
        }
    }
}
