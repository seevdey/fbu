using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm04
{
    //Eğer sınıfın başına hiçbir belirteç koymazsan internal olmuş olur
    class Kopek : Hayvan
    {
        public bool EgitimliMi { get; set; }
        public string KopekDisi { get; set; }

        //Hayvan classında Metod isimli Metod
        public override string SesCikar()
        {
            return "Kopek Sesi";
        }
    }
}
