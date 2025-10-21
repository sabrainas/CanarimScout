using CanarinScout.Domain.Entities.Sum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Sum
{
    public class PossesSumMapping : IEntityTypeConfiguration<PossesSum>
    {
        public void Configure(EntityTypeBuilder<PossesSum> entity)
        {
            entity.HasKey(e => e.PlayerId).HasName("possession_sum_pkey");

            entity.ToTable("possession_sum");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.Contatos).HasColumnName("total_touches");
            entity.Property(e => e.ContatosDefensivosPen).HasColumnName("total_def_pen");
            entity.Property(e => e.ContatosTercoDef).HasColumnName("total_def_3rd");
            entity.Property(e => e.ContatosTercoCentral).HasColumnName("total_mid_3rd");
            entity.Property(e => e.ContatosTercoAtaque).HasColumnName("total_att_3rd");
            entity.Property(e => e.ContatosAtaquePen).HasColumnName("total_att_pen");
            entity.Property(e => e.ContatoBolaJogo).HasColumnName("total_live");
            entity.Property(e => e.TentativasDribles).HasColumnName("total_att");
            entity.Property(e => e.DriblesCompletos).HasColumnName("total_succ");
            entity.Property(e => e.PerDriblesCompletos).HasColumnName("total_succ_");
            entity.Property(e => e.DriblesInterrompidos).HasColumnName("total_tkld");
            entity.Property(e => e.PerDriblesInterrompidos).HasColumnName("total_tkld_");
            entity.Property(e => e.Conducoes).HasColumnName("total_carries");
            entity.Property(e => e.DistTotal).HasColumnName("total_totdist");
            entity.Property(e => e.DistProgressivas).HasColumnName("total_prgdist");
            entity.Property(e => e.CarregadaProgressiva).HasColumnName("total_prgc");
            entity.Property(e => e.CarregadaTercoFinal).HasColumnName("total_1_3");
            entity.Property(e => e.CarregadaAreaPenalti).HasColumnName("total_cpa");
            entity.Property(e => e.PerdaDominio).HasColumnName("total_mis");
            entity.Property(e => e.Desarmado).HasColumnName("total_dis");
            entity.Property(e => e.PassesRecebidos).HasColumnName("total_rec");
            entity.Property(e => e.PassesProgressivosRecebidos).HasColumnName("total_prgr");

            entity.Ignore(e => e.Jogador);
        }
    }
}
