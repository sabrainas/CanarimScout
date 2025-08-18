namespace CanarinScout.Domain.Entities
{
    public class ForaDaArea
    {
        public int Id { get; private set; }
        public int AcoesForaDaPequenaArea { get; private set; }
        public float DistMedia { get; private set; }

        public ForaDaArea() { }

        public ForaDaArea(int acoesForaDaPequenaArea, float distMedia)
        {
            AcoesForaDaPequenaArea = acoesForaDaPequenaArea;
            DistMedia = distMedia;
        }
    }
}
