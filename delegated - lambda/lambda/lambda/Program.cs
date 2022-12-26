using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    internal class Program
    {
        public delegate int MyDelegate(int Deger);
        public delegate int MyDelegate1(int Deger, int Deger1);


        static void Main(string[] args)
        {
            //Lambdasız kullanım
            MyDelegate oDlg = new MyDelegate(KareAl); //oDlg nesnemi çalıştırınca KareAl çalışacak. KareAl oDlg de çalışıyor. oDlg birden fazla şeyi temsil edebilir
            int sonuc = oDlg(3);
            Console.WriteLine("Lambdasız 3 ün karesi : " + sonuc);

            Console.WriteLine("--------------------------------");

            //Lambdalı kullanım
            //Lambda kullanarak oDlg ye dedik ki sen sayıya dönüştüreceksin return sayi * sayi yani KareAl ı yok ettik
            //Lambda Linq da sizin olmazsa olmazınız çok kullanılıyor
            //Lambda ile birden fazla yapılan işlemi tek satıra getirebildim
            MyDelegate oDlg0 = (int sayi) => { return sayi * sayi; };

            //lambdanın kısaltılmış hali
            MyDelegate oDlg1 = (int sayi) =>  sayi * sayi;

            //en kısa hali
            MyDelegate oDlg2 = sayi => sayi * sayi;

            int sonuc1 = oDlg0(4);
            int sonuc2 = oDlg0(4);
            int sonuc3 = oDlg0(4);
            Console.WriteLine("Lambdalı 4 ün karesi (oDlg0 nesnesi ile) : " + sonuc1);
            Console.WriteLine("Lambdalı 4 ün karesi (oDlg1 nesnesi ile) : " + sonuc2);
            Console.WriteLine("Lambdalı 4 ün karesi (oDlg2 nesnesi ile) : " + sonuc3);


            Console.ReadLine();
        }

        static int KareAl(int sayi)
        {
            return sayi * sayi;
        }
    }
}
