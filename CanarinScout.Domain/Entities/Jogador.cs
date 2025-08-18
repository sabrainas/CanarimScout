using CanarinScout.Domain.Enums;

namespace CanarinScout.Domain.Entities
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public float ValorMercado { get; set; }
        public float Altura {  get; set; }
        public float Peso { get; set; }
        public PeDominante PeDominante { get; set; }
        public string Titulos { get; set; }
        public string CompDisputadas { get; set; }
        public string Selecao { get; set; }
        public string TimeAtual {  get; set; }
        public Posicao Posicao { get; set; }

        public Jogador() { }

        public Jogador(string nome, DateTime dtNascimento, float valorMercado, float altura, float peso, PeDominante peDominante, string titulos, string compDisputadas, string selecao, string timeAtual, Posicao posicao)
        {
            Nome = nome;
            DtNascimento = dtNascimento;
            ValorMercado = valorMercado;
            Altura = altura;
            Peso = peso;
            PeDominante = peDominante;
            Titulos = titulos;
            CompDisputadas = compDisputadas;
            Selecao = selecao;
            TimeAtual = timeAtual;
            Posicao = posicao;
        }
    }
}
