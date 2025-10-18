using CanarinScout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping
{
    public class PossesMapping : IEntityTypeConfiguration<Posses>
    {
        public void Configure(EntityTypeBuilder<Posses> entity)
        {
            entity.HasKey(e => e.Id).HasName("possession_pkey");

            entity.ToTable("possession");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.TentativasDribles).HasColumnName("att");
            entity.Property(e => e.ContatosTercoAtaque).HasColumnName("att_3rd");
            entity.Property(e => e.ContatosAtaquePen).HasColumnName("att_pen");
            entity.Property(e => e.Conducoes).HasColumnName("carries");
            entity.Property(e => e.CarregadaAreaPenalti).HasColumnName("cpa");
            entity.Property(e => e.ContatosTercoDef).HasColumnName("def_3rd");
            entity.Property(e => e.ContatosDefensivosPen).HasColumnName("def_pen");
            entity.Property(e => e.Desarmado).HasColumnName("dis");
            entity.Property(e => e.ContatoBolaJogo).HasColumnName("live");
            entity.Property(e => e.ContatosTercoCentral).HasColumnName("mid_3rd");
            entity.Property(e => e.PerdaDominio).HasColumnName("mis");
            entity.Property(e => e.CarregadaProgressiva).HasColumnName("prgc");
            entity.Property(e => e.DistProgressivas).HasColumnName("prgdist");
            entity.Property(e => e.PassesProgressivosRecebidos).HasColumnName("prgr");
            entity.Property(e => e.PassesRecebidos).HasColumnName("rec");
            entity.Property(e => e.DriblesCompletos).HasColumnName("succ");
            entity.Property(e => e.PerDriblesCompletos).HasColumnName("succ_");
            entity.Property(e => e.DriblesInterrompidos).HasColumnName("tkld");
            entity.Property(e => e.PerDriblesInterrompidos).HasColumnName("tkld_");
            entity.Property(e => e.DistTotal).HasColumnName("totdist");
            entity.Property(e => e.Contatos).HasColumnName("touches");
            entity.Property(e => e.CarregadaTercoFinal).HasColumnName("1_3");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId);
        }
    }
}