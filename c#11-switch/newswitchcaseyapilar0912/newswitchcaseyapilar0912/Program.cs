using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

public class Yazar
{
    string Ad;
    string Kitap;
    int yil;

    public Yazar(string ad, string kitap, int yil)
    {
        Ad = ad;
        Kitap = kitap;
        this.yil = yil;
    }
}

public enum Renk {red, yellow, green, blue}

namespace newswitchcaseyapilar0912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enum yapısı
            switchcasedesen(Renk.red);

            //Dizi yapısı
            string[] isimler = { "serdar" , "mehmet", "yeşim", "veli", "hasan" };
            switchcasedesen(isimler);

            //List yapısı
            List<Yazar> list = new List<Yazar>();
            list.Add(new Yazar("Serdar", "Beyaz Geceler", 1995));
            switchcasedesen(list);

            Console.ReadLine();
        }

        public static void switchcasedesen(object type)
        {
            //Normalde değişken içindeki değerleri kontrol ediyorduk
            //Kontrol dışında yapılara göre de seçim yaptım --> sınıf, list, array...
            switch (type)
            {
                case Enum e:
                    switch (e)
                    {
                        case Renk.red:
                            Console.BackgroundColor= ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine("Arkaplan Kırmızı");
                            break;
                        case Renk.yellow:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            Console.WriteLine("Arkaplan Sarı");
                            break;
                        case Renk.green:
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Clear();
                            Console.WriteLine("Arkaplan Yeşil");
                            break;
                        case Renk.blue:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            Console.WriteLine("Arkaplan Mavi");
                            break;
                        default:
                            break;
                    }
                    break;

                case Array a:
                    Console.WriteLine($"Dizinin boyutu : {a.Length}");
                    break;
                case IList list:
                    Console.WriteLine($"Listenin eleman sayı adedi : {list.Count}");
                    break;
                default:
                    Console.WriteLine("Bunların dışında");
                    break;
            }
        }
    }
}



