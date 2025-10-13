using CanarinScout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping
{
    public class DefensivasMapping : IEntityTypeConfiguration<Defensivas>
    {
        public void Configure(EntityTypeBuilder<Defensivas> entity)
        {
            entity.ToTable("defense");
            entity.HasKey(e => e.Id).HasName("id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.TentativaDesarmes).HasColumnName("tkl");
            entity.Property(e => e.Defesas).HasColumnName("clr");
            entity.Property(e => e.Competicao).HasColumnName("comp");
            entity.Property(e => e.DesarmesCentrais).HasColumnName("mid_3rd");
            entity.Property(e => e.DesarmesAtaque).HasColumnName("att_3rd");
            entity.Property(e => e.DesarmesDefensivos).HasColumnName("def_3rd");
            entity.Property(e => e.DesarmesConcluidos).HasColumnName("tklw");
            entity.Property(e => e.PassesBloqueados).HasColumnName("blocks");
            entity.Property(e => e.Interceptacoes).HasColumnName("int");
            entity.Property(e => e.DesDriblador).HasColumnName("att");
            entity.Property(e => e.Bloqueios).HasColumnName("blocks");
            entity.Property(e => e.ChutesBloqueados).HasColumnName("sh");
            entity.Property(e => e.PassesBloqueados).HasColumnName("pass");
            entity.Property(e => e.Erros).HasColumnName("err");
            entity.Property(e => e.PerDesDriblador).HasColumnName("tkl_");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId);
        }
    }
}
