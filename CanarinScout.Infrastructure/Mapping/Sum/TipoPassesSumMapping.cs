using CanarinScout.Domain.Entities.Sum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Sum
{
    public class TipoPassesSumMapping : IEntityTypeConfiguration<TipoPassesSum>
    {
        public void Configure(EntityTypeBuilder<TipoPassesSum> entity)
        {
            entity.HasKey(e => e.PlayerId).HasName("player_passing_types_sum_pkey");

            entity.ToTable("player_passing_types_sum");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.TentativasPasses).HasColumnName("total_att");
            entity.Property(e => e.PassesEmJogo).HasColumnName("total_live");
            entity.Property(e => e.PassesBolasParadas).HasColumnName("total_dead");
            entity.Property(e => e.PassesAPartirDeFaltas).HasColumnName("total_fk");
            entity.Property(e => e.PassesEntreLinhaDefesa).HasColumnName("total_tb");
            entity.Property(e => e.PassesDeReversao).HasColumnName("total_sw");
            entity.Property(e => e.Cruzamentos).HasColumnName("total_crs");
            entity.Property(e => e.LancamentoLateral).HasColumnName("total_ti");
            entity.Property(e => e.LancamentoEscanteio).HasColumnName("total_ck");
            entity.Property(e => e.EscanteiosDentroArea).HasColumnName("total_ck_in");
            entity.Property(e => e.EscanteioForaArea).HasColumnName("total_ck_out");
            entity.Property(e => e.EscanteioReto).HasColumnName("total_ck_str");
            entity.Property(e => e.PassesConcluidos).HasColumnName("total_cmp");
            entity.Property(e => e.PassesImpedidos).HasColumnName("total_off");
            entity.Property(e => e.PassesBloqueados).HasColumnName("total_blocks");

            entity.Ignore(e => e.Jogador);
            entity.Ignore(e => e.Passes);
        }
    }
}
