using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class DortIslem
    {
        //static işaretlediğin anda insteance alamazsın
        //invoke <-- metodu çağırma
        public static double Toplam(double sayi1, double sayi2)
        {
            double sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public static double Cikarma(double sayi1, double sayi2)
        {
            double sonuc = sayi1 - sayi2;
            return sonuc;
        }

        public static double Carpma(double sayi1, double sayi2)
        {
            double sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public static double Bolme(double sayi1, double sayi2)
        {
            double sonuc;
            if (sayi1 > sayi2)
            {
                sonuc = sayi1 / sayi2;
            }
            else if (sayi1 == 0 || sayi2 == 0)
            {
                return 0;
            }
            else
            {
                sonuc = sayi2 / sayi1;
            }
            return sonuc;
        }
    }
}
