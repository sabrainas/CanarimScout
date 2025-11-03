using CanarinScout.Domain.Entities;

namespace CanarinScout.Application.DTO.Analysis
{
    public class GoalkeeperAnalysisDto
    {
        public string PlayerId { get; set; }
        public string? Nome { get; set; }
        public string? Clube { get; set; }
        public string? PerfilCluster { get; set; }
        public double? DefesaChutesNormVitoria { get; set; }
        public double? ControleAereoSaidaNormVitoria { get; set; }
        public double? ConfiabilidadePenaltiNormVitoria { get; set; }

        public Jogador Jogador { get; set; }
    }
}
