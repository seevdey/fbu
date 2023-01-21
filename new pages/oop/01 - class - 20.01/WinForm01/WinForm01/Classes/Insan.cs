using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm01.Classes
{
    class Insan
    {
        //en çok sorgulanacak yerleri en üste yazıyorum
        public int ID { get; set; }

        //field ın private olması gerekiyor
        // _ koyduğun zaman field olduğu anlaşılmış oluyor. Yani encapsulation yaptığını belirtmiş oluyorsun
        private string _isim;

        /*
            object tüm veri tipşerini kapsar
            gelen datayı kapsül içerisinde tut 
            boxing
            unboxing
        */

        public string Isim
        {
            get
            {
                return _isim;
            }
            set
            {
                //büyük harfe çevir ve boşlukları alma
                _isim = value.ToUpper().Trim();
            }
        }

        //Double, arka tarafda double değişkeninin oluşması için oluşturulan class
        private double _boy;
        public double Boy { get; set; }

        // CTRL + r + e
        public double _kilo { get => kilo; set => kilo = value; }
        private double kilo;

        public double Kilo
        {
            //kapsüllediğim datayı get ten gönderiyorum
            get { return kilo; }
            //aldığı değeri field a veriyor ben onu okuyorum
            set { _kilo = value;  }
        }

        public byte Yas { get => _yas; set => _yas = value; }
        private byte _yas;

        public Color SacRengi { get => _sacrengi; set => _sacrengi = value; }
        private Color _sacrengi;

        public void YemekYe()
        {}

        public void AlisverisYap()
        { }

        public void Uyu()
        { }

    }
}
