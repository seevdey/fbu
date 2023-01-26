using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinForm03
{
    public class Kedi : Hayvan
    {
        //public string Adi { get; set; }
        //public string Cinsi { get; set; }
        //public double Kilo { get; set; }
        //public int Yas{ get; set; }
        //public double Boy { get; set; }
        //public Color Rengi { get; set; }
        public int KalanCanSayisi { get; set; }
        public bool GeceGorusu { get; set; }

        public override string SesCikar()
        {
            return "Kedi Sesi";
        }
    }
}
