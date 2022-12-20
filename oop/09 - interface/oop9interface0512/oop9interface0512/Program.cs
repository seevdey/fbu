using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop9interface0512
{
    /*
         *  Sınıfların içlerini bana göstermeyi sağlayan kılavuzlardır
         *  Sanaldırlar içlerinde kod yok sadece tanım mevcuttur
         *  Kullanım zorunluluğu yok ama çok çok çok önemle kullanılmasını isteriz
         *  Örnek verecek olursak bir yemek yapımındaki malzeme listesine bir interface(arayüz) denir
         *  Örnek verecek olursak; kitapta içindekiler. İçindekiler indeksi interface oluyor
         *  oop ta class açarken ilk başta interface oluştur
         *  interface tanımında ne varsa class ta onu kullanmakla yükümlüyüz
         *  
    */

    internal class Program
    {
        
        public interface IAracOzellikleri
        {
            //Yemeğin malzemeleri - malzeme listesi
            //Yani ihtiyaçlar
            string Marka { get; } //Sen marka ve modele değer atamazsın dışardan. Yani marka ve model tanımlı
            string Model { get; } //Yani model tanımlı

            int Hız { get; set; } //Arabanın hızıyla oynarım bu yüzden get set kullandım. Değiştirilebilir
            int Fiyat { get; set; } 
            int Gosterge(int deger);

            void Bilgiler();

        }

        public interface IAracPuan
        {
            double AracPuani(double puan);
        }

        public class Mercedes : IAracOzellikleri
        {
            public string Marka
            {
                //interface tanımında ne varsa class ta onu kullanmakla yükümlüyüz
                //Bu özellikte sadece get olduğu için classta yazarken sadece get kullandık
                get
                {
                    return "Mercedes";
                }
            }

            public string Model
            {
                get
                {
                    return "C Serisi";
                }
            }

            private int hiz;

            public int Hız 
            {
                get { return hiz; }
                set { hiz = value; }
            }

            private int fiyat;

            public int Fiyat
            {
                get { return fiyat; }
                set { fiyat = value; }
            }


            public void Bilgiler()
            {
                Console.WriteLine($"Marka : {Marka} \nModel : {Model} \nFiyat : {Fiyat} \nHız : {Hız} \nGösterge : {Gosterge(300)}");
            }

            public int Gosterge(int deger)
            {
                return (deger + 50);
            }

        }

        public class Bmw : IAracOzellikleri, IAracPuan
        {
            public string marka = "BMW";
            public string model = "3.40";
            private int hiz;
            private int fiyat;

            public string Marka {get {return marka;}}

            public string Model {get{ return model;}}

            public int Hız
            {
                get { return hiz; }
                set { hiz = value; }
            }

            public int Fiyat
            {
                get { return fiyat; }
                set { fiyat = value; }

                //istediğim gibi değiştirebilmek için get  set tanımladım
            }

            //get-set kullanmamın sebebi iş kuralı tanımlayabilmek

            public void Bilgiler()
            {
                Console.WriteLine($"Marka : {Marka} \nModel : {Model} \nFiyat : {Fiyat} \nHız : {Hız} \nGösterge : {Gosterge(300)} \nPuan : {AracPuani(2000)}");
            }


            public double AracPuani(double puan)
            {
                return puan * 3.6;
            }

            public int Gosterge(int deger)
            {
                return deger;
            }
        }

        static void Main(string[] args)
        {
            Mercedes mm = new Mercedes();
            mm.Fiyat = 1000000;
            mm.Hız = 250;
            mm.Bilgiler();

            Console.WriteLine("------------------------------");

            Bmw bmw = new Bmw();
            bmw.Fiyat = 200000;
            bmw.Hız = 400;
            bmw.Bilgiler();

            Console.ReadLine();
        }
    }
}
