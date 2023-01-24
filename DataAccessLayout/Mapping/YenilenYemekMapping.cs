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
    public class YenilenYemekMapping:EntityTypeConfiguration<YenilenYemek>
    {
        public YenilenYemekMapping()
        {
            this.HasKey(x => x.YenilenYemekId);

            this.Property(x => x.YenilenYemekId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            this.HasRequired(yy => yy.Ogun).WithMany(o => o.YenilenYemeks).HasForeignKey(yy => yy.OgunId);
        }

       
    }
}
