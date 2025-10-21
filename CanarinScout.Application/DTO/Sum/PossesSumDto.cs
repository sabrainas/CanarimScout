namespace CanarinScout.Application.DTO.Sum
{
    public class PossesSumDto
    {
        public string PlayerId { get; set; } = null!;
        public decimal? Contatos { get; set; }
        public decimal? ContatosDefensivosPen { get; set; }
        public decimal? ContatosTercoDef { get; set; }
        public decimal? ContatosTercoCentral { get; set; }
        public decimal? ContatosTercoAtaque { get; set; }
        public decimal? ContatosAtaquePen { get; set; }
        public decimal? ContatoBolaJogo { get; set; }
        public decimal? TentativasDribles { get; set; }
        public decimal? DriblesCompletos { get; set; }
        public decimal? PerDriblesCompletos { get; set; }
        public decimal? DriblesInterrompidos { get; set; }
        public decimal? PerDriblesInterrompidos { get; set; }
        public decimal? Conducoes { get; set; }
        public decimal? DistTotal { get; set; }
        public decimal? DistProgressivas { get; set; }
        public decimal? CarregadaProgressiva { get; set; }
        public decimal? CarregadaTercoFinal { get; set; }
        public decimal? CarregadaAreaPenalti { get; set; }
        public decimal? PerdaDominio { get; set; }
        public decimal? Desarmado { get; set; }
        public decimal? PassesRecebidos { get; set; }
        public decimal? PassesProgressivosRecebidos { get; set; }
    }
}
