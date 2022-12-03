using oop20112.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop20112
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sınıf Uygulaması

            //Nokta nokta = new Nokta(); //Bu kullanımı her programı kapatıp açtığında hafızada yer kaplar. Bu şekilde kullanım yanlış

            //using --> hafızada işi bitince relaize ediyor 
            //hafızada nokta sınıfını tutmamış oluyosun
            using (Nokta nokta = new Nokta())
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


        }
    }
}
