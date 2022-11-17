using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Açıklamalar

            /*
             Diziler kalıcı hafızaya geçiyor. Çok ihtiyaç olmadıkça kullanmayız
             Diziler 0. indeksten başlar
             2 boyutluda (0,0) , (0,1) , (0,2) , (1,0), (1,1), (1,2) 

             Diziler 4 gruba ayrılır.
             1. Tek Boyutlu Diziler --> Tek eksen var
             2. İki Boyutlu Diziler --> x ve y ekesni var
             3. Üç Boyutlu Diziler
             4. Düzensiz Diziler(Jagged) 

            Diziler İçin Kurallar: 
                Dizinin boyutu belli olmak zorunda (Yani kaç elemanlı olduğu)
                Dizinin tipi olacak(Yani int, karakter, float...)
                Eğer bir dizinin tipi ve boyutu olmazsa buna koleksiyon deriz.
            */

            #endregion

            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            #region Diziler01
            /*
            #region Tanımlamalar

            int[] dizi = new int[4]; //4 elemanlı, itpi int olan dizi

            //new ile kalıcı hafızaya atıyoruz

            #endregion

            #region Veri Girişi

            dizi[0] = 5;
            dizi[1] = 6;

            #endregion

            #region Dizileri Ekrana Yazmak

            Console.WriteLine($"Dizinin 1. elemanı : {dizi[0]}");
            Console.WriteLine($"Dizinin 2. elemanı : {dizi[1]}");
            Console.WriteLine($"Dizinin 3. elemanı : {dizi[2]}");
            Console.WriteLine($"Dizinin 4. elemanı : {dizi[3]}");

            #endregion
            */

            #endregion

            #region Tanımlar

            //string[] hocalar = { "serdar", "ufuk", "sinan" };  //Değer girdiğin için dizinin içine boyut belirtmene gerek yok. Bu örnekte otomatik olarak diziyi 3 boyutlu alır.
            //int[] dizi2 = { 4, 5, 6 };
            //float[] dizi3 = { 2f, 1.2f };
            //double[] dizi4 = { 2d, 5.2d, 55.5d };

            //#endregion

            //#region Dizileri Ekrana Yazmak

            //Console.WriteLine($"Dizinin 1. elemanı : {hocalar[0]}");
            //Console.WriteLine($"Dizinin 2. elemanı : {dizi2[1]}");
            //Console.WriteLine($"Dizinin 2. elemanı : {dizi3[1]}");
            //Console.WriteLine($"Dizinin 3. elemanı : {dizi4[2]}");

            #endregion

            #region Diziye Veri Girişi Girmek

            //menu:
            //    Console.Clear();
            //    Console.Write("Dizinin boyutunu 0 ile 100 aralığında belirleyiniz : ");
            //    int sayi = int.Parse(Console.ReadLine());
            //    Console.WriteLine();

            //    if (sayi>0 && sayi<100)
            //    {
            //        int [] dizi = new int[sayi]; //Belirlediğim sayı kadar dizinin boyutunu oluşturdum
            //        for (int i = 0; i < sayi; i++)
            //        {

            //            if (sayi-1 == i) //dizinin son elemanı
            //            {
            //                dizi[i] = 50; // 50 ye eşitle
            //            }
            //            else
            //             dizi[i] = i;
            //            Console.WriteLine("Dizinin " + (i+1) + ". elemanı : " + dizi[i]);
            //        }
            //        Console.WriteLine("\nYeni bir işlem yapmak istiyor musunuz ? (e/h)");
            //        string cevap = Console.ReadLine();
            //        if (cevap == "e" || cevap == "E")
            //        {
            //            Console.Clear();
            //            goto menu;
            //        }
            //        else
            //            Environment.Exit(0);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen dizinin eleman sayısı 0 dan büyük şekilde giriniz");
            //        goto menu;
            //    }

            #endregion

            #region Diziler Örnek1

            //Kullanıcıdan kaç adet ders ve süre olduğunu girin
            //kaç adet ders, dersin adı, dersin süre
            //3 adet girdiyse 3 adet ders adı ve 3 dersin süresini iste
            //mat:45, tr:30, tarih:25 <-- listele

            //menu:
            //Console.Clear();
            //Console.Write("Ders sayısı girin: ");
            //int dersAdet = int.Parse(Console.ReadLine());

            //string[] dizi = new string[dersAdet*2];

            //int x = dersAdet * 2;

            //for (int i = 0; i < x; i+=2)
            //{
            //    Console.Write("\nDers adını giriniz : ");
            //    dizi[i] = Console.ReadLine();

            //    Console.Write("Ders süresi giriniz : ");
            //    dizi[i + 1] = Console.ReadLine();
            //}


            //for (int j = 0; j < x; j+=2)
            //{
            //    Console.WriteLine("Dersin adı : "  + dizi[j] + ", Dersin süresi :" + dizi[j+1] );
            //}

            //    Console.WriteLine("\nYeni bir işlem yapmak istiyor musunuz ? (e/h)");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "e" || cevap == "E")
            //    {
            //        Console.Clear();
            //        goto menu;
            //    }
            //    else
            //        Environment.Exit(0);

            #endregion

            #region for ve foreach döngüsü

            /* 
             
            foreach sadece okur yani listeler --> içinde dizi elemanını değiştiremem
            foreach kullanılan yerler : 
                1) diziler,
                2) koleksiyonlar,
                3) nesneler
            for hem okur hem yazar --> içinde dizi elemanını değiştirebilirim
             
            */

            ////int[] sayilar = { 1, 2, 3 };

            ////Console.WriteLine("For each Listesi");
            ////foreach (int i in sayilar)
            ////{
            ////    Console.WriteLine(i);
            ////}

            /*
                GetLength --> dizinin boyutunu alır. 
                (0) tek boyutlu, 
                (1) de ise iki boyutlu, 
                (2) üç boyutlu dizilerde kullanılır
            */

            ////Console.WriteLine("For Döngüsü ile Listeleme");
            ////for (int i = 0; i < sayilar.GetLength(0); i++)
            ////{
            ////    if (i == sayilar.GetLength(0) - 1)
            ////        sayilar[i] = 1000;
            ////    Console.WriteLine(sayilar[i]);
            ////}


            #endregion


            #region foreach örnek

            //14 öğrencinin adı ve notlarını klavyeden al. Ekrana bu sınıfta kaç kişi A aldı, B aldı, C aldı yazacak

            int sayac = 0, sayac1=0, sayac2=0;
            int boyut = 3;
            string [] not = new string[boyut * 2];

            int x = boyut * 2;

            for (int i = 0; i < x; i+=2)
            {
                Console.Write("Ad giriniz : ");
                string adi = Console.ReadLine();
                not[i] = adi;

                Console.Write("Not giriniz : ");
                string not2 = Console.ReadLine();
                not[i + 1] = not2;
            }

            for (int j = 0; j < x; j+=2)
            {
                if (not[j + 1] == "100")
                {
                    sayac++;
                    Console.WriteLine($"{sayac} kişi A aldı");
                }
                else if (not[j + 1] == "80")
                {
                    sayac1++;
                    Console.WriteLine($"{sayac1} kişi B aldı");
                }
                else  if (not[j + 1] == "70")
                {
                    sayac2++;
                    Console.WriteLine($"{sayac2} kişi C aldı");
                }
            }

            #endregion


            Console.ReadLine();
        }
    }
}
