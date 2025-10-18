namespace CanarinScout.Domain.Entities
{
    public class Jogador
    {
        public int Id { get; private set; }
        public string? PlayerId { get; private set; } 
        public string? Nome { get; private set; }
        public string? DtNascimento { get; private set; }
        public string? Altura {  get; private set; }
        public string? Peso { get; private set; }
        public string? PeDominante { get; private set; }
        public string? Selecao { get; private set; }
        public string? TimeAtual {  get; private set; }
        public string? Posicao { get; private set; }
        public string? Foto { get; private set; }
        public Jogador() { }

    }
}
