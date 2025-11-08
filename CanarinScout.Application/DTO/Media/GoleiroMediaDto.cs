using CanarinScout.Domain.Entities;

namespace CanarinScout.Application.DTO.Media
{
    public class GoleiroMediaDto
    {
        public string PlayerId { get; set; } = null!;
        public Jogador Jogador { get; set; }

        public double? MinutosJogados { get; set; }
        public double? ChutesNoGol { get; set; }
        public double? GolSofridos { get; set; }
        public double? Defesas { get; set; }
        public double? PerDefesas { get; set; }
        public double? PartidaSemGol { get; set; }
        public double? GolsEsperados { get; set; }
        public double? PenaltiSofrido { get; set; }
        public double? PenaltiCausados { get; set; }
        public double? PenaltiDefendidos { get; set; }
        public double? PenaltiErrado { get; set; }
        public double? PassesConcluidos { get; set; }
        public double? TentativasPasses { get; set; }
        public double? PerPassesConcluidos { get; set; }
        public double? QtdTirosDeMeta { get; set; }
        public double? LancamentoTotal { get; set; }
        public double? DistMediaLancamentos { get; set; }
        public double? TentativasLancamentos { get; set; }
        public double? PerLancamentosCompletos { get; set; }
        public double? DistMediaTiroDeMeta { get; set; }
        public double? CruzamentosEnfrentados { get; set; }
        public double? CruzamentoBloqueado { get; set; }
        public double? PerCruzamentoBloqueado { get; set; }
        public double? AcoesForaDaPequenaArea { get; set; }
        public double? DistMedia { get; set; }

    }
}
