using CanarinScout.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Jogador> Jogadores => Set<Jogador>();
        public DbSet<Defensivas> Defensivas => Set<Defensivas>();
       // public DbSet<Passes> Passes => Set<Passes>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defensivas>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("defense_pkey");

                entity.ToTable("defense");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Desarmes).HasColumnName("tkl");          
                entity.Property(e => e.DesarmesConcluidos).HasColumnName("tklw");         
                entity.Property(e => e.DriblesDesarmados).HasColumnName("tkl_1");
                entuty.Property(e => e.).HasColumnName("tkl+1");
                entity.Property(e => e.Desarmes3rdDefensivos).HasColumnName("def_3rd");     
                entity.Property(e => e.Desarmes3rdAtaque).HasColumnName("att_3rd");
                entity.Property(e => e.DesarmesMidDefensivo).HasColumnName("min_3rd");
                entity.Property(e => e.TentDesDriblador).HasColumnName("att");          
                entity.Property(e => e.Competicao).HasColumnName("comp");     
                entity.Property(e => e.PassesBloqueados).HasColumnName("pass");         
                entity.Property(e => e.Bloqueios).HasColumnName("blocks");
                entity.Property(e => e.ChutesBloqueados).HasColumnName("sh");
                entity.Property(e => e.Cortes).HasColumnName("clr"); //tirar a bola da area
                entity.Property(e => e.Interceptacoes).HasColumnName("int");
                entity.Property(e => e.Defesas).HasColumnName("");
                entity.Property(e => e.Erros).HasColumnName("err");

                //entity.Property(e => e.PlayerId).HasColumnName("player_id");
                //entity.Property(e => e.MatchReport).HasColumnName("match_report");
                //entity.Property(e => e.Min).HasColumnName("min");
                //entity.Property(e => e.Round).HasColumnName("round");
                //entity.Property(e => e.Squad).HasColumnName("squad");
                //entity.Property(e => e.Start).HasColumnName("start");
                //entity.Property(e => e.Pos).HasColumnName("pos");
                //entity.Property(e => e.Result).HasColumnName("result");
                //entity.Property(e => e.Venue).HasColumnName("venue");
                //entity.Property(e => e.Day).HasColumnName("day");
                //entity.Property(e => e.Date).HasColumnName("date");
            });
        }
    }
}
