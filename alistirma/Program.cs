using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
        #region  örnek -1 --> 2 boyutlu dizi

        //Girilen 2 boyutlu diziyi ilk 3 ü alt alta gelecek şekilde yazdır

        // ÖRNEK ÇIKTI 
        //Input elements in the matrix :                                                                                
        //element - [0, 0] : 1
        //element - [0, 1] : 2
        //element - [0, 2] : 3
        //element - [1, 0] : 4
        //element - [1, 1] : 5
        //element - [1, 2] : 6
        //element - [2, 0] : 7
        //element - [2, 1] : 8
        //element - [2, 2] : 9


        //The matrix is :                                                                                               

        //1       2       3
        //4       5       6
        //7       8       9


        //int[,] dizi = new int[3, 3];

        //Console.WriteLine("2 Boyutlu Dizinin elemanlarını giriniz : ");

        //for (int i = 0; i < dizi.GetLength(0); i++)
        //{
        //    for (int j = 0; j < dizi.GetLength(1); j++)
        //    {
        //        Console.Write($"Dizinin {i + 1}. satır , {j + 1}. sütununu giriniz : ");
        //        dizi[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}

        //Console.WriteLine("\nGirilen Dizi Elamanlarının Listelenmesi");

        //for (int i = 0; i < dizi.GetLength(0); i++)
        //{
        //    Console.WriteLine();

        //    for (int j = 0; j < dizi.GetLength(1); j++)
        //    {
        //        Console.Write(dizi[i, j] + "\t");

        //        //0,0   //0,1   //0,2
        //        //1,0   //1,1   //1,2
        //        //2,0   //2,1   //2,2
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //}

        /*
        //foreach (int item in dizi)
        //{
        //    Console.Write(item + "\t");
        //}
        */

        #endregion

        #region örnek2

        /* 
         Write a program in C# Sharp to read n number of values in an array and display it in reverse order. Go to the editor
            Test Data :
            Input the number of elements to store in the array :3
            Input 3 number of elements in the array :
            element - 0 : 2
            element - 1 : 5
            element - 2 : 7
            Expected Output:
            The values store into the array are:
            2 5 7
            The values store into the array in reverse are :
            7 5 2
         */

        //Console.Write("Dizi boyutu gir : ");

        //byte boyut;
        //boyut = Convert.ToByte(Console.ReadLine());

        //byte[] dizi = new byte[boyut];

        //for (byte i = 0; i < dizi.GetLength(0); i++)
        //{
        //    Console.Write($"{i+1}. elemanı giriniz : ");
        //    byte giris;
        //    giris = Convert.ToByte(Console.ReadLine());
        //    dizi[i] = giris;
        //}

        //Console.WriteLine();

        //Console.WriteLine("\nGirilen Elemanların Listesi");
        //for (byte i = 0; i < dizi.GetLength(0); i++)
        //{
        //    Console.Write(dizi[i] + "\t");
        //}

        //Console.WriteLine();

        //Array.Reverse(dizi);

        //Console.WriteLine("\nGirilen Elemanların Tersten Sıralanmış Listesi");
        //foreach (byte item in dizi)
        //{
        //    Console.Write(item + "\t");
        //}

        //Console.WriteLine();

        //byte toplam = 0;

        //for (byte i = 0; i < dizi.GetLength(0); i++)
        //{
        //    toplam += dizi[i];
        //}
        //Console.WriteLine($"\nGirilen Elemanlarının Toplamı =  {toplam}");


        #endregion

        #region örnek 3 

        //Dizide tekrar eden sayı ve kaç adet olduğunu bul

        /*
        Console.Write("Dizi boyutu gir : ");

        byte sayac = 1, temp=0, sayi =0;
        byte boyut;
        boyut = Convert.ToByte(Console.ReadLine());

        byte[] dizi = new byte[boyut];

        for (byte i = 0; i < dizi.GetLength(0); i++)
        {
            Console.Write($"{i + 1}. elemanı giriniz : ");
            byte giris;
            giris = Convert.ToByte(Console.ReadLine());
            dizi[i] = giris;

        }

        //for (int i = 0; i < dizi.GetLength(0)-1; i++)
        //{
        //    if (dizi[i] == dizi[i+1])
        //    {
        //        temp++;
        //    }

        //    if (i == dizi.GetLength(0)-2 || dizi[i] != dizi[i+1])
        //    {
        //        if (temp >  sayac)
        //        {
        //            sayac = temp;
        //            sayi = dizi[i];
        //        }
        //        temp = 1;
        //    }
        //}

        //Console.WriteLine($"Dizide en çok tekrar eden sayı : {sayi}");
        //Console.WriteLine($"Dizide en çok tekrar eden sayının adedi : {sayac}");

        */

        #endregion

        #region örnek 4

        /*
        Write a program in C# Sharp to merge two arrays of same size sorted in ascending order. Go to the editor
            Test Data:
                        Input the number of elements to be stored in the first array: 3
            Input 3 elements in the array :
            element - 0 : 1
            element - 1 : 2
            element - 2 : 3
            Input the number of elements to be stored in the second array: 3
            Input 3 elements in the array:
            element - 0 : 4
            element - 1 : 5
            element - 2 : 6
            Expected Output:
            The array in ascending order is :
            1,4   2,5    4,6 
        */

        //byte[] dizi1 = new byte[3];
        //byte[] dizi2 = new byte[3];


        //Console.WriteLine("Dizi1 'in elemanlarını gir!");
        //for (int i = 0; i < dizi1.GetLength(0); i++)
        //{
        //    Console.Write($"{i+1}. elemanı gir : ");
        //    byte giris1;
        //    giris1 = Convert.ToByte(Console.ReadLine());

        //    dizi1[i] = giris1;
        //}

        //Console.WriteLine("\nDizi2 'nin elemanlarını gir!");
        //for (int i = 0; i < dizi2.GetLength(0); i++)
        //{
        //    Console.Write($"{i + 1}. elemanı gir : ");
        //    byte giris2;
        //    giris2 = Convert.ToByte(Console.ReadLine());

        //    dizi2[i] = giris2;

        //}

        //Console.WriteLine();

        //Console.WriteLine("Artan sırayla birleştirilmiş dizi");
        //for (int i = 0; i < dizi1.GetLength(0); i++)
        //{
        //    Console.Write($"{dizi1[i]},");
        //    Console.Write($"{dizi2[i]} \t");
        //}

        #endregion

        #region örnek 5 

        //Boyutu klavyeden alınan dizide en büyük ve en küçük sayıyı bulma ve hangi indekste olduğunu yazdırma

        //Console.Write("Dizi boyutu gir : ");

        //byte boyut;
        //byte buyuk = 0, kucuk = 0;
        //boyut = Convert.ToByte(Console.ReadLine());

        //byte sayac=0, sira=0;

        //byte[] dizi = new byte[boyut];

        //for (byte i = 0; i < dizi.GetLength(0); i++)
        //{
        //    Console.Write($"{i + 1}. elemanı giriniz : ");
        //    byte giris;
        //    giris = Convert.ToByte(Console.ReadLine());
        //    dizi[i] = giris;
        //}

        //Console.WriteLine();
        //byte enkucuksira=0, enbuyuksira=0;

        //for (byte i = 0; i < dizi.GetLength(0); i++)
        //{
        //    if (i == 0)
        //    {
        //        buyuk = dizi[i];
        //        kucuk = dizi[i];
        //    }

        //    if (kucuk > dizi[i])
        //    {
        //        kucuk = dizi[i];
        //        enkucuksira = i;
        //    }

        //    if (buyuk < dizi[i])
        //    {
        //        buyuk = dizi[i];
        //        enbuyuksira = i;
        //    }
        //}

        //Console.WriteLine($"Dizideki en büyük sayının indeksi : {enbuyuksira+1}, değeri = {buyuk} ");
        //Console.WriteLine($"Dizideki en küçük sayının indeksi : {enkucuksira+1}, değeri = {kucuk}");

        #endregion

        #region örnek 6

        //Boyutu klavyeden alınan dizi elemanlarından tek ve çift olanları ayrı ayrı yazdırma

        //Console.Write("Dizi boyutu gir : ");

        //byte boyut;
        //boyut = Convert.ToByte(Console.ReadLine());

        //byte[] dizi = new byte[boyut];

        //byte tek = 0, cift = 0;

        //byte[] tekdizi = new byte[10];
        //byte[] ciftdizi = new byte[10];

        //for (byte i = 0; i < dizi.GetLength(0); i++)
        //{
        //    Console.Write($"{i + 1}. elemanı giriniz : ");
        //    byte giris;
        //    giris = Convert.ToByte(Console.ReadLine());
        //    dizi[i] = giris;
        //}

        //for (byte i = 0; i < dizi.GetLength(0); i++)
        //{
        //    if (dizi[i] % 2 == 0)
        //    {
        //        ciftdizi[cift] = dizi[i];
        //        cift++;
        //    }

        //    else
        //    {
        //        tekdizi[tek] = dizi[i];
        //        tek++;
        //    }
        //}

        //Console.WriteLine();

        //Console.WriteLine("Dizideki tek sayılar : ");

        //for (byte i = 0; i < tek; i++)
        //    Console.Write(tekdizi[i] + "\t");

        //Console.WriteLine();

        //Console.WriteLine("Dizideki çift sayılar : ");
        //for (byte i = 0; i < cift; i++)
        //    Console.Write(ciftdizi[i] + "\t");

        #endregion

        #region örnek 7

        //Diziye yeni değer eklemek


            #region Boyut Belirleme

        menu:

            Console.Write("Dizi boyutu gir : ");

            int val;
            string boyut;
            boyut = Console.ReadLine();

            if (!Int32.TryParse(boyut, out val))
            {
                Console.Clear();
                goto menu;
            }

            #endregion

            #region dizileri oluşturma 
                int[] dizi = new int[val];
            #endregion

            #region diziye elemanları girdirme
            menu2:

                for (int i = 0; i < dizi.GetLength(0); i++)
                {
                    Console.Write($"{i + 1}. elemanı giriniz : ");

                    int val2;
                    string giris;
                    giris = Console.ReadLine();
                    if (!Int32.TryParse(giris, out val2))
                    {
                        Console.Clear();
                        goto menu2;
                    }
                    dizi[i] = val2;
                }
            #endregion

            #region Diziye yeni eleman ekleme 

            Console.Write("Diziye yeni eleman eklemek ister misiniz ? (e/h) : ");
            string cevap;
            cevap = Console.ReadLine();
            if (cevap == "e" || cevap == "E")
                goto end;
            else
                Environment.Exit(0);


            //Array.Reverse(array);   

            end:   

            //val++;
            //byte[] yeniDizi = new byte[val];
            menu3:
            Console.Write("Eklenecek elemanı giriniz : ");
            int val3;
            string yeniDiziE;
            yeniDiziE = Console.ReadLine();
            if (!Int32.TryParse(yeniDiziE, out val3))
            {
                Console.Clear();
                goto menu3;
            }

            val3 = dizi[val+1];

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                Console.WriteLine(dizi[i]);
                val3 = dizi[i];
            }

            #endregion



            #endregion

            Console.ReadLine();

        }
    }
}
