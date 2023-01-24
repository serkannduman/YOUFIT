using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IKullaniciDetay
    {

         int KullaniciDetayId { get; set; }
        int KullaniciId { get; set; }
        Kullanici Kullanici { get; set; }
        YasAraligi? YasAraligi { get; set; }
       DateTime? KullaniciDogumTarihi { get; set; }
        int? KullaniciKilo { get; set; }
        int? KullaniciBoy { get; set; }
        double? KullaniciVKE { get; set; }

        Cinsiyet? Cinsiyet { get; set; }
        Obezite? Obezite { get; set; }



       
        Hedef? Hedef { get; set; }
    }
}
