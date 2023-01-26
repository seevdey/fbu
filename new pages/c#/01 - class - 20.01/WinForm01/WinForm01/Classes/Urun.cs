using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm01.Classes
{
    public class Urun
    {
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat{ get; set; }
        public bool SatisiDevamEdiyorMu { get; set; }
        public string Kategori { get; set; }
        public DateTime UretimTarihi { get; set; }
        public DateTime GarantiBitisTarihi { get; set; }
        public double Agirlik { get; set; }


        public void Sat()
        {
            GarantiBitisTarihi = DateTime.Now.AddYears(2); // 2 yıl ekle
        }

        public void Iade()
        {

        }
    }
}
