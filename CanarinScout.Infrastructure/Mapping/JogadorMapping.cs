using CanarinScout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping
{
    public class JogadorMapping : IEntityTypeConfiguration<Jogador>
    {
        public void Configure(EntityTypeBuilder<Jogador> entity)
        {
            entity.HasKey(e => e.Id).HasName("player_pkey");
            entity.ToTable("player");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome).HasColumnName("full_name");
            entity.Property(e => e.Posicao).HasColumnName("position");
            entity.Property(e => e.PeDominante).HasColumnName("footed");
            entity.Property(e => e.Altura).HasColumnName("height_cm");
            entity.Property(e => e.Peso).HasColumnName("weight_kg");
            entity.Property(e => e.DtNascimento).HasColumnName("birth_date");
            entity.Property(e => e.Selecao).HasColumnName("national_team");
            entity.Property(e => e.TimeAtual).HasColumnName("club");
            entity.Property(e => e.Foto).HasColumnName("photo_url");
        }
    }
}
