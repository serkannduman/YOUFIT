using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IIcilenSu
    {
        int IcilenSuId { get; set; }
        int KullaniciId { get; set; }
        Kullanici Kullanici { get; set; }


        int IcilenSuMiktari { get; set; }

        


    }
}
