using CanarinScout.Domain.Entities.Sum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Sum
{
    public class OfensivasSumMapping : IEntityTypeConfiguration<OfensivasSum>
    {
        public void Configure(EntityTypeBuilder<OfensivasSum> entity)
        {
            entity.HasKey(e => e.PlayerId).HasName("gca_sum_pkey");

            entity.ToTable("gca_sum");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.AcaoCriacaoChute).HasColumnName("total_sca");
            entity.Property(e => e.PassesTentChutes).HasColumnName("total_passlive");
            entity.Property(e => e.PassesTentChutesBolaParada).HasColumnName("total_passdead");
            entity.Property(e => e.DriblesTentChutes).HasColumnName("total_to");
            entity.Property(e => e.ChutesTentChutes).HasColumnName("total_sh");
            entity.Property(e => e.FaltaTentChutes).HasColumnName("total_fld");
            entity.Property(e => e.AcaoDefensivaTentChutes).HasColumnName("total_def");
            entity.Property(e => e.AcaoGol).HasColumnName("total_gca");
            entity.Property(e => e.PasseGol).HasColumnName("total_passlive_1");
            entity.Property(e => e.GolBolaParada).HasColumnName("total_passdead_1");
            entity.Property(e => e.DribleGol).HasColumnName("total_to_1");
            entity.Property(e => e.ChuteGol).HasColumnName("total_sh_1");
            entity.Property(e => e.FaltaGol).HasColumnName("total_fld_1");
            entity.Property(e => e.AcaoDefensivaGol).HasColumnName("total_def_1");

            entity.Ignore(e => e.Jogador);
        }
    }
}
