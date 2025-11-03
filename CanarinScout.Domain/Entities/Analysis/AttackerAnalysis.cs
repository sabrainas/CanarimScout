namespace CanarinScout.Domain.Entities.Analysis
{
    public class AttackerAnalysis
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

        public AttackerAnalysis() { }

        public AttackerAnalysis(string playerId, string? nome, string? clube, string? peDominante, int? altura, int? peso, double? finalizacao, double? criacaoDeChances, double? pressao, double? disciplina, double? participacaoTercoOfensivo, double? dribles, string? perfilCluster, double? finalizacaoNormVitoria, double? chancesNormVitoria, double? pressaoNormVitoria, double? disciplinasNormVitoria, double? ofensivoNormVitoria, double? driblesNormVitoria, Jogador jogador)
        {
            PlayerId = playerId;
            Nome = nome;
            Clube = clube;
            PeDominante = peDominante;
            Altura = altura;
            Peso = peso;
            Finalizacao = finalizacao;
            CriacaoDeChances = criacaoDeChances;
            Pressao = pressao;
            Disciplina = disciplina;
            ParticipacaoTercoOfensivo = participacaoTercoOfensivo;
            Dribles = dribles;
            PerfilCluster = perfilCluster;
            FinalizacaoNormVitoria = finalizacaoNormVitoria;
            ChancesNormVitoria = chancesNormVitoria;
            PressaoNormVitoria = pressaoNormVitoria;
            DisciplinasNormVitoria = disciplinasNormVitoria;
            OfensivoNormVitoria = ofensivoNormVitoria;
            DriblesNormVitoria = driblesNormVitoria;
            Jogador = jogador;
        }
    }
}
