using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IBesinler
    {

        int BesinId { get; set; }
        string BesinAdi { get; set; }

        int BesinKalori { get; set; }



        int KategoriId { get; set; }
        BesinKategorileri BesinKategorileri { get; set; }

        ICollection<Ogun> Oguns { get; set; }




    }
}
