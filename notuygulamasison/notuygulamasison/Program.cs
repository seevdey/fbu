using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notuygulamasison
{
    internal class Program
    {


        //A, B, C nin dışında bir not sistemi olursa dinamik olarak tanımlıyoruz
        //A, B, C nin dışında bir not sistemi olmadığı için static olarak tanımladık
        //Bir iş tek yapılıyorsa static, yapılmıyorsa dinamik
        //Nesne oluşturulurken 'using' kod bloğu kullanılır --> Nesneyi hafızada relaize edebilmek için
        static string notdonustur(string not)
        {
            string sonuc = "";

            int val;
            if (!Int32.TryParse(not, out val))
                sonuc = "Geçersiz Not";
            else
            {
                int notyeni = int.Parse(not);

                if (notyeni <= 100 && notyeni > 85)
                    sonuc = "A";
                else if (notyeni < 86 && notyeni > 69)
                    sonuc = "B";
                else if (notyeni < 69 && notyeni > 54)
                    sonuc = "C";
                else if (notyeni < 55 && notyeni >= 45)
                    sonuc = "D";
                else
                    sonuc = "F";
            }

            return sonuc;
        }


        static void Main(string[] args)
        {
            #region Ödev

            #region Odev Faz0
            //string vad1 = "", vad2 = "", vnot1 = "", vnot2 = "";

            //Console.Write("Lütfen Öğrenci İsmini Giriniz : ");
            //vad1 = Console.ReadLine();

            //Console.Write("Lütfen Öğrenci Notunu Giriniz : ");
            //vnot1 = Console.ReadLine();

            //Console.Write("Lütfen Öğrenci İsmini Giriniz : ");
            //vad2 = Console.ReadLine();

            //Console.Write("Lütfen Öğrenci Notunu Giriniz : ");
            //vnot2 = Console.ReadLine();

            //Console.WriteLine($"Öğrenci Adı : {vad1} \t Öğrenci Notu : {notdonustur(vnot1)}");
            //Console.WriteLine($"Öğrenci Adı : {vad2} \t Öğrenci Notu : {notdonustur(vnot2)}");
            #endregion

            #region Odev Faz1

            Console.Write("Lütfen öğrenci sayısını giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            sayi *= 2;
            string[] ogrenci = new string[sayi];

            //GetLength her seferinde performansı düşürür, sayi değişkeni düşürmez

            for (int i = 0; i < sayi; i+=2)
            {
                Console.Write("Lütfen Öğrenci İsmini Giriniz : ");
                ogrenci[i] = Console.ReadLine();

                Console.Write("Lütfen Öğrenci Notunu Giriniz : ");
                ogrenci[i+1] = Console.ReadLine();

            }

            //var içine her türlü değişkeni alabilir

            Console.WriteLine("Öğrencileri Listelemek İster Misiniz ? (e/h) : ");
            string cevap = Console.ReadLine();
            if (cevap == "e" || cevap == "E")
            {
                for (int i = 0; i < sayi; i+=2)
                {
                    Console.WriteLine($"Öğrenci Adı : {ogrenci[i]} \t Öğrenci Notu : {notdonustur(ogrenci[i+1])}");
                }
            }

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
