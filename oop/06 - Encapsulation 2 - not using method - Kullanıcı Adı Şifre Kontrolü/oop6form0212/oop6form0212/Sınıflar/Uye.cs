using System;

namespace oop6form0212.Sınıflar
{
    internal class Uye : IDisposable
    {
        private string _kullaniciAdi;

        public string KullaniciAdi
        {
            get { return _kullaniciAdi; }
            set
            {
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
                {
                    _kullaniciAdi = value;
                }
                else
                    throw new ArgumentException("Kullanıcı Adı içerisinde Harf dışında başka karakter olamaz");
            }

        }

        private string _sifre;

        public string Sifre
        {
            get { return _sifre; }
            set
            {
                if (value.Length <= 8)
                {
                    _sifre = value;
                }
                else
                    throw new ArgumentException("Kullanıcı Şifresi 8 karakterden fazla olamaz");
            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
