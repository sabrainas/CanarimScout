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

            entity.HasOne(e => e.Jogador)
                  .WithMany()
                  .HasForeignKey(e => e.PlayerId)
                  .HasPrincipalKey(j => j.PlayerId);

            entity.HasOne(e => e.Defensivas)
                  .WithOne()
                  .HasForeignKey<Defensivas>(d => d.Id)
                  .HasPrincipalKey<Estatisticas>(e => e.Id);

            entity.HasOne(e => e.Ofensivas)
                  .WithOne()
                  .HasForeignKey<Ofensivas>(o => o.Id)
                  .HasPrincipalKey<Estatisticas>(e => e.Id);

            entity.HasOne(e => e.Passes)
                  .WithOne()
                  .HasForeignKey<Passes>(p => p.Id)
                  .HasPrincipalKey<Estatisticas>(e => e.Id);

            entity.HasOne(e => e.Posses)
                  .WithOne()
                  .HasForeignKey<Posses>(p => p.Id)
                  .HasPrincipalKey<Estatisticas>(e => e.Id);

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataJogo).HasColumnName("date");
            entity.Property(e => e.DiaJogo).HasColumnName("day");
            entity.Property(e => e.Competicao).HasColumnName("comp");
            entity.Property(e => e.Partida).HasColumnName("round");
            entity.Property(e => e.Local).HasColumnName("venue");
            entity.Property(e => e.ResultadoPartida).HasColumnName("result");
            entity.Property(e => e.TimeAtual).HasColumnName("squad");
            entity.Property(e => e.Oponente).HasColumnName("opponent");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.MinutosJogados).HasColumnName("min");
            entity.Property(e => e.Gols).HasColumnName("gls");
            entity.Property(e => e.Assistencias).HasColumnName("ast");
            entity.Property(e => e.CartaoAmarelo).HasColumnName("crdy");
            entity.Property(e => e.CartaoVermelho).HasColumnName("crdr");
        }
    }
}