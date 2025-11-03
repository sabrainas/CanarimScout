namespace CanarinScout.Domain.Entities.Analysis
{
    public class GoalkeeperAnalysis
    {
        public string PlayerId { get; set; }
        public string? Nome { get; set; }
        public string? Clube { get; set; }
        public string? PerfilCluster { get; set; }
        public double? DefesaChutesNormVitoria { get; set; }
        public double? ControleAereoSaidaNormVitoria { get; set; }
        public double? ConfiabilidadePenaltiNormVitoria { get; set; }

        public Jogador Jogador { get; set; }

        public GoalkeeperAnalysis() { }

        public GoalkeeperAnalysis(string playerId, string? nome, string? clube, string? perfilCluster, double? defesaChutesNormVitoria, double? controleAereoSaidaNormVitoria, double? confiabilidadePenaltiNormVitoria, Jogador jogador)
        {
            PlayerId = playerId;
            Nome = nome;
            Clube = clube;
            PerfilCluster = perfilCluster;
            DefesaChutesNormVitoria = defesaChutesNormVitoria;
            ControleAereoSaidaNormVitoria = controleAereoSaidaNormVitoria;
            ConfiabilidadePenaltiNormVitoria = confiabilidadePenaltiNormVitoria;
            Jogador = jogador;
        }
    }
}
