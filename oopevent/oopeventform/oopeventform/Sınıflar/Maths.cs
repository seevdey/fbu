using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopeventform.Sınıflar
{
    internal class Maths
    {
        public delegate void SampleDelegate();
        public event SampleDelegate SampleEvent;

        public int Add(int a, int b)
        {
            if (SampleEvent != null)
            {
                SampleEvent();
                return a + b;
            }
            else
                MessageBox.Show("Olay çağırılamadı");
            return 0;
        }

        public int Substract(int x, int y)
        {
            if (SampleEvent != null)
            {
                SampleEvent();
                if (x > y)
                {
                    return x - y;
                }
                else
                    return y - x;
            }
            else
            {
                MessageBox.Show("Olay çağırılamadı");
                return 0;
            }
        }
    }
}
