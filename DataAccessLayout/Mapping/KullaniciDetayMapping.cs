using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Mapping
{
    public class KullaniciDetayMapping : EntityTypeConfiguration<KullaniciDetay>
    {

        public KullaniciDetayMapping()
        {
            this.HasKey(x => x.KullaniciDetayId);


            this.Property(x => x.KullaniciDetayId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();



           

        }
    }
}
