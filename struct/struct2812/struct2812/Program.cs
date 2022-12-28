using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct2812
{
    //objeler heapte tutuluyor. javada bunun kolaylığı yok. c# ta var
    //veriler 16 kb ın üstündeyse (string, nesne.....) classta tutalım
    //veri 16kb ın altındaysa bunu sınıfta tutmayalım struct diye bir yapı oluşturalım class mantığında bir yapıyla olsun
    //struct kalıtım olmuyor classs tan en büyük farkı bu 
    //sınıfa göre daha az yer kaplıyor
    //stack te tutuluyor, heapte tutulmuyor
    //veri değer türlü değşkenler kadar küçükse tutacağım bilgiler struct kullanıyorum
    struct User
    {
        public const string name = "serdar beyazkaya";
        public string location;
        public int age;

        public User(string a, int b)
        {
            location = a;
            age = b;
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nesne oluşturduk
            User u = new User("İstanbul", 45);

            //Yapı kullandık
            User u1; //sadece struct ı kullandım
            Console.WriteLine("Name : {0}, Location : {1}, Age : {2}", User.name, u.location, u.age);

            u1.location = "Maltepe";
            u1.age= 32;
            Console.WriteLine("Name : {0}, Location : {1}, Age : {2}", User.name, u1.location, u1.age);
            Console.ReadLine();
        }
    }
}
