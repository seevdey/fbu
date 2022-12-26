using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lambdaoop.Calisan;

namespace lambdaoop
{
    enum Departman
    {
        Bilgiİşlem, GenelMüdürlük, Muhasebe, İnsanKaynakları, Tahsilat
    };

    class Calisan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Departman Bolumu { get; set; }

        public double Maas { get; set; }
        public DateTime GiriSTarihi { get; set; }


        public override string ToString() //standart kullanılan ToStrin()g i ezmek istiyorum. Bunu diğer standart kullanılan metotlar için de yapabilirsin
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", Id.ToString(), Ad, Soyad.ToUpper(), Bolumu, Maas.ToString(), GiriSTarihi.ToShortDateString());
        }

    }


    internal class Program
    {
        public delegate double primMetod(double prim, double maas);

        static void Main(string[] args)
        {
            List<Calisan> Personeller = new List<Calisan>()
            { 
                // personel listeme 6 adet çalışan ekledim
                new Calisan() { Id = 1, Ad = "Sevde", Soyad = "Yılmaz", Bolumu = Departman.İnsanKaynakları, Maas = 10000, GiriSTarihi = new DateTime(2012,10,1)},
                new Calisan() { Id = 2, Ad = "Göktuğ", Soyad = "Yıldız", Bolumu = Departman.Muhasebe, Maas = 20000, GiriSTarihi = new DateTime(2015, 11, 1) },
                new Calisan() { Id = 3, Ad = "Ali", Soyad = "Bayazıt", Bolumu = Departman.Tahsilat, Maas = 20000, GiriSTarihi = new DateTime(2015, 11, 1) },
                new Calisan() { Id = 4, Ad = "Işıl", Soyad = "Öztürk", Bolumu = Departman.İnsanKaynakları, Maas = 18000, GiriSTarihi = new DateTime(2018, 11, 6) },
                new Calisan() { Id = 5, Ad = "Nahide", Soyad = "Sümer", Bolumu = Departman.Muhasebe, Maas = 15000, GiriSTarihi = new DateTime(2018, 11, 1) },
                new Calisan() { Id = 6, Ad = "Serdar", Soyad = "Beyazkaya", Bolumu = Departman.GenelMüdürlük, Maas = 15000, GiriSTarihi = new DateTime(2014, 11, 5) },
            };

            //S ile başlayanları getir
            var adiSileBaslayanlar = Personeller.FindAll((Calisan c) => (c.Ad[0] == 'S')); //içinden  ne geleceğini bilmiyorum c nin ilk adı S ile başlayanları bul ve ata. FindAll metodu kullanarak Calisan tipinde 
            Console.WriteLine("Adı 'S' ile başlayanlar : ");
            Listele<Calisan>(adiSileBaslayanlar); //adiSileBaslayanlar ın tipini bilmiyorum

            Console.WriteLine("------------------");

            //Bölümü Genel Müdürlük olan çalışanları listele
            var genelMudurluk = Personeller.FindAll((Calisan c) => (c.Bolumu == Departman.GenelMüdürlük));
            Console.WriteLine("Bölümü Genel Müdürlük olan çalışanlar : ");
            Listele<Calisan>(genelMudurluk);

            Console.WriteLine("------------------");


            //Giriş Yılı 2015 ten önce olanları listele ve bu kişiler için prim talebi oluştur
            primMetod pr = (prim, maas) => maas += prim;

            var yil = Personeller.Where((Calisan c) =>
            {
                if (c.GiriSTarihi.Year < 2015)
                {
                    c.Maas = pr(1000, c.Maas);
                    return true;
                }
                else
                {
                    return false;
                }

            });
            Console.WriteLine("Giriş Yılı 2015 ten önce olanları listele ve bu kişiler için prim talebi oluştur : ");
            Listele<Calisan>(yil);

            Console.ReadLine();
        }

        static void Listele<T>(IEnumerable<T> list)  //IEnumerable ileri gidebilmek için kullanıyorum
        {
            foreach (T t in list) //Ther şeyi T tipinde ki t ye atıp t yi ToString() i kullanarak ekrana yazdırıyorum
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine();
        }

    }
}
