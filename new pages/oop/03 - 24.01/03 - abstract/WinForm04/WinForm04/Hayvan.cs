using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinForm04
{
    public  class Hayvan
    {
        public string Adi { get; set; }
        public string Cinsi { get; set; }
        public double Kilo { get; set; }
        public int Yas { get; set; }
        public double Boy { get; set; }
        public Color Rengi { get; set; }

        //tanımladığın abstract class ve metodu bundan tğretilen tüm sınıflarda kullanman gerekir.
        //abstract tanımladığın metodun gövdesi olmaz
        public abstract string SesCikar();

    }
}
