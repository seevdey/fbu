using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopders40112
{
    // nested class içi içe sınıflar
    class Daire : IDisposable
    {
        public string semti;
        public int odasayısı = 3;

        public Daire(string semti)
        {
            this.semti = semti;
        }

        Oda o = new Oda(50, Oda.OdaCesidi.Salon);
        Oda o1 = new Oda(20, Oda.OdaCesidi.MisafirODası);
        Oda o2 = new Oda(30, Oda.OdaCesidi.YatakOdası);

        public string Bilgiver()
        {
            return string.Format($"Semti: {semti} \n Oda Sayısı : {odasayısı} \n Oda Çeşidi :{o.odaCesitalanı}- Metrekaresi :{o.metrakare} \n Oda Çeşidi :{o1.odaCesitalanı}- Metrekaresi :{o1.metrakare}\n Oda Çeşidi :{o2.odaCesitalanı}- Metrekaresi :{o2.metrakare}  ");
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }

    class Oda : IDisposable
    {
        //enum combobox gibi , enum ın içindeki bilgiler sabitse bir küme olarak tutar. Örnek aylar. enum bir aylar
        public enum OdaCesidi
        {
            Salon, ÇocukOdası, MisafirODası, YatakOdası, OturmaOdası, ÇalışmaOdası
        }

        public int metrakare;
        public OdaCesidi odaCesitalanı;

        public Oda(int metrakare, OdaCesidi odaCesitalanı)
        {
            this.metrakare = metrakare;
            this.odaCesitalanı = odaCesitalanı;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Daire d1 = new Daire("Caddebostan"))
            {
                Console.WriteLine(d1.Bilgiver());
            }
            Console.ReadLine();
        }
    }
}
