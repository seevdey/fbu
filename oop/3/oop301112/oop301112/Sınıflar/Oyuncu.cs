namespace Sınıflar
{

    /*
        Ekran açılacak
        cmbx ten ülke seç 
        comboboxtan  takım isimleri gelecek
        comboxoxtan 2. takımı seç
        ülkenin içindeki takımları çıkacak 
        A takımı gs, B takımı fb
        Butona bas takım oluştur 
        Oyuncu havuzu yapıyorsunuz
        oyuncu skoruna göre takım oluştur
        image ile gs ve fb takımlarını oluştur

            SKOR TAHMİNİ :  2 ratinge göre kombinasyonla, permütasyon kazanma yüzdesi
               
        maçı oyna 
        skor yazdır
     
     */

    internal class Oyuncu : System.IDisposable
    {
        public string Adi;
        public string takimi;
        public byte FormaNo;

        //constructor bir metot demek
        //birinde başlangıç değeri var
        //diğerinde başlangıç değeri yok

        //sınıfın adında açılan metotda constructor diyoruz

        //ctor + tab --> constructor oluşturuyoruz
        public Oyuncu(string adi, string takimi, byte formaNo) //bilgi verilmiş constructor
        {
            Adi = adi;
            this.takimi = takimi; //aynı isimde ise this gelecek, farklı isimdeyse this yok
            FormaNo = formaNo;
            System.Console.WriteLine("Parametrik metot çalıştı...");
        }

        public Oyuncu()
        {
            System.Console.WriteLine("Varsayılan parametrik metot çalıştı...");
        }

        public void takimdegistir(string takimi)
        {
            this.takimi = takimi;
        }

        public string BilgiVer()
        {
            return string.Format("{0} {1} - {2}", FormaNo, Adi, takimi);
        }

        //public takim

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
