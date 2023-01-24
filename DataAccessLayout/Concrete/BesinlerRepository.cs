using DataAccessLayout.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayout.Concrete
{
    public class BesinlerRepository : BaseRepository<Besinler>
    {
        public BesinlerRepository(YouFitDbContext youFitDbContext) : base(youFitDbContext)
        {
        }
    }
}
