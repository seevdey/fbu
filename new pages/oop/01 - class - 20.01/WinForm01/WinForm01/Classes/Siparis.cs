using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm01.Classes
{
    public class Siparis
    {
        public string SiparisKodu { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public string Adres { get; set; }

        //Bir sınıfın dizi, tip olarak kullanılması söz konusu olabilir

        public Urun[] Urunler { get; set; } //sınıfı dizi olarak kullanabiliyoruz

        //ilgili sipariş içinde toplam ürün sayısını alabiliriz
        public int ToplamUrunSayisi
        {
            get
            {
                return Urunler.Length; 
            }
        }
    }
}
