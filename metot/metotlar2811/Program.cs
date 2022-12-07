using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar2811
{
    class Program
    {
        //static demek 1 tane olması demek. 2.si olmayacak. Tek metot her yerde aynı
        //Yemek yapmaya başlarken ilk yağ ve soğan sabit. Bnu tüm yemekle de kullanıyorum :)

        //static kaldırınca dinamik oluyor
        //static varsa static

        //metot kullanım tipi metot geriye döndürülen değer tipi metot ismi (parametreleri)
        static int toplaikikati(int a, int b)
        {
            //geriye değer döndürürken return kullan
            return (a + b) * 2;
        }

        //aynı isimli parametreli kullanabilmek için dinamik yapıyoruz
        //static ve dynamic farkı şu dinamik metodu çağırma yöntemi farklı
        //aynı isimli farklı parametrelerde kullanılan metotlara overloading denir
        //dinamikte aynı isimde metot oluşturabiliyoruz(parametre sayısı farklı), ama statikte aynı isimde metot oluşturmuyoruz 

        int Topla(int a, int b)
        {
            return a + b;
        }

        int Topla(int a, int b, int c)
        {
            return a + b + c;
        }

        static string parabirimi(int tl, float dolar, float euro)
        {
            return ($" Anapara : {tl / dolar} dolar ,{tl / euro} euro ");
        }

        //geriye değer döndürüyorsan return
        //void geriye değer döndürmeyen demek
        //void de return kullanılır ama yanına bir değişken almaz, programı bitirmesi için kullanılır

        //ÖR:
        //öğrenci notunu ekranda göster --> void
        //Öğrencilerin notlarının ortalamasını istiyorsan --> return

        //for ve metod veri tutmaz

        static void EkranaDegerYaz(object mesaj, int sayitekrari)
        {
            //var, object --> ne geliyosa kabulüm
            //Geriye değer döndürmüyorsa void kullan

            if (sayitekrari > 10)
            {
                Console.WriteLine("10 değerinden fazla mesaj yazılamaz");
                return; //Bunu söyleyerek programı kapatıyorum
            }

            for (int i = 0; i < sayitekrari; i++)
            {
                Console.WriteLine(mesaj);
            }
        }

        static void dizigoster(int[] dizi)
        {
            string tek = "", cift = "";
            foreach (int i in dizi)
            {
                if (i % 2 == 0)
                {
                    cift += i + ",";
                }
                else
                    tek += i + ",";
            }
            Console.WriteLine($"Çift Sayılar : {cift} \nTek Sayılar : {tek}");

        }

        //Her türlü diziyi kabul etmesi için 'Array' kullandım
        //string, int hangi veri tipinde olursa olsun
        static void tumdiziler(Array dizi)
        {
            foreach (var i in dizi) //tüm değişkenleri alması için var kullandık
                Console.WriteLine("i değeri : " + i);

        }

        static void degistirdizi(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                if (i < 3)
                    dizi[i] = 10; //ilk 3 değere 10 ata
                else
                    dizi[i] = 1; //geri kalan değerlere 1 ata
            }
        }

        static void degistir(int i)
        {
            i = 10;
        }

        static void yazdegisken(int i)
        {
            Console.WriteLine("i değeri : " + i);
        }

        static void Yaz(Array dizi)
        {
            foreach (object i in dizi)
                Console.WriteLine("i değeri : " + i);
        }

        static void degistir1(ref int i)
        {
            i = 10;
        }

        static void degistir2(out int i)
        {
            i = 10;
        }

        static int islem(string islemtipi, params int[] sayilar)
        {
            //params koyduğum zaman dizi içindeki parametreleri istediğin kadar sayı verebiliyoruz
            //params dinamik olmasını sağlıyor

            if (islemtipi == "Toplama")
            {
                int sonuc = 0;
                foreach (int i in sayilar)
                    sonuc += i;
                return sonuc;
            }

            else if (islemtipi == "Çarpma")
            {
                int sonuc = 1;
                foreach (int i in sayilar)
                    sonuc *= i;
                return sonuc;
            }

            else if (islemtipi == "Çıkarma")
            {
                int sonuc = sayilar[0];
                for (int i = 1; i < sayilar.Length; i++)
                    sonuc -= sayilar[i];
                return sonuc;
            }

            else if (islemtipi == "Bölme")
            {
                int sonuc = sayilar[0];
                for (int i = 1; i < sayilar.Length; i++)
                    sonuc /= sayilar[i];
                return sonuc;
            }
            else
                return 0;
        }

        static void Main(string[] args)
        {
            //Metot Mantığı --> Bir kere yaz her yerde kullan

            #region Açıklamalar

            /*
                Metotlar 
                küçük alt programlardır.
                2 ye ayrılır. 
                1.Statik
                2.Dinamik 
                Dinamik ve statik metotların aynı sınıfta birbirlerinden hiçbir farkları yoktur
                Kullanım olarak 2'ye ayrılırlar
                1. Değer Döndüren
                2. Değer Döndürmeyen
             */

            #endregion

            #region Metotlar

            #region Metotlar Bölüm1

            #region Örnek0 Statik Metotlar

            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //int c = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //int d = int.Parse(Console.ReadLine());

            //Console.Write($"Sonuç : {toplaikikati(c,d)}");

            #endregion

            #region Örnek dolareuro

            //Para birimi ver ona göre dönüşüm
            //metotta tl gir , dönüştürülecek para briimi 
            //klavyeden tl yi al

            //Console.Write("Ana para değeri gir (TL): ");
            //int para = int.Parse(Console.ReadLine());

            //Console.Write("Dolar kurunu değeri gir : ");
            //float dolar = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Euro kurunu değeri gir : ");
            //float euro = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine(parabirimi(para, dolar, euro));

            #endregion

            #region Örnek1 Dinamik Metotlar

            //Dinamik metota ulaşabilmek için onun bulunduğu sınıftan nesne oluşturmak zorundayım

            //Program pp = new Program(); //Program sınıfından pp nesnesi oluşturdum
            //int sonuc = pp.Topla(1, 2);
            //int sonuc1 = pp.Topla(1, 2, 3);
            //Console.WriteLine($"Sonuç : {sonuc}, Sonuç1 : {sonuc1}");

            #endregion

            #region Tanımlı metotlar

            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sayıyı giriniz : ");
            //int c = int.Parse(Console.ReadLine());


            ////Math class ındaki metotları kullandım
            //Console.WriteLine("3 sayı içindeki en büyük sayı = " + Math.Max(a, Math.Max(b,c)));
            //Console.WriteLine("3 sayı içindeki en küçük sayı = " + Math.Min(a, Math.Min(b, c)));


            #endregion

            #region Girilen sayının karesi

            //Console.Write("Lütfen karesi alınacak sayıyı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Pow(sayi, 2));

            #endregion

            #region Başka sınıftan static metot kullanımı

            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //int c = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //int d = int.Parse(Console.ReadLine());

            //Console.Write($"Sonuç : {Metotlarim.Topla(c,d)}"); //Metodun başına sınıfın ismini verdim

            #endregion

            #region Başka sınıftan dinamik metot kullanımı

            //Metotlarim mm = new Metotlarim();
            //int c = mm.Toplayeni(1,2);
            //int d = mm.Toplayeni(1, 2, 3);
            //Console.WriteLine($"Sonuç : {c}, \n Sonuç1 : {d}");

            #endregion

            #region voidliMetot

            //Console.Write("Lütfen Gösterilecek Mesajı Giriniz : ");
            //string cevap = Console.ReadLine();
            //Console.Write("Lütfen Mesaj Tekrar Sayısını Giriniz : ");
            //string cevap1 = Console.ReadLine();
            //EkranaDegerYaz(cevap, int.Parse(cevap1));

            #endregion

            #region Metota Dizi Gönderme

            //int[] dizi = { 1, 2, 3, 4, 5, 6 };
            //dizigoster(dizi);

            #endregion

            #region dizilermetot

            //int[] dizi = { 1, 2, 3, 4, 5, 6 };
            //string[] dizi1 = { "Sizce", "Bu ", "Sınıf", "Başarır", "mı?" };
            //tumdiziler(dizi);
            //Console.WriteLine("------------------------");
            //tumdiziler(dizi1);

            #endregion

            #region Dizi Güncelleme

            //int[] dizi = { 1, 2, 3, 4, 5, 6 };
            //foreach (int i in dizi)
            //{
            //    Console.WriteLine("i : " + i);
            //}

            //Console.WriteLine("---------------------------");

            //degistirdizi(dizi);
            //Yaz(dizi);

            #endregion

            #endregion

            #region Değişken Güncelleme

            //int i = 1;
            //degistir(i); //Değişken kalıcı hafızada olmadığı için değişmiyor
            //yazdegisken(i);

            #endregion

            #region Değişken Güncelleme Yeni - ref
            //Değişkenin başlangıç değeri varsa ref paramteresi kullan <-- Kalıcı hafızaya aktarabilmek için

            //int i = 1;
            //degistir1(ref i); //ref kullanarak geçici hafızadaki i yi kalıcı hafızaya aktarıyoruz
            //yazdegisken(i);

            #endregion

            #region Değişken Güncelleme Yeni - out

            //out a başlangıç değeri de atabilirsin ama ref e başlangıç değeri atamadan yazamasın
            //Değişkenin başlangıç değeri yoksa out paramteresi kullan  <-- Kalıcı hafızaya aktarabilmek için

            //int ii;
            //degistir2(out ii);
            //yazdegisken(ii);

            #endregion

            #region Birden Fazla Parametre

            Console.WriteLine("Sonuç : " + islem("Toplama", 4, 8, 6));
            Console.WriteLine("Sonuç : " + islem("Toplama", 4, 8, 6, 9, 15));
            Console.WriteLine("Sonuç : " + islem("Çarpma", 4, 8));
            Console.WriteLine("Sonuç : " + islem("Çıkarma", 4, 8));
            Console.WriteLine("Sonuç : " + islem("Bölme", 180, 9));

            #endregion

            #endregion

            #region Not Uygulaması

            //bir sınıfın notları girilecek 10 tane öğrencinin
            //içerisinde notları harf olarak göster listele 
            //notlar harfe dönüştürülsün mü diye soracak
            //ortalamanın üstünde olanları listelensin mi evet ise listele
            //hayır yazdığın zaman altında olanları listele
            //sınıfın en yüksek ve en düşük notlarını listele (isimle birlikte)

            //Not puan = new Not();
            //puan.notGir();

            //Console.Write("\nGirilen notların harf listesini görmek ister misiniz ? (e/h) : ");
            //string cevap = Console.ReadLine();

            //if (cevap == "e" || cevap == "e")
            //{
            //    puan.harfNotu("");
            //}

            //puan.ortalama(0);
            //puan.buyukkucuk(0);

            #endregion

            Console.ReadLine();

        }

        //static dinamik
        //void return
        //metod içine dizi
        //ref, out
        //param

    }

    class Not
    {
        string[] Liste2 = new string[6]; // 3 isim, 3 not

        public int notGir()
        {
            for (int i = 0; i < Liste2.GetLength(0); i += 2)
            {
                Console.Write($"İsim giriniz : ");
                string adi = Console.ReadLine();
                Liste2[i] = adi;

                Console.Write($"Not giriniz : ");
                string not2 = Console.ReadLine();
                Liste2[i + 1] = not2;

            }

            return Liste2.Length;
        }

        public string harfNotu(string harf)
        {

            for (int i = 0; i < Liste2.GetLength(0); i += 2)
            {
                if (int.Parse(Liste2[i + 1]) <= 100 && int.Parse(Liste2[i + 1]) > 80)
                {
                    Console.WriteLine($"İsim : {Liste2[i]} , Harf Notu : A");
                }

                if (int.Parse(Liste2[i + 1]) <= 80 && int.Parse(Liste2[i + 1]) > 70)
                {
                    Console.WriteLine($"İsim : {Liste2[i]} , Harf Notu : B");
                }

                if (int.Parse(Liste2[i + 1]) <= 70 && int.Parse(Liste2[i + 1]) >= 60)
                {
                    Console.WriteLine($"İsim : {Liste2[i]} , Harf Notu : C");
                }
            }

            return harf;
        }

        public int ortalama(int ortalama)
        {
            int toplam = 0, ortalama2 = 0;
            for (int i = 0; i < Liste2.GetLength(0); i += 2)
            {
                toplam += int.Parse(Liste2[i + 1]);
            }

            ortalama2 = toplam / 3;
            Console.WriteLine($"\nOrtalama =  {ortalama2}");


            Console.Write("Ortalamanın üstünde olanlar listelensin mi ? (e/h) : ");
            string cevap2 = Console.ReadLine();

            if (cevap2 == "e" || cevap2 == "E")
            {
                for (int i = 0; i < Liste2.GetLength(0); i += 2)
                {
                    if (int.Parse(Liste2[i + 1]) >= ortalama2)
                    {
                        Console.WriteLine($"İsim : {Liste2[i]} , Not :  {Liste2[i + 1]}");
                    }
                }
            }

            if (cevap2 == "h" || cevap2 == "H")
            {
                for (int i = 0; i < Liste2.GetLength(0); i += 2)
                {
                    if (int.Parse(Liste2[i + 1]) < ortalama2)
                    {
                        Console.WriteLine($"İsim : {Liste2[i]} , Not :  {Liste2[i + 1]}");
                    }
                }
            }

            return ortalama;
        }

        public int buyukkucuk(int a)
        {

            int buyuk = 0;
            int kucuk = 1000;

            Console.Write("En yüksek ve en düşük not listelensin mi ? (e/h) : ");
            string cevap3 = Console.ReadLine();

            string name1 = "", name2 = "";

            for (int i = 0; i < Liste2.GetLength(0); i += 2)
            {
                if (buyuk < int.Parse(Liste2[i + 1]))
                {
                    buyuk = int.Parse(Liste2[i + 1]);
                    name1 = Liste2[i];
                }

                else if (kucuk > int.Parse(Liste2[i + 1]))
                {
                    kucuk = int.Parse(Liste2[i + 1]);
                    name2 = Liste2[i];
                }
            }

            Console.WriteLine($"İsim : {name1} , En yüksek not : {buyuk} ");
            Console.WriteLine($"İsim : {name2} , En küçük not : {kucuk} ");


            return a;
        }


    }

    class Metotlarim
    {
        /* 
        Erişim belirteçleri (public, private, protected, internal protected)
        public bir sınıf üyelerine dışardan herkesin erişebilmesini sağlar
        private bir sınıf üyelerine sadece o sınıftan erişilebilir
        protected bir sınıfın üyelerine sadece o sınıftan türeyen sınıflar erişebilir
        */

        //metot ismi için
        //ne işe yaradığını en kısaca anlat 
        //string döndürüyor ise s, int döndürüyor ise i 

        public static int Topla(int a, int b)
        {
            return a + b;
        }

        public int Toplayeni(int a, int b)
        {
            return a + b;
        }

        public int Toplayeni(int a, int b, int c)
        {
            return a + b + c;
        }
    }

}

