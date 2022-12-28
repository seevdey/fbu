using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopeventform.Sınıflar
{
    internal class Operations
    {
        Maths m;
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
            MessageBox.Show("SampleEventHandler çağırıldı");
        }

        public int AddOperations()
        {
            return m.Add(a, b);
        }

        public int SubOperations()
        {
            return m.Substract(a, b);
        }
    }
}
