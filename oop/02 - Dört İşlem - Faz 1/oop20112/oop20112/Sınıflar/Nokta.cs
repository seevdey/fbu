using System;

namespace oop20112.Sınıflar
{
    internal class Nokta : IDisposable //Sınıfı dışardan alma internal
    {
        public int x;
        public int y;

        public void topla()
        {
            Console.WriteLine($"X ve Y değerlerinin toplanmış hali {x + y}");
        }

        public void cikarma()
        {
            Console.WriteLine($"X ve Y değerlerinin çıkarılmış hali {x - y}");
        }

        public void carpma()
        {
            Console.WriteLine($"X ve Y değerlerinin çarpılmış hali {x * y}");
        }

        public void bolme()
        {
            Console.WriteLine($"X ve Y değerlerinin bölünmüş hali {x / y}");
        }

        public int ikiyecarpma()
        {
            return x * y * 2;
        }

        public void Dispose() //Bu sınıftan nesne oluşturup bu nesne işi bittiği anda direkt olarak burası çalışır
        {
            //En son Dispose a geliyor
            //istediğin kadar çalıştır hafızada askıda kalır

            //throw new NotImplementedException();

            Console.WriteLine("Nesne artık yok");
        }
    }
}
