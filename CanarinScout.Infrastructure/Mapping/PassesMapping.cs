using CanarinScout.Domain.Entities;
using CanarinScout.WebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping
{
    public class PassesMapping : IEntityTypeConfiguration<Passes>
    {
        public void Configure(EntityTypeBuilder<Passes> entity)
        {
            entity.HasKey(e => e.Id).HasName("player_passing_pkey1");

            entity.ToTable("player_passing");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('player_passing_id_seq1'::regclass)")
                .HasColumnName("id");

            entity.Property(e => e.PassesConcluidos).HasColumnName("cmp");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.TentativasPasses).HasColumnName("att");
            entity.Property(e => e.DistanciaTotal).HasColumnName("totdist");
            entity.Property(e => e.DistPassesProgressivo).HasColumnName("prgdist");
            entity.Property(e => e.QtdPassesProgressivos).HasColumnName("prgp");

            entity.Property(e => e.PassesCurtosTentados).HasColumnName("att_1");
            entity.Property(e => e.PerPassesConcluidos).HasColumnName("cmp_");
            entity.Property(e => e.PassesCurtosConcluidos).HasColumnName("cmp_1");
            entity.Property(e => e.PerPassesCurtosConcluidos).HasColumnName("cmp__1");
            entity.Property(e => e.PassesMediosTentados).HasColumnName("att_2");
            entity.Property(e => e.PassesMediosConcluidos).HasColumnName("cmp_2");
            entity.Property(e => e.PerPassesMediosTentados).HasColumnName("cmp__2");
            entity.Property(e => e.PassesLongosTentados).HasColumnName("att_3");
            entity.Property(e => e.PassesLongosConcluidos).HasColumnName("cmp_3");
            entity.Property(e => e.PerPassesLongosTentados).HasColumnName("cmp__3");

            entity.Property(e => e.Assistencia).HasColumnName("ast");
            entity.Property(e => e.XAG).HasColumnName("xag");
            entity.Property(e => e.XA).HasColumnName("xa");

            entity.Property(e => e.PassesImportantes).HasColumnName("kp");
            entity.Property(e => e.PassesPeqAreaAdv).HasColumnName("ppa");
            entity.Property(e => e.PassesAreaAdv).HasColumnName("1_3");
            entity.Property(e => e.CruzamentoPeqArea).HasColumnName("crspa");
            
            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId);
            
            entity.HasOne(p => p.Tipo)
                  .WithOne(tp => tp.Passes)
                  .HasForeignKey<TipoPasses>(tp => tp.PassesId);
        }
    }
}
