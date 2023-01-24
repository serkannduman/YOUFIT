using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BesinKategorileri : IBesinKategorileri, IBaseEntity
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public ICollection<Besinler> Besinlers { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public Status Status { get; set; } = Status.Actived;



        public BesinKategorileri()
        {
            Besinlers=new List<Besinler>();
        }
    }
}
