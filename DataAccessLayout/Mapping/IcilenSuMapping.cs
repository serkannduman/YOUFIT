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
    public class IcilenSuMapping : EntityTypeConfiguration<IcilenSu>
    {


        public IcilenSuMapping()
        {
            this.HasKey(x => x.IcilenSuId);


            this.Property(x => x.IcilenSuId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
        }
    }
}
