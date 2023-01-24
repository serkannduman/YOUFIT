using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici : IKullanici, IBaseEntity
    {
        public int KullaniciId { get; set; }
        

       
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string KullaniciMail { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciTelefon { get; set; }
       
        public KullaniciDetay KullaniciDetay { get; set; }
        public IcilenSu IcilenSu { get; set; }
        public ICollection<Ogun> Oguns { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status Status { get; set; }=Status.Actived;
        

        public Kullanici()
        {
            Oguns= new List<Ogun>();
        }
    }
}
