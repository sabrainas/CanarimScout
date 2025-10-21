namespace CanarinScout.Domain.Entities.Sum
{
    public class EstatisticasSum
    {
        public string PlayerId { get; private set; } = null!;
        public Jogador Jogador { get; private set; } = null!;

        public decimal? Gols { get; private set; }
        public decimal? Assistencias { get; private set; }
        public decimal? PenaltisMarcados { get; private set; }
        public decimal? PenaltisTentados { get; private set; }
        public decimal? Chutes { get; private set; }
        public decimal? ChutesNoGol { get; private set; }
        public decimal? CartaoAmarelo { get; private set; }
        public decimal? CartaoVermelho { get; private set; }
        public decimal? Contatos { get; private set; }
        public decimal? Desarmes { get; private set; }
        public decimal? Interceptacoes { get; private set; }
        public decimal? Bloqueios { get; private set; }
        public decimal? GolsEsperados { get; private set; }
        public decimal? GolsEsperadosSemPenalti { get; private set; }
        public decimal? AssistenciasEsperadas { get; private set; }
        public decimal? AcaoCriacaoChute { get; private set; }
        public decimal? AcaoGol { get; private set; }
        public decimal? PassesConcluidos { get; private set; }
        public decimal? TentativasPasses { get; private set; }
        public decimal? PassesProgressivos { get; private set; }
        public decimal? Conducoes { get; private set; }
        public decimal? ConducoesProgressivas { get; private set; }
        public decimal? DriblesCompletos { get; private set; }
        public decimal? FaltasCometidas { get; private set; }
        public decimal? FaltasSofridas { get; private set; }
        public decimal? Impedimentos { get; private set; }
        public decimal? Cruzamentos { get; private set; }
        public decimal? DesarmesGanhos { get; private set; }
        public decimal? GolsContra { get; private set; }
        public decimal? PenaltisGanhos { get; private set; }
        public decimal? PenaltisConcedidos { get; private set; }

        public OfensivasSum? Ofensivas { get; private set; }
        public PassesSum? Passes { get; private set; }
        public PossesSum? Posses { get; private set; }
        public DefensivasSum? Defensivas { get; private set; }

        public EstatisticasSum() { }

        public EstatisticasSum(string playerId, Jogador jogador, decimal? gols, decimal? assistencias,
            decimal? penaltisMarcados, decimal? penaltisTentados, decimal? chutes, decimal? chutesNoGol,
            decimal? cartaoAmarelo, decimal? cartaoVermelho, decimal? contatos, decimal? desarmes,
            decimal? interceptacoes, decimal? bloqueios, decimal? golsEsperados, decimal? golsEsperadosSemPenalti,
            decimal? assistenciasEsperadas, decimal? acaoCriacaoChute, decimal? acaoGol, decimal? passesConcluidos,
            decimal? tentativasPasses, decimal? passesProgressivos, decimal? conducoes, decimal? conducoesProgressivas,
            decimal? driblesCompletos, decimal? faltasCometidas, decimal? faltasSofridas, decimal? impedimentos,
            decimal? cruzamentos, decimal? desarmesGanhos, decimal? golsContra, decimal? penaltisGanhos,
            decimal? penaltisConcedidos)
        {
            PlayerId = playerId;
            Jogador = jogador;
            Gols = gols;
            Assistencias = assistencias;
            PenaltisMarcados = penaltisMarcados;
            PenaltisTentados = penaltisTentados;
            Chutes = chutes;
            ChutesNoGol = chutesNoGol;
            CartaoAmarelo = cartaoAmarelo;
            CartaoVermelho = cartaoVermelho;
            Contatos = contatos;
            Desarmes = desarmes;
            Interceptacoes = interceptacoes;
            Bloqueios = bloqueios;
            GolsEsperados = golsEsperados;
            GolsEsperadosSemPenalti = golsEsperadosSemPenalti;
            AssistenciasEsperadas = assistenciasEsperadas;
            AcaoCriacaoChute = acaoCriacaoChute;
            AcaoGol = acaoGol;
            PassesConcluidos = passesConcluidos;
            TentativasPasses = tentativasPasses;
            PassesProgressivos = passesProgressivos;
            Conducoes = conducoes;
            ConducoesProgressivas = conducoesProgressivas;
            DriblesCompletos = driblesCompletos;
            FaltasCometidas = faltasCometidas;
            FaltasSofridas = faltasSofridas;
            Impedimentos = impedimentos;
            Cruzamentos = cruzamentos;
            DesarmesGanhos = desarmesGanhos;
            GolsContra = golsContra;
            PenaltisGanhos = penaltisGanhos;
            PenaltisConcedidos = penaltisConcedidos;
        }
    }
}
