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
    public class BesinlerMapping:EntityTypeConfiguration<Besinler>
    {
        public BesinlerMapping()
        {

            this.HasKey(x => x.BesinId);

            this.Property(x => x.BesinId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.HasRequired(b => b.BesinKategorileri).WithMany(bk=>bk.Besinlers).HasForeignKey(b=>b.KategoriId);


            this.HasMany(b => b.Oguns).WithMany(o => o.Besinlers).Map(x =>
            {
                x.MapLeftKey("OgunsRefId");
                x.MapRightKey("BesinlersRefId");
                x.ToTable("OgunsBesinlers");
            });
        }

    }
}
