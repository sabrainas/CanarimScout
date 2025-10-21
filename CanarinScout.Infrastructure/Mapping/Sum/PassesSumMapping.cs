using CanarinScout.Domain.Entities.Sum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Sum
{
    public class PassesSumMapping : IEntityTypeConfiguration<PassesSum>
    {
        public void Configure(EntityTypeBuilder<PassesSum> entity)
        {
            entity.HasKey(e => e.PlayerId).HasName("player_passing_sum_pkey");

            entity.ToTable("player_passing_sum");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.PassesConcluidos).HasColumnName("total_cmp");
            entity.Property(e => e.TentativasPasses).HasColumnName("total_att");
            entity.Property(e => e.PerPassesConcluidos).HasColumnName("total_cmp_");
            entity.Property(e => e.DistanciaTotal).HasColumnName("total_totdist");
            entity.Property(e => e.DistPassesProgressivo).HasColumnName("total_prgdist");
            entity.Property(e => e.PassesCurtosConcluidos).HasColumnName("total_cmp_1");
            entity.Property(e => e.PassesCurtosTentados).HasColumnName("total_att_1");
            entity.Property(e => e.PerPassesCurtosConcluidos).HasColumnName("total_cmp__1");
            entity.Property(e => e.PassesMediosConcluidos).HasColumnName("total_cmp_2");
            entity.Property(e => e.PassesMediosTentados).HasColumnName("total_att_2");
            entity.Property(e => e.PerPassesMediosTentados).HasColumnName("total_cmp__2");
            entity.Property(e => e.PassesLongosConcluidos).HasColumnName("total_cmp_3");
            entity.Property(e => e.PassesLongosTentados).HasColumnName("total_att_3");
            entity.Property(e => e.PerPassesLongosTentados).HasColumnName("total_cmp__3");
            entity.Property(e => e.Assistencia).HasColumnName("total_ast");
            entity.Property(e => e.XAG).HasColumnName("total_xag");
            entity.Property(e => e.XA).HasColumnName("total_xa");
            entity.Property(e => e.PassesImportantes).HasColumnName("total_kp");
            entity.Property(e => e.PassesAreaAdv).HasColumnName("total_1_3");
            entity.Property(e => e.PassesPeqAreaAdv).HasColumnName("total_ppa");
            entity.Property(e => e.CruzamentoPeqArea).HasColumnName("total_crspa");
            entity.Property(e => e.QtdPassesProgressivos).HasColumnName("total_prgp");

            entity.Ignore(e => e.Jogador);
            entity.Ignore(p => p.Tipo);
        }
    }
}
