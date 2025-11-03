using CanarinScout.Domain.Entities.Analysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Analysis
{
    public class DefenseAnalysisMapping : IEntityTypeConfiguration<DefenseAnalysis>
    {
        public void Configure(EntityTypeBuilder<DefenseAnalysis> entity)
        {
            entity.ToTable("perfil_defensores");
            entity.HasKey(e => e.PlayerId).HasName("ID");

            entity.Property(e => e.Nome).HasColumnName("Nome");
            entity.Property(e => e.PlayerId).HasColumnName("ID");
            entity.Property(e => e.Clube).HasColumnName("Clube");
            entity.Property(e => e.PeDominante).HasColumnName("Pé dominante");
            entity.Property(e => e.Altura).HasColumnName("Altura (cm)");
            entity.Property(e => e.Peso).HasColumnName("Peso (kg)");
            entity.Property(e => e.SolidezDefensiva).HasColumnName("solidez_defensiva");
            entity.Property(e => e.DuelosBorda).HasColumnName("duelos_borda");
            entity.Property(e => e.DistribuicaoCurtaMedia).HasColumnName("distribuicao_curta_media");
            entity.Property(e => e.ProgressaoJogo).HasColumnName("progressao_jogo");
            entity.Property(e => e.ParticipacaoOfensiva).HasColumnName("participacao_ofensiva");
            entity.Property(e => e.EnvolvimentoPosse).HasColumnName("envolvimento_posse");
            entity.Property(e => e.DisciplinaRisco).HasColumnName("disciplina_risco");
            entity.Property(e => e.PerfilCluster).HasColumnName("Perfil_Cluster");
            entity.Property(e => e.SolidezDefensivaNormVitoria).HasColumnName("solidez_defensiva_norm_vitoria");
            entity.Property(e => e.DuelosBordaNormVitoria).HasColumnName("duelos_borda_norm_vitoria");
            entity.Property(e => e.DistribuicaoCurtaMediaNormVitoria).HasColumnName("distribuicao_curta_media_norm_vitoria");
            entity.Property(e => e.ProgressaoJogoNormVitoria).HasColumnName("progressao_jogo_norm_vitoria");
            entity.Property(e => e.ParticipacaoOfensivaNormVitoria).HasColumnName("participacao_ofensiva_norm_vitoria");
            entity.Property(e => e.EnvolvimentoPosseNormVitoria).HasColumnName("envolvimento_posse_norm_vitoria");
            entity.Property(e => e.DisciplinaRiscoNormVitoria).HasColumnName("disciplina_risco_norm_vitoria");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId);
        }
    }
}
