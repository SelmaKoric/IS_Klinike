using ISKlinike.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKlinike
{
    public class DBContext:DbContext
    {
        public DBContext():base("PutanjaDoBaze")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Pacijenti> Pacijenti { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<KartonLicniPodaci> KartonLicniPodaci { get; set; }
        public DbSet<KartonOboljenja> KartonOboljenja { get; set; }
        public DbSet<KartonNalazi> KartonNalazi { get; set; }
        public DbSet<KartonPeriodicniPregledi> KartonPeriodičniPregledi { get; set; }
        public DbSet<KartonIzdataUvjerenja> KartonIzdataUvjerenja { get; set; }
        public DbSet<KartonPreventivneMjere> KartonPreventivneMjere { get; set; }
        public DbSet<KartonDrugeUstanove> KartonDrugeUstanove { get; set; }
        public DbSet<KartonDatumiPosjeta> KartonDatumiPosjeta { get; set; }
        public DbSet<TerminPregleda> TerminPregleda { get; set; }
    }


}
