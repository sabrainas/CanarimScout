using CanarinScout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping
{
    public class OfensivasMapping : IEntityTypeConfiguration<Ofensivas>
    {
        public void Configure(EntityTypeBuilder<Ofensivas> entity)
        {
            entity.HasKey(e => e.Id).HasName("gca_pkey");

            entity.ToTable("gca");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcaoDefensivaTentChutes).HasColumnName("def");
            entity.Property(e => e.AcaoDefensivaGol).HasColumnName("def_1");
            entity.Property(e => e.FaltaTentChutes).HasColumnName("fld");
            entity.Property(e => e.FaltaGol).HasColumnName("fld_1");
            entity.Property(e => e.AcaoGol).HasColumnName("gca");
            entity.Property(e => e.PassesTentChutesBolaParada).HasColumnName("passdead");
            entity.Property(e => e.GolBolaParada).HasColumnName("passdead_1");
            entity.Property(e => e.PassesTentChutes).HasColumnName("passlive");
            entity.Property(e => e.PasseGol).HasColumnName("passlive_1");
            entity.Property(e => e.AcaoCriacaoChute).HasColumnName("sca");
            entity.Property(e => e.ChutesTentChutes).HasColumnName("sh");
            entity.Property(e => e.ChuteGol).HasColumnName("sh_1");
            entity.Property(e => e.DriblesTentChutes).HasColumnName("to");
            entity.Property(e => e.DribleGol).HasColumnName("to_1");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId);
        }
    }
}
