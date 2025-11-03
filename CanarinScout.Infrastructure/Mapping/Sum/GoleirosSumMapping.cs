using CanarinScout.Domain.Entities.Sum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Sum
{
    public class GoleirosSumMapping : IEntityTypeConfiguration<GoleirosSum>
    {
        public void Configure(EntityTypeBuilder<GoleirosSum> entity)
        {
            entity.ToTable("goalkeeper_sum");

            entity.HasKey(e => e.PlayerId);
            entity.Property(e => e.PlayerId).HasColumnName("player_id").IsRequired();

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.ChutesNoGol).HasColumnName("total_sota");
            entity.Property(e => e.GolSofridos).HasColumnName("total_ga");
            entity.Property(e => e.Defesas).HasColumnName("total_saves");
            entity.Property(e => e.PerDefesas).HasColumnName("total_save_");
            entity.Property(e => e.PartidaSemGol).HasColumnName("total_cs");
            entity.Property(e => e.GolsEsperados).HasColumnName("total_psxg");
            entity.Property(e => e.PenaltiSofrido).HasColumnName("total_pkatt");
            entity.Property(e => e.PenaltiCausados).HasColumnName("total_pka");
            entity.Property(e => e.PenaltiDefendidos).HasColumnName("total_pksv");
            entity.Property(e => e.PenaltiErrado).HasColumnName("total_pkm");
            entity.Property(e => e.PassesConcluidos).HasColumnName("total_cmp");
            entity.Property(e => e.TentativasPasses).HasColumnName("total_att");
            entity.Property(e => e.PerPassesConcluidos).HasColumnName("total_cmp_");
            entity.Property(e => e.QtdTirosDeMeta).HasColumnName("total_att_gk_");
            entity.Property(e => e.LancamentoTotal).HasColumnName("total_thr");
            entity.Property(e => e.PerLancamentosCompletos).HasColumnName("total_launch_");
            entity.Property(e => e.DistMediaLancamentos).HasColumnName("total_avglen");
            entity.Property(e => e.TentativasLancamentos).HasColumnName("total_att_1");
            entity.Property(e => e.DistMediaTiroDeMeta).HasColumnName("total_avglen_1");
            entity.Property(e => e.CruzamentosEnfrentados).HasColumnName("total_opp");
            entity.Property(e => e.CruzamentoBloqueado).HasColumnName("total_stp");
            entity.Property(e => e.PerCruzamentoBloqueado).HasColumnName("total_stp_");
            entity.Property(e => e.AcoesForaDaPequenaArea).HasColumnName("total_opa");
            entity.Property(e => e.DistMedia).HasColumnName("total_avgdist");

            entity.HasIndex(e => e.PlayerId);
        }
    }
}
