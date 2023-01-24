using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IKullanici
    {
        int KullaniciId { get; set; }
        
       
        string KullaniciAdi { get; set; }
        string KullaniciSoyadi { get; set; }
        string KullaniciMail { get; set; }
        string KullaniciSifre { get; set; }
        string KullaniciTelefon { get; set; }
       
        KullaniciDetay KullaniciDetay { get; set; }
        IcilenSu IcilenSu { get; set; }
        ICollection<Ogun> Oguns { get; set; }

    }
}
