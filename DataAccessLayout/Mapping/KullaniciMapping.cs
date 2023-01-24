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
    public class KullaniciMapping: EntityTypeConfiguration<Kullanici>
    {

        public KullaniciMapping()
        {
            this.HasKey(x => x.KullaniciId);
            this.Property(x=>x.KullaniciId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            this.HasMany(k => k.Oguns).WithRequired(o => o.Kullanici).HasForeignKey(o => o.KullaniciId);

            this.HasOptional(x => x.KullaniciDetay).WithOptionalPrincipal(x => x.Kullanici).WillCascadeOnDelete(false);


            this.HasOptional(s => s.IcilenSu).WithOptionalPrincipal(k => k.Kullanici).WillCascadeOnDelete(false);
        }

    }
}
