//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace CanarinScout.WebApi.Entities;

//public partial class AppDbContext : DbContext
//{
//    public AppDbContext()
//    {
//    }

//    public AppDbContext(DbContextOptions<AppDbContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<Defense> Defenses { get; set; }

//    public virtual DbSet<Gca> Gcas { get; set; }

//    public virtual DbSet<PlayerPassing> PlayerPassings { get; set; }

//    public virtual DbSet<PlayerPassingType> PlayerPassingTypes { get; set; }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<Defense>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("defense_pkey");

//            entity.ToTable("defense");

//            entity.Property(e => e.Id).HasColumnName("id");
//            entity.Property(e => e.Att).HasColumnName("att");
//            entity.Property(e => e.Att3rd).HasColumnName("att_3rd");
//            entity.Property(e => e.Blocks).HasColumnName("blocks");
//            entity.Property(e => e.Clr).HasColumnName("clr");
//            entity.Property(e => e.Comp).HasColumnName("comp");
//            entity.Property(e => e.Date).HasColumnName("date");
//            entity.Property(e => e.Day).HasColumnName("day");
//            entity.Property(e => e.Def3rd).HasColumnName("def_3rd");
//            entity.Property(e => e.Err).HasColumnName("err");
//            entity.Property(e => e.Int).HasColumnName("int");
//            entity.Property(e => e.Lost).HasColumnName("lost");
//            entity.Property(e => e.MatchReport).HasColumnName("match_report");
//            entity.Property(e => e.Mid3rd).HasColumnName("mid_3rd");
//            entity.Property(e => e.Min).HasColumnName("min");
//            entity.Property(e => e.Opponent).HasColumnName("opponent");
//            entity.Property(e => e.Pass).HasColumnName("pass");
//            entity.Property(e => e.PlayerId).HasColumnName("player_id");
//            entity.Property(e => e.Pos).HasColumnName("pos");
//            entity.Property(e => e.Result).HasColumnName("result");
//            entity.Property(e => e.Round).HasColumnName("round");
//            entity.Property(e => e.Sh).HasColumnName("sh");
//            entity.Property(e => e.Squad).HasColumnName("squad");
//            entity.Property(e => e.Start).HasColumnName("start");
//            entity.Property(e => e.Tkl).HasColumnName("tkl");
//            entity.Property(e => e.Tkl1).HasColumnName("tkl_1");
//            entity.Property(e => e.Tkl2).HasColumnName("tkl_");
//            entity.Property(e => e.TklInt).HasColumnName("tkl_int");
//            entity.Property(e => e.Tklw).HasColumnName("tklw");
//            entity.Property(e => e.Venue).HasColumnName("venue");
//        });

//        modelBuilder.Entity<Gca>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("gca_pkey");

//            entity.ToTable("gca");

//            entity.Property(e => e.Id).HasColumnName("id");
//            entity.Property(e => e.Comp).HasColumnName("comp");
//            entity.Property(e => e.Date).HasColumnName("date");
//            entity.Property(e => e.Day).HasColumnName("day");
//            entity.Property(e => e.Def).HasColumnName("def");
//            entity.Property(e => e.Def1).HasColumnName("def_1");
//            entity.Property(e => e.Fld).HasColumnName("fld");
//            entity.Property(e => e.Fld1).HasColumnName("fld_1");
//            entity.Property(e => e.Gca1).HasColumnName("gca");
//            entity.Property(e => e.MatchReport).HasColumnName("match_report");
//            entity.Property(e => e.Min).HasColumnName("min");
//            entity.Property(e => e.Opponent).HasColumnName("opponent");
//            entity.Property(e => e.Passdead).HasColumnName("passdead");
//            entity.Property(e => e.Passdead1).HasColumnName("passdead_1");
//            entity.Property(e => e.Passlive).HasColumnName("passlive");
//            entity.Property(e => e.Passlive1).HasColumnName("passlive_1");
//            entity.Property(e => e.PlayerId).HasColumnName("player_id");
//            entity.Property(e => e.Pos).HasColumnName("pos");
//            entity.Property(e => e.Result).HasColumnName("result");
//            entity.Property(e => e.Round).HasColumnName("round");
//            entity.Property(e => e.Sca).HasColumnName("sca");
//            entity.Property(e => e.Sh).HasColumnName("sh");
//            entity.Property(e => e.Sh1).HasColumnName("sh_1");
//            entity.Property(e => e.Squad).HasColumnName("squad");
//            entity.Property(e => e.Start).HasColumnName("start");
//            entity.Property(e => e.To).HasColumnName("to");
//            entity.Property(e => e.To1).HasColumnName("to_1");
//            entity.Property(e => e.Venue).HasColumnName("venue");
//        });

//        modelBuilder.Entity<PlayerPassing>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("player_passing_pkey1");

//            entity.ToTable("player_passing");

//            entity.Property(e => e.Id)
//                .HasDefaultValueSql("nextval('player_passing_id_seq1'::regclass)")
//                .HasColumnName("id");
//            entity.Property(e => e.Ast).HasColumnName("ast");
//            entity.Property(e => e.Att).HasColumnName("att");
//            entity.Property(e => e.Att1).HasColumnName("att_1");
//            entity.Property(e => e.Att2).HasColumnName("att_2");
//            entity.Property(e => e.Att3).HasColumnName("att_3");
//            entity.Property(e => e.Cmp).HasColumnName("cmp");
//            entity.Property(e => e.Cmp1).HasColumnName("cmp_");
//            entity.Property(e => e.Cmp11).HasColumnName("cmp_1");
//            entity.Property(e => e.Cmp12).HasColumnName("cmp__1");
//            entity.Property(e => e.Cmp2).HasColumnName("cmp_2");
//            entity.Property(e => e.Cmp21).HasColumnName("cmp__2");
//            entity.Property(e => e.Cmp3).HasColumnName("cmp_3");
//            entity.Property(e => e.Cmp31).HasColumnName("cmp__3");
//            entity.Property(e => e.Comp).HasColumnName("comp");
//            entity.Property(e => e.Crspa).HasColumnName("crspa");
//            entity.Property(e => e.Date).HasColumnName("date");
//            entity.Property(e => e.Day).HasColumnName("day");
//            entity.Property(e => e.Kp).HasColumnName("kp");
//            entity.Property(e => e.MatchReport).HasColumnName("match_report");
//            entity.Property(e => e.Min).HasColumnName("min");
//            entity.Property(e => e.Opponent).HasColumnName("opponent");
//            entity.Property(e => e.PlayerId).HasColumnName("player_id");
//            entity.Property(e => e.Pos).HasColumnName("pos");
//            entity.Property(e => e.Ppa).HasColumnName("ppa");
//            entity.Property(e => e.Prgdist).HasColumnName("prgdist");
//            entity.Property(e => e.Prgp).HasColumnName("prgp");
//            entity.Property(e => e.Result).HasColumnName("result");
//            entity.Property(e => e.Round).HasColumnName("round");
//            entity.Property(e => e.Squad).HasColumnName("squad");
//            entity.Property(e => e.Start).HasColumnName("start");
//            entity.Property(e => e.Totdist).HasColumnName("totdist");
//            entity.Property(e => e.Venue).HasColumnName("venue");
//            entity.Property(e => e.Xa).HasColumnName("xa");
//            entity.Property(e => e.Xag).HasColumnName("xag");
//            entity.Property(e => e._13).HasColumnName("1_3");
//        });

//        modelBuilder.Entity<PlayerPassingType>(entity =>
//        {
//            entity.HasKey(e => e.Id).HasName("player_passing_pkey");

//            entity.ToTable("player_passing_types");

//            entity.Property(e => e.Id)
//                .HasDefaultValueSql("nextval('player_passing_id_seq'::regclass)")
//                .HasColumnName("id");
//            entity.Property(e => e.Att).HasColumnName("att");
//            entity.Property(e => e.Blocks).HasColumnName("blocks");
//            entity.Property(e => e.Ck).HasColumnName("ck");
//            entity.Property(e => e.Cmp).HasColumnName("cmp");
//            entity.Property(e => e.Comp).HasColumnName("comp");
//            entity.Property(e => e.Crs).HasColumnName("crs");
//            entity.Property(e => e.Date).HasColumnName("date");
//            entity.Property(e => e.Day).HasColumnName("day");
//            entity.Property(e => e.Dead).HasColumnName("dead");
//            entity.Property(e => e.Fk).HasColumnName("fk");
//            entity.Property(e => e.In).HasColumnName("in");
//            entity.Property(e => e.Live).HasColumnName("live");
//            entity.Property(e => e.MatchReport).HasColumnName("match_report");
//            entity.Property(e => e.Min).HasColumnName("min");
//            entity.Property(e => e.Off).HasColumnName("off");
//            entity.Property(e => e.Opponent).HasColumnName("opponent");
//            entity.Property(e => e.Out).HasColumnName("out");
//            entity.Property(e => e.PlayerId).HasColumnName("player_id");
//            entity.Property(e => e.Pos).HasColumnName("pos");
//            entity.Property(e => e.Result).HasColumnName("result");
//            entity.Property(e => e.Round).HasColumnName("round");
//            entity.Property(e => e.Squad).HasColumnName("squad");
//            entity.Property(e => e.Start).HasColumnName("start");
//            entity.Property(e => e.Str).HasColumnName("str");
//            entity.Property(e => e.Sw).HasColumnName("sw");
//            entity.Property(e => e.Tb).HasColumnName("tb");
//            entity.Property(e => e.Ti).HasColumnName("ti");
//            entity.Property(e => e.Venue).HasColumnName("venue");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
