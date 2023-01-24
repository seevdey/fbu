using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm03
{
    public class Bebek
    {
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
        }

        public DateTime DogumTarihi { get; set; }
        public double Kilo{ get; set; }
        public string Adi{ get; set; }
        public bool KizMi { get; set; }

        public void BabyShower() { }
        public void Muzik() { }

        //Bir metodun defalarca kullanılması overloading
        //Constructor dışında yapılmaması gereken bir şey
        //Constructor yapıcı metod olduğu için bu hakka sahip

        //her class en başta bebeğimiz oluştuğu anda tetiklenmesi gerekiyor:)
        //tetiklendiği anda bebek oluşuyor

    }
}
