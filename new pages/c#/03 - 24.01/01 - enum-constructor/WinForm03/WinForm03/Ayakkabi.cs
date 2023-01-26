using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinForm03
{
    public class Ayakkabi
    {
        //Programı çalıştırınca Constructor çalışır
        //Bir başlangıç değeri verebilirsin
        public Ayakkabi() //constructor
        {
            //AyakkabiNo = 44;
        }

        ~Ayakkabi()
        {
            /*
             *DESTRUCTOR
                Her class'ın sadece bir tane Destructor'ı olabilir,
                Destructor tanımlanırken class ismini başına "~" işareti koyulur,
                Struct'lar için tanımlanamaz, sadece class'lar için tanımlanırlar,
                Dışarıdan çağrılamaz, otomatik olarak invoke olur,
                Destructor parametre alamaz.
                Kalıtım yapılamazlar ve overload edilemezler.
            */
        }


        //Bir başka yerden bu sınıfa değer gönderdiğimde onu karşılayan değer, constructor o değerleri karşılayıp işlem yapar
        //Formlar arası veri transferi yapabilirsin
        //Bir sınıfta birden fazla Constructor olabilir. Ama birbirinden farklı olması gerekiyor. Burda parametreli constructor devreye giriyor.
        public Ayakkabi(int _ayakkabiNo, Tip _tipi) //gelen verileri koruyorum, encapsulation var, _ kullanırsam korumuş oluyorum
        {
            AyakkabiNo = _ayakkabiNo;
            Tipi = _tipi;
        }

        public int AyakkabiNo { get; set; }
        public Color Rengi { get; set; }
        public DateTime UretimTarihi { get; set; } //Arka tarafta 'DateTime' özelliğinin içinde set özelliği yok
        public string Marka { get; set; }

        //Enums.cs
        public Tip Tipi { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public Malzeme Malzemesi { get; set; }

        //struct class gibi davranı ama class değil
        //enum dizimsi yapıdır
        //dizi olması için tipinin olması gerekir ama enumda tip yok
    }

    
}
