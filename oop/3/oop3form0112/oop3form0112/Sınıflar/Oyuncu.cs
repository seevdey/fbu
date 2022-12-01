

namespace oop3form0112.Sınıflar
{
    internal class Oyuncu : System.IDisposable
    {
        public string Adi;
        public string takimi;
        public string FormaNo;

        public Oyuncu(string adi, string takimi, string formaNo) //bilgi verilmiş constructor
        {
            Adi = adi;
            this.takimi = takimi; //aynı isimde ise this gelecek, farklı isimdeyse this yok
            FormaNo = formaNo;
            //System.Console.WriteLine("Parametrik metot çalıştı...");
        }

        public Oyuncu()
        {
            System.Console.WriteLine("Varsayılan parametrik metot çalıştı...");
        }

        public void takimdegistir(string takimi, Form1 formnesnesi)
        {
            this.takimi = takimi;
        }

        public string BilgiVer(Form1 formnesnesi)
        {
            return string.Format("{0} \t\t {1} \t\t - {2}", FormaNo, Adi, takimi);
        }

        public void Dispose()
        {
            //throw new System.NotImplementedException();
        }
    }
}
