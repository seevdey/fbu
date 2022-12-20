using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop8abstract0512
{
    //Abstract kelimesiyle bu sınıftan kalıtım zorunluluğu var demektir
    public abstract class Kisi
    {
        //Kisi abstract olduğu için kesin olarak bundan bir sınıf tanımlamak zorundayım

        public String AdSoyad; //AdSoyad ı alan olarak tanımladık
        public abstract string Meslek 
        {
            //Meslek classs olarak tanımladık
            //Meslek class ına dışardan kimse ulaşamayacak
            //Bu alanı türeyen class ta değiştirmek zorundasın

            get;

            //Meslek sınıfına değer atamıycam bu yüzden set kullanmadım
            //Değiştirilebilir bir özellik yoksa set kullanmıyoruz
            //Oluşturulan class larda zaten bu özellik tanımlanmış oluyor

        }
        public virtual void Yaz()
        {
            Console.WriteLine("Adı Soyadı : " + AdSoyad);
            Console.WriteLine("Mesleği : " + Meslek);
        }
    }

    public class Ogrenci : Kisi
    {
        public int Sınıf;
        public string Bolum;
        public override string Meslek
        {
            get { return "Öğrenci"; }
        }

        public override void Yaz()
        {
            Console.WriteLine("Adı Soyadı : " + AdSoyad);
            Console.WriteLine("Mesleği : " + Meslek);
            Console.WriteLine("Sınıfı : " + Sınıf);
            Console.WriteLine("Bölümü : " + Bolum);

        }
    }


    public class Ogretmen : Kisi
    {
        public string Brans;
        public override string Meslek
        {
            get { return "Öğretmen"; }
        }

        public override void Yaz()
        {
            Console.WriteLine("Adı Soyadı : " + AdSoyad);
            Console.WriteLine("Mesleği : " + Meslek);
            Console.WriteLine("Branş : " + Brans);
        }
    }

    //Patrondan hiçbir şey üretemezsin
    //sealed --> koruma altına almak
    //Ortak sınıflarda kullanılan sınıflar sealed olur
    //Ör : Müşteri bakiyesi --> sealed 
    //ortak kullanılan parametrik sınıflarda sealed kullan
    //sealed class Patron
    //{

    //}

    //class Mudur : Patron //Patron hata verir
    //{

    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //Kisi sınıfı abstract olduğundan dolayı o sınıfa erişip bir nesne oluşturamayız
            //Kisi kisi = new Kisi(); //böyle kullanamayız hata verir

            //Bunun yerine Ogrenci sınıfından ogrenci nesnesi oluştururuz
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.AdSoyad = "Eren Turk Yılmaz";
            ogrenci.Sınıf = 216;
            ogrenci.Bolum = "Bilgisayar Mühendisi";
            ogrenci.Yaz();

            Console.WriteLine("--------------------");

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Brans = "Yazılım";
            ogretmen.AdSoyad = "Serdar Beyazkaya";
            ogretmen.Yaz();


            //Abstract sınıflar abstract alan içerebilirler 
            //Abstract alan bir sınıf içinde tanımlanmışsa o sınıf abstract olmalıdır
            //Alan abstract sa sınıfı da abstract olmak zorunda
            //Abstract sınıflar sealed olamaz
            //static metotlar abstract olamaz

            //abstract sınıftaki abstract bir alan türeyen bir sınıfta obverride ile mutlaka değşitirilmelidir

            Console.ReadLine();
        }
    }
}

