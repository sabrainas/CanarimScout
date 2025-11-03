using CanarinScout.Domain.Entities;
using CanarinScout.Domain.Entities.Analysis;
using CanarinScout.Domain.Entities.Sum;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.Infrastructure
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<Defensivas> Defensivas { get; set; }

        public virtual DbSet<Ofensivas> Ofensivas { get; set; }

        public virtual DbSet<Passes> Passes { get; set; }

        public virtual DbSet<TipoPasses> TipoPasses { get; set; }

        public virtual DbSet<Posses> Posses { get; set; }

        public virtual DbSet<Estatisticas> Estatisticas { get; set; }

        public virtual DbSet<Jogador> Jogador { get; set; }

        public virtual DbSet<Goleiros> Goleiros { get; set; }

        public virtual DbSet<DefensivasSum> DefensivasSum { get; set; }

        public virtual DbSet<OfensivasSum> OfensivasSum { get; set; }

        public virtual DbSet<PassesSum> PassesSum { get; set; }

        public virtual DbSet<TipoPassesSum> TipoPassesSum { get; set; }

        public virtual DbSet<PossesSum> PossesSum { get; set; }

        public virtual DbSet<EstatisticasSum> EstatisticasSum { get; set; }

        public virtual DbSet<GoleirosSum> GoleirosSum { get; set; }

        public virtual DbSet<AttackerAnalysis> AttackerAnalysis { get; set; }

        public virtual DbSet<MidfielderAnalysis> MidfielderAnalysis { get; set; }

        public virtual DbSet<DefenseAnalysis> DefenseAnalysis { get; set; }

        public virtual DbSet<GoalkeeperAnalysis> GoalkeeperAnalysis { get; set; }

        public virtual DbSet<PlayerFeatures> PlayerFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
