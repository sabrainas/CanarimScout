using CanarinScout.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping
{
    public class GoleirosMapping : IEntityTypeConfiguration<Goleiros>
    {
        public void Configure(EntityTypeBuilder<Goleiros> entity)
        {
            entity.ToTable("goalkeeper_stats");
            entity.HasKey(e => e.Id).HasName("id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChutesNoGol).HasColumnName("sota");
            entity.Property(e => e.GolSofridos).HasColumnName("ga");
            entity.Property(e => e.Defesas).HasColumnName("saves");
            entity.Property(e => e.PerDefesas).HasColumnName("save_");
            entity.Property(e => e.PartidaSemGol).HasColumnName("cs");
            entity.Property(e => e.GolsEsperados).HasColumnName("psxg");
            entity.Property(e => e.PenaltiCausados).HasColumnName("pkatt");
            entity.Property(e => e.PenaltiSofrido).HasColumnName("pka");
            entity.Property(e => e.PenaltiDefendidos).HasColumnName("pksv");
            entity.Property(e => e.PenaltiErrado).HasColumnName("pkm");
            entity.Property(l => l.LancamentosCompletos).HasColumnName("cmp");
            entity.Property(l => l.TentativasLancamentos).HasColumnName("att");
            entity.Property(l => l.PerLancamentosCompletos).HasColumnName("cmp_");
            entity.Property(pg => pg.Passes).HasColumnName("att_gk_");
            entity.Property(pg => pg.TentativasPasses).HasColumnName("thr");
            entity.Property(t => t.PerTiroDeMetas).HasColumnName("launch_");
            entity.Property(pg => pg.DistanciaMedia).HasColumnName("avglen");
            entity.Property(t => t.QtdTirosDeMeta).HasColumnName("att_1");
            entity.Property(t => t.DistMediaTiroDeMeta).HasColumnName("avglen_1");
            entity.Property(c => c.CruzamentosEnfrentados).HasColumnName("opp");
            entity.Property(c => c.CruzamentoBloqueado).HasColumnName("stp");
            entity.Property(c => c.PerCruzamentoBloqueado).HasColumnName("stp_");
            entity.Property(f => f.AcoesForaDaPequenaArea).HasColumnName("_opa");
            entity.Property(f => f.DistMedia).HasColumnName("avgdist");  //distancia que o goleiro tava do gol quando fez uma ação defensiva fora do gol
            entity.Property(e => e.PlayerId).HasColumnName("player_id");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId);
        }
    }
}
