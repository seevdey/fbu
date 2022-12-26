using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Program
    {
        //programı dinamik yazman gerek. Kullanıcı yetki ve bilgilerini tanımladığınız zaman ona göre ekran açılacak. 1 kere yaz kullanıcı farkı kullanıcı girdikçe o otomatik program içierisinde aliye kaydetme özelliği olmasın
        //ali kaydetme güncelleme yapamasın, göktuğ güncelleme yapsın
        //alinin yetkilerine göre ayrı, göktuğun yetkilerine göre ayrı çalışır
        //diğer türlü her durum için kod yazıyosun

        delegate void temsilci(); //ben buna her şeyi atabilirim. delegate tipinde temsilci oluşturdum
        //delegate tipinde tanımladığın bir isme aşağıda birden fazla metodu aktarabiliyosun ve nesneyi çalıştırdığın zaman 3 metodu aynı anda çağırıyor
       // Birden fazla event ı topluyorum

        static void Metot1()
        {
            Console.WriteLine("Metot1 çağırıldı");
        }

        static void Metot2()
        {
            Console.WriteLine("Metot2 çağırıldı");
        }

        static void Metot3()
        {
            Console.WriteLine("Metot3 çağırıldı");
        }


        static void Main(string[] args)
        {
            //tanımlamadığın disposible ı using de kullanamazsın. yani bu nesne oluşturmasında using kullanmıyoruz

            temsilci nesne = null; //temsilci tipinde nesne oluşturuyorum içine null attım
            //Nesnenin içine 3 adet metodu attım
            //Nesne çalıştığı anda 3 metodu aynı anda çalıştıracak
            nesne += new temsilci(Metot1); //neseneye sırayla metotları ağlıyorum
            nesne += new temsilci(Metot2);
            nesne += new temsilci(Metot3);
            nesne();

            Console.WriteLine("-------------------------");
            nesne -= new temsilci(Metot2);
            nesne();

            Console.ReadLine();
        }
    }
}
