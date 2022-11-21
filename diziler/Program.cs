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

            #region for ile dizi örneği

            //14 öğrencinin adı ve notlarını klavyeden al. Ekrana bu sınıfta kaç kişi A aldı, B aldı, C aldı yazacak

            //int sayac = 0, sayac1=0, sayac2=0;
            //int boyut = 3;
            //string [] not = new string[boyut * 2];

            //int x = boyut * 2;

            //for (int i = 0; i < x; i+=2)
            //{
            //    Console.Write("Ad giriniz : ");
            //    string adi = Console.ReadLine();
            //    not[i] = adi;

            //    Console.Write("Not giriniz : ");
            //    string not2 = Console.ReadLine();
            //    not[i + 1] = not2;
            //}

            //for (int j = 0; j < x; j+=2)
            //{
            //    if (not[j + 1] == "100")
            //    {
            //        sayac++;
            //    }
            //    else if (not[j + 1] == "80")
            //    {
            //        sayac1++;
            //    }
            //    else  if (not[j + 1] == "70")
            //    {
            //        sayac2++;
            //    }
            //}
            //Console.WriteLine($"{sayac} kişi A aldı");
            //Console.WriteLine($"{sayac1} kişi B aldı");
            //Console.WriteLine($"{sayac2} kişi C aldı");

            #endregion

            #region foreach

            //string [] ss = {"x", "40", "y", "50", "z", "52" };
            //int val;
            //int sayacf = 0, sayacd = 0, sayacc = 0, sayacb = 0;

            //foreach (string s in ss)
            //{
            //    if (int.TryParse(s, out val))
            //    {
            //        if (int.Parse(s) < 45)
            //            sayacf++;

            //        else if (int.Parse(s) > 45 || int.Parse(s) < 55)
            //            sayacd++;
            //    }
            //}

            //Console.WriteLine($"F : {sayacf}");
            //Console.WriteLine($"D : {sayacd}");

            #endregion

            #region forech döngüsü örnek

            //int sayacf = 0, sayacd = 0, sayacc = 0;
            //int boyut = 3;
            //string[] not = new string[boyut * 2];
            //int x = boyut * 2;

            //for (int i = 0; i < x; i+=2)
            //{
            //    Console.Write("Ad giriniz : ");
            //    string adi = Console.ReadLine();
            //    not[i] = adi;

            //    Console.Write("Not giriniz : ");
            //    string not2 = Console.ReadLine();
            //    not[i + 1] = not2;
            //}

            //int val;
            //foreach (string s in not)
            //{
            //    if (Int32.TryParse(s, out val))//girilen değerin int e dönüşüp dönüşmediğini kontrol ediyoruz
            //    {
            //        if (int.Parse(s) < 45)
            //            sayacf++;

            //        else if (int.Parse(s) >= 45 && int.Parse(s) < 55)
            //            sayacd++;

            //        else if (int.Parse(s) >= 55 && int.Parse(s) < 65)
            //            sayacc++;
            //    }
            //}

            //Console.WriteLine($"{sayacf} kişi F aldı");
            //Console.WriteLine($"{sayacd} kişi D aldı");
            //Console.WriteLine($"{sayacc} kişi C aldı");

            #endregion

            //dizinin boyutunu öğrenmek için Rank metodunu kullanırız

            #region 18.11 - örnek
            //Notları girdi soru sorsun sınıftaki en yüksek mi en düşük notu mu getirmek istiyorsun?
            //yüksek seçerse en yükseği, düşük seçerse en düşük not görünsün

            //menu:
            //    int buyuk = 0, kucuk = 0;
            //    int sayacf = 0, sayacd = 0, sayacc = 0;
            //    int boyut = 3;
            //    string[] not = new string[boyut * 2];
            //    int x = boyut * 2;

            //    for (int i = 0; i < x; i += 2)
            //    {
            //        Console.Write("Ad giriniz : ");
            //        string adi = Console.ReadLine();
            //        not[i] = adi;

            //        Console.Write("Not giriniz : ");
            //        string not2 = Console.ReadLine();
            //        not[i + 1] = not2;
            //    }

            //    Console.WriteLine("Sınıftaki en yüksek mi en düşük notu mu getirmek istiyorsun? (Yüksek / Düşük)");
            //    string cevap = Console.ReadLine();

            //    for (int i = 0; i < x; i+=2)
            //    {
            //        int sayi = int.Parse(not[i + 1]);
            //        if (i==0)
            //        {
            //            buyuk = sayi;
            //            kucuk = sayi;
            //        }

            //        if (sayi > buyuk)
            //            buyuk = sayi;

            //        if (sayi < kucuk)
            //            kucuk = sayi;
            //    }

            //    if (cevap == "Yüksek")
            //    {
            //        Console.Write($"En yüksek not : {buyuk}");
            //    }
            //    else if (cevap == "Düşük")
            //    {
            //        Console.Write($"En düşük not : {kucuk}");
            //    }

            //    Console.WriteLine("\nYeniden işlem yapmak istiyor musunuz ? (e/h)");
            //    string cevap2 = Console.ReadLine();
            //    if (cevap2 == "e" || cevap2 == "E")
            //    {
            //        Console.Clear();
            //        goto menu;
            //    }

            #endregion

            #region Diziler

            //int[] array = new int[5] { 1,4,2,3,5 };
            //Console.WriteLine("Dizinin başlangıç değerleri : ");
            //foreach(int i in array)
            //    Console.WriteLine(i);

            //Array.Sort(array);


            //Console.WriteLine("Dizinin sıralanmış değerleri : ");
            //foreach (int i in array)
            //    Console.WriteLine(i);

            //Array.Reverse(array);


            //Console.WriteLine("Dizinin tersten sıralanmış değerleri : ");
            //foreach (int i in array)
            //    Console.WriteLine(i);

            #endregion

            #region İki Boyutlu Diziler

            //dizi1[satır, sütun]-- > GetLength(0) dersem satırı, GetLength(1) sütunu alır

            //int[,] dizi1 = new int[2, 3]; //2 boyutlu dizi --> 2 satır 3 sütun 
            //int[,] dizi2 = new int[2, 3];
            //int[,] dizi3 = new int[2, 3];

            //Console.WriteLine("Dizi1 olan A matrisinin elemanlarını giriniz");

            //for (int i = 0; i < dizi1.GetLength(0); i++) //i --> satır
            //{
            //    for (int j = 0; j < dizi1.GetLength(1); j++) //sütun
            //    {
            //        Console.Write($"A matrisinin {i + 1}. satır {j + 1}. sütun değerini giriniz : ");
            //        dizi1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nDizi1 olan A matrisinin elemanlarını listeleyiniz");
            //for (int i = 0; i < dizi1.GetLength(0); i++) //satır
            //{
            //    for (int j = 0; j < dizi1.GetLength(1); j++) //sütun
            //    {
            //        Console.Write(dizi1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}


            #endregion

            #region İki Boyutlu Dizi Örneği

            //int[,] dizi4 = new int[2, 3]; //2 boyutlu dizi --> 2 satır 3 sütun 
            //int[,] dizi5 = new int[2, 3];
            //int[,] sonuc = new int[2, 3];

            ////A matrisi
            //Console.WriteLine("Dizi1 olan A matrisinin elemanlarını giriniz");

            //for (int i = 0; i < dizi4.GetLength(0); i++) //i --> satır
            //{
            //    for (int j = 0; j < dizi4.GetLength(1); j++) //sütun
            //    {
            //        Console.Write($"A matrisinin {i + 1}. satır {j + 1}. sütun değerini giriniz : ");
            //        dizi4[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nDizi1 olan A matrisinin elemanlarını listeleyiniz");
            //for (int i = 0; i < dizi4.GetLength(0); i++) //satır
            //{
            //    for (int j = 0; j < dizi4.GetLength(1); j++) //sütun
            //    {
            //        Console.Write(dizi4[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            ////B matrisi
            //Console.WriteLine("Dizi2 olan B matrisinin elemanlarını giriniz");

            //for (int k = 0; k < dizi5.GetLength(0); k++) //i --> satır
            //{
            //    for (int l = 0; l < dizi5.GetLength(1); l++) //sütun
            //    {
            //        Console.Write($"B matrisinin {k + 1}. satır {l + 1}. sütun değerini giriniz : ");
            //        dizi5[k, l] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nDizi2 olan B matrisinin elemanlarını listeleyiniz");
            //for (int i = 0; i < dizi5.GetLength(0); i++) //satır
            //{
            //    for (int j = 0; j < dizi5.GetLength(1); j++) //sütun
            //    {
            //        Console.Write(dizi5[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\nC matrisi : ");
            ////C matrisi

            //for (int i = 0; i < sonuc.GetLength(0); i++) //satır
            //{
            //    for (int j = 0; j < sonuc.GetLength(1); j++) //sütun
            //    {
            //        sonuc[i, j] = dizi4[i, j] + dizi5[i, j];

            //        Console.Write(sonuc[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}


            #endregion

            //4. hafta ÖDEV

            #region 1 ile 1000 arasında 5 e bölünebilen sayıların listesi ve adedi

            //short sayac = 0;

            //Console.WriteLine("1 ile 1000 arasında 5 e bölünebilen sayıların listesi : ");

            //int[] dizi = new int[60];

            //for (short i = 1; i < dizi.Length; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        dizi[i] = i;
            //        Console.WriteLine(dizi[i]);
            //        sayac++;
            //    }
            //}

            //Console.WriteLine($"\n5 e bölünebilen sayıların adedi : {sayac}");

            #endregion

            #region 5 e bölünebilen 7 ye bölünemeyen sayıların listesi ve adetleri 

            //int sayac2 = 0;

            //int[] dizi2 = new int[60];


            //for (int i = 1; i < dizi2.Length; i++)
            //{
            //    if (i % 5 == 0 && i % 7 != 0)
            //    {
            //        dizi2[i] = i;
            //        Console.WriteLine(i);
            //        sayac2++;
            //    }
            //}

            //Console.WriteLine($"5'e tam bölünebilen 7'ye bölünemeyen sayıların adedi :  {sayac2}");

            #endregion


            //Kullanıcı adı ve şifre için ilk önce giriş gelecek giriş yapınca böyle bir kullanıcı adı şifre yok diyip kayıt ol ekranı gelecek
            //Kaydetmek istiyor musunuz diye soracak evet dersem kaydedecek hayır dersem kaydetmeyecek


            #region Kullanıcı Girişi - Faz 1

            //faz1 kullanıcı adını kendin gir
            //form adı : kullanıcı adı , şifre
            //dizinin ismi: kullanıcı ismi
            //menu:
            //    string[,] kullanici_ismi = new string[,] { { "0", "user", "pass" }, { "1", "usern", "passw" } };

            //    int boyut = 1;
            //    string[] dizi = new string[boyut * 2];
            //    int x = boyut * 2;

            //    for (int i = 0; i < x; i += 2)
            //    {
            //        Console.Write("Kullanıcı adı giriniz : ");
            //        string kadi = Console.ReadLine();
            //        dizi[i] = kadi;

            //        Console.Write("Şifre giriniz : ");
            //        string sifre = Console.ReadLine();
            //        dizi[i + 1] = sifre;
            //    }

            //    bool st = false;

            //    for (int i = 0; i < kullanici_ismi.GetLength(0); i += 2) //satır
            //    {
            //        for (int j = 0; j < kullanici_ismi.GetLength(0); j += 2)
            //        {
            //            if (dizi[i] == kullanici_ismi[i, j + 1] && dizi[i + 1] == kullanici_ismi[i, j + 2])
            //            {
            //                Console.WriteLine("Kullanıcı girişi başarılı");
            //                st = true;
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Kullanıcı girişi başarısız");
            //                Console.WriteLine("\nYeniden giriş yapmak istiyor musunuz ? (e/h)");
            //                string cevap2 = Console.ReadLine();
            //                if (cevap2 == "e" || cevap2 == "E")
            //                {
            //                    Console.Clear();
            //                    goto menu;
            //                }
            //                else
            //                    Environment.Exit(0);
            //            }
            //        }
            //    }

            #endregion

            #region Kullanıcı Girişi Faz - 2

            string[,] veritabani = new string[2, 3];

            string name1, name2, pass1, pass2;

            string name3, pass3, name4, pass4;

            veritabani[0, 0] = "1";
            veritabani[1, 0] = "2";

            int sayac = 0, sayac2 = 0;
            int j = 0;
            for (int i = 0; i < veritabani.GetLength(0); i++)
            {
                if (j == 0)
                {
                    Console.WriteLine("\nKAYIT OL\n");
                    Console.Write("Kullanıcı adı giriniz : ");
                    name1 = Console.ReadLine();
                    veritabani[i, j + 1] = name1;

                    Console.Write("Şifre giriniz : ");
                    pass1 = Console.ReadLine();
                    veritabani[i, j + 2] = pass1;
                    j++;
                    sayac++;
                    sayac2++;

                    Console.WriteLine("Kullanıcı kaydı başarılı");

                menu2:
                    Console.Clear();
                    Console.WriteLine("\nGİRİŞ YAP\n");

                    Console.Write("Kullanıcı Adı giriniz : ");
                    name3 = Console.ReadLine();

                    Console.Write("Şifre giriniz : ");
                    pass3 = Console.ReadLine();

                    bool st = false;

                    if (name3 == name1 && pass3 == pass1)
                    {
                        Console.WriteLine("Kullanıcı girişi başarılı");
                        st = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kullanıcı girişi başarısız");
                        Console.WriteLine("\nYeniden giriş yapmak istiyor musunuz ? (e/h)");
                        string cevap2 = Console.ReadLine();
                        if (cevap2 == "e" || cevap2 == "E")
                        {
                            Console.Clear();
                            goto menu2;
                        }
                    }
                }

                Console.Clear();

            menu:
                Console.Write("\nYeni kullanıcı girmek ister misiniz ? (e/h) : ");
                string cevap = Console.ReadLine();

                if (j == 1)
                {
                    if (cevap == "e" || cevap == "E")
                    {
                        if (sayac == 1)
                        {
                            Console.Write("Kullanıcı adı giriniz : ");
                            name2 = Console.ReadLine();
                            name2 = veritabani[i, j];

                            Console.Write("Şifre giriniz : ");
                            pass2 = Console.ReadLine();
                            pass2 = veritabani[i, j + 1];
                            sayac++;
                            sayac2++;

                        menu3:
                            Console.Clear();
                            Console.WriteLine("\nGİRİŞ YAP\n");

                            Console.WriteLine("Kullanıcı Adı giriniz : ");
                            name4 = Console.ReadLine();

                            Console.WriteLine("Şifre giriniz : ");
                            pass4 = Console.ReadLine();

                            bool st = false;

                            if (name4 == name2 && pass4 == pass2)
                            {
                                Console.WriteLine("Kullanıcı girişi başarılı");
                                st = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kullanıcı girişi başarısız");

                                Console.Clear();

                                Console.Write("\nYeniden giriş yapmak istiyor musunuz ? (e/h) : ");
                                string cevap2 = Console.ReadLine();
                                if (cevap2 == "e" || cevap2 == "E")
                                {
                                    Console.WriteLine("Kayıt doldu artık kayıt yapılamaz");
                                    break;
                                }
                            }
                            goto menu;

                        }

                        if (sayac2 == 2)
                        {
                            Console.WriteLine("Kayıt doldu artık kayıt yapılamaz");
                            break;
                        }
                    }
                    else
                        Environment.Exit(0);

                }

            }


            #endregion

            Console.ReadLine();
        }
    }
}
