using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopders10112
{
    /*
     * Nokta isimli bir sınıf tanımladık
     * Sınıfta toplama, çıkarma, çarpma, bölme ve iki katı çarpma metotlarını tanımladık 
     * Yeni tanımlanan sınıflarda dispose arayüzünü kullandık
     * Sınıftan oluşturduğummuz nesneyi using blogu içine oluşturduk
     * Böylelikle hafızadan direkt olarak silinmesini sağlamış olduk
     * 
     * Var olan bi sınıfı kullanıyorsan Visual Studio içinde dispose açmana gerek kalmadan 
     * Yeni class açıyorsan her zaman IDisposable kullan
    */


    class Nokta : IDisposable
    {
        public int x;
        public int y;
        public void topla()
        {
            Console.WriteLine($"X ve Y değerlerinin toplanmış hali {x+y}");
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

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Sınıf Uygulaması

            //Nokta nokta = new Nokta(); //Bu kullanımı her programı kapatıp açtığında hafızada yer kaplar. Bu şekilde kullanım yanlış

            //using --> hafızada işi bitince relaize ediyor 
            //hafızada nokta sınıfını tutmamış oluyosun
            using(Nokta nokta = new Nokta())
            {
                Console.Write("Lütfen noktanın X koordinatını giriniz : ");
                nokta.x = int.Parse(Console.ReadLine());

                Console.Write("Lütfen noktanın Y koordinatını giriniz : ");
                nokta.y = int.Parse(Console.ReadLine());

                Console.Write("Noktanın X koordinatı :" + nokta.x);
                Console.Write("\nNoktanın Y koordinatı :" + nokta.y);

                menu:
                Console.Write("\nLütfen nokta için işlem tipi seçiniz (+, /, -, *) : ");
                string islemtipi = Console.ReadLine();
                switch (islemtipi)
                {
                    case "+":
                        nokta.topla();
                        break;
                    case "-":
                        nokta.cikarma();
                        break;
                    case "*":
                        nokta.carpma();
                        break;
                    case "/":
                        nokta.bolme();
                        break;
                    default:
                        goto menu;
                        break;
                }

                int dortkat = nokta.ikiyecarpma();
                Console.WriteLine("x*y*2 : " + dortkat.ToString());

            }

            #endregion


            Console.ReadLine();

        }
    }
}
