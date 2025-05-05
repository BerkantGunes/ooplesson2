using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__
{
    public interface IKitaplar_
    {
         string barkodNo { get; set; }

         string kitapAd { get; set; }

         string TurNo { get; set; }

         string Yazar { get; set; }
    }
}
