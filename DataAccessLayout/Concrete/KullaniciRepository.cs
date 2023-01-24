using DataAccessLayout.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Concrete
{
    public class KullaniciRepository : BaseRepository<Kullanici>
    {
        public KullaniciRepository(YouFitDbContext youFitDbContext) : base(youFitDbContext)
        {
        }
    }
}
