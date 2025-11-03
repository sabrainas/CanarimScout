using CanarinScout.Domain.Entities;

namespace CanarinScout.Application.DTO.Analysis
{
    public class DefenseAnalysisDto
    {
        public string PlayerId { get; set; }
        public string? Nome { get; set; }
        public string? Clube { get; set; }
        public string? PeDominante { get; set; }
        public int? Altura { get; set; }
        public int? Peso { get; set; }
        public double? SolidezDefensiva { get; set; }
        public double? DuelosBorda { get; set; }
        public double? DistribuicaoCurtaMedia { get; set; }
        public double? ProgressaoJogo { get; set; }
        public double? ParticipacaoOfensiva { get; set; }
        public double? EnvolvimentoPosse { get; set; }
        public double? DisciplinaRisco { get; set; }
        public string? PerfilCluster { get; set; }
        public double? SolidezDefensivaNormVitoria { get; set; }
        public double? DuelosBordaNormVitoria { get; set; }
        public double? DistribuicaoCurtaMediaNormVitoria { get; set; }
        public double? ProgressaoJogoNormVitoria { get; set; }
        public double? ParticipacaoOfensivaNormVitoria { get; set; }
        public double? EnvolvimentoPosseNormVitoria { get; set; }
        public double? DisciplinaRiscoNormVitoria { get; set; }

        public Jogador Jogador { get; set; }
    }
}
