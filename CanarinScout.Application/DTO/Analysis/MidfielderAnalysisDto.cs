using CanarinScout.Domain.Entities;

namespace CanarinScout.Application.DTO.Analysis
{
    public class MidfielderAnalysisDto
    {
        public string PlayerId { get; set; }
        public string? Nome { get; set; }
        public string? Clube { get; set; }
        public string? PeDominante { get; set; }
        public int? Altura { get; set; }
        public int? Peso { get; set; }
        public double? CriacaoVisao { get; set; }
        public double? ControleSeguranca { get; set; }
        public double? ContribuicaoOfensivaDireta { get; set; }
        public double? ContribuicaoDefensiva { get; set; }
        public double? ParticipacaoDefensiva { get; set; }
        public double? ParticipacaoCentral { get; set; }
        public double? ParticipacaoOfensiva { get; set; }
        public string? PerfilCluster { get; set; }
        public double? CriacaoVisaoNormVitoria { get; set; }
        public double? ControleSegurancaNormVitoria { get; set; }
        public double? ContribuicaoOfensivaDiretaNormVitoria { get; set; }
        public double? ContribuicaoDefensivaNormVitoria { get; set; }
        public double? ParticipacaoDefensivaNormVitoria { get; set; }
        public double? ParticipacaoCentralNormVitoria { get; set; }
        public double? ParticipacaoOfensivaNormVitoria { get; set; }

        public Jogador Jogador { get; set; }
    }
}
