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

            #region deneme

            #endregion

            Console.ReadLine();
        }
    }
}
