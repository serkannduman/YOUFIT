using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBesinKategorileri
    {
         int KategoriId { get; set; }
         string KategoriAdi { get; set; }

        ICollection<Besinler> Besinlers { get; set; }

    }
}
