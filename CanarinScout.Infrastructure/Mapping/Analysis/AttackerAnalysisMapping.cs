using CanarinScout.Domain.Entities.Analysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Analysis
{
    public class AttackerAnalysisMapping : IEntityTypeConfiguration<AttackerAnalysis>
    {
        public void Configure(EntityTypeBuilder<AttackerAnalysis> entity)
        {
            entity.ToTable("perfil_atacantes");
            entity.HasKey(e => e.PlayerId).HasName("ID");

            entity.Property(e => e.Nome).HasColumnName("Nome");
            entity.Property(e => e.PlayerId).HasColumnName("ID");
            entity.Property(e => e.Clube).HasColumnName("Clube");
            entity.Property(e => e.PeDominante).HasColumnName("Pé dominante");
            entity.Property(e => e.Altura).HasColumnName("Altura (cm)");
            entity.Property(e => e.Peso).HasColumnName("Peso (kg)");
            entity.Property(e => e.Finalizacao).HasColumnName("finalizacao");
            entity.Property(e => e.CriacaoDeChances).HasColumnName("criação de chances");
            entity.Property(e => e.Pressao).HasColumnName("pressão");
            entity.Property(e => e.Disciplina).HasColumnName("disciplina");
            entity.Property(e => e.ParticipacaoTercoOfensivo).HasColumnName("participação terço ofensivo");
            entity.Property(e => e.Dribles).HasColumnName("dribles");
            entity.Property(e => e.PerfilCluster).HasColumnName("Perfil_Cluster");
            entity.Property(e => e.FinalizacaoNormVitoria).HasColumnName("finalizacao_norm_vitoria");
            entity.Property(e => e.ChancesNormVitoria).HasColumnName("criação de chances_norm_vitoria");
            entity.Property(e => e.PressaoNormVitoria).HasColumnName("pressão_norm_vitoria");
            entity.Property(e => e.DisciplinasNormVitoria).HasColumnName("disciplina_norm_vitoria");
            entity.Property(e => e.OfensivoNormVitoria).HasColumnName("participação terço ofensivo_norm_vitoria");
            entity.Property(e => e.DriblesNormVitoria).HasColumnName("dribles_norm_vitoria");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId);
        }
    }
}
