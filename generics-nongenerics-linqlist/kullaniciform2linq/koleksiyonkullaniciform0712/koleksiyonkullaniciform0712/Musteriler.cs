using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koleksiyonkullaniciform0712
{
    public class Musteriler : IDisposable
    {
        public string Name;
        public string Surname;
        public string Cinsiyet;
        public string Telefon;
        public DateTime Tarih;
        public string Il;
        public string Ilce;
        public string Il2;
        public string Ilce2;

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
