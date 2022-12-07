using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqlist0712
{
    class Ogrenci
    {
        //3 adet alan tanımladık. Koşul durumu yok bu yüzden alan olarak tanımladık
        public string   Adi;
        public DateTime DogumTarihi;
        public int      Numarasi;

        //constructor başlangıç metodu

        public Ogrenci(string adi, DateTime dogumTarihi, int numara)
        {
            Adi = adi;
            DogumTarihi = dogumTarihi;
            Numarasi = numara;
        }

        public Ogrenci()
        {
            Adi = "deneme";
            DogumTarihi = Convert.ToDateTime("09.03.2000");
            Numarasi = 1000;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Linque nesne şeklindeki veya küme şeklindeki tüm yapılar için oluşturulan bir sorgulama dilidir
            //SQL diline çok benzer

            #region Dizi Linq Örneği

            //int [] sayilar = new int[5] {1, 2, 3, 4, 5};

            ////linq sorgulama dili
            //var teksayilar = from s in sayilar
            //                 where (s % 2) == 1
            //                 select s;

            ////from sayılar içindeki her şeyi select ile s ye aktar where koşulunu kullanarak
            //foreach (int i in teksayilar)
            //    Console.WriteLine(i);

            #endregion

            #region Ogrenci Örneği

            //Ogrenci o0 = new Ogrenci();
            //Ogrenci o1 = new Ogrenci("Mehmet Şahin", new DateTime(1999, 09, 11), 1);
            //Ogrenci o2 = new Ogrenci("Ali Bayazıt", new DateTime(1996, 12, 26), 2);
            //Ogrenci o3 = new Ogrenci("Sevde Yılmaz", new DateTime(1999, 08, 25), 3);
            //Ogrenci o4 = new Ogrenci("Göktuğ Yıldız", new DateTime(1998, 06, 23), 4);

            //ArrayList gibi tek boyutlu idiz açtım. List --> Generic
            //Class ı List in içinde aldım

            //List<Ogrenci> ogrenciler = new List<Ogrenci>() {o0, o1, o2, o3,o4};

            List<Ogrenci> ogrenciler = new List<Ogrenci>() {};
            //var --> tipi belli olmayan tipler

            for (int i=0; i<1; i++)
            {
                Console.Write("Lütfen müşteri adı giriniz : ");
                string vad = Console.ReadLine();
                Console.Write("Lütfen doğum tarihini giriniz : ");
                DateTime vv = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Lütfen numaranızı giriniz :");
                int vno = Convert.ToInt32(Console.ReadLine());
                Ogrenci o1 = new Ogrenci(vad, vv, vno);
                ogrenciler.Add(o1);
            }
           
            Console.WriteLine("------------Tüm öğrencileriniz------------\n");
            foreach (Ogrenci o in ogrenciler)
                Console.WriteLine(o.Adi + " / " + o.Numarasi.ToString() + " / " + o.DogumTarihi.Year);

            var sorgu = from o in ogrenciler
                        where o.DogumTarihi.Year < 1999
                        select o.Adi + " / " + o.Numarasi.ToString() + " / " + o.DogumTarihi.Year;

            Console.WriteLine("\n------------Doğum tarihi 99 dan küçük olan öğrencileriniz------------\n");
            foreach(var o in sorgu)
                Console.WriteLine(o);


            var sorgu2 = from o in ogrenciler
                        where o.DogumTarihi.Year > 1999
                        select o.Adi + " / " + o.Numarasi.ToString() + " / " + o.DogumTarihi.Year;

            Console.WriteLine("\n------------Doğum tarihi 99 dan büyük olan öğrencileriniz------------\n");
            foreach (var o in sorgu2)
                Console.WriteLine(o);

            #endregion

            Console.ReadLine();
        }
    }
}
