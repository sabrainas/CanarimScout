using CanarinScout.Domain.Entities.Media;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Media
{
    public class GoleirosMediaMapping : IEntityTypeConfiguration<GoleiroMedia>
    {
        public void Configure(EntityTypeBuilder<GoleiroMedia> entity)
        {
            entity.ToTable("goalkeeper_stats_agg");

            entity.HasKey(e => e.PlayerId);
            entity.Property(e => e.PlayerId).HasColumnName("player_id").IsRequired();

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.MinutosJogados).HasColumnName("avg_min");
            entity.Property(e => e.ChutesNoGol).HasColumnName("avg_sota");
            entity.Property(e => e.GolSofridos).HasColumnName("avg_ga");
            entity.Property(e => e.Defesas).HasColumnName("avg_saves");
            entity.Property(e => e.PerDefesas).HasColumnName("avg_save_pct");
            entity.Property(e => e.PartidaSemGol).HasColumnName("avg_cs");
            entity.Property(e => e.GolsEsperados).HasColumnName("avg_psxg");
            entity.Property(e => e.PenaltiSofrido).HasColumnName("avg_pkatt");
            entity.Property(e => e.PenaltiCausados).HasColumnName("avg_pka");
            entity.Property(e => e.PenaltiDefendidos).HasColumnName("avg_pksv");
            entity.Property(e => e.PenaltiErrado).HasColumnName("avg_pkm");
            entity.Property(e => e.PassesConcluidos).HasColumnName("avg_cmp");
            entity.Property(e => e.TentativasPasses).HasColumnName("avg_att");
            entity.Property(e => e.PerPassesConcluidos).HasColumnName("avg_cmp_pct");
            entity.Property(e => e.QtdTirosDeMeta).HasColumnName("avg_att_gk");
            entity.Property(e => e.LancamentoTotal).HasColumnName("avg_thr");
            entity.Property(e => e.PerLancamentosCompletos).HasColumnName("avg_launch_pct");
            entity.Property(e => e.DistMediaLancamentos).HasColumnName("avg_avglen");
            entity.Property(e => e.TentativasLancamentos).HasColumnName("avg_att_1");
            entity.Property(e => e.PerTiroDeMetas).HasColumnName("avg_launch__1");
            entity.Property(e => e.DistMediaTiroDeMeta).HasColumnName("avg_avglen_1");
            entity.Property(e => e.CruzamentosEnfrentados).HasColumnName("avg_opp");
            entity.Property(e => e.CruzamentoBloqueado).HasColumnName("avg_stp");
            entity.Property(e => e.PerCruzamentoBloqueado).HasColumnName("avg_stp_pct");
            entity.Property(e => e.AcoesForaDaPequenaArea).HasColumnName("avg_opa");
            entity.Property(e => e.DistMedia).HasColumnName("avg_avgdist");

            entity.HasIndex(e => e.PlayerId);
        }
    }
}
