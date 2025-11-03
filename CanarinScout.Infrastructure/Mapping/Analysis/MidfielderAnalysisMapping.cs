using CanarinScout.Domain.Entities.Analysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanarinScout.Infrastructure.Mapping.Analysis
{
    public class MidfielderAnalysisMapping : IEntityTypeConfiguration<MidfielderAnalysis>
    {
        public void Configure(EntityTypeBuilder<MidfielderAnalysis> entity)
        {
            entity.ToTable("perfil_meio_campistas");
            entity.HasKey(e => e.PlayerId).HasName("ID");

            entity.Property(e => e.Nome).HasColumnName("Nome");
            entity.Property(e => e.PlayerId).HasColumnName("ID");
            entity.Property(e => e.Clube).HasColumnName("Clube");
            entity.Property(e => e.PeDominante).HasColumnName("Pé dominante");
            entity.Property(e => e.Altura).HasColumnName("Altura (cm)");
            entity.Property(e => e.Peso).HasColumnName("Peso (kg)");
            entity.Property(e => e.CriacaoVisao).HasColumnName("criacao_visao");
            entity.Property(e => e.ControleSeguranca).HasColumnName("controle_seguranca");
            entity.Property(e => e.ContribuicaoOfensivaDireta).HasColumnName("contribuicao_ofensiva_direta");
            entity.Property(e => e.ContribuicaoDefensiva).HasColumnName("contribuicao_defensiva");
            entity.Property(e => e.ParticipacaoDefensiva).HasColumnName("participacao_defensiva");
            entity.Property(e => e.ParticipacaoCentral).HasColumnName("participacao_central");
            entity.Property(e => e.ParticipacaoOfensiva).HasColumnName("participacao_ofensiva");
            entity.Property(e => e.PerfilCluster).HasColumnName("Perfil_Cluster");
            entity.Property(e => e.CriacaoVisaoNormVitoria).HasColumnName("criacao_visao_norm_vitoria");
            entity.Property(e => e.ControleSegurancaNormVitoria).HasColumnName("controle_seguranca_norm_vitoria");
            entity.Property(e => e.ContribuicaoOfensivaDiretaNormVitoria).HasColumnName("contribuicao_ofensiva_direta_norm_vitoria");
            entity.Property(e => e.ContribuicaoDefensivaNormVitoria).HasColumnName("contribuicao_defensiva_norm_vitoria");
            entity.Property(e => e.ParticipacaoDefensivaNormVitoria).HasColumnName("participacao_defensiva_norm_vitoria");
            entity.Property(e => e.ParticipacaoCentralNormVitoria).HasColumnName("participacao_central_norm_vitoria");
            entity.Property(e => e.ParticipacaoOfensivaNormVitoria).HasColumnName("participacao_ofensiva_norm_vitoria");

            entity.HasOne(e => e.Jogador)
                .WithMany()
                .HasForeignKey(e => e.PlayerId)
                .HasPrincipalKey(j => j.PlayerId);
        }
    }
}
