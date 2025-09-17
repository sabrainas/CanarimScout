using CanarinScout.Domain.Entities;
using CanarinScout.WebApi;
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

        //public virtual DbSet<Misc> Miscs { get; set; }

        public virtual DbSet<Passes> Passes { get; set; }
        public virtual DbSet<TipoPasses> TipoPasses { get; set; }

        public virtual DbSet<Posses> Posses { get; set; }

        public virtual DbSet<Estatisticas> Estatisticas { get; set; }

        public virtual DbSet<Jogador> Jogador { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            //modelBuilder.Entity<Misc>(entity =>
            //{
            //    entity.HasKey(e => e.Id).HasName("misc_pkey");

            //    entity.ToTable("misc");

            //    entity.Property(e => e.Id).HasColumnName("id");
            //    entity.Property(e => e.Comp).HasColumnName("comp");
            //    entity.Property(e => e.Crdr).HasColumnName("crdr");
            //    entity.Property(e => e.Crdy).HasColumnName("crdy");
            //    entity.Property(e => e.Crs).HasColumnName("crs");
            //    entity.Property(e => e.Date).HasColumnName("date");
            //    entity.Property(e => e.Day).HasColumnName("day");
            //    entity.Property(e => e.Fld).HasColumnName("fld");
            //    entity.Property(e => e.Fls).HasColumnName("fls");
            //    entity.Property(e => e.Int).HasColumnName("int");
            //    entity.Property(e => e.Lost).HasColumnName("lost");
            //    entity.Property(e => e.MatchReport).HasColumnName("match_report");
            //    entity.Property(e => e.Min).HasColumnName("min");
            //    entity.Property(e => e.Off).HasColumnName("off");
            //    entity.Property(e => e.Og).HasColumnName("og");
            //    entity.Property(e => e.Opponent).HasColumnName("opponent");
            //    entity.Property(e => e.Pkcon).HasColumnName("pkcon");
            //    entity.Property(e => e.Pkwon).HasColumnName("pkwon");
            //    entity.Property(e => e.PlayerId).HasColumnName("player_id");
            //    entity.Property(e => e.Pos).HasColumnName("pos");
            //    entity.Property(e => e.Recov).HasColumnName("recov");
            //    entity.Property(e => e.Result).HasColumnName("result");
            //    entity.Property(e => e.Round).HasColumnName("round");
            //    entity.Property(e => e.Squad).HasColumnName("squad");
            //    entity.Property(e => e.Start).HasColumnName("start");
            //    entity.Property(e => e.Tklw).HasColumnName("tklw");
            //    entity.Property(e => e.Venue).HasColumnName("venue");
            //    entity.Property(e => e.Won).HasColumnName("won");
            //    entity.Property(e => e.Won1).HasColumnName("won_");
            //    entity.Property(e => e._2crdy).HasColumnName("2crdy");
            //});
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
