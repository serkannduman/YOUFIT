using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ogun : IOgun, IBaseEntity
    {
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public int OgunId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public OgunTipi OgunTipi { get; set; }
        public Porsiyon porsiyon { get; set; }
        public double ToplamKalori { get; set; }
        public ICollection<Besinler> Besinlers { get; set; }
        public ICollection<YenilenYemek> YenilenYemeks { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status Status { get; set; }=Status.Actived;
        

        public Ogun()
        {
            Besinlers=new List<Besinler>();
        }
    }
}
