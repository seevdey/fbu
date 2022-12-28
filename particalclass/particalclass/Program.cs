using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particalclass
{
    //Partial kelimesiyle class kapatılmaz ileride ek kodlar ekleyebilmemizi sağlar
    //Her class için kullanmamız doğru olur
    public partial class User
    {
        private string name;
        private string location;
        public User(string a, string b)
        {
            this.name = a;
            this.location = b;
        }
    }
    //iki class ı birleştirmiş oluyorum
    public partial class User
    {
        public void GetUserDetails()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("location" + location);
        }
    }

    //Interface bütün class laarı yaz 
    //class ları oluştur
    //class ları içine metod ve alanları yaz
    //doldur
    //paketle
    //projenin her yerşinde classs ve mtod çağır ve 
    //try catch kullan

   //dopper tablo bağlantılarına bak

    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User("serdar", "istanbul");

            //Bilgi metounu unuttuğumuzu varsay. Bulunduğu class ta metod içine yazmadan kullanabilmek için partial kelimesini class a ekliyoruz
            //Sonrasında aynı isimde partial kelimesini içeren bir class oluşturup yazmak istediğimiz metodu bu yeni class ın içine yazıyoruz
            u.GetUserDetails();

            Console.ReadLine();
        }
    }
}
