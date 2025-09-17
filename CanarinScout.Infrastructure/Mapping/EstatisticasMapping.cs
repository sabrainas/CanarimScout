using CanarinScout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping
{
    public class EstatisticasMapping : IEntityTypeConfiguration<Estatisticas>
    {
        public void Configure(EntityTypeBuilder<Estatisticas> entity)
        {
            entity.HasKey(e => e.Id).HasName("summary_pkey");
            entity.ToTable("summary");

            entity.HasOne(e => e.Ofensivas)
                  .WithOne()
                  .HasForeignKey<Estatisticas>(e => e.OfensivasId);

            entity.HasOne(e => e.Passes)
                  .WithOne()
                  .HasForeignKey<Estatisticas>(e => e.PassesId);

            entity.HasOne(e => e.Posses)
                  .WithOne()
                  .HasForeignKey<Estatisticas>(e => e.PossesId);

            entity.HasOne(e => e.Defensivas)
                  .WithOne()
                  .HasForeignKey<Estatisticas>(e => e.DefensivasId);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MinutosJogados).HasColumnName("min");
            entity.Property(e => e.Gols).HasColumnName("gls");
            entity.Property(e => e.Assistencias).HasColumnName("ast");
            entity.Property(e => e.CartaoAmarelo).HasColumnName("crdy");
            entity.Property(e => e.CartaoVermelho).HasColumnName("crdr");
        }
    }
}
