using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2011122
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  Bölüm2 Tür Dönüşümü

            #region bilinçsiz tür dönüşümü

            //byte a = 5;
            //sbyte b = 10;
            //short s = 30;
            //int d = a + b + s;
            //string e = "deneme";
            //char f = 'k';
            //object g = e + f + d;
            //long h = d;
            //float f2 = h;
            //double g2 = f2;

            //Console.WriteLine($"d değeri : {d}");
            //Console.WriteLine($"g değeri : {g}");
            //Console.WriteLine($"g2 değeri : {g2}");

            #endregion

            #region karakteri integer a dönüştürme

            //char a = 'k';
            //int b = a;
            //Console.WriteLine($"b : {b}");

            //metini int e atamıyoruz
            //string c = "deneme";
            //int d = c;
            //Console.WriteLine($"d : {d}");

            #endregion

            #region bilinçli tür dönüşümü
            //(byte) dönüşümüne casting diyoruz

            //ekstra kod yazıyor dönüştüğümüz türün içine yazıyoruz
            //performans kaybı var, zorda kalmadığın sürece kullanma

            //int a = 3;
            //float b = 2.5f;
            //decimal c = 12.5m;
            //byte bb = (byte)a;
            //sbyte bb2 = (sbyte)b; //her zaman aşağı yuvarlar
            //short c2 = (short)b;
            //b = (byte)c;

            //Console.WriteLine($"bb nin değeri : {bb}");
            //Console.WriteLine($"bb2 nin değeri : {bb2}");
            //Console.WriteLine($"c2 nin değeri : {c2}");
            //Console.WriteLine($"b nin değeri : {b}");

            #endregion

            #region Taşma Kontrolü

            //int anapara = 100;
            //int faiz = 2; //faiz = 2 iken çalışır
            ////faiz 3 iken çalışmaz
            //int bakiye = anapara * faiz;
            ////byte b = (byte)bakiye; --> MANTIK HATASI var ama çalışır
            //byte b = 0;
            //byte c = 0;
            //float kdv = 318.5f;
            ////Check --> kontrol, uncheck kontrol dışı

            //checked //dönüşümü, kontrolü yapıyor
            //{
            //    b = (byte)bakiye; //b nin taşma ihtimali var

            //    unchecked //muaf bırakıyor //check kontrolünün dışında
            //    {
            //        //b ile c arasında ilişki olmadığı zaman ayrı ayrı yerlerde yazabiliriz
            //        //c nin taşma ihtimali yok onun için unchecked kullandık
            //        //c = (byte)kdv;

            //        //Ancak aralarında ilişki olduğu zaman bu şekilde kullanmamız gerekir
            //        c = (byte)((byte)kdv + b / 2); //b ile c arasında ilişki var
            //    }
            //}

            //Console.WriteLine($"b nin değeri : {b}");
            //Console.WriteLine($"c nin değeri : {c}");

            #endregion

            #region Convert ile Parse arasındaki Fark

            // her ikisi de dönüşüm için kullanılan metotlardır
            // 1. si Parse metodu kullanıyorsak içindeki değer her zaman metin olmak zorundadır
            // Örnek int.parse(x) komutunda x her zaman metin olmak zorundadır
            // Klavyeden veri girişi varsa Parse kullan. Tipini biliyorsan Parse, bilmiyorsan Convert kullan
            // klavyeden her girişe kullan

            //2.si Convert metot'unu kullanıyorsak içindeki değeri metin olma zorunluluğu yoktur
            //Örnek Convert.ToByte(x) komutunda x değeri null olabilir
            //Bu şekilde geriye 0 değerini döndürür
            //Klavyeden değil de tablodan vs veri okursa Convert kullanıyoruz

            //Parse Örneği
            //int sonuc = 0;
            //string cevap = "1";
            //sonuc = int.Parse(cevap);
            //Console.WriteLine($"sonuc : " + sonuc);

            //Convert Örneği
            //int sonuc1 = 0;
            //string cevap1 = "12";
            //ToInt16-ToInt32-ToInt64 --> bunlar işletim sistemine göre belirleniyor
            //ToInt64 int i aşıyor, long kullanırsan hata vermez
            //sonuc1 = Convert.ToInt32(cevap1);
            //Console.WriteLine($"sonuc1 : " + sonuc1);


            //ÖRNEK
            //int sonuc2 = 0;
            //string cevap2 = null; ;
            //sonuc2 = Convert.ToInt32(cevap2);
            //Console.WriteLine($"sonuc2 : " + sonuc2);

            //ÖRNEK
            //çalışmaz --> parse bir değere null atanmaz
            //'Değer null olmaz' hatası verir.
            //int sonuc3 = 0;
            //string cevap3 = null;
            //sonuc3 = int.Parse(cevap3);
            //Console.WriteLine($"sonuc : " + sonuc3);


            #endregion

            #region Örnek1
            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //byte toplam = 0;
            //byte sayi1;
            //sayi1 = Convert.ToByte(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //byte sayi2;
            //sayi2 = Convert.ToByte(Console.ReadLine());
            //toplam = Convert.ToByte(sayi1 + sayi2);

            //Console.WriteLine($"Toplam = {toplam}");

            #endregion

            #region Örnek2

            //Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            //float toplam = 0;
            //float sayi1;
            //sayi1 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
            //float sayi2;
            //sayi2 = Convert.ToSingle(Console.ReadLine());
            //toplam = Convert.ToSingle(sayi1 + sayi2);

            //Console.WriteLine($"Toplam = {toplam}");

            #endregion

            #endregion

            #region Bölüm3 Operatörler

            /*
            Operatörler tek başına anlamı olmayan ancak programın işleyişine katkıda bulunan karakterlerdir.
            Örneğin a + b ifadesinde + işareti operatördür.
            Operatörlerin etki ettikleri sabit ya da değişkenlere operand denir
            a ve b operand tır
            */

            #region ornek1 operator
            //işlemler matematiksel duruma göre ilerler.
            //int i = 3 + 5 / 7; //çıktısı 3 olur
            //double d = 3 + 5 / 7; //çıktısı 3 olur
            //double dd = 3d + 5d / 7d; //çıktısı küsüratlı olur //sadece birine d koyman da aynı sonucu verir
            //float f = 3f * 5f / 6f; //çıktısı 2.5 olur
            //float ff = 3f * (5 / 7); //parantez öncelik kazanır. Öncelikli işlemdir

            //Console.WriteLine($"Tamsayı değeri : {i} \n ondalıklı sayı double değeri : {d} \n ");


            #endregion

            #region ornek2 attırım operatörleri

            //++a veya a++ kullanımı a = a + 1 değerine eşittir

            //int a = 5;
            //int b = a++; //burda a++ --> a'yı etkiliyor
            ////b değişkenine önce a değeri atanır sonra a değeri 1 artırılır
            //Console.WriteLine("b değeri : " + b); //b nin değeri 5 olur
            //Console.WriteLine("a değeri : " + a); //a nin değeri 6 olur

            //Console.WriteLine("----------------------------------");

            //int c = 5;
            //int d = ++c; //burda a++ --> a'yı etkiliyor
            ////d değişkenine önce c değeri 1 artırılır sonra c değeri atanır
            //Console.WriteLine("d değeri : " + d); //d nin değeri 6 olur
            //Console.WriteLine("c değeri : " + c); //c nin değeri 6 olur

            //Console.WriteLine("----------------------------------");

            //int e = 5;
            //int f = e--;
            //Console.WriteLine("e değeri : " + e); //f nin değeri 5 olur
            //Console.WriteLine("f değeri : " + f); //e nin değeri 4 olur

            //Console.WriteLine("----------------------------------");

            //int k = 5;
            //int l = --k;
            //Console.WriteLine("k değeri : " + k); //k nin değeri 4 olur
            //Console.WriteLine("l değeri : " + l); //l nin değeri 4 olur


            #endregion

            #region değişkene null değeri atamak

            // ? olunca null değeri atabilir olur
            // bir şeyi hafızadan rezerve ediyor
            // ? bir operatördür
            //int? sayi = null;
            //double? sayid = new double?();
            //bool? sayis = new bool?();
            //float? sayif = 2f; //burda '?' değer olduğu gibi olamaz da
            //Console.WriteLine($"sayi : {sayi} \n sayid : {sayid} \n sayis : {sayis} \n sayif : {sayif}");

            #endregion

            #region örnek3

            //klavyeden sıcaklık değeri gir K ve F ye dönüştür kullanıcıya bilgi aktar
            //Console.Write("Klavyeden sıcaklık değeri giriniz : ");
            //float sicaklik;
            //sicaklik = Convert.ToSingle(Console.ReadLine());
            //float kelvin = Convert.ToSingle(sicaklik + 273.15);
            //float fahrenheit = Convert.ToSingle((sicaklik * 1.8) + 32);

            //Console.WriteLine($"kelvin : {kelvin}");
            //Console.WriteLine($"fahrenheit : {fahrenheit}");

            #endregion

            #region örnek4

            //çarpım tablosu 
            //1*1
            //1*2
            //1*3
            //1*4

            //Console.Write("Sayıyı giriniz : ");
            //byte x = Convert.ToByte(Console.ReadLine());

            //Console.Write($"{x} * {1} = " + (1 * x)
            //            + $"\n{x} * {2} = " + (2 * x)
            //            + $"\n{x} * {3} = " + (3 * x)
            //            + $"\n{x} * {4} = " + (4 * x)
            //            + $"\n{x} * {5} = " + (5 * x)
            // );

            #endregion

            #region örnek5 iki sayıdan negatif veya pozitif kontrolü

            //girilen 2 sayının negatif pozitif kontrolü
            //iki sayı ya pozitif ya da negatif olacak
            //iki sayıdan biri negatif olacak

            //mantıksal operatör
            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //sbyte sayi1;
            //sayi1 = Convert.ToSByte(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //sbyte sayi2;
            //sayi2 = Convert.ToSByte(Console.ReadLine());

            //Console.WriteLine((sayi1 < 0 && sayi2 > 0) || (sayi1 > 0 && sayi2 < 0));

            #endregion

            #region bool kontrolü

            //bool a = 4 < 6;
            //bool b = 6 > 5;
            //bool c = 7 <= 7;
            //bool d = 9 >= 12;
            //bool e = 10 == 12;
            //bool f = 1 != 8;

            //Console.WriteLine($"a : {a}");
            //Console.WriteLine($"b : {b}");
            //Console.WriteLine($"c : {c}");
            //Console.WriteLine($"d : {d}");
            //Console.WriteLine($"e : {e}");
            //Console.WriteLine($"f : {f}");

            #endregion

            #region As operatörü kullanımı
            //as operatörü ile nesne başka bir tipe dönüştürülebilir.
            //veya bir tip nesneye as operatörü ile dönüşüm yapabilir.
            //nesne(object) bir alt tipe dönüştürülemiyor.
            //object i = 50;
            //string s = i as string;
            //Console.WriteLine("s : " + s);

            //int ss = 50;
            //object oo = ss as object;
            //Console.WriteLine("oo : " + oo);//çıktı 50 olur

            //object ten küçüğü dönüştürülebilir
            //object i tek başına bu şekilde kullanmıyoruz

            //using kullanınca aa değişkeni çalışmaz

            #endregion

            #region is komutuyla kontrol

            //int i = 50;
            //byte a = 12;
            //bool b1 = i is int;
            //bool b2 = i is double;
            //bool b3 = 15.3 is double;
            //bool b4 = "ceyhan" is string;
            //bool b5 = 12f + 7 is float;
            //bool b6 = a is byte;
            //bool b7 = 'c' is char;
            //bool b8 = "ceyhan" is char;

            //Console.WriteLine($"b1 : {b1}");
            //Console.WriteLine($"b2 : {b2}");
            //Console.WriteLine($"b3 : {b3}");
            //Console.WriteLine($"b4 : {b4}");
            //Console.WriteLine($"b5 : {b5}");
            //Console.WriteLine($"b6 : {b6}");
            //Console.WriteLine($"b7 : {b7}");
            //Console.WriteLine($"b8 : {b8}");

            #endregion

            #region ?: tenary operatörü

            //koşul ? true : false mantığında çalışır
            //Console.Write("Bu serdar hoca iyi mi? (e,h) : ");
            //string cevap = Console.ReadLine();
            //Console.WriteLine((cevap == "e" || cevap == "E") ? "Teşekkürler bunu sizden duymak güzel" : "Sağlık olsun");
            #endregion

            #region örnek 03112022

            //tenary kullanarak tek satırda yap
            //sınav notunu giriniz
            //100-85 ise A
            //80-70 ise B
            //70-55 ise C
            //55-45 ise D
            //45< ise F

            //byte not;
            //Console.Write("Ekrana sınav notunu yazınız : ");
            //not = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine((not < 100 && not > 85) ? "A" : 
            //                  (not < 85 && not > 70) ? "B" : 
            //                  (not < 70 && not > 55) ? "C" :
            //                  (not < 100 && not > 85) ? "D" : "F");

            #endregion

            #region ?? operatörü

            //double? num1 = null;
            //double? num2 = 3.14;
            //double? num3;

            //num3 = num1 ?? 5.34; //num1 null ise sağ tarafındakini atıyoruz
            //Console.WriteLine($"num3 değişkeni : {num3}");
            //num3 = num2 ?? 3.14; //num2 null değilse sol taraf çalışır
            //Console.WriteLine($"num3 değişkeni : {num3}");

            #endregion

            #endregion

            #region Bölüm4 Kontrol İfadeleri

            #region ornek1
            //Console.WriteLine(); içinde if kullanamazsın

            //2 veya 3 farklı durum için if kullanırsın
            //3 ten fazla durum varsa if kullanmamalısın
            //if az durumlarda kontrol edilmesi avantajlı bir durum
            //case sayısı arttıkça bizi yavaşlatır

            //Console.Write("Lütfen bir sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());
            //if (sayi < 10)
            //    Console.WriteLine("Sayı 10 dan küçüktür");
            //else
            //{
            //    Console.WriteLine("Sayı 10 dan büyüktür");
            //    Console.WriteLine("Sayı 10 dan büyüktür");
            //    Console.WriteLine("Sayı 10 dan büyüktür");
            //    Console.WriteLine("Sayı 10 dan büyüktür");
            //}

            #endregion

            #region Klavyeden girilen sayı tek mi çift mi

            //Console.Write("Lütfen sayıyı giriniz : ");
            //byte sayi = Convert.ToByte(Console.ReadLine());
            //if (sayi % 2 == 0)
            //    Console.WriteLine("Sayı çifttir");
            //else
            //    Console.WriteLine("Sayı tektir");


            #endregion

            #region goto

            //goto ile uygulamayı başa alırım 

            //menu:
            //if (true)
            //{

            //}
            //else if (false)
            //{

            //}
            //else
            //{
            //    goto menu;
            //}

            #endregion

            #region ornek2 (goto)
            //Klavyeden girilen 2 sayıdan büyük olan sayıyı ekrana yazdırın
            //eşitlik durumu varsa onu da ekrana yazın
            //Yeniden sayı girmek ister misiniz? Evet derseniz uygulama tekrar çalışsın. Hayır derseniz mesaj yazsın

            //menu:
            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //byte sayi1 = Convert.ToByte(Console.ReadLine());
            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //byte sayi2 = Convert.ToByte(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine($"Büyük olan sayı : {sayi1}");
            //}
            //else if (sayi1 < sayi2)
            //{
            //    Console.WriteLine($"Küçük olan sayı : {sayi1}");
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşittir");
            //}


            //Console.WriteLine("Yeniden sayı girmek ister misiniz?");
            //String s = Console.ReadLine();
            //if (s == "e" || s == "E")
            //{
            //    Console.Clear();
            //    goto menu;
            //}
            //else
            //    Console.WriteLine("Hayır teşekkürler!");

            #endregion

            #region ornek3 sayi tahmin oyunu

            //sayı değişkeni tut --> sayı = 7;
            //5 in üstüne geçtiğiniz zaman sayı girme hakkınız bitmiştir

            //Console.WriteLine("1 ile 10 arasında tutulan sayıyı bulunuz");

            //start:
            //    byte sayi = 7;
            //    byte sayac = 1;

            //menu:
            //    Console.WriteLine("Lütfen sayıyı tahmin ediniz: ");
            //    byte tahmin;
            //    tahmin = Convert.ToByte(Console.ReadLine());

            //    if (sayac >= 5)
            //    {
            //        Console.WriteLine("Tahmin hakkınız bitti!");
            //        Console.Write("Yeniden oynamak ister misiniz (e/h) : ");
            //        string cevap;
            //        cevap = Console.ReadLine();
            //        if (cevap == "e" || cevap == "E")
            //        {
            //            Console.Clear();
            //            goto start;
            //        }

            //        else
            //            Console.WriteLine("Teşekkürler");
            //    }
            //    else
            //    {
            //        if (sayi > tahmin)
            //        {
            //            Console.WriteLine("Girdiğiniz sayı tuttuğunuz sayıdan küçüktür");
            //            sayac++;
            //            goto menu;
            //        }
            //        else if (sayi < tahmin)
            //        {
            //            Console.WriteLine("Girdiğiniz sayı tuttuğunuz sayıdan büyüktür");
            //            sayac++;
            //            goto menu;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Tebrikler bildiniz {sayac} kerede");
            //            Console.Write("Yeniden oynamak ister misiniz (e/h) : ");
            //            string cevap;
            //            cevap = Console.ReadLine();
            //            if (cevap == "e" || cevap == "E")
            //            {
            //                Console.Clear();
            //                goto start;
            //            }
            //        else
            //                Console.WriteLine("Oyun bitti!");

            //        }
            //    }

            #endregion

            #region tryparse uygulaması

            //Değişim yapılıp yapılmadığı kontrolü

            /* Bu yöntem döndürdüğünde, içinde bulunan sayının eşdeğeri olan 32 bit imzalı tamsayı değerini, 
            dönüştürme başarılı olursa değerini veya dönüştürme başarısız olursa sıfırı içerir. */

            //menu:
            //    Console.Clear();
            //    int val;
            //    string cevap;
            //    Console.Write("Lütfen bir sayı giriniz : ");
            //    cevap = Console.ReadLine();

            //    if (Int32.TryParse(cevap, out val))
            //    {   //True olduğu zaman bu kısım çalışıyor
            //        Console.WriteLine("Dönüşüm yapıldı : " + val);//rakam girdiği sürece dönüşüm yapıyor
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dönüşüm yapılamadı : " + val);//rakam girmediği sürece dönüşüm yapmıyor
            //    }
            //    Console.WriteLine();
            //    Console.Write("Yeniden sayı girmek istiyor musunuz ? (e/h) : ");
            //    string cevap1 = Console.ReadLine();
            //    if (cevap1 == "e" || cevap1 == "E")
            //    {
            //        goto menu;
            //    }
            //    else
            //    {
            //        Environment.Exit(0);//ile uygulamayı kapatabilirsiniz
            //        //Console.WriteLine("iyi günler tekrar görüşmek üzere");
            //    }


            #endregion

            #region klavyeden girilen sayı tek mi çift mi - tryparse ile kullanımı

            //menu: 
            //    Console.Clear();
            //    Console.Write("Lütfen sayıyı giriniz : ");
            //    int val;
            //    string sayi = Console.ReadLine();
            //    if (!Int32.TryParse(sayi, out val))
            //        goto menu;
            //    if (val % 2 == 0)
            //        Console.WriteLine("Sayı çifttir");
            //    else
            //        Console.WriteLine("Sayı tektir");

            #endregion

            #region ornek2 - tryparse metodu ile kullanımı

            //klavyeden girilen 2 sayıdan büyük olanı ekrana yazın
            //eşitlik durumu varsa onu da ekrana yazın

            //Yeniden sayı girmek ister misiniz? Evet derseniz uygulama tekrar çalışsın. Hayır derseniz mesaj yazsın

            //start:
            //Console.Clear();
            //int val1, val2;
            //Console.Write("Lütfen 1. sayıyı giriniz : ");
            //string sayi1 = Console.ReadLine();

            //if (!Int32.TryParse(sayi1, out val1))
            //    goto start;

            //start2:
            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //string sayi2 = Console.ReadLine();

            //if (!Int32.TryParse(sayi2, out val2))
            //    goto start2;

            //menu:
            //if (val1 > val2)
            //    Console.WriteLine($"Büyük olan sayı : {sayi1}");
            //else if (val1 < val2)
            //    Console.WriteLine($"Küçük olan olan sayı : {sayi1}");
            //else
            //    Console.WriteLine("Sayılar eşittir");

            //Console.WriteLine("Yeniden sayı girmek ister misiniz ?");
            //string s = Console.ReadLine();
            //if (s == "e" || s == "E")
            //{
            //    goto start;
            //}
            //else
            //    Console.WriteLine("Hayır teşekkürler");

            #endregion

            #region ornek3 sayı tahmin oyunu - tryparse ile kullanımı

            //sayı değişkeni tut --> sayı = 7;
            //5 in üstüne geçtiğiniz zaman sayı girme hakkınız bitmiştir

            //Console.WriteLine("1 ile 10 arasında tutulan sayıyı bulunuz");

            //start:
            //    byte sayi = 7;
            //    byte sayac = 1;

            //menu:
            //    Console.Write("Lütfen sayıyı tahmin ediniz: ");
            //    int val;
            //    string tahmin = Console.ReadLine();
            //    if (!Int32.TryParse(tahmin, out val))
            //        goto menu;
            //    //byte tahmin;
            //    //tahmin = Convert.ToByte(Console.ReadLine());

            //    if (sayac >= 5)
            //    {
            //        Console.WriteLine("Tahmin hakkınız bitti!");
            //        Console.WriteLine("Tekrar oyun oynamak ister misiniz?");
            //        string cevap;
            //        cevap = Console.ReadLine();
            //        if (cevap == "e" || cevap == "E")
            //        {
            //            goto start;
            //        }
            //        else
            //            Console.WriteLine("Teşekkürler");
            //    }
            //    else
            //    {
            //        if (sayi > val)
            //        {
            //            Console.WriteLine("Girdiğiniz sayı tutulan sayıdan küçüktür ");
            //            sayac++;
            //            goto menu;

            //        }
            //        else if (sayi < val)
            //        {
            //            Console.WriteLine("Girdiğiniz sayı tutulan sayıdan büyüktür ");
            //            sayac++;
            //            goto menu;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Tebrikler bildiniz = {sayac} kerede!");
            //            string cevap;
            //            cevap = Console.ReadLine();
            //            if (cevap == "e" || cevap == "E")
            //            {
            //                goto start;
            //            }
            //            else
            //                Console.WriteLine("Oyun bitti!");
            //        }
            //    }
            #endregion

            #endregion

            #region if-else ödev -- 2. hafta

            #region odev1
            //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 tl den fazla ise, 2. üründen %25 indirim yaparak ödenecek tutarı gösteren uygulama

            //start:
            //    Console.Clear();
            //    int val1, val2;
            //    Console.WriteLine("Lütfen 1. ürünün fiyatını giriniz : ");
            //    string fiyat1 = Console.ReadLine();

            //    if (!Int32.TryParse(fiyat1, out val1))
            //        goto start;

            //start2:
            //    Console.Write("Lütfen 2. ürünün fiyatını giriniz : ");
            //    string fiyat2 = Console.ReadLine(); ;

            //    if (!Int32.TryParse(fiyat2, out val2))
            //        goto start2;

            //if ((val1 + val2) >= 200)
            //{
            //val2 = val2 - ((val2 * 25)/100);
            //Console.WriteLine($"Ödenecek tutar : {val1 + val2}");
            //}
            //else
            //{
            //  Console.WriteLine($"Ödenecek tutar : {val1 + val2}");
            //}

            #endregion

            #region odev2

            //Kenar uzunlukları girilen bir üçgenin ikizkenar, eşkenar veya çeşitkenar üçgen mi olduğunu bulunuz

            //start:
            //    Console.Clear();
            //    int val1, val2, val3;
            //    Console.WriteLine("Lütfen 1. kanarı giriniz : ");
            //    string kenar1 = Console.ReadLine();

            //    if (!Int32.TryParse(kenar1, out val1))
            //        goto start;

            //    start2:
            //    Console.Write("Lütfen 2. kanarı giriniz : ");
            //    string kenar2 = Console.ReadLine(); ;

            //    if (!Int32.TryParse(kenar2, out val2))
            //        goto start2;

            //    start3:
            //    Console.Write("Lütfen 3. kanarı giriniz : ");
            //    string kenar3 = Console.ReadLine(); ;

            //    if (!Int32.TryParse(kenar3, out val3))
            //        goto start3;

            //    if (val1 == val2 && val2 == val3)
            //    {
            //        Console.WriteLine("Eşkenar üçgendir");
            //    }
            //    else if (val1 == val2 || val2 == val3 || val1 == val3)
            //    {
            //        Console.WriteLine("İkizkenar üçgendir");
            //    }
            //    else
            //        Console.WriteLine("Çeşitkenar üçgendir");

            #endregion

            #region odev3

            //Bir otoparkın ücret tarifesi şöyledir:
            //0 – 3 saat: 4 TL
            //3 – 7 saat: 3 TL
            //7 – 12 saat: 2 TL
            //12 ve üzeri: 1 TL’dir.
            //Buna göre girilen saate göre otoparka ödenecek ücreti hesaplayıp ekrana yazan programı oluşturunuz.

            //start:
            //    Console.Clear();
            //    int val1;
            //    Console.Write("Saat girin : ");
            //    string saat = Console.ReadLine();

            //    if (!Int32.TryParse(saat, out val1))
            //        goto start;

            //    if (val1 > 0 && val1 < 3)
            //    {
            //        Console.WriteLine("Ödenecek tutar : 4 TL");
            //    }
            //    else if (val1 >= 3 && val1 < 7)
            //    {
            //        Console.WriteLine("Ödenecek tutar : 3 TL");
            //    }
            //    else if (val1 >= 7 && val1 < 12)
            //    {
            //        Console.WriteLine("Ödenecek tutar : 2 TL");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ödenecek tutar : 1 TL");
            //    }

            #endregion

            #region odev4

            /* Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz
               kullanıcı adı veya şifre hatalı” mesajı veren. 3 kere yanlış girildiğinde şifrenizi değiştirmek ister
               misiniz? diye sor ve şifreyi değiştir. 
            */

            //string kadi = "sevde";
            //string sifre = "12as";
            //byte sayac = 0;

            //start2:
            //if (sayac >= 3)
            //{
            //    Console.Write("Şifrenizi değiştirmek ister misiniz (e/h) : ");
            //    string cevap;
            //    cevap = Console.ReadLine();
            //    if (cevap == "e" || cevap == "E")
            //    {
            //        Console.WriteLine("Yeni şifre gir : ");
            //        string sifre2;
            //        sifre2 = Console.ReadLine();
            //        sifre = sifre2;
            //        Console.WriteLine($"Yeni şifreniz : {sifre2}");
            //    }
            //    else
            //        Console.WriteLine("Teşekkürler");

            //}
            //else
            //{
            //    Console.Write("Lütfen kullanıcı adı giriniz : ");
            //    string kadi1 = Console.ReadLine();

            //    Console.Write("Lütfen şifre giriniz : ");
            //    string sifre1 = Console.ReadLine();
            //    sayac++;

            //    if (kadi == kadi1 && sifre == sifre1)
            //    {
            //        Console.WriteLine("Giriş başarılı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");
            //        goto start2;
            //    }
            //}


            #endregion

            #region odev5

            /*
            kullanıcı 3 adet sayı girer: a,b,c. bu sayılara göre ikinci dereceden denklemin (ax^{2}+bx+c=0)
            köklerini hesapla. kökleri eşitse eşit. kökler imaginary ise çözümsüz. kökler farklı ise ekrana
            belirt.
             */

            //float val1, val2, val3;
            //float kok1, kok2;

            //Console.Write("Lütfen a değerini giriniz : ");
            //val1 = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Lütfen b değerini giriniz : ");
            //val2 = Convert.ToSingle(Console.ReadLine()); 

            //Console.Write("Lütfen c değerini giriniz : ");
            //val3 = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("");

            //float delta = (val2 * val2) - (4 * val1 * val3);
            //if (delta > 0)
            //{
            //    Console.WriteLine("Kökler farklı - iki kök vardır");
            //    kok1 = Convert.ToSingle(((-1) * val2 - Math.Sqrt(delta)) / (2 * val1));
            //    kok2 = Convert.ToSingle(((-1) * val2 + Math.Sqrt(delta)) / (2 * val1));
            //    Console.WriteLine($"1.kök : {kok1} , 2. kök : {kok2}");
            //}
            //else if (delta == 0)
            //{
            //    Console.WriteLine("Kökler eşit - denklemin bir kökü vardır");
            //    kok1 = Convert.ToSingle(-val2 / (2 * val1));
            //    Console.WriteLine($"Denklemin kökü : {kok1}");
            //}
            //else // (delta < 0)
            //{
            //    Console.WriteLine("Kökler çözümsüz"); //gerçek kökler yoktur
            //}

            #endregion

            #endregion

            #region For Döngüsü

            //Başlangıç bitiş tarihi olan döngülerde for döngüsü kullanılır -- sınır varsa for kullan
            //Başlangıç bitiş tarihi olmayan döngülerde de for döngüsü kullanılır ama tavsiye edilmez
            //Eğer sadece koşul durumu varsa while döngüsü kullanılır
            //Koşul durumu uyup uymamaya bakmaksızın her halükarda 1 kere çalıştırılmasına do-while döngüsü kullanılır

            //byte toplam = 0, gtoplam = 0;
            //Console.WriteLine("Sayaç değeri : 0 Toplam değeri : 0");
            //Console.WriteLine("-----------------------------------");
            //for (byte i = 0; i <= 3; i++)
            //{
            //    toplam += i;
            //    gtoplam += toplam;
            //    Console.WriteLine($"Sayaç değeri : {i} \t toplam = {toplam} \t genel toplam = {gtoplam}");

            //}
            //Console.WriteLine($"toplam = {toplam} \ngenel toplam = {gtoplam}");

            #endregion

            #region for ornek1

            //1 ile 1000 arasında 5'e tam bölünebilen 7'ye bölünemeyen sayıların kaç adet olduğunu gösteren ve sayıların toplamını gösteren program

            //int toplam = 0;
            //byte sayac = 0;

            //for (short i = 0; i <= 10; i+=5)
            //{
            //    if (i % 7 != 0)
            //    {
            //        sayac++;
            //        Console.WriteLine(i);
            //    }
            //    toplam += i;
            //}

            //Console.WriteLine($"5'e tam bölünebilen 7'ye bölünemeyen sayıların adedi :  {sayac}");
            //Console.WriteLine($"Sayıların toplamı : {toplam} ");

            #endregion

            #region üslü sayı örneği

            //    int sonuc = 1;
            //    int val1, val2;

            //menu:
            //    Console.Write("Sayıyı giriniz : ");
            //    string sayi = Console.ReadLine();
            //    Console.Write("Üssü giriniz : ");
            //    string us = Console.ReadLine();

            //    if ((!Int32.TryParse(sayi, out val1) || val1 < 0) || (!Int32.TryParse(us, out val2) || val2 < 0))
            //    {
            //        goto menu;
            //    }
            //    else
            //    {
            //        for (byte i = 1; i <= val2; i++)
            //        {
            //            sonuc = sonuc * val1;
            //        }
            //        Console.WriteLine($"Sonuc = {sonuc}");
            //    }
            #endregion

            #region odev -  sayıyı 2 lik tabana çevirme
            //sayı giriniz : 8
            //ikilik düzene çevir: 1000

            //Console.Write("Sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //string sonuc = "";
            //for (byte i = 0; sayi > 0; i++)
            //{
            //    sonuc = sayi % 2 + sonuc; //sonucu başa yazarsan 10 un karşılığı 1010 yerin 0101 yazdırır
            //    sayi = sayi / 2;
            //}
            //Console.WriteLine($"Girilen sayının 2 lik tabandaki karşılığı : {sonuc}");


            //Console.WriteLine("Sayı giriniz : "); ;
            //string sayi = Console.ReadLine();
            ////String askForDecimal = Console.ReadLine();
            //int sayi2 = int.Parse(sayi);

            //int remainder = 0;
            //for (int i = 1; sayi2 > 0; i++)
            //{
            //    sayi2 /= 2;
            //    remainder = sayi2 % 2 ;
            //    Console.Write(remainder);
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
