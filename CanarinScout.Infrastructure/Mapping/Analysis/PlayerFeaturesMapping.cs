using CanarinScout.Domain.Entities.Analysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Analysis
{
    public class PlayerFeaturesMapping : IEntityTypeConfiguration<PlayerFeatures>
    {
        public void Configure(EntityTypeBuilder<PlayerFeatures> entity)
        {
            entity.ToTable("player_features");
            entity.HasKey(e => e.Id).HasName("id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome).HasColumnName("player_name");
            entity.Property(e => e.Posicao).HasColumnName("position");
            entity.Property(e => e.PeDominante).HasColumnName("footed");
            entity.Property(e => e.Altura).HasColumnName("height_cm");
            entity.Property(e => e.Peso).HasColumnName("weight_kg");
            entity.Property(e => e.DtNascimento).HasColumnName("birth_date");
            entity.Property(e => e.Selecao).HasColumnName("national_team");
            entity.Property(e => e.Clube).HasColumnName("club");
            entity.Property(e => e.Foto).HasColumnName("photo_url");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");

            entity.Property(p => p.Gols).HasColumnName("summary_avg_gls");
            entity.Property(p => p.Chutes).HasColumnName("summary_avg_sh");
            entity.Property(p => p.ChutesNoAlvo).HasColumnName("summary_avg_sot");
            entity.Property(p => p.GolsEsperados).HasColumnName("summary_avg_xg");
            entity.Property(p => p.GolsEsperadosSemPenaltis).HasColumnName("summary_avg_npxg");
            entity.Property(p => p.AssistenciasSumario).HasColumnName("summary_avg_ast");
            entity.Property(p => p.XagSumario).HasColumnName("summary_avg_xag");
            entity.Property(p => p.AcoesGeramGolSumario).HasColumnName("summary_avg_gca");
            entity.Property(p => p.AcoesGeramChuteSumario).HasColumnName("summary_avg_sca");
            entity.Property(p => p.MinutosJogados).HasColumnName("summary_avg_min");

            // === PP (Passes) ===
            entity.Property(p => p.PassesConcluidos).HasColumnName("pp_avg_cmp");
            entity.Property(p => p.PassesTentados).HasColumnName("pp_avg_att");
            entity.Property(p => p.PercentualPassesConcluidos).HasColumnName("pp_avg_cmp_pct");
            entity.Property(p => p.DistanciaTotalPasses).HasColumnName("pp_avg_totdist");
            entity.Property(p => p.DistanciaProgressivaPasses).HasColumnName("pp_avg_prgdist");
            entity.Property(p => p.PassesProgressivos).HasColumnName("pp_avg_prgp");

            entity.Property(p => p.PassesCurtosConcluidos).HasColumnName("pp_avg_cmp_short");
            entity.Property(p => p.PassesCurtosTentados).HasColumnName("pp_avg_att_short");
            entity.Property(p => p.PercentualPassesCurtosConcluidos).HasColumnName("pp_avg_cmp_pct_short");

            entity.Property(p => p.PassesMediosConcluidos).HasColumnName("pp_avg_cmp_medium");
            entity.Property(p => p.PassesMediosTentados).HasColumnName("pp_avg_att_medium");
            entity.Property(p => p.PercentualPassesMediosConcluidos).HasColumnName("pp_avg_cmp_pct_medium");

            entity.Property(p => p.PassesLongosConcluidos).HasColumnName("pp_avg_cmp_long");
            entity.Property(p => p.PassesLongosTentados).HasColumnName("pp_avg_att_long");
            entity.Property(p => p.PercentualPassesLongosConcluidos).HasColumnName("pp_avg_cmp_pct_long");

            entity.Property(p => p.AssistenciasPasse).HasColumnName("pp_avg_ast");
            entity.Property(p => p.XagPasse).HasColumnName("pp_avg_xag");
            entity.Property(p => p.AssistenciasEsperadas).HasColumnName("pp_avg_xa");
            entity.Property(p => p.PassesChave).HasColumnName("pp_avg_kp");
            entity.Property(p => p.PassesTercoFinal).HasColumnName("pp_avg_pass_final_third");
            entity.Property(p => p.PassesPequenaArea).HasColumnName("pp_avg_ppa");
            entity.Property(p => p.CruzamentosPequenaArea).HasColumnName("pp_avg_crspa");

            // === PPT (Tipos de Passe) ===
            entity.Property(p => p.PassesTentadosTipo).HasColumnName("ppt_avg_att");
            entity.Property(p => p.PassesBolaRolando).HasColumnName("ppt_avg_live");
            entity.Property(p => p.PassesBolaParada).HasColumnName("ppt_avg_dead");
            entity.Property(p => p.PassesDeFaltas).HasColumnName("ppt_avg_fk");
            entity.Property(p => p.PassesEntreLinhas).HasColumnName("ppt_avg_tb");
            entity.Property(p => p.PassesReversao).HasColumnName("ppt_avg_sw");
            entity.Property(p => p.CruzamentosTipo).HasColumnName("ppt_avg_crs");
            entity.Property(p => p.LateraisCobradas).HasColumnName("ppt_avg_ti");
            entity.Property(p => p.EscanteiosBatidos).HasColumnName("ppt_avg_ck");
            entity.Property(p => p.EscanteiosDentroArea).HasColumnName("ppt_avg_in");
            entity.Property(p => p.EscanteiosForaArea).HasColumnName("ppt_avg_out");
            entity.Property(p => p.EscanteiosRetos).HasColumnName("ppt_avg_str");
            entity.Property(p => p.PassesConcluidosTipo).HasColumnName("ppt_avg_cmp");
            entity.Property(p => p.PassesImpedimento).HasColumnName("ppt_avg_off");
            entity.Property(p => p.PassesBloqueados).HasColumnName("ppt_avg_blocks");

            // === GCA (Criação de jogadas) ===
            entity.Property(p => p.MinutosJogadosGca).HasColumnName("gca_avg_min");
            entity.Property(p => p.AcoesGeramChuteGca).HasColumnName("gca_avg_sca");
            entity.Property(p => p.PassesFinalizacaoBolaRolando).HasColumnName("gca_avg_passlive");
            entity.Property(p => p.PassesFinalizacaoBolaParada).HasColumnName("gca_avg_passdead");
            entity.Property(p => p.DriblesFinalizacao).HasColumnName("gca_avg_to");
            entity.Property(p => p.ChutesGeramFinalizacao).HasColumnName("gca_avg_sh");
            entity.Property(p => p.FaltasSofridasFinalizacao).HasColumnName("gca_avg_fld");
            entity.Property(p => p.AcoesDefensivasFinalizacao).HasColumnName("gca_avg_def");
            entity.Property(p => p.AcoesGeramGolGca).HasColumnName("gca_avg_gca");
            entity.Property(p => p.PassesGolBolaRolando).HasColumnName("gca_avg_passlive_1");
            entity.Property(p => p.PassesGolBolaParada).HasColumnName("gca_avg_passdead_1");
            entity.Property(p => p.DriblesGol).HasColumnName("gca_avg_to_1");
            entity.Property(p => p.ChutesGol).HasColumnName("gca_avg_sh_1");
            entity.Property(p => p.FaltasSofridasGol).HasColumnName("gca_avg_fld_1");
            entity.Property(p => p.AcoesDefensivasGol).HasColumnName("gca_avg_def_1");

            // === POS (Posse e condução) ===
            entity.Property(p => p.Contatos).HasColumnName("pos_avg_touches");
            entity.Property(p => p.ContatosDefensivosPen).HasColumnName("pos_avg_def_pen");
            entity.Property(p => p.ContatosTercoDef).HasColumnName("pos_avg_def_3rd");
            entity.Property(p => p.ContatosTercoCentral).HasColumnName("pos_avg_mid_3rd");
            entity.Property(p => p.ContatosTercoAtaque).HasColumnName("pos_avg_att_3rd");
            entity.Property(p => p.ContatosAtaquePen).HasColumnName("pos_avg_att_pen");
            entity.Property(p => p.ContatoBolaJogo).HasColumnName("pos_avg_live");
            entity.Property(p => p.TentativasDribles).HasColumnName("pos_avg_att");
            entity.Property(p => p.DriblesCompletos).HasColumnName("pos_avg_succ");
            entity.Property(p => p.PercentualDriblesCompletos).HasColumnName("pos_avg_succ_pct");
            entity.Property(p => p.DriblesInterrompidos).HasColumnName("pos_avg_tkld");
            entity.Property(p => p.PercentualDriblesInterrompidos).HasColumnName("pos_avg_tkld_pct");
            entity.Property(p => p.Conducoes).HasColumnName("pos_avg_carries");
            entity.Property(p => p.DistanciaTotal).HasColumnName("pos_avg_totdist");
            entity.Property(p => p.DistanciaProgressiva).HasColumnName("pos_avg_prgdist");
            entity.Property(p => p.ConducoesProgressivas).HasColumnName("pos_avg_prgc");
            entity.Property(p => p.ConducoesTercoFinal).HasColumnName("pos_avg_1_3");
            entity.Property(p => p.ConducoesAreaPenalti).HasColumnName("pos_avg_cpa");
            entity.Property(p => p.PerdaDominio).HasColumnName("pos_avg_mis");
            entity.Property(p => p.Desarmado).HasColumnName("pos_avg_dis");
            entity.Property(p => p.PassesRecebidos).HasColumnName("pos_avg_rec");
            entity.Property(p => p.PassesProgressivosRecebidos).HasColumnName("pos_avg_prgr");

            // === DEFENSE (Defesa) ===
            entity.Property(p => p.TentativasDesarmes).HasColumnName("defense_avg_tkl");
            entity.Property(p => p.DesarmesConcluidos).HasColumnName("defense_avg_tklw");
            entity.Property(p => p.DesarmesDefensivos).HasColumnName("defense_avg_def_3rd");
            entity.Property(p => p.DesarmesCentrais).HasColumnName("defense_avg_mid_3rd");
            entity.Property(p => p.DesarmesAtaque).HasColumnName("defense_avg_att_3rd");
            entity.Property(p => p.DribladoresDesarmados).HasColumnName("defense_avg_tkl_1");
            entity.Property(p => p.DribladoresDesafiados).HasColumnName("defense_avg_att");
            entity.Property(p => p.PercentualDesarmeDribladores).HasColumnName("defense_avg_tkl_pct");
            entity.Property(p => p.DribladoresVenceram).HasColumnName("defense_avg_lost");
            entity.Property(p => p.Bloqueios).HasColumnName("defense_avg_blocks");
            entity.Property(p => p.ChutesBloqueados).HasColumnName("defense_avg_shots");
            entity.Property(p => p.PassesBloqueadosDefesa).HasColumnName("defense_avg_pass");
            entity.Property(p => p.Interceptacoes).HasColumnName("defense_avg_int");
            entity.Property(p => p.DesarmesInterceptacoes).HasColumnName("defense_avg_tkl_int");
            entity.Property(p => p.Defesas).HasColumnName("defense_avg_clr");
            entity.Property(p => p.Erros).HasColumnName("defense_avg_err");

            // === GS (Goleiro - Defesa de Chutes) ===
            entity.Property(p => p.ChutesNoGolSofridos).HasColumnName("gs_avg_sota");
            entity.Property(p => p.GolsSofridos).HasColumnName("gs_avg_ga");
            entity.Property(p => p.DefesasGoleiro).HasColumnName("gs_avg_saves");
            entity.Property(p => p.PercentualDefesas).HasColumnName("gs_avg_save_pct");
            entity.Property(p => p.PartidasSemSofrerGol).HasColumnName("gs_avg_cs");
            entity.Property(p => p.GolsEsperadosPosChute).HasColumnName("gs_avg_psxg");

            // === GS (Goleiro - Pênaltis) ===
            entity.Property(p => p.PenaltisCausados).HasColumnName("gs_avg_pkatt");
            entity.Property(p => p.PenaltisGolsSofridos).HasColumnName("gs_avg_pka");
            entity.Property(p => p.PenaltisDefendidos).HasColumnName("gs_avg_pksv");
            entity.Property(p => p.PenaltisPerdidosOponente).HasColumnName("gs_avg_pkm");

            // === GS (Goleiro - Distribuição) ===
            entity.Property(p => p.LancamentosCompletos).HasColumnName("gs_avg_cmp");
            entity.Property(p => p.TentativasLancamento).HasColumnName("gs_avg_att");
            entity.Property(p => p.PercentualLancamentosCompletos).HasColumnName("gs_avg_cmp_pct");
            entity.Property(p => p.PassesCurtosMedio).HasColumnName("gs_avg_att_gk");
            entity.Property(p => p.TentativasArremesso).HasColumnName("gs_avg_thr");
            entity.Property(p => p.PercentualLancamentosLongos).HasColumnName("gs_avg_launch_pct");
            entity.Property(p => p.DistanciaMediaLancamentos).HasColumnName("gs_avg_avglen");
            entity.Property(p => p.QuantidadeTirosMeta).HasColumnName("gs_avg_att_1");
            entity.Property(p => p.PercentualTiroMetaLongo).HasColumnName("gs_avg_launch_1");
            entity.Property(p => p.DistanciaMediaTiroMeta).HasColumnName("gs_avg_avglen_1");

            // === GS (Goleiro - Controle Aéreo) ===
            entity.Property(p => p.CruzamentosEnfrentados).HasColumnName("gs_avg_opp");
            entity.Property(p => p.CruzamentosInterceptados).HasColumnName("gs_avg_stp");
            entity.Property(p => p.PercentualCruzamentosBloqueados).HasColumnName("gs_avg_stp_pct");
            entity.Property(p => p.AcoesForaPequenaArea).HasColumnName("gs_avg_opa");
            entity.Property(p => p.DistanciaMediaAcoesForaArea).HasColumnName("gs_avg_avgdist");

            // === MISC (Disciplina) ===
            entity.Property(p => p.CartoesAmarelos).HasColumnName("misc_avg_crdy");
            entity.Property(p => p.CartoesVermelhos).HasColumnName("misc_avg_crdr");
            entity.Property(p => p.Impedimentos).HasColumnName("misc_avg_off");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId);
        }
    }
}