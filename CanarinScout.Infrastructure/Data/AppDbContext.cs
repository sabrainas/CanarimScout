using CanarinScout.Domain.Entities;
using CanarinScout.WebApi;
using Microsoft.EntityFrameworkCore;

namespace CanarinScout.Infrastructure.Data
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

        public virtual DbSet<Passes> PlayerPassings { get; set; }

        //public virtual DbSet<TipoPasseJogador> PlayerPassingTypes { get; set; }

        public virtual DbSet<Posses> Posses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Defensivas>(entity =>
            {
                entity.ToTable("defense");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.TentativaDesarmes).HasColumnName("tkl");
                entity.Property(e => e.Defesas).HasColumnName("clr");
                entity.Property(e => e.Competicao).HasColumnName("comp");
                entity.Property(e => e.DesarmesCentrais).HasColumnName("mid_3rd");
                entity.Property(e => e.DesarmesAtaque).HasColumnName("att_3rd");
                entity.Property(e => e.DesarmesDefensivos).HasColumnName("def_3rd");
                entity.Property(e => e.DesarmesConcluidos).HasColumnName("tklw");
                entity.Property(e => e.PassesBloqueados).HasColumnName("blocks");
                entity.Property(e => e.Interceptacoes).HasColumnName("int");
                entity.Property(e => e.DesDriblador).HasColumnName("att");
                entity.Property(e => e.Bloqueios).HasColumnName("blocks");
                entity.Property(e => e.ChutesBloqueados).HasColumnName("sh");
                entity.Property(e => e.PassesBloqueados).HasColumnName("pass");
                entity.Property(e => e.Erros).HasColumnName("err");
                entity.Property(e => e.PerDesDriblador).HasColumnName("tkl_");
            });

            modelBuilder.Entity<Ofensivas>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("gca_pkey");

                entity.ToTable("gca");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.AcaoDefensivaTentChutes).HasColumnName("def");
                entity.Property(e => e.AcaoDefensivaGol).HasColumnName("def_1");
                entity.Property(e => e.FaltaTentChutes).HasColumnName("fld");
                entity.Property(e => e.FaltaGol).HasColumnName("fld_1");
                entity.Property(e => e.AcaoGol).HasColumnName("gca");
                entity.Property(e => e.PassesTentChutesBolaParada).HasColumnName("passdead");
                entity.Property(e => e.GolBolaParada).HasColumnName("passdead_1");
                entity.Property(e => e.PassesTentChutes).HasColumnName("passlive");
                entity.Property(e => e.PasseGol).HasColumnName("passlive_1");
                entity.Property(e => e.AcaoCriacaoChute).HasColumnName("sca");
                entity.Property(e => e.ChutesTentChutes).HasColumnName("sh");
                entity.Property(e => e.ChuteGol).HasColumnName("sh_1");
                entity.Property(e => e.DriblesTentChutes).HasColumnName("to");
                entity.Property(e => e.DribleGol).HasColumnName("to_1");
            });

            modelBuilder.Entity<Passes>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("player_passing_pkey1");

                entity.ToTable("player_passing");

                entity.Property(e => e.Id)
                    .HasDefaultValueSql("nextval('player_passing_id_seq1'::regclass)")
                    .HasColumnName("id");

                entity.Property(e => e.PassesConcluidos).HasColumnName("cmp");
                entity.Property(e => e.TentativasPasses).HasColumnName("att");
                entity.Property(e => e.DistanciaTotal).HasColumnName("totdist");
                entity.Property(e => e.DistPassesProgressivo).HasColumnName("prgdist");
                entity.Property(e => e.QtdPassesProgressivos).HasColumnName("prgp");

                entity.Property(e => e.PerPassesConcluidos).HasColumnName("cmp_");
                entity.Property(e => e.PassesCurtosTentados).HasColumnName("att_1");
                entity.Property(e => e.PassesCurtosConcluidos).HasColumnName("cmp_1");
                entity.Property(e => e.PerPassesCurtosConcluidos).HasColumnName("cmp__1");
                entity.Property(e => e.PassesMediosTentados).HasColumnName("att_2");
                entity.Property(e => e.PassesMediosConcluidos).HasColumnName("cmp_2");
                entity.Property(e => e.PerPassesMediosTentados).HasColumnName("cmp__2");
                entity.Property(e => e.PassesLongosTentados).HasColumnName("att_3");
                entity.Property(e => e.PassesLongosConcluidos).HasColumnName("cmp_3");
                entity.Property(e => e.PerPassesLongosTentados).HasColumnName("cmp__3");
                entity.Property(e => e.Assistencia).HasColumnName("ast");
                entity.Property(e => e.XAG).HasColumnName("xag");
                entity.Property(e => e.XA).HasColumnName("xa");

                entity.Property(e => e.PassesImportantes).HasColumnName("kp");
                entity.Property(e => e.PassesPeqAreaAdv).HasColumnName("ppa");
                entity.Property(e => e.PassesAreaAdv).HasColumnName("1_3");
                entity.Property(e => e.CruzamentoPeqArea).HasColumnName("crspa");
            });

            modelBuilder.Entity<Passes>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("player_passing_pkey");

                entity.ToTable("player_passing_types");

                entity.Property(e => e.Id)
                    .HasDefaultValueSql("nextval('player_passing_id_seq'::regclass)")
                    .HasColumnName("id");
                entity.Property(e => e.PassesBloqueados).HasColumnName("blocks");
                entity.Property(e => e.LancamentoEscanteio).HasColumnName("ck");
                entity.Property(e => e.Cruzamentos).HasColumnName("crs");
                entity.Property(e => e.PassesBolasParadas).HasColumnName("dead");
                entity.Property(e => e.PassesAPartirDeFaltas).HasColumnName("fk");
                entity.Property(e => e.EscanteiosDentroArea).HasColumnName("in");
                entity.Property(e => e.PassesEmJogo).HasColumnName("live");
                entity.Property(e => e.PassesImpedidos).HasColumnName("off");
                entity.Property(e => e.EscanteioForaArea).HasColumnName("out");
                entity.Property(e => e.EscanteioReto).HasColumnName("str");
                entity.Property(e => e.PassesDeReversao).HasColumnName("sw");
                entity.Property(e => e.PassesEntreLinhaDefesa).HasColumnName("tb");
                entity.Property(e => e.LancamentoLateral).HasColumnName("ti");
            });

            modelBuilder.Entity<Posses>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("possession_pkey");

                entity.ToTable("possession");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.TentativasDribles).HasColumnName("att");
                entity.Property(e => e.ContatosTercoAtaque).HasColumnName("att_3rd");
                entity.Property(e => e.ContatosAtaquePen).HasColumnName("att_pen");
                entity.Property(e => e.Conducoes).HasColumnName("carries");
                entity.Property(e => e.CarregadaAreaPenalti).HasColumnName("cpa");
                entity.Property(e => e.ContatosTercoDef).HasColumnName("def_3rd");
                entity.Property(e => e.ContatosDefensivosPen).HasColumnName("def_pen");
                entity.Property(e => e.Desarmado).HasColumnName("dis");
                entity.Property(e => e.ContatoBolaJogo).HasColumnName("live");
                entity.Property(e => e.ContatosTercoCentral).HasColumnName("mid_3rd");
                entity.Property(e => e.PerdaDominio).HasColumnName("mis");
                entity.Property(e => e.CarregadaProgressiva).HasColumnName("prgc");
                entity.Property(e => e.DistProgressivas).HasColumnName("prgdist");
                entity.Property(e => e.PassesProgressivosRecebidos).HasColumnName("prgr");
                entity.Property(e => e.PassesRecebidos).HasColumnName("rec");
                entity.Property(e => e.DriblesCompletos).HasColumnName("succ");
                entity.Property(e => e.PerDriblesCompletos).HasColumnName("succ_");
                entity.Property(e => e.DriblesInterrompidos).HasColumnName("tkld");
                entity.Property(e => e.PerDriblesInterrompidos).HasColumnName("tkld_");
                entity.Property(e => e.DistTotal).HasColumnName("totdist");
                entity.Property(e => e.Contatos).HasColumnName("touches");
                entity.Property(e => e.CarregadaTercoFinal).HasColumnName("1_3");
            });

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
