namespace CanarinScout.Domain.Entities.Analysis
{
    public class DefenseAnalysis
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

        public DefenseAnalysis() { }

        public DefenseAnalysis(string playerId, string? nome, string? clube, string? peDominante, int? altura, int? peso, double? solidezDefensiva, double? duelosBorda, double? distribuicaoCurtaMedia, double? progressaoJogo, double? participacaoOfensiva, double? envolvimentoPosse, double? disciplinaRisco, string? perfilCluster, double? solidezDefensivaNormVitoria, double? duelosBordaNormVitoria, double? distribuicaoCurtaMediaNormVitoria, double? progressaoJogoNormVitoria, double? participacaoOfensivaNormVitoria, double? envolvimentoPosseNormVitoria, double? disciplinaRiscoNormVitoria, Jogador jogador)
        {
            PlayerId = playerId;
            Nome = nome;
            Clube = clube;
            PeDominante = peDominante;
            Altura = altura;
            Peso = peso;
            SolidezDefensiva = solidezDefensiva;
            DuelosBorda = duelosBorda;
            DistribuicaoCurtaMedia = distribuicaoCurtaMedia;
            ProgressaoJogo = progressaoJogo;
            ParticipacaoOfensiva = participacaoOfensiva;
            EnvolvimentoPosse = envolvimentoPosse;
            DisciplinaRisco = disciplinaRisco;
            PerfilCluster = perfilCluster;
            SolidezDefensivaNormVitoria = solidezDefensivaNormVitoria;
            DuelosBordaNormVitoria = duelosBordaNormVitoria;
            DistribuicaoCurtaMediaNormVitoria = distribuicaoCurtaMediaNormVitoria;
            ProgressaoJogoNormVitoria = progressaoJogoNormVitoria;
            ParticipacaoOfensivaNormVitoria = participacaoOfensivaNormVitoria;
            EnvolvimentoPosseNormVitoria = envolvimentoPosseNormVitoria;
            DisciplinaRiscoNormVitoria = disciplinaRiscoNormVitoria;
            Jogador = jogador;
        }
    }
}
