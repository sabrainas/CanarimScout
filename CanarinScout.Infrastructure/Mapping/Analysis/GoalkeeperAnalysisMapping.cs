using CanarinScout.Domain.Entities.Analysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Analysis
{
    public class GoalkeeperAnalysisMapping : IEntityTypeConfiguration<GoalkeeperAnalysis>
    {
        public void Configure(EntityTypeBuilder<GoalkeeperAnalysis> entity)
        {
            entity.ToTable("perfil_goleiros");
            entity.HasKey(e => e.PlayerId).HasName("ID");

            entity.Property(e => e.Nome).HasColumnName("Nome");
            entity.Property(e => e.PlayerId).HasColumnName("ID");
            entity.Property(e => e.Clube).HasColumnName("Clube");
            entity.Property(e => e.PerfilCluster).HasColumnName("Perfil_Cluster");
            entity.Property(e => e.DefesaChutesNormVitoria).HasColumnName("defesa_chutes_elite_norm_vitoria");
            entity.Property(e => e.ControleAereoSaidaNormVitoria).HasColumnName("controle_aereo_saida_norm_vitoria");
            entity.Property(e => e.ConfiabilidadePenaltiNormVitoria).HasColumnName("confiabilidade_penalti_norm_vitoria");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId);
        }
    }
}
