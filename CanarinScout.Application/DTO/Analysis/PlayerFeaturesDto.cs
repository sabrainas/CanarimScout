using CanarinScout.Application.DTO.Sum;

namespace CanarinScout.Application.DTO.Analysis
{
    public class PlayerFeaturesDto
    {
        public JogadorDetailDto? Jogador { get; set; }

        // Finalização / Produção ofensiva
        public double? Gols { get; set; }
        public double? Chutes { get; set; }
        public double? ChutesNoAlvo { get; set; }
        public double? GolsEsperados { get; set; }
        public double? GolsEsperadosSemPenaltis { get; set; }
        public double? AssistenciasSumario { get; set; }
        public double? XagSumario { get; set; }
        public double? AcoesGeramGolSumario { get; set; }
        public double? AcoesGeramChuteSumario { get; set; }

        // Passes
        public double? PassesConcluidos { get; set; }
        public double? PassesTentados { get; set; }
        public double? PercentualPassesConcluidos { get; set; }
        public double? DistanciaTotalPasses { get; set; }
        public double? DistanciaProgressivaPasses { get; set; }
        public double? PassesProgressivos { get; set; }
        public double? PassesCurtosConcluidos { get; set; }
        public double? PassesCurtosTentados { get; set; }
        public double? PercentualPassesCurtosConcluidos { get; set; }
        public double? PassesMediosConcluidos { get; set; }
        public double? PassesMediosTentados { get; set; }
        public double? PercentualPassesMediosConcluidos { get; set; }
        public double? PassesLongosConcluidos { get; set; }
        public double? PassesLongosTentados { get; set; }
        public double? PercentualPassesLongosConcluidos { get; set; }
        public double? AssistenciasPasse { get; set; }
        public double? XagPasse { get; set; }
        public double? AssistenciasEsperadas { get; set; }
        public double? PassesChave { get; set; }
        public double? PassesTercoFinal { get; set; }
        public double? PassesPequenaArea { get; set; }
        public double? CruzamentosPequenaArea { get; set; }

        // Tipos de Passe
        public double? PassesTentadosTipo { get; set; }
        public double? PassesBolaRolando { get; set; }
        public double? PassesBolaParada { get; set; }
        public double? PassesDeFaltas { get; set; }
        public double? PassesEntreLinhas { get; set; }
        public double? PassesReversao { get; set; }
        public double? CruzamentosTipo { get; set; }
        public double? LateraisCobradas { get; set; }
        public double? EscanteiosBatidos { get; set; }
        public double? EscanteiosDentroArea { get; set; }
        public double? EscanteiosForaArea { get; set; }
        public double? EscanteiosRetos { get; set; }
        public double? PassesConcluidosTipo { get; set; }
        public double? PassesImpedimento { get; set; }
        public double? PassesBloqueados { get; set; }

        // Criação de jogadas
        public double? MinutosJogadosGca { get; set; }
        public double? AcoesGeramChuteGca { get; set; }
        public double? PassesFinalizacaoBolaRolando { get; set; }
        public double? PassesFinalizacaoBolaParada { get; set; }
        public double? DriblesFinalizacao { get; set; }
        public double? ChutesGeramFinalizacao { get; set; }
        public double? FaltasSofridasFinalizacao { get; set; }
        public double? AcoesDefensivasFinalizacao { get; set; }
        public double? AcoesGeramGolGca { get; set; }
        public double? PassesGolBolaRolando { get; set; }
        public double? PassesGolBolaParada { get; set; }
        public double? DriblesGol { get; set; }
        public double? ChutesGol { get; set; }
        public double? FaltasSofridasGol { get; set; }
        public double? AcoesDefensivasGol { get; set; }

        // Posse e condução
        public double? Contatos { get; set; }
        public double? ContatosDefensivosPen { get; set; }
        public double? ContatosTercoDef { get; set; }
        public double? ContatosTercoCentral { get; set; }
        public double? ContatosTercoAtaque { get; set; }
        public double? ContatosAtaquePen { get; set; }
        public double? ContatoBolaJogo { get; set; }
        public double? TentativasDribles { get; set; }
        public double? DriblesCompletos { get; set; }
        public double? PercentualDriblesCompletos { get; set; }
        public double? DriblesInterrompidos { get; set; }
        public double? PercentualDriblesInterrompidos { get; set; }
        public double? Conducoes { get; set; }
        public double? DistanciaTotal { get; set; }
        public double? DistanciaProgressiva { get; set; }
        public double? ConducoesProgressivas { get; set; }
        public double? ConducoesTercoFinal { get; set; }
        public double? ConducoesAreaPenalti { get; set; }
        public double? PerdaDominio { get; set; }
        public double? Desarmado { get; set; }
        public double? PassesRecebidos { get; set; }
        public double? PassesProgressivosRecebidos { get; set; }

        // Defesa
        public double? TentativasDesarmes { get; set; }
        public double? DesarmesConcluidos { get; set; }
        public double? DesarmesDefensivos { get; set; }
        public double? DesarmesCentrais { get; set; }
        public double? DesarmesAtaque { get; set; }
        public double? DribladoresDesarmados { get; set; }
        public double? DribladoresDesafiados { get; set; }
        public double? PercentualDesarmeDribladores { get; set; }
        public double? DribladoresVenceram { get; set; }
        public double? Bloqueios { get; set; }
        public double? ChutesBloqueados { get; set; }
        public double? PassesBloqueadosDefesa { get; set; }
        public double? Interceptacoes { get; set; }
        public double? DesarmesInterceptacoes { get; set; }
        public double? Defesas { get; set; }
        public double? Erros { get; set; }

        // Goleiro - Defesa de Chutes
        public double? ChutesNoGolSofridos { get; set; }
        public double? GolsSofridos { get; set; }
        public double? DefesasGoleiro { get; set; }
        public double? PercentualDefesas { get; set; }
        public double? PartidasSemSofrerGol { get; set; }
        public double? GolsEsperadosPosChute { get; set; }

        // Goleiro - Pênaltis
        public double? PenaltisCausados { get; set; }
        public double? PenaltisGolsSofridos { get; set; }
        public double? PenaltisDefendidos { get; set; }
        public double? PenaltisPerdidosOponente { get; set; }

        // Goleiro - Distribuição
        public double? LancamentosCompletos { get; set; }
        public double? TentativasLancamento { get; set; }
        public double? PercentualLancamentosCompletos { get; set; }
        public double? PassesCurtosMedio { get; set; }
        public double? TentativasArremesso { get; set; }
        public double? PercentualLancamentosLongos { get; set; }
        public double? DistanciaMediaLancamentos { get; set; }
        public double? QuantidadeTirosMeta { get; set; }
        public double? PercentualTiroMetaLongo { get; set; }
        public double? DistanciaMediaTiroMeta { get; set; }

        // Goleiro - Controle Aéreo
        public double? CruzamentosEnfrentados { get; set; }
        public double? CruzamentosInterceptados { get; set; }
        public double? PercentualCruzamentosBloqueados { get; set; }
        public double? AcoesForaPequenaArea { get; set; }
        public double? DistanciaMediaAcoesForaArea { get; set; }

        // Disciplina
        public double? CartoesAmarelos { get; set; }
        public double? CartoesVermelhos { get; set; }
        public double? Impedimentos { get; set; }

        // Resumo
        public double? MinutosJogados { get; set; }

        // Dados agregados e análises
        public EstatisticasSumDto? EstatisticasAgregadas { get; set; }
        public AttackerAnalysisDto? AnaliseAtacante { get; set; }
        public MidfielderAnalysisDto? AnaliseMeioCampo { get; set; }
        public DefenseAnalysisDto? AnaliseDefensor { get; set; }
        public GoalkeeperAnalysisDto? AnaliseGoleiro { get; set; }
    }
}