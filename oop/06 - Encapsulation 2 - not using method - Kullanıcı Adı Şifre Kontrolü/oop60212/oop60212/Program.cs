using Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop60212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sifredrm = false;
            string kullad = "";

        menu:
            try
            {
                using (Uye uu = new Uye())
                {
                    if (!sifredrm)
                    {
                        Console.Write("Lütfen Kullanıcı Adınızı Giriniz : ");
                        kullad = Console.ReadLine();
                    }

                    Console.Write("Lütfen Şifrenizi Giriniz : ");
                    string sifre = Console.ReadLine();

                    uu.KullaniciAdi = kullad;
                    uu.Sifre = sifre;

                    //ing anahtarı ikonu özellik anlamına gelir

                    Console.WriteLine($"\nÜye adınız {uu.KullaniciAdi} \nŞifre {uu.Sifre}");
                }
            }
            catch (ArgumentException ex)
            {
                //şifrede hata varsa tekrar kullanıcı adını tekrar istemiyoruz

                if (ex.Message == "Kullanıcı Adı içerisinde harf dışında başka karakter olamaz")
                {
                    Console.WriteLine(ex.Message);

                    sifredrm = true;
                    goto menu;
                }
                else
                    Console.WriteLine(ex.Message);

            }

            Console.Write("Yeniden Giriş Yapmak İstiyor Musunuz ?");
            string cevap = Console.ReadLine();
            if (cevap == "e" || cevap == "E")
            {
                Console.Clear();
                sifredrm = false;
                goto menu;
            }
            else
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
