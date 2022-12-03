using System;

namespace Sınıflar
{
    internal class Uye : IDisposable
    {
        //Önceki örnekte metot kullanarak kapsülleme yaptık
        //Metod Kullanmadan Kapsülleme

        //propfull + tab --> hazır şablon çıkıyor

        //_kullaniciAdi Alandır
        private string _kullaniciAdi;  //korumalı yapıyoruz

        //KullaniciAdi özelliktir
        //Özellikler alamlara iş kuralı konulmuş halidir.
        public string KullaniciAdi //herkes bu metoda erişim sağlayabilecek
        {
            //get --> değer okuma
            get { return _kullaniciAdi; }
            //set --> değer atama
            set {
                bool oldumu = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        oldumu = false;
                        break;
                    }
                }

                if (oldumu)
                    _kullaniciAdi = value;
                else
                {
                    throw new ArgumentException("Kullanıcı Adı içerisinde harf dışında başka karakter olamaz");
                }

            } 

            //value --> dışarıdan gelen değer anlamına geliyor
        }

        private string _sifre;

        public string Sifre
        {
            get { return _sifre; }
            set {
                if (value.Length <= 8)
                    _sifre = value;
                else
                    throw new ArgumentException("Kullanıcı Şifresi 8 karakterden büyük olamaz");

            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
