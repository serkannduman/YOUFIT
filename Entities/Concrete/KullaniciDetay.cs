using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class KullaniciDetay : IKullaniciDetay, IBaseEntity
    {
        public int KullaniciDetayId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime? KullaniciDogumTarihi { get; set; }
        public Cinsiyet? Cinsiyet { get; set; }
        public YasAraligi? YasAraligi { get; set; }
        public Kullanici Kullanici { get; set; }

        public int? KullaniciKilo { get; set; }
        public int? KullaniciBoy { get; set; }
        public double? KullaniciVKE { get; set; }
        public Obezite? Obezite { get; set; }



       
        public Hedef? Hedef { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status Status { get; set; } = Status.Actived;
       
    }
}
