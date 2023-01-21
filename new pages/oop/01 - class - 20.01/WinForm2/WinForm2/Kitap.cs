using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm2
{
    public class Kitap
    {
        public string KitapAdi{ get; set; }
        public string Yazar{ get; set; }
        public string ISBN { get; set; }
        public string Tur { get; set; }
        public string Yayinevi { get; set; }
        public DateTime YayinTarihi { get; set; }
        public int SayfaSayisi { get; set; }

        public override string ToString()
        {
            return KitapAdi + " " + Yazar;
        }
    }
}
