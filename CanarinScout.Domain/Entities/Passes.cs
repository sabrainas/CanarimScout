
namespace CanarinScout.Domain.Entities
{
    public class Passes
    {
        public int Id { get; private set; }
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;
        public string? PassesConcluidos { get; private set; }
        public string? TentativasPasses { get; private set; }
        public string? DistanciaTotal { get; private set; }
        public string? DistPassesProgressivo { get; private set; }
        public string? QtdPassesProgressivos { get; private set; }

        public string? PassesCurtosTentados { get; private set; }
        public string? PerPassesConcluidos { get; private set; }
        public string? PassesCurtosConcluidos { get; private set; }
        public string? PerPassesCurtosConcluidos { get; private set; }

        public string? PassesMediosTentados { get; private set; }
        public string? PassesMediosConcluidos { get; private set; }
        public string? PerPassesMediosTentados { get; private set; }

        public string? PassesLongosTentados { get; private set; }
        public string? PassesLongosConcluidos { get; private set; }
        public string? PerPassesLongosTentados { get; private set; }

        public string? Assistencia { get; private set; }
        public string? XAG { get; private set; }
        public string? XA { get; private set; }
        public string? PassesImportantes { get; private set; }
        public string? PassesPeqAreaAdv { get; private set; }
        public string? PassesAreaAdv { get; private set; }
        public string? CruzamentoPeqArea { get; private set; }

        public TipoPasses Tipo { get; set; } = null!;

    }
}
