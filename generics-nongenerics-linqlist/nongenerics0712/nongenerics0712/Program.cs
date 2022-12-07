using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nongenerics0712
{
    internal class Program
    {
        static void Main(string[] args)
        {
            otomobil oto1 = new otomobil(2006);
            oto1.TipGoster();

            //NonGenerics te tipe dönüştürmek zorundayız
            //Dışardaki veriyi tip dönüşümü yapmadan alamıyorum
            //Yani 2006 yı dönüşüm yapmadan alamazsın

            //almak zorunda kaldığın zaman nongenerics oluyor
            //SortedList, ArrayList, Hastable NonGenerics grubunda--> nesne gönderdiğinde nesneyi dışarı çekmek istediğin zaman tip dönüşümü yapmak zorundasın

            int vint =(int) oto1.GetObj();
            Console.WriteLine("Otomobil değeri : " + (vint + 4));

            otomobil oto2 = new otomobil("Şahin");
            oto2.TipGoster();
            string bilgi = (string) oto2.GetObj();
            Console.WriteLine("Değeri : " + bilgi);

            otomobil oto3 = new otomobil('s');
            oto3.TipGoster();
            char bilgi2 = (char)oto3.GetObj();
            Console.WriteLine("Değeri : " + bilgi2);

            Console.ReadLine();
        }
    }
}
