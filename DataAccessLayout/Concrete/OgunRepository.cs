using DataAccessLayout.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Concrete
{
    public class OgunRepository : BaseRepository<Ogun>
    {
        public OgunRepository(YouFitDbContext youFitDbContext) : base(youFitDbContext)
        {
        }
    }
}
