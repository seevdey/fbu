using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm06
{
    public abstract class Personel
    {
        public string Adi{ get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyet { get; set; }
        public int Yas { get; set; }

        public abstract string Pozisyon { get; }
        public int Maas { get; set; }

        public abstract void Para();

    }
}
