using CanarinScout.Domain.Entities.Sum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Sum
{
    public class EstatisticasSumMapping : IEntityTypeConfiguration<EstatisticasSum>
    {
        public void Configure(EntityTypeBuilder<EstatisticasSum> entity)
        {
            entity.HasKey(e => e.PlayerId).HasName("summary_sum_pkey");

            entity.ToTable("summary_sum");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.Gols).HasColumnName("total_gls");
            entity.Property(e => e.Assistencias).HasColumnName("total_ast");
            entity.Property(e => e.PenaltisMarcados).HasColumnName("total_pk");
            entity.Property(e => e.PenaltisTentados).HasColumnName("total_pkatt");
            entity.Property(e => e.Chutes).HasColumnName("total_sh");
            entity.Property(e => e.ChutesNoGol).HasColumnName("total_sot");
            entity.Property(e => e.CartaoAmarelo).HasColumnName("total_crdy");
            entity.Property(e => e.CartaoVermelho).HasColumnName("total_crdr");
            entity.Property(e => e.Contatos).HasColumnName("total_touches");
            entity.Property(e => e.Desarmes).HasColumnName("total_tkl");
            entity.Property(e => e.Interceptacoes).HasColumnName("total_int");
            entity.Property(e => e.Bloqueios).HasColumnName("total_blocks");
            entity.Property(e => e.GolsEsperados).HasColumnName("total_xg");
            entity.Property(e => e.GolsEsperadosSemPenalti).HasColumnName("total_npxg");
            entity.Property(e => e.AssistenciasEsperadas).HasColumnName("total_xag");
            entity.Property(e => e.AcaoCriacaoChute).HasColumnName("total_sca");
            entity.Property(e => e.AcaoGol).HasColumnName("total_gca");
            entity.Property(e => e.PassesConcluidos).HasColumnName("total_cmp");
            entity.Property(e => e.TentativasPasses).HasColumnName("total_att");
            entity.Property(e => e.PassesProgressivos).HasColumnName("total_prgp");
            entity.Property(e => e.Conducoes).HasColumnName("total_carries");
            entity.Property(e => e.ConducoesProgressivas).HasColumnName("total_prgc");
            entity.Property(e => e.DriblesCompletos).HasColumnName("total_succ");
            entity.Property(e => e.FaltasCometidas).HasColumnName("total_fls");
            entity.Property(e => e.FaltasSofridas).HasColumnName("total_fld");
            entity.Property(e => e.Impedimentos).HasColumnName("total_off");
            entity.Property(e => e.Cruzamentos).HasColumnName("total_crs");
            entity.Property(e => e.DesarmesGanhos).HasColumnName("total_tklw");
            entity.Property(e => e.GolsContra).HasColumnName("total_og");
            entity.Property(e => e.PenaltisGanhos).HasColumnName("total_pkwon");
            entity.Property(e => e.PenaltisConcedidos).HasColumnName("total_pkcon");

            entity.Ignore(e => e.Jogador);
            entity.Ignore(e => e.Ofensivas);
            entity.Ignore(e => e.Passes);
            entity.Ignore(e => e.Posses);
            entity.Ignore(e => e.Defensivas);
        }
    }
}
