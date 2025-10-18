namespace CanarinScout.Application.DTO
{
    public class EstatisticasDto
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public string? Jogos { get; set; }
        public string? Gols { get; set; }
        public string? Assistencias { get; set; }
        public string? CartaoAmarelo { get; set; }
        public string? CartaoVermelho { get; set; }
        public string? MinutosJogados { get; set; }
        public OfensivasDto? Ofensivas { get; set; }
        public PassesDto? Passes { get; set; }
        public PossesDto? Posses { get; set; }
        public DefensivasDto? Defensivas { get; set; }
    }
}
