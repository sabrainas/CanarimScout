namespace CanarinScout.Domain.Entities
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DtNascimento { get; set; }
        public string ValorMercado { get; set; }
        public string Altura {  get; set; }
        public string Peso { get; set; }
        public string PeDominante { get; set; }
        public string Titulos { get; set; }
        public string CompDisputadas { get; set; }
        public string Selecao { get; set; }
        public string TimeAtual {  get; set; }
        public string Posicao { get; set; }

        public Jogador() { }

        public Jogador(string nome, string dtNascimento, string valorMercado, string altura, string peso, string peDominante, string titulos, string compDisputadas, string selecao, string timeAtual, string posicao)
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
