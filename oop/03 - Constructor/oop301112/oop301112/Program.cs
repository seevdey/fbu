using Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop301112
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (Oyuncu o1 = new Oyuncu()) //parametresiz nesne oluşturunca parametresiz metot çalışacak
            {
                Console.WriteLine(o1.BilgiVer());
                Console.WriteLine("---------------------------------");

            }

            using (Oyuncu o2 = new Oyuncu("Cenk", "Beşiktaş", 9))//parametreli nesne oluşturunca parametreli metot çalışacak
            {
                Console.WriteLine("---------------ilk hali------------------");
                Console.WriteLine(o2.BilgiVer());

                Console.WriteLine("---------------son hali------------------");
                o2.takimdegistir("Gs");
                Console.WriteLine(o2.BilgiVer());
            }

            Console.ReadLine();

        }

    }
}
