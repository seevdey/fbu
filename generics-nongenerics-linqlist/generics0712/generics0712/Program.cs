using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics0712
{
    //Generics te casting yapmıyoruz

    class Otomobil<T>
    {
        //<T> --> bütün tipleri alabilir

        T t1;
        public T Deger { 
            get { return t1; }
            set { t1 = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil<string> oto1 = new Otomobil<string>();
            oto1.Deger = "Şahin";
            //casting yapmıyoruz
            string yenideger = oto1.Deger;
            Console.WriteLine("Otomobil nesnemizin değeri : " + yenideger);

            Otomobil<int> oto2 = new Otomobil<int>();
            oto2.Deger = 2006;
            int yenideger2 = oto2.Deger;
            Console.WriteLine("Otomobil2 nesnemizin değeri : " + yenideger2);


            /*
             *  NON GENERICS                GENERICS
             *  ArrayList                   List
             *  Hashtable                   IDictionary<k,t>
             *  SortedList                  SortedList<TKey, TValue>
            */

            Console.ReadLine();
        }
    }
}
