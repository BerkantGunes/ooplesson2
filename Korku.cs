using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__
{
    public class Korku : IKitaplar_
    {
        public string barkodNo { get ; set; }
        public string kitapAd { get; set; }
        public string TurNo { get; set; }
        public string Yazar { get; set; }
    }
}
