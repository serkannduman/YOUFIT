using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Besinler : IBesinler, IBaseEntity
    {
        public int BesinId { get; set; }
        public string BesinAdi { get; set; }
        public int BesinKalori { get; set; }
        public int KategoriId { get; set; }
        public BesinKategorileri BesinKategorileri { get; set; }
        public ICollection<Ogun> Oguns { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status Status { get; set; }=Status.Actived;

        public override string ToString()
        {
            return BesinAdi.ToString();
        }
        public Besinler()
        {
            Oguns= new List<Ogun>();
        }
    }
}
