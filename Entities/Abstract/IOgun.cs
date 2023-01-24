using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IOgun
    {

        int KullaniciId { get; set; }

        Kullanici Kullanici { get; set; }

         int OgunId { get; set; }

        DateTime KayitTarihi { get; set; }

        OgunTipi OgunTipi { get; set; }

        Porsiyon porsiyon { get; set; }

        double ToplamKalori { get; set; }


        ICollection <Besinler> Besinlers { get; set; }
        ICollection <YenilenYemek> YenilenYemeks { get; set; }


      


    }
}
