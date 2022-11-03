﻿using System;
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

            Console.ReadLine();
        }
    }
}
