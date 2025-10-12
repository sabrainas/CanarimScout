namespace CanarinScout.Domain.Entities
{
    public class Jogador
    {
        public int Id { get; set; }
        public string? PlayerId { get; set; }
        public string? Nome { get; set; }
        public string? DtNascimento { get; set; }
        public string? Altura {  get; set; }
        public string? Peso { get; set; }
        public string? PeDominante { get; set; }
        public string? Selecao { get; set; }
        public string? TimeAtual {  get; set; }
        public string? Posicao { get; set; }
        public string? Foto { get; set; }
        public Jogador() { }

    }
}
