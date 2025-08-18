namespace CanarinScout.Domain.Entities
{
    public class Estatisticas
    {
        public int Id { get; private set; }
        public int Jogos {  get; set; }
        public int Gols { get; set; }
        public int Assistencias { get; set; }
        public int Cartoes { get; set; }
        public int MinutosJogados { get; set; }
        public Ofensivas Ofensivas { get; set; }
        public Passes Passes { get; set; }
        public Posses Posses { get; set; }
        public Defensivas Defensivas { get; set; }

        public Estatisticas() { }

        public Estatisticas(int jogos, int gols, int assistencias, int cartoes, int minutosJogados, Ofensivas ofensivas, Passes passes, Posses posses, Defensivas defensivas)
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
