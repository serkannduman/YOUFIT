using Entities.Concrete;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IYenilenYemek
    {

        int YenilenYemekId {get;set;}
        int KategoriId {get;set;}
        string YenilenYemekAdi {get;set;}
        double ToplamKalori { get; set; }
        Porsiyon Porsiyon { get; set; }

        int OgunId { get; set; }

        Ogun Ogun { get; set; }
    }
}
