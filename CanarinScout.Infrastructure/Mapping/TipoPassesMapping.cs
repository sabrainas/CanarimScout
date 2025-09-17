using CanarinScout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping
{
    public class TiposPassesMapping : IEntityTypeConfiguration<TipoPasses>
    {
        public void Configure(EntityTypeBuilder<TipoPasses> entity)
        {
            entity.HasKey(e => e.Id).HasName("player_passing_types_pkey");

            entity.ToTable("player_passing_types");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('player_passing_types_id_seq'::regclass)")
                .HasColumnName("id");

            entity.Property(e => e.PassesBloqueados).HasColumnName("blocks");
            entity.Property(e => e.LancamentoEscanteio).HasColumnName("ck");
            entity.Property(e => e.Cruzamentos).HasColumnName("crs");
            entity.Property(e => e.PassesBolasParadas).HasColumnName("dead");
            entity.Property(e => e.PassesAPartirDeFaltas).HasColumnName("fk");
            entity.Property(e => e.EscanteiosDentroArea).HasColumnName("in");
            entity.Property(e => e.PassesEmJogo).HasColumnName("live");
            entity.Property(e => e.PassesImpedidos).HasColumnName("off");
            entity.Property(e => e.EscanteioForaArea).HasColumnName("out");
            entity.Property(e => e.EscanteioReto).HasColumnName("str");
            entity.Property(e => e.PassesDeReversao).HasColumnName("sw");
            entity.Property(e => e.PassesEntreLinhaDefesa).HasColumnName("tb");
            entity.Property(e => e.LancamentoLateral).HasColumnName("ti");

            entity.Property(e => e.PassesId).HasColumnName("player_id");
        }
    }
}
