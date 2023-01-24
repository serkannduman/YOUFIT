using DataAccessLayout.Mapping;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Context
{
    public class YouFitDbContext:DbContext
    {

        public YouFitDbContext():base("Server=DESKTOP-PMQ8OOE\\MSSQLSERVER2019;Database=YOUFITDB8;Trusted_Connection=True;")
        {

        }

        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<KullaniciDetay> KullaniciDetays { get; set; }
        public DbSet<Besinler> Besinlers { get; set; }
        public DbSet<BesinKategorileri> BesinKategorileris { get; set; }
        public DbSet<Ogun> Oguns { get; set; }

        public DbSet<YenilenYemek> YenilenYemeks{ get; set; }


    public DbSet<IcilenSu> IcilenSus { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KullaniciMapping());
            modelBuilder.Configurations.Add(new KullaniciDetayMapping());
            modelBuilder.Configurations.Add(new BesinlerMapping());
            modelBuilder.Configurations.Add(new BesinKategorileriMapping());
            modelBuilder.Configurations.Add(new IcilenSuMapping());
            modelBuilder.Configurations.Add(new OgunMapping());
          
            
        }
    }
}
