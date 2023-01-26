using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WinForm03
{
    public class Hayvan
    {
        public string Adi { get; set; }
        public string Cinsi { get; set; }
        public double Kilo { get; set; }
        public int Yas { get; set; }
        public double Boy { get; set; }
        public Color Rengi { get; set; }

        //virtual sayesinde bundan türeyen classta bu metodu override ederek buraya yeni bir durum katmış oluyorum
        public virtual string SesCikar()
        {
            return "Default Ses";
        } 

        //bir metodun birden fazla şekilde kullanılması <-- POLİMORFİZM(çok biçimlilik) (başkalaştırmak)
        //ses çıkarıyor ama aynı sesi çıkarmıyor

        //ilişkileri verirken Entity tarafında virtual kullanıyoruz
    }
}
