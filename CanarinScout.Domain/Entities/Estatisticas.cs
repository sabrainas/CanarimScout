using CanarinScout.WebApi;

namespace CanarinScout.Domain.Entities
{
    public class Estatisticas
    {
        public int Id { get; private set; }
        public string? Jogos {  get; set; }
        public string? Gols { get; set; }
        public string? Assistencias { get; set; }
        public string? Cartoes { get; set; }
        public string? MinutosJogados { get; set; }
        public Ofensivas Ofensivas { get; set; }
        public Passes Passes { get; set; }
        public Posses Posses { get; set; }
        public Defensivas Defensivas { get; set; }

        public Estatisticas() { }

        public Estatisticas(string? jogos, string? gols, string? assistencias, string? cartoes, string? minutosJogados, Ofensivas ofensivas, Passes passes, Posses posses, Defensivas defensivas)
        {
            Jogos = jogos;
            Gols = gols;
            Assistencias = assistencias;
            Cartoes = cartoes;
            MinutosJogados = minutosJogados;
            Ofensivas = ofensivas;
            Passes = passes;
            Posses = posses;
            Defensivas = defensivas;
        }
    }
}
