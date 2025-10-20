using CanarinScout.Domain.Entities;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
