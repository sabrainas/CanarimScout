namespace CanarinScout.Domain.Entities.Analysis
{
    public class MidfielderAnalysis
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

        public MidfielderAnalysis() { }

        public MidfielderAnalysis(
            string playerId,
            string? nome,
            string? clube,
            string? peDominante,
            int? altura,
            int? peso,
            double? criacaoVisao,
            double? controleSeguranca,
            double? contribuicaoOfensivaDireta,
            double? contribuicaoDefensiva,
            double? participacaoDefensiva,
            double? participacaoCentral,
            double? participacaoOfensiva,
            string? perfilCluster,
            double? criacaoVisaoNormVitoria,
            double? controleSegurancaNormVitoria,
            double? contribuicaoOfensivaDiretaNormVitoria,
            double? contribuicaoDefensivaNormVitoria,
            double? participacaoDefensivaNormVitoria,
            double? participacaoCentralNormVitoria,
            double? participacaoOfensivaNormVitoria,
            Jogador jogador)
        {
            PlayerId = playerId;
            Nome = nome;
            Clube = clube;
            PeDominante = peDominante;
            Altura = altura;
            Peso = peso;
            CriacaoVisao = criacaoVisao;
            ControleSeguranca = controleSeguranca;
            ContribuicaoOfensivaDireta = contribuicaoOfensivaDireta;
            ContribuicaoDefensiva = contribuicaoDefensiva;
            ParticipacaoDefensiva = participacaoDefensiva;
            ParticipacaoCentral = participacaoCentral;
            ParticipacaoOfensiva = participacaoOfensiva;
            PerfilCluster = perfilCluster;
            CriacaoVisaoNormVitoria = criacaoVisaoNormVitoria;
            ControleSegurancaNormVitoria = controleSegurancaNormVitoria;
            ContribuicaoOfensivaDiretaNormVitoria = contribuicaoOfensivaDiretaNormVitoria;
            ContribuicaoDefensivaNormVitoria = contribuicaoDefensivaNormVitoria;
            ParticipacaoDefensivaNormVitoria = participacaoDefensivaNormVitoria;
            ParticipacaoCentralNormVitoria = participacaoCentralNormVitoria;
            ParticipacaoOfensivaNormVitoria = participacaoOfensivaNormVitoria;
            Jogador = jogador;
        }
    }
}