using CanarinScout.Domain.Entities;
using CanarinScout.WebApi;
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

            entity.HasOne(e => e.Jogador)
                  .WithMany()
                  .HasForeignKey(e => e.PlayerId);

            entity.HasOne(e => e.Defensivas)
                  .WithOne()
                  .HasForeignKey<Defensivas>(d => d.PlayerId);

            entity.HasOne(e => e.Ofensivas)
                  .WithOne()
                  .HasForeignKey<Ofensivas>(o => o.PlayerId);

            entity.HasOne(e => e.Passes)
                  .WithOne()
                  .HasForeignKey<Passes>(p => p.PlayerId);

            entity.HasOne(e => e.Posses)
                  .WithOne()
                  .HasForeignKey<Posses>(p => p.PlayerId);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.MinutosJogados).HasColumnName("min");
            entity.Property(e => e.Gols).HasColumnName("gls");
            entity.Property(e => e.Assistencias).HasColumnName("ast");
            entity.Property(e => e.CartaoAmarelo).HasColumnName("crdy");
            entity.Property(e => e.CartaoVermelho).HasColumnName("crdr");
        }
    }
}
