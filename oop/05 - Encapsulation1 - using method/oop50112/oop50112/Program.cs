using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop50112
{
    /*
     * OOP temelleri
     * 1.Abstract(Soyutlama)
     * 2.Encapsulation(Kapsülleme)
     * 3.Inheritance(Kalıtım)
     * 4.Polimorfizm(Çok Biçimlilik)
    */

    
    //ÖR: Metod kullanarak Encapsulation yapıyoruz
    class Kitap
    {
        public string Ad;
        public string KitapAdıİste()
        {
            return Ad;
        }
        public void KitapAdiBelirle(string kitapad)
        {
            bool oldumu = true;
            for (int i = 0; i < kitapad.Length; i++)
            {
                if (!char.IsLetter(kitapad[i])) //Her bir harfi al
                {
                    oldumu = false;
                    break;
                }
            }

            if (oldumu) //oldumu true ise buraya gir
                Ad = kitapad;
            else
            {
                //ArgumentException kullanarak kendi hatamı oluşturdum
                throw new ArgumentException("Kitap Adı içerisinde harften başka bir karakter olamaz"); 

                //kitabın isminde 1 tane bile rakam olursa hataya düşer ve hatayı ekrana yazdırır
            }
        }

        public double fiyat;

        public double FiyatOku()
        {
            return fiyat;
        }

        public void FiyatBelirle(double fiyatyeni)
        {
            if (fiyatyeni > 1000)
                throw new ArgumentException("Kitap Adı fiyatı 1000 den büyük olamaz");
            else
                this.fiyat = fiyatyeni;
        }

        //şifre 8 den büyük olamaz
    }

    internal class Program
    {

        //İstisnasız şunu yapman gerekiyor --> try-catch 
        //Her zaman bu kod bloğuna bunu yazman gerekiyor

        static void Main(string[] args)
        {
            try
            {
                //Kod

                Kitap kk = new Kitap();

                Console.Write("Lütfen Kitap Adı Giriniz : ");
                //kk.Ad = Console.ReadLine();
                kk.KitapAdiBelirle(Console.ReadLine());

                Console.Write("Lütfen Kitap Fiyatı Giriniz : ");
                //kk.fiyat = double.Parse(Console.ReadLine());
                kk.FiyatBelirle(double.Parse(Console.ReadLine()));

                Console.WriteLine($"Kitap Adı : {kk.KitapAdıİste()} \nKitap Fiyatı : {kk.FiyatOku()}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
