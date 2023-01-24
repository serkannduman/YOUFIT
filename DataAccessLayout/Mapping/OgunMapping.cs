using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Mapping
{
    public class OgunMapping : EntityTypeConfiguration<Ogun>
    {

        public OgunMapping()
        {
            this.HasKey(x => x.OgunId);

            this.Property(x => x.OgunId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.HasRequired(o => o.Kullanici).WithMany(k => k.Oguns).HasForeignKey(o => o.KullaniciId);

            this.HasMany(o => o.YenilenYemeks).WithRequired(yy => yy.Ogun).HasForeignKey(yy => yy.OgunId);

            
        }
    }
}
