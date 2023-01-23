using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm2
{
    public class Urun
    {
        public string UrunKodu{ get; set; }
        public string UrunAdi { get; set; }

        public decimal Fiyati { get; set; }
        public int StokMiktari { get; set; }
        public DateTime UretimTarihi { get; set; }
        public int GarantiSuresi { get; set; }

    }
}
