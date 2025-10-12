using CanarinScout.Domain.Entities;

namespace CanarinScout.WebApi
{
    public class Passes
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public Jogador Jogador { get; set; }
        public string? PassesConcluidos { get; set; }
        public string? TentativasPasses { get; set; }
        public string? DistanciaTotal { get; set; }
        public string? DistPassesProgressivo { get; set; }
        public string? QtdPassesProgressivos { get; set; }

        public string? PassesCurtosTentados { get; set; }
        public string? PerPassesConcluidos { get; set; }
        public string? PassesCurtosConcluidos { get; set; }
        public string? PerPassesCurtosConcluidos { get; set; }

        public string? PassesMediosTentados { get; set; }
        public string? PassesMediosConcluidos { get; set; }
        public string? PerPassesMediosTentados { get; set; }

        public string? PassesLongosTentados { get; set; }
        public string? PassesLongosConcluidos { get; set; }
        public string? PerPassesLongosTentados { get; set; }

        public string? Assistencia { get; set; }
        public string? XAG { get; set; }
        public string? XA { get; set; }
        public string? PassesImportantes { get; set; }
        public string? PassesPeqAreaAdv { get; set; }
        public string? PassesAreaAdv { get; set; }
        public string? CruzamentoPeqArea { get; set; }

        public TipoPasses Tipo { get; set; } = null!;

    }
}
