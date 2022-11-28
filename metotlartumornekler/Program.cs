using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlartumornekler
{
    class Program
    {
        //string Tekrar(string cevap)
        //{
        //    string cevap2 = Console.ReadLine();
        //    if (cevap2 == "e")
        //    {
        //        Console.Clear();
        //    }
        //    return cevap;
        //}

        static void Main(string[] args)
        {
            For nesne = new For();

            #region 5 e bölünen 7 ye bölünemeyen

            //Console.Write("Birinci sayıyı giriniz : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz : ");
            //int b = int.Parse(Console.ReadLine());

            //nesne.BesYediyeBolunme(a, b);

            #endregion

            #region Üs, Karekök Alma

            //nesne.UsKarekokAlma();

            #endregion

            #region Sayıyı İkilik Tabana Çevirme

            //Console.Write("Sayı girin : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //For.ikilikTaban(sayi);

            #endregion

            #region Dört İşlem

            //nesne.DortIslem();

            //Console.WriteLine("1 - Toplama(+)");
            //Console.WriteLine("2 - Çıkarma(-)");
            //Console.WriteLine("3 - Çarpma(*)");
            //Console.WriteLine("4 - Bölme(/)");
            //Console.Write("Lütfen işlem seçimi yapınız.....: ");
            //string islem = Console.ReadLine();

            //Console.Write("1. Sayıyı giriniz : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("2. Sayıyı giriniz : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //switch (islem)
            //{
            //    case "+":
            //        nesne.Toplama(sayi1, sayi2);
            //    break;

            //    case "-":
            //        nesne.Cikarma(sayi1, sayi2);
            //    break;

            //    case "*":
            //        nesne.Carpma(sayi1, sayi2);
            //    break;

            //    case "/":
            //        nesne.Bolme(sayi1, sayi2);
            //    break;

            //    default:
            //        break;
            //}

            #endregion

            #region Sıcaklık Dönüşümü

            //Console.Write("1-Kelvin \n2-Fahrenheit \n");
            //Console.Write("Çevirilecek birimi seçiniz: ");
            //string cevap = Console.ReadLine();

            //Console.Write("Sıcaklık değeri giriniz : ");
            //float sicaklik2;
            //sicaklik2 = Convert.ToSingle(Console.ReadLine());
            //float x = Convert.ToSingle(sicaklik2);

            //if (cevap == "1")
            //    Console.WriteLine($"Kelvin : {nesne.Kelvin(x)}");

            //else if (cevap == "2")
            //    Console.WriteLine($"Fahrenheit : {nesne.Fahrenheit(x)}");

            #endregion

            #region Girilen metinde belli bir kısmı almak

            //Console.Write("Lütfen bir metin giriniz : ");
            //string metin = Console.ReadLine();

            //Console.Write("Metinde başlangıç değeri seçiniz : ");
            //int first = int.Parse(Console.ReadLine());

            //Console.Write("Metinde bitiş değeri seçiniz : ");
            //int second = int.Parse(Console.ReadLine()) - first;

            //Console.WriteLine(For.MetinBolme(metin, first, second));

            #endregion

            #region FaktoriyelFor

            //Console.Write("Sayı giriniz : ");
            //int fakt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Sonuç = {For.FaktoriyelFor(fakt)}");

            #endregion

            #region Permütasyon

            //P (n,r) = n! / (n-r)!

            //Console.WriteLine("PERMUTASYON HESABI");

            //Console.Write("n değeri giriniz : ");
            //int n;
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.Write("r değeri giriniz : ");
            //int r;
            //r = Convert.ToInt32(Console.ReadLine());

            //int x = n - r;
            //int pern = For.FaktoriyelFor(n);
            //int pernr = For.FaktoriyelFor(x);

            //int permutasyon = pern / pernr;
            //Console.WriteLine($"Sonuç = {permutasyon}");


            #endregion

            #region Kombinasyon 

            //Console.WriteLine("KOMBINASYON HESABI");
            //Console.Write("n değeri giriniz : ");
            //int n;
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.Write("r değeri giriniz : ");
            //int r;
            //r = Convert.ToInt32(Console.ReadLine());

            //int pern = For.FaktoriyelFor(n);
            //int x = n - r;
            //int pernr = For.FaktoriyelFor(x);
            //int perr = For.FaktoriyelFor(r);

            //int kombinasyon = pern / (pernr * perr);
            //Console.WriteLine($"Sonuç = {kombinasyon}");

            #endregion

            #region Girilen kelimeyi tersten yazdırma

            //Console.Write("Metin giriniz : ");
            //string metin;
            //metin = Console.ReadLine();

            //Console.Write($"Girilen metnin tersten yazılmış hali : ");
            //Console.WriteLine(nesne.TerstenYazdirma(metin));

            #endregion

            #region KdvHesaplama

            //Console.Write("Ürün fiyatını giriniz : ");
            //int fiyat = Convert.ToInt32(Console.ReadLine());

            //Console.Write("1- GIDA\n");
            //Console.Write("2- HİZMET\n");
            //Console.Write("3- BEYAZ EŞYA\n");
            //Console.Write("Lütfen seçim yapınız.....:");

            //string cevap = Console.ReadLine();

            //switch (cevap)
            //{
            //    case "1":
            //        Console.WriteLine($"KDV = {nesne.KdvHesaplama1(fiyat)}");
            //        break;

            //    case "2":
            //        Console.WriteLine($"KDV = {nesne.KdvHesaplama2(fiyat)}");
            //        break;

            //    case "3":
            //        Console.WriteLine($"KDV = {nesne.KdvHesaplama3(fiyat)}");
            //        break;

            //    default:
            //        break;
            //}


            #endregion

            Console.ReadLine();

        }

    }

    class For
    {
        public int BesYediyeBolunme(int x, int y)
        {
            //1 ile 1000 arasında 5'e tam bölünebilen 7'ye bölünemeyen sayıların kaç adet olduğunu gösteren ve sayıların toplamını gösteren program

            int [] dizi = new int[y];

            for (int i = x; i < dizi.GetLength(0); i++)
            {
                if (i%5 == 0 && i % 7 != 0)
                {
                    dizi[i] = i;
                    Console.WriteLine(dizi[i] + " ");
                }
            }
            return 0;
        }

        public int UsKarekokAlma()
        {
        menu:
            Console.Write("Sayıyı gir : ");
            int sayi = int.Parse(Console.ReadLine());

            Console.Write("1- Üs Alma İşlemi \n 2- KArekök Alma İşlemi");
            Console.Write("Lütfen işlem seçiniz : ");

            string cevap = Console.ReadLine();

            if (cevap == "1")
            {
                Console.Write("Üssünü giriniz : ");
                int us = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Sonuç : {Math.Pow(sayi, us)}");
            }
            else if (cevap == "2")
            {
                Console.Write($"Sonuç : {Math.Sqrt(sayi)}");
            }

            Console.Write("Tekrardan işlem yapmak istiyor musunuz ? (e/h) : ");
            string cevap2 = Console.ReadLine();
            if (cevap2 == "e" || cevap2 == "E")
            {
                Console.Clear();
                goto menu;
            }
            else
            {
                Environment.Exit(0);
            }

            return 0;
        }

        public static int ikilikTaban(int sayi)
        {
            string sonuc = "";

            for (; sayi > 0; sayi /=2)
            {
                sonuc = sayi % 2 + sonuc; //1010
            }
            Console.WriteLine($"Sonuç : {sonuc}");

            return sayi;
        }

        public int Toplama(int a, int b)
        {
            return a + b;
        }

        public int Cikarma(int a, int b)
        {
            return a - b;
        }

        public int Carpma(int a, int b)
        {
            return a * b;
        }

        public int Bolme(int a, int b)
        {
            return a / b;
        }

        public int DortIslem()
        {
            Console.WriteLine("1 - Toplama(+)");
            Console.WriteLine("2 - Çıkarma(-)");
            Console.WriteLine("3 - Çarpma(*)");
            Console.WriteLine("4 - Bölme(/)");
            Console.Write("Lütfen işlem seçimi yapınız.....: ");
            string islem = Console.ReadLine();

            Console.Write("1. Sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case "+":
                    Console.WriteLine("Sonuç = " + Toplama(sayi1, sayi2));
                    break;

                case "-":
                    Console.WriteLine("Sonuç = " + Cikarma(sayi1, sayi2));
                    break;

                case "*":
                    Console.WriteLine("Sonuç = " + Carpma(sayi1, sayi2));
                    break;

                case "/":
                    Console.WriteLine("Sonuç =" + Bolme(sayi1, sayi2));
                    break;

                default:
                    break;
            }
            return 0;
        }

        public float Kelvin(float sicaklik)
        {
            return sicaklik + 273.15f;
        }

        public float Fahrenheit(float sicaklik)
        {
            return (sicaklik * 1.8f) + 32f;
        }

        public static string MetinBolme(string metin, int baslangic, int bitis)
        {
            return metin.Substring(baslangic, bitis);
        }

        public static int FaktoriyelFor(int sayi)
        {
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            return faktoriyel;
        }

        //public string TerstenYazdirma(string metin)
        //{
        //    //int metin2 = metin.Length;
        //    //int i = metin2;
        //    //string x = "";

        //    //while (i > 0)
        //    //{
        //    //    Console.Write(metin.Substring(i - 1, 1));
        //    //    i--;
        //    //}

        //    //return x;

        //}


        public int KdvHesaplama1(int tutar)
        {
            return tutar / 100;
        }

        public int KdvHesaplama2(int tutar)
        {
            return (tutar*18) / 100;
        }

        public int KdvHesaplama3(int tutar)
        {
            return (tutar*8) / 100;
        }
    }
}
