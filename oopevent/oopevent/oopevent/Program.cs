using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopevent
{
    //BÜTÜN SINIFLARIN BAŞINA PARTIAL KOY
    class Maths
    {
        public delegate void SampleDelegate();
        public event SampleDelegate SampleEvent;

        public void Add(int a, int b)
        {
            if (SampleEvent != null)
            {
                SampleEvent();
                Console.WriteLine("Add Result : {0}", a+b);
            }
            else
                Console.WriteLine("Olay çağırılmadı");
        }

        public void Substract(int x, int y)
        {
            if (SampleEvent != null)
            {
                SampleEvent();
                if (x>y)
                {
                    Console.WriteLine("Substract Result : {0}", x - y);
                }
                else
                    Console.WriteLine("Substract Result : {0}", y - x);

            }
            else
                Console.WriteLine("Olay çağırılmadı");
        }
    }

    class Operations
    {
        Maths m; //m, Maths tipinde değişken
        public int a { get; set; }
        public int b { get; set; }

        public Operations(int x, int y)//const başlangıç metodu
        {
            //bu kodu class içinde değil metod içinde yazarsın yani class ta işlem olmaz. metodda olur

            m = new Maths(); //m hafızada bir nesne olmuş oluyor
            m.SampleEvent += SampleEventHandler; //m nin event ı  çağrıldığında SampleEventHandler() bu kısım çağırılacak
            a = x; //a sınıfın özelliği
            b = y;
        }

        public void SampleEventHandler()
        {
            Console.WriteLine("SampleEventHandler çağırıldı");
        }

        public void AddOperations()
        {
            m.Add(a, b);
        }

        public void SubOperations()
        {
            m.Substract(a, b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Olay Uygulaması****");
            Operations op = new Operations(10, 20);
            op.AddOperations();
            op.SubOperations();
            Console.ReadLine();

        }
    }
}
