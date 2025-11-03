using CanarinScout.Domain.Entities;

namespace CanarinScout.Application.DTO.Analysis
{
    public class AttackerAnalysisDto
    {
        public string PlayerId { get; set; }
        public string? Nome { get; set; }
        public string? Clube { get; set; }
        public string? PeDominante { get; set; }
        public int? Altura { get; set; }
        public int? Peso { get; set; }
        public double? Finalizacao { get; set; }
        public double? CriacaoDeChances { get; set; }
        public double? Pressao { get; set; }
        public double? Disciplina { get; set; }
        public double? ParticipacaoTercoOfensivo { get; set; }
        public double? Dribles { get; set; }
        public string? PerfilCluster { get; set; }
        public double? FinalizacaoNormVitoria { get; set; }
        public double? ChancesNormVitoria { get; set; }
        public double? PressaoNormVitoria { get; set; }
        public double? DisciplinasNormVitoria { get; set; }
        public double? OfensivoNormVitoria { get; set; }
        public double? DriblesNormVitoria { get; set; }

        public Jogador Jogador { get; set; }
    }
}
