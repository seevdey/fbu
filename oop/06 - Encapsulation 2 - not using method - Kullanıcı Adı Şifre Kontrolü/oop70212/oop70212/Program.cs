using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop70212
{
    class Calisan : IDisposable
    {
        private int sskNo;

        public int SSKNO
        {
            get { return sskNo; }
            set { sskNo = value; }
        }

        private string ad;

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }

        protected double maas;
        //protected --> bu sınıftan türeyenler ulaşabiliyor

        //babada isim, soyisim hobi özellikleri var. 
        //çocukta bu özellikleri kalıtımla alıyor
        //babada ve çocukta hobi farklıysa 'virtual' olarak tanımlıyoruz
        //değişmiyorsa hiçbir şey yapma yani virtual yazma
        //override (polimorfizm) olarak gösterilmesi için virtual kullanıyoruz

        public double MAAS
        {
            get { return maas; }
            set { maas = value; }
        }

        public virtual void zamYap(double zam)
        {
            maas += zam;        
        }

        public virtual string BilgiVer(string ozellik)
        {

            if (ozellik is null)
            {
                return ADI + " / " + SSKNO + " / " + MAAS;

            }

            switch (ozellik)
            {
                case "ADI":
                    return ADI;
                case "MAAS":
                    return MAAS.ToString();
                case "SSKNO":
                    return SSKNO.ToString();
                default:
                    return "boş";
            }

            
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }

    //KALITM
    class Mudur : Calisan
    {
        private double departmankar;

        public double DepartmanKAR
        {
            get { return departmankar; }
            set { departmankar = value; }
        }

        public override void zamYap(double zam)
        {
            double prim = 0;
            if (MAAS > 0)
            {
                if (DepartmanKAR > 0 && DepartmanKAR <= 10000)
                    prim = 5000;
                else if (DepartmanKAR > 10000 && DepartmanKAR <= 100000)
                    prim = 10000;
                else
                    prim = 20000;
            }
            else
            {
                Console.WriteLine("Maaş Bilgisi Yoktur");
                return;
            }

            MAAS += zam +  prim;
        }

    }

    class SatisElemani : Calisan
    {
        //Satış sayıısna göre zam alacak

        private int satisSayi;

        public int SatisSayisi
        {
            get { return satisSayi; }
            set { satisSayi = value; }
        }

        //metodu alabilmen için virtual alman lazım
        public override void zamYap(double zam)
        {
            double prim = 0;
            if (MAAS > 0)
            {
                if (SatisSayisi > 0 && SatisSayisi <= 100)
                    prim = 5000;
                else if (SatisSayisi > 100 && SatisSayisi <= 1000)
                    prim = 10000;
                else
                    prim = 20000;
            }
            else
            {
                Console.WriteLine("Maaş Bilgisi Yoktur");
                return;
            }

            MAAS += zam + prim;
        }

        public override string BilgiVer(string ozellik)
        {
            return base.BilgiVer(ozellik) + " / " + SatisSayisi;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(Calisan cc = new Calisan())
                {
                    cc.ADI = "Utku";
                    cc.SSKNO = 123456;
                    cc.MAAS = 5000;
                    cc.zamYap(2000);
                    Console.WriteLine($"Çalışan Bilgileri : \n{cc.BilgiVer(null)}");
                }

                Console.WriteLine("--------------------");

                using (Mudur mm = new Mudur())
                {
                    mm.ADI = "Mustafa";
                    mm.SSKNO = 12345;
                    mm.MAAS = 15000;
                    mm.DepartmanKAR = 50000;
                    mm.zamYap(2000);
                    Console.WriteLine($"Müdür Bilgileri : \n{mm.BilgiVer("ADI")}");
                }

                Console.WriteLine("--------------------");

                using (SatisElemani ss = new SatisElemani())
                {
                    ss.ADI = "Demet";
                    ss.SSKNO = 1234;
                    ss.MAAS = 25000;
                    ss.SatisSayisi = 500;
                    ss.zamYap(2000);
                    Console.WriteLine($"Satış Elemanı Bilgileri : \n{ss.BilgiVer(null)}");
                }

            }
            catch (Exception ex) //HATALARI ARAŞTIR
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
