namespace CanarinScout.Application.DTO.Sum
{
    public class EstatisticasSumDto
    {
        public string PlayerId { get; set; } = null!;
        public decimal? Gols { get; set; }
        public decimal? Assistencias { get; set; }
        public decimal? PenaltisMarcados { get; set; }
        public decimal? PenaltisTentados { get; set; }
        public decimal? Chutes { get; set; }
        public decimal? ChutesNoGol { get; set; }
        public decimal? CartaoAmarelo { get; set; }
        public decimal? CartaoVermelho { get; set; }
        public decimal? Contatos { get; set; }
        public decimal? Desarmes { get; set; }
        public decimal? Interceptacoes { get; set; }
        public decimal? Bloqueios { get; set; }
        public decimal? GolsEsperados { get; set; }
        public decimal? GolsEsperadosSemPenalti { get; set; }
        public decimal? AssistenciasEsperadas { get; set; }
        public decimal? AcaoCriacaoChute { get; set; }
        public decimal? AcaoGol { get; set; }
        public decimal? PassesConcluidos { get; set; }
        public decimal? TentativasPasses { get; set; }
        public decimal? PassesProgressivos { get; set; }
        public decimal? Conducoes { get; set; }
        public decimal? ConducoesProgressivas { get; set; }
        public decimal? DriblesCompletos { get; set; }
        public decimal? FaltasCometidas { get; set; }
        public decimal? FaltasSofridas { get; set; }
        public decimal? Impedimentos { get; set; }
        public decimal? Cruzamentos { get; set; }
        public decimal? DesarmesGanhos { get; set; }
        public decimal? GolsContra { get; set; }
        public decimal? PenaltisGanhos { get; set; }
        public decimal? PenaltisConcedidos { get; set; }

        public OfensivasSumDto? Ofensivas { get; set; }
        public PassesSumDto? Passes { get; set; }
        public PossesSumDto? Posses { get; set; }
        public DefensivasSumDto? Defensivas { get; set; }
    }
}
