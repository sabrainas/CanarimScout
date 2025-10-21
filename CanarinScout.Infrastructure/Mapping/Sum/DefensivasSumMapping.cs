using CanarinScout.Domain.Entities.Sum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Sum
{
    public class DefensivasSumMapping : IEntityTypeConfiguration<DefensivasSum>
    {
        public void Configure(EntityTypeBuilder<DefensivasSum> entity)
        {
            entity.HasKey(e => e.PlayerId).HasName("defense_sum_pkey");

            entity.ToTable("defense_sum");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.DesarmesConcluidos).HasColumnName("total_tkl");
            entity.Property(e => e.DesarmesDefensivos).HasColumnName("total_def_3rd");
            entity.Property(e => e.DesarmesCentrais).HasColumnName("total_mid_3rd");
            entity.Property(e => e.DesarmesAtaque).HasColumnName("total_att_3rd");
            entity.Property(e => e.TentativaDesarmes).HasColumnName("total_att");
            entity.Property(e => e.PerDesDriblador).HasColumnName("total_tkl_");
            entity.Property(e => e.DesDriblador).HasColumnName("total_lost");
            entity.Property(e => e.Bloqueios).HasColumnName("total_blocks");
            entity.Property(e => e.ChutesBloqueados).HasColumnName("total_sh");
            entity.Property(e => e.PassesBloqueados).HasColumnName("total_pass");
            entity.Property(e => e.Interceptacoes).HasColumnName("total_int");
            entity.Property(e => e.DesarmesInterceptacoes).HasColumnName("total_tkl_int");
            entity.Property(e => e.Defesas).HasColumnName("total_clr");
            entity.Property(e => e.Erros).HasColumnName("total_err");

            entity.Ignore(e => e.Jogador);
        }
    }
}
