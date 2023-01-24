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
    public class BesinKategorileriMapping:EntityTypeConfiguration<BesinKategorileri>
    {
        public BesinKategorileriMapping()
        {

            this.HasKey(x => x.KategoriId);

            this.Property(x => x.KategoriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.HasMany(bk => bk.Besinlers).WithRequired(b => b.BesinKategorileri).HasForeignKey(b => b.KategoriId);


            
        }

    }
}
